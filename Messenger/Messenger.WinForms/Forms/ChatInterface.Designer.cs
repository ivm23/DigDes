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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatInterface));
            this.lbNameChat = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AutoDelMess = new System.Windows.Forms.CheckBox();
            this.addUsersControl1 = new Messenger.WinForms.Controls.AddUsersControl();
            this.addUsersControl2 = new Messenger.WinForms.Controls.AddUsersControl();
            this.SuspendLayout();
            // 
            // lbNameChat
            // 
            this.lbNameChat.AutoSize = true;
            this.lbNameChat.BackColor = System.Drawing.SystemColors.Control;
            this.lbNameChat.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbNameChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbNameChat.Location = new System.Drawing.Point(41, 15);
            this.lbNameChat.Name = "lbNameChat";
            this.lbNameChat.Size = new System.Drawing.Size(57, 19);
            this.lbNameChat.TabIndex = 2;
            this.lbNameChat.Text = "        ";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.RosyBrown;
            this.txtMessage.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMessage.Location = new System.Drawing.Point(310, 196);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMessage.Size = new System.Drawing.Size(303, 57);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "Введите сообщение...";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.SystemColors.Window;
            this.btnSendMessage.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSendMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSendMessage.Location = new System.Drawing.Point(435, 265);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(122, 43);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Отправить";
            this.btnSendMessage.UseVisualStyleBackColor = false;
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
            this.label1.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(310, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сообщения :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.checkedListBox1.Font = new System.Drawing.Font("VAGRounded BT", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(310, 82);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(303, 76);
            this.checkedListBox1.TabIndex = 9;
            // 
            // AutoDelMess
            // 
            this.AutoDelMess.AutoSize = true;
            this.AutoDelMess.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.AutoDelMess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AutoDelMess.Location = new System.Drawing.Point(42, 236);
            this.AutoDelMess.Name = "AutoDelMess";
            this.AutoDelMess.Size = new System.Drawing.Size(231, 23);
            this.AutoDelMess.TabIndex = 10;
            this.AutoDelMess.Text = "Автоудаление сообщений";
            this.AutoDelMess.UseVisualStyleBackColor = true;
            // 
            // addUsersControl1
            // 
            this.addUsersControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUsersControl1.BackgroundImage")));
            this.addUsersControl1.Location = new System.Drawing.Point(1, -6);
            this.addUsersControl1.Name = "addUsersControl1";
            this.addUsersControl1.Size = new System.Drawing.Size(649, 331);
            this.addUsersControl1.TabIndex = 1;
            // 
            // addUsersControl2
            // 
            this.addUsersControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUsersControl2.BackgroundImage")));
            this.addUsersControl2.Location = new System.Drawing.Point(21, 30);
            this.addUsersControl2.Name = "addUsersControl2";
            this.addUsersControl2.Size = new System.Drawing.Size(231, 158);
            this.addUsersControl2.TabIndex = 1;
            // 
            // ChatInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 318);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.AutoDelMess);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbNameChat);
            this.Controls.Add(this.addUsersControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatInterface";
            this.Text = "PANDAChatInterface";
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