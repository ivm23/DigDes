namespace Messenger.WinForms.Forms
{
    partial class NewChat
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
            this.newChatControl1 = new Messenger.WinForms.Controls.NewChatControl();
            this.btnCreateChat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newChatControl1
            // 
            this.newChatControl1.Location = new System.Drawing.Point(12, 12);
            this.newChatControl1.Name = "newChatControl1";
            this.newChatControl1.Size = new System.Drawing.Size(463, 180);
            this.newChatControl1.TabIndex = 0;
            // 
            // btnCreateChat
            // 
            this.btnCreateChat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateChat.Location = new System.Drawing.Point(324, 228);
            this.btnCreateChat.Name = "btnCreateChat";
            this.btnCreateChat.Size = new System.Drawing.Size(75, 23);
            this.btnCreateChat.TabIndex = 1;
            this.btnCreateChat.Text = "Создать";
            this.btnCreateChat.UseVisualStyleBackColor = true;
            this.btnCreateChat.Click += new System.EventHandler(this.btnCreateChat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(429, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 263);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateChat);
            this.Controls.Add(this.newChatControl1);
            this.Name = "NewChat";
            this.Text = "NewChat";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NewChatControl newChatControl1;
        private System.Windows.Forms.Button btnCreateChat;
        private System.Windows.Forms.Button btnCancel;
    }
}