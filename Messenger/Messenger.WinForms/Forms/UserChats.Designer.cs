namespace Messenger.WinForms.Forms
{
    partial class UserChats
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
            this.NewChat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbAllChats = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NewChat
            // 
            this.NewChat.Location = new System.Drawing.Point(27, 35);
            this.NewChat.Name = "NewChat";
            this.NewChat.Size = new System.Drawing.Size(61, 56);
            this.NewChat.TabIndex = 0;
            this.NewChat.Text = "Создать новый диалог";
            this.NewChat.UseVisualStyleBackColor = true;
            this.NewChat.Click += new System.EventHandler(this.NewChat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbAllChats
            // 
            this.cbAllChats.FormattingEnabled = true;
            this.cbAllChats.Location = new System.Drawing.Point(123, 54);
            this.cbAllChats.Name = "cbAllChats";
            this.cbAllChats.Size = new System.Drawing.Size(121, 21);
            this.cbAllChats.TabIndex = 2;
            this.cbAllChats.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UserChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 151);
            this.Controls.Add(this.cbAllChats);
            this.Controls.Add(this.NewChat);
            this.Name = "UserChats";
            this.Text = "UserChats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewChat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbAllChats;
    }
}