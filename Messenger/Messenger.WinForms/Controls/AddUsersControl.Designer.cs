namespace Messenger.WinForms.Controls
{
    partial class AddUsersControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtChatUsers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пользователи:";
            // 
            // txtChatUsers
            // 
            this.txtChatUsers.Location = new System.Drawing.Point(6, 42);
            this.txtChatUsers.Multiline = true;
            this.txtChatUsers.Name = "txtChatUsers";
            this.txtChatUsers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChatUsers.Size = new System.Drawing.Size(209, 54);
            this.txtChatUsers.TabIndex = 2;
            // 
            // AddUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtChatUsers);
            this.Controls.Add(this.label1);
            this.Name = "AddUsersControl";
            this.Size = new System.Drawing.Size(218, 158);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChatUsers;
    }
}
