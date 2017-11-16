using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Model;

namespace Messenger.WinForms
{

    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
    public struct CreateChatData
    {
        public string nameChat;
        public IEnumerable<Guid> members;
    }

    public static class Data
    {
        public delegate void MyEventDelUser(User user);
        public static MyEventDelUser EventHandlerDelUser;

        public delegate void MyEventUpdateUser(User user);
        public static MyEventUpdateUser EventHandlerUpdateUser;


        public delegate void MyEventGetUserChats(User user);
        public static MyEventGetUserChats EventHandlerGetUserChats;

        public delegate void MyEventCreateNewChat(User user);
        public static MyEventCreateNewChat EventHandlerCreateNewChat;


        public delegate void MyEventAddNewChat(List<String> users, String name);
        public static MyEventAddNewChat EventHandlerAddNewChat;


        public delegate void MyEventCreateMessage(Chat chat, User user, String text);
        public static MyEventCreateMessage EventHandlerCreateMessage;

        public delegate void MyEventChatsOfUser(User user);
        public static MyEventChatsOfUser EventHandlerChatsOfUser;

        public delegate void MyEventOpenChat (User user, Chat chat);
        public static MyEventOpenChat EventHandlerOpenChat;

        public delegate void MyEventWatchMessages(Chat chat);
        public static MyEventWatchMessages EventHandlerWatchMessages;

        public delegate void MyEventMessages(Chat chat, ref List<Messenger.Model.Message> mes);
        public static MyEventMessages EventHandlerMessages;
    }
}
