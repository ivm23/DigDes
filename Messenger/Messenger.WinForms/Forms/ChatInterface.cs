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
            get { return txtMessage.Text; }
        }

        public List<String> SetChatMembers
        {
            set { addUsersControl1.SetChatMembers = value; }
        }
        public List<String> SetChatMessages
        {
            set { messageControl1.SetChatMessages = value; }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {

            Data.EventHandlerCreateMessage(_chat, _user, txtMessage.Text);

        }

        private void btnWatchMessages_Click(object sender, EventArgs e)
        {
            Data.EventHandlerWatchMessages(_chat);
        }

        private void ChatInterface_Load(object sender, EventArgs e)
        {
            
            var timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;
        }
        int k = 0;
        public void TimerTick(object sender, EventArgs e)
        {
            List<String> mes = new List<String>();
            Data.EventHandlerMessages(_chat, ref mes);
            messageControl1.SetChatMessages = mes;
            ++k;
        }
    }
}
