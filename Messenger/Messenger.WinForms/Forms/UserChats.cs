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
        List<Chat> _chats;
        public UserChats(User user, List<Chat> chats)
        {
            InitializeComponent();
            Data.EventHandlerGetUserChats(user);
            _user = user;
            _chats = chats;
        }

        public List<String> NameChatsOfUser
        {
            set
            {
                foreach (var item in value)
                    cbAllChats.Items.Add(item);
            }
        }

        public Chat GetChat(int index)
        {
             return _chats[index]; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexChat = cbAllChats.SelectedIndex;
            var chat = GetChat(indexChat);
            Data.EventHandlerOpenChat(_user, chat);
        }

        
        private void NewChat_Click(object sender, EventArgs e)
        {
            Data.EventHandlerCreateNewChat(_user);  
        }
    }
}
