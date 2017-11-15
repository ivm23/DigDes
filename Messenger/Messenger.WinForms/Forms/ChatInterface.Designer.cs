namespace Messenger.WinForms.Forms
{
    partial class ChatInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbNameChat = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnWatchMessages = new System.Windows.Forms.Button();
            this.messageControl1 = new Messenger.WinForms.Controls.MessageControl();
            this.addUsersControl1 = new Messenger.WinForms.Controls.AddUsersControl();
            this.addUsersControl2 = new Messenger.WinForms.Controls.AddUsersControl();
            this.SuspendLayout();
            // 
            // lbNameChat
            // 
            this.lbNameChat.AutoSize = true;
            this.lbNameChat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbNameChat.Location = new System.Drawing.Point(29, 12);
            this.lbNameChat.Name = "lbNameChat";
            this.lbNameChat.Size = new System.Drawing.Size(31, 13);
            this.lbNameChat.TabIndex = 2;
            this.lbNameChat.Text = "        ";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(258, 68);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(223, 71);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "Введите сообщение...";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSendMessage.Location = new System.Drawing.Point(400, 145);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(84, 43);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Отправить";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnWatchMessages
            // 
            this.btnWatchMessages.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnWatchMessages.Location = new System.Drawing.Point(258, 145);
            this.btnWatchMessages.Name = "btnWatchMessages";
            this.btnWatchMessages.Size = new System.Drawing.Size(84, 43);
            this.btnWatchMessages.TabIndex = 5;
            this.btnWatchMessages.Text = "Посмотреть сообщения";
            this.btnWatchMessages.UseVisualStyleBackColor = true;
            this.btnWatchMessages.Click += new System.EventHandler(this.btnWatchMessages_Click);
            // 
            // messageControl1
            // 
            this.messageControl1.Location = new System.Drawing.Point(17, 187);
            this.messageControl1.Name = "messageControl1";
            this.messageControl1.Size = new System.Drawing.Size(134, 111);
            this.messageControl1.TabIndex = 6;
            // 
            // addUsersControl1
            // 
            this.addUsersControl1.Location = new System.Drawing.Point(12, 28);
            this.addUsersControl1.Name = "addUsersControl1";
            this.addUsersControl1.Size = new System.Drawing.Size(207, 205);
            this.addUsersControl1.TabIndex = 1;
            // 
            // addUsersControl2
            // 
            this.addUsersControl2.Location = new System.Drawing.Point(21, 30);
            this.addUsersControl2.Name = "addUsersControl2";
            this.addUsersControl2.Size = new System.Drawing.Size(231, 158);
            this.addUsersControl2.TabIndex = 1;
            // 
            // ChatInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 310);
            this.Controls.Add(this.messageControl1);
            this.Controls.Add(this.btnWatchMessages);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lbNameChat);
            this.Controls.Add(this.addUsersControl1);
            this.Name = "ChatInterface";
            this.Text = "ChatInterface";
            this.Load += new System.EventHandler(this.ChatInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AddUsersControl addUsersControl1;
        private Controls.AddUsersControl addUsersControl2;
        private System.Windows.Forms.Label lbNameChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnWatchMessages;
        private Controls.MessageControl messageControl1;
    }
}