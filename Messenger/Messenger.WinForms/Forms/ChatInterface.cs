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
    public partial class ChatInterface : Form
    {
        Chat _chat;
        User _user;
        public ChatInterface(Chat chat, User user)
        {
            InitializeComponent();
            _chat = chat;
            _user = user;
        
        }
        public string ChatName
        {
            set { lbNameChat.Text = value; }
        }

        public string GetMessage
        {
            get { return txtMessage.Text;  }
        }
        public List<String> SetChatMembers
        {
            set
            {
                addUsersControl2.SetChatMembers = value;
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            
            Data.EventHandlerCreateMessage(_chat, _user, txtMessage.Text);
        }
    }
}
