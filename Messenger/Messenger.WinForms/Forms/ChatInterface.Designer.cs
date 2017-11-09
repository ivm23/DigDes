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
            this.lbNameChat = new System.Windows.Forms.Label();
            this.addUsersControl2 = new Messenger.WinForms.Controls.AddUsersControl();
            this.addUsersControl1 = new Messenger.WinForms.Controls.AddUsersControl();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // addUsersControl2
            // 
            this.addUsersControl2.Location = new System.Drawing.Point(21, 30);
            this.addUsersControl2.Name = "addUsersControl2";
            this.addUsersControl2.Size = new System.Drawing.Size(231, 158);
            this.addUsersControl2.TabIndex = 1;
            // 
            // addUsersControl1
            // 
            this.addUsersControl1.Location = new System.Drawing.Point(67, 177);
            this.addUsersControl1.Name = "addUsersControl1";
            this.addUsersControl1.Size = new System.Drawing.Size(207, 205);
            this.addUsersControl1.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(282, 202);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(221, 71);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "Введите сообщение...";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(428, 279);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Отправить";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(282, 70);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.ScrollAlwaysVisible = true;
            this.lbMessages.Size = new System.Drawing.Size(221, 121);
            this.lbMessages.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сообщения:";
            // 
            // ChatInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lbNameChat);
            this.Controls.Add(this.addUsersControl2);
            this.Name = "ChatInterface";
            this.Text = "ChatInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AddUsersControl addUsersControl1;
        private Controls.AddUsersControl addUsersControl2;
        private System.Windows.Forms.Label lbNameChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.Label label1;
    }
}