﻿using System;
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
            Data.EventHandlerMessages(_chat, ref oldMessages);
            for (int i = 0; i < oldMessages.Count; ++i) { 
                    checkedListBox1.Items.Insert(0, oldMessages[i].Text);
                    if (oldMessages[i].IdUser == _user.Id || oldMessages[i].AlreadyRead) checkedListBox1.SetItemChecked(0, false);
                    else
                        checkedListBox1.SetItemChecked(0, true);
                }
            
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
            timer.Interval = 2000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;
        }

        public void TimerTick(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();

            List<Messenger.Model.Message> mes = new List<Messenger.Model.Message>();
            Data.EventHandlerMessages(_chat, ref mes);
           

            foreach (var m in mes)
            {
               // bool exist = false;
            /*    foreach (var message in oldMessages)
                {
                    if (message.Id.Equals(m.Id)) exist = true;
                }*/
                //if (!exist)
                {
                    checkedListBox1.Items.Insert(0, m.Text);
                    if (m.IdUser.Equals(_user.Id) || m.AlreadyRead) checkedListBox1.SetItemChecked(0, false);
                    else
                        checkedListBox1.SetItemChecked(0, true);
                    oldMessages.Add(m);
                }
            }
        }

        private void AutoDelMess_CheckedChangedItemCheck(object sender, EventArgs e)
        {
            if (AutoDelMess.Checked == true)
            {
                int localI = checkedListBox1.Items.Count - 1;
                for (int i = 0; i < checkedListBox1.Items.Count; ++i)
                {
                    if (!checkedListBox1.GetItemChecked(i) && oldMessages[localI].Text.IndexOf(_user.FirstName) != 0)
                    {
                       // checkedListBox1.Items.RemoveAt(localI);
                        Data.EventHandlerDelMessage(oldMessages[localI]);
                        //  oldMessages.RemoveAt(localI);
                    }
                    localI--;
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; ++i)
                {
                    if (!checkedListBox1.GetItemChecked(i) && oldMessages[checkedListBox1.Items.Count - i - 1].Text.IndexOf(_user.FirstName) != 0)
                    {
                        Data.EventHandlerReadMessage(oldMessages[checkedListBox1.Items.Count - i - 1].Id);
                    }
                }
            }
        }
    }
}
