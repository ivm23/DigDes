using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Model;

namespace Messenger.WinForms.Controls
{
    public partial class NewChatControl : UserControl
    {
        public NewChatControl()
        {
            InitializeComponent();
        }

        public List<User> AllUsers
        {
            set
            {
                foreach (var name in value)
                {
                    clbUsers.Items.Add(name.FirstName + ' ' + name.SecondName + " (" + name.Login + ')');
                }
            }
        }

        public string GetNameChat
        {
            get
            {
                return txtNameChat.Text;
            }
        }

        public List<String> AddUserToChat
        {
            get
            {
                List<String> usersToChat = new List<String>();
                foreach (var user in clbUsers.CheckedItems)
                {
                    usersToChat.Add(user.ToString());
                }
                return usersToChat;
            }
        }

        private void NewChatControl_Load(object sender, EventArgs e)
        {

        }
    }
}
