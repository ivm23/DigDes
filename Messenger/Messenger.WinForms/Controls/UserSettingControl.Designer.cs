namespace Messenger.WinForms.Controls
{
    partial class UserSettingControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.txtUserSecondName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserTimeDelMes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Повторите пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Время автоудаления:";
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(152, 17);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUserFirstName.TabIndex = 12;
            // 
            // txtUserSecondName
            // 
            this.txtUserSecondName.Location = new System.Drawing.Point(152, 50);
            this.txtUserSecondName.Name = "txtUserSecondName";
            this.txtUserSecondName.Size = new System.Drawing.Size(100, 20);
            this.txtUserSecondName.TabIndex = 13;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(152, 75);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtUserPassword.TabIndex = 14;
            // 
            // txtRepeatUserPassword
            // 
            this.txtRepeatUserPassword.Location = new System.Drawing.Point(152, 104);
            this.txtRepeatUserPassword.Name = "txtRepeatUserPassword";
            this.txtRepeatUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRepeatUserPassword.TabIndex = 15;
            // 
            // txtUserTimeDelMes
            // 
            this.txtUserTimeDelMes.Location = new System.Drawing.Point(152, 131);
            this.txtUserTimeDelMes.Name = "txtUserTimeDelMes";
            this.txtUserTimeDelMes.Size = new System.Drawing.Size(100, 20);
            this.txtUserTimeDelMes.TabIndex = 16;
            // 
            // UserSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUserTimeDelMes);
            this.Controls.Add(this.txtRepeatUserPassword);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserSecondName);
            this.Controls.Add(this.txtUserFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserSettingControl";
            this.Size = new System.Drawing.Size(322, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.TextBox txtUserSecondName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtRepeatUserPassword;
        private System.Windows.Forms.TextBox txtUserTimeDelMes;
        
    }
}
