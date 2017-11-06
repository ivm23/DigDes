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
    public partial class UserChats : Form
    {
        User _user;
        public UserChats(User user)
        {
            InitializeComponent();
            Data.EventHandlerGetUserChats(user);
            _user = user;
        }
        public string[] NameChatsOfUser
        {
            set
            {
                foreach (var item in value)
                    cbAllChats.Items.Add(item);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
