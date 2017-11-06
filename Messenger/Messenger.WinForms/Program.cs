﻿using System;
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
    public static class Data
    {
        public delegate void MyEventDelUser(User user);
        public static MyEventDelUser EventHandlerDelUser;

        public delegate void MyEventUpdateUser(User user);
        public static MyEventUpdateUser EventHandlerUpdateUser;


        public delegate void MyEventGetUserChats(User user);
        public static MyEventGetUserChats EventHandlerGetUserChats;

    }
}
