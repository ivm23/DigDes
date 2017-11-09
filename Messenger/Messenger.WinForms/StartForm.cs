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
            foreach (var chat in chats)
            {
                MessageBox.Show(chat.NameOfChat, "", MessageBoxButtons.OK);
            }
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
            MessageBox.Show(Convert.ToString(index));
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
                List<String> mes = new List<String> { "dsfsd", "sdfd" };
                form.SetMessages = mes;
                //form.ShowDialog();
                //  form.Show();
                MessageBox.Show("fdf");
                form.SetMessages = mes;

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
        }

        void ChatsOfUser(User user)
        {
            var chats = _serviceClient.GetChatsOfUser(user);
            var nameChatsOfUsers = new List<String>();
            foreach(var chat in chats)
            {
                nameChatsOfUsers.Add(chat.NameOfChat);
            }
            using (var form = new UserChats(user))
            {
                form.NameChatsOfUser = nameChatsOfUsers;
                form.ShowDialog();
            }
                foreach (var chat in chats)
            {

                //MessageBox.Show(Convert.ToString(chat.Id));
            }
        }

        private void btnMainEnter_Click(object sender, EventArgs e)
        {
            using (var form = new UserEnter())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var id = getId(form.UserName);
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
            using (var form = new UserInterface(user)) //new MyDelegate.DelUser(DelUser), user))
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
