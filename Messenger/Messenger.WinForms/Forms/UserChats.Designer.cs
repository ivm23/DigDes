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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChats));
            this.NewChat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbAllChats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewChat
            // 
            this.NewChat.BackColor = System.Drawing.SystemColors.Window;
            this.NewChat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NewChat.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.NewChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NewChat.Location = new System.Drawing.Point(26, 123);
            this.NewChat.Name = "NewChat";
            this.NewChat.Size = new System.Drawing.Size(148, 63);
            this.NewChat.TabIndex = 0;
            this.NewChat.Text = "Создать новый диалог";
            this.NewChat.UseVisualStyleBackColor = false;
            this.NewChat.Click += new System.EventHandler(this.NewChat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbAllChats
            // 
            this.cbAllChats.BackColor = System.Drawing.Color.RosyBrown;
            this.cbAllChats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllChats.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbAllChats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbAllChats.FormattingEnabled = true;
            this.cbAllChats.Location = new System.Drawing.Point(26, 67);
            this.cbAllChats.Name = "cbAllChats";
            this.cbAllChats.Size = new System.Drawing.Size(148, 27);
            this.cbAllChats.TabIndex = 2;
            this.cbAllChats.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбрать диалог :";
            // 
            // UserChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(202, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllChats);
            this.Controls.Add(this.NewChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserChats";
            this.Text = "PANDAChats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewChat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbAllChats;
        private System.Windows.Forms.Label label1;
    }
}