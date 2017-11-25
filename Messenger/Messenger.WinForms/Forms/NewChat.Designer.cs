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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewChat));
            this.btnCreateChat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.newChatControl1 = new Messenger.WinForms.Controls.NewChatControl();
            this.SuspendLayout();
            // 
            // btnCreateChat
            // 
            this.btnCreateChat.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreateChat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateChat.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCreateChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateChat.Location = new System.Drawing.Point(28, 335);
            this.btnCreateChat.Name = "btnCreateChat";
            this.btnCreateChat.Size = new System.Drawing.Size(94, 43);
            this.btnCreateChat.TabIndex = 1;
            this.btnCreateChat.Text = "Создать";
            this.btnCreateChat.UseVisualStyleBackColor = false;
            this.btnCreateChat.Click += new System.EventHandler(this.btnCreateChat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(152, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 43);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // newChatControl1
            // 
            this.newChatControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newChatControl1.BackgroundImage")));
            this.newChatControl1.Location = new System.Drawing.Point(1, 1);
            this.newChatControl1.Name = "newChatControl1";
            this.newChatControl1.Size = new System.Drawing.Size(279, 399);
            this.newChatControl1.TabIndex = 0;
            // 
            // NewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 394);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateChat);
            this.Controls.Add(this.newChatControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewChat";
            this.Text = "PANDANewChat";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NewChatControl newChatControl1;
        private System.Windows.Forms.Button btnCreateChat;
        private System.Windows.Forms.Button btnCancel;
    }
}