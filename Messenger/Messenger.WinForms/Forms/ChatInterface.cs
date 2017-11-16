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
        List<Messenger.Model.Message> oldMessages = new List<Messenger.Model.Message>();

        public ChatInterface(Chat chat, User user)
        {
            InitializeComponent();
            checkedListBox1.SelectedIndexChanged += AutoDelMess_CheckedChangedItemCheck;
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
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;
        }

        public void TimerTick(object sender, EventArgs e)
        {
            List<Messenger.Model.Message> mes = new List<Messenger.Model.Message>();
            Data.EventHandlerMessages(_chat, ref mes);

            foreach (var m in mes)
            {
                bool exist = false;
                foreach (var message in oldMessages)
                {
                    if (message.Id.Equals(m.Id)) exist = true;
                }
                if (!exist)
                {
                    checkedListBox1.Items.Insert(0, m.Text);
                    checkedListBox1.SetItemChecked(0, true);
                    oldMessages.Add(m);
                }
            }
        }

        private void AutoDelMess_CheckedChangedItemCheck(object sender, EventArgs e)
        {
            if (AutoDelMess.Checked == true)
            {
                var selectedMessages = checkedListBox1.SelectedItems;
                List<int> indexOfDelMess = new List<int>();
                for (int i = 0; i < checkedListBox1.Items.Count; ++i)
                {
                    if (!checkedListBox1.GetItemChecked(i))
                    {
                        checkedListBox1.Items.RemoveAt(i);
                        Data.EventHandlerDelMessage(oldMessages[checkedListBox1.Items.Count - i]);
                        oldMessages.RemoveAt(checkedListBox1.Items.Count - i);
                    }
                }
            }
        }
    }
}
