using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Model;

namespace Messenger.WinForms.Forms
{
    public partial class NewChat : Form
    {
        public NewChat(User user, List<User> users)
        {
            InitializeComponent();
            newChatControl1.AllUsers = users;
        }

        public string GetNameChat
        {
            get
            {
                return newChatControl1.GetNameChat;
            }
        }
        public List<String> AddUserToChat
        {
            get { return newChatControl1.AddUserToChat; }
        }

        private void btnCreateChat_Click(object sender, EventArgs e)
        {
            var usersToChat = newChatControl1.AddUserToChat;
            var name = newChatControl1.GetNameChat;
            Data.EventHandlerAddNewChat(usersToChat, name);
        }
    }
}
