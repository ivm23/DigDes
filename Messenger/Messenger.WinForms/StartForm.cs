using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.WinForms.Forms;
using Messenger.Model;


namespace Messenger.WinForms
{
    public partial class StartForm : Form
    {
        private ServiceClient _serviceClient;

        public StartForm()
        {
            InitializeComponent();
            Data.EventHandlerDelUser = new Data.MyEventDelUser(DelUser);
            Data.EventHandlerUpdateUser = new Data.MyEventUpdateUser(UpdateUser);
            Data.EventHandlerGetUserChats = new Data.MyEventGetUserChats(GetUserChats);
            Data.EventHandlerCreateNewChat = new Data.MyEventCreateNewChat(CreateNewChat);
            Data.EventHandlerAddNewChat = new Data.MyEventAddNewChat(AddNewChat);
            Data.EventHandlerCreateMessage = new Data.MyEventCreateMessage(CreateMessage);
            Data.EventHandlerChatsOfUser = new Data.MyEventChatsOfUser(ChatsOfUser);
            Data.EventHandlerOpenChat = new Data.MyEventOpenChat(OpenChat);
            Data.EventHandlerWatchMessages = new Data.MyEventWatchMessages(WatchMessages);
            Data.EventHandlerMessages = new Data.MyEventMessages(GetMessages);
        }

        void DelUser(User param)
        {
            _serviceClient.DelUser(param.Id);
            MessageBox.Show("Пользователь удален!");
        }

        void UpdateUser(User param)
        {
            _serviceClient.UpdateUser(param);
            MessageBox.Show($"Пользователь: {param.FirstName} изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void GetUserChats(User user)
        {
            var chats = _serviceClient.GetUserChats(user.Id).ToList();
        }

        void CreateNewChat(User user)
        {
            var users = _serviceClient.GetAllUsers(user.Id);
            using (var form = new NewChat(user, users))
            {
                if (form.ShowDialog() == DialogResult.Abort)
                    MessageBox.Show("UserInterface");
            }
        }
        Guid getId(string str)
        {
            var index = str.LastIndexOf('(');

            var id = new Guid(str.Substring(index + 1, str.Length - index - 2));
            return id;
        }

        void AddNewChat(List<String> users, String name)
        {
            var chatUsers = new List<Guid>();
            foreach (var usr in users)
            {
                var id = getId(usr);
                var _user = _serviceClient.GetUser(id);
                chatUsers.Add(_user.Id);
            }

            var chat = new CreateChatData
            {
                nameChat = name,
                members = chatUsers
            };

            var newChat = _serviceClient.CreateChat(chat);
            var user = _serviceClient.GetUser((chatUsers.Last()));

            using (var form = new ChatInterface(newChat, user))
            {
                form.ChatName = name;
                form.SetChatMembers = users;
                form.ShowDialog();
            }
        }

        void CreateMessage(Chat chat, User user, String text)
        {
            var message = new Model.Message
            {
                IdChat = chat.Id,
                IdUser = user.Id,
                Text = text,
                TimeCreate = Convert.ToDateTime("0:0:0")

            };
            var newMessage = _serviceClient.CreateMessage(message);
            MessageBox.Show("Сообщение отправлено");
        }

        void ChatsOfUser(User user)
        {
            var chats = _serviceClient.GetChatsOfUser(user);
            var nameChatsOfUsers = new List<String>();
            foreach (var chat in chats)
            {
                nameChatsOfUsers.Add(chat.NameOfChat);
            }
            using (var form = new UserChats(user, chats))
            {
                form.NameChatsOfUser = nameChatsOfUsers;
                form.ShowDialog();
            }
        }


        void OpenChat(User user, Chat chat)
        {
            List<User> users = (chat.Members).ToList<User>();
            List<String> nameOfUsers = new List<String>();
            foreach (var us in users)
            {
                nameOfUsers.Add(us.FirstName + ' ' + us.SecondName);
            }
            using (var form = new ChatInterface(chat, user))
            {
                form.ChatName = chat.NameOfChat;
                form.SetChatMembers = nameOfUsers;
                form.ShowDialog();
            }
        }

        void WatchMessages(Chat chat)
        {
            var messages = _serviceClient.GetChatMessages(chat);
            List<String> textMessages = new List<String>();

            foreach (var mes in messages)
            {
                var name = _serviceClient.GetUser(mes.IdUser);
                textMessages.Add(name.FirstName + ' ' + name.SecondName + ':' + mes.Text);
            }
            using (var form = new MessagesInterface())
            {
                form.SetText = textMessages;
                form.ShowDialog();
            }
        }


        void GetMessages(Chat chat, ref List<String> m)
        {
            var messages = _serviceClient.GetChatMessages(chat);
            List<String> textMessages = new List<String>();
            messages.OrderByDescending(x => x.TimeCreate);
            foreach (var mes in messages)
            {
                var name = _serviceClient.GetUser(mes.IdUser);
                textMessages.Add(name.FirstName + ' ' + name.SecondName + ": " + mes.Text);
            }
            m = textMessages;
        }

        private void btnMainEnter_Click(object sender, EventArgs e)
        {
            using (var form = new UserEnter())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var login = form.UserLogin;
                    var id = _serviceClient.GetId(login);
                    User user = _serviceClient.GetUser(id);
                    if (user.Password == form.UserPassword)
                    {
                        using (var formChat = new UserInterface(user))
                        {
                            formChat.UserName = user.FirstName + ' ' + user.SecondName;
                            formChat.UserPhoto = user.Photo;
                            formChat.ShowDialog();
                        }
                    }
                }
            }
        }


        private void UserInterface(User user)
        {
            using (var form = new UserInterface(user))
            {
                form.UserName = user.FirstName + ' ' + user.SecondName;
                form.UserPhoto = user.Photo;
                if (form.ShowDialog() == DialogResult.Abort) MessageBox.Show("sdfgF");
            }
        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            byte[] ph = new byte[] { 1, 2, 3 };
            using (var form = new UserCheckIn())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var _user = _serviceClient.CreateUser(new User
                    {
                        Login = form.UserLogin,
                        FirstName = form.UserFirstName,
                        SecondName = form.UserSecondName,
                        Password = form.UserPassword,
                        Photo = form.UserPhoto,
                        TimeOfDelMes = form.UserTimeDelMes
                    });

                    var message = "Пользователь" + _user.FirstName + ' ' + _user.SecondName + " успешно зарегистрирован!";
                    MessageBox.Show(message, "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserInterface(_user);
                }

            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            _serviceClient = new ServiceClient("http://localhost:57893/api/");
        }
    }
}
