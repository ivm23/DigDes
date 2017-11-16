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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.addUsersControl1 = new Messenger.WinForms.Controls.AddUsersControl();
            this.addUsersControl2 = new Messenger.WinForms.Controls.AddUsersControl();
            this.AutoDelMess = new System.Windows.Forms.CheckBox();
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
            this.txtMessage.Location = new System.Drawing.Point(239, 150);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMessage.Size = new System.Drawing.Size(247, 71);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "Введите сообщение...";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(401, 227);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сообщения:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(239, 50);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(247, 94);
            this.checkedListBox1.TabIndex = 9;
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
            // AutoDelMess
            // 
            this.AutoDelMess.AutoSize = true;
            this.AutoDelMess.Location = new System.Drawing.Point(239, 227);
            this.AutoDelMess.Name = "AutoDelMess";
            this.AutoDelMess.Size = new System.Drawing.Size(157, 17);
            this.AutoDelMess.TabIndex = 10;
            this.AutoDelMess.Text = "Автоудаление сообщений";
            this.AutoDelMess.UseVisualStyleBackColor = true;
            // 
            // ChatInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 310);
            this.Controls.Add(this.AutoDelMess);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox AutoDelMess;
    }
}