namespace Messenger.WinForms.Controls
{
    partial class UserCheckInControl
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
            this.txtUserTimeDelMes = new System.Windows.Forms.TextBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCancelCheckIn = new System.Windows.Forms.Button();
            this.pbUserPhoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(42, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время удаления сообщений:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(42, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Загрузить фотографию:";
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(204, 82);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUserFirstName.TabIndex = 5;
            // 
            // txtUserSecondName
            // 
            this.txtUserSecondName.Location = new System.Drawing.Point(204, 109);
            this.txtUserSecondName.Name = "txtUserSecondName";
            this.txtUserSecondName.Size = new System.Drawing.Size(100, 20);
            this.txtUserSecondName.TabIndex = 6;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(204, 135);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtUserPassword.TabIndex = 7;
            // 
            // txtUserTimeDelMes
            // 
            this.txtUserTimeDelMes.Location = new System.Drawing.Point(204, 161);
            this.txtUserTimeDelMes.Name = "txtUserTimeDelMes";
            this.txtUserTimeDelMes.Size = new System.Drawing.Size(100, 20);
            this.txtUserTimeDelMes.TabIndex = 8;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(204, 210);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(100, 35);
            this.btnSelectPicture.TabIndex = 9;
            this.btnSelectPicture.Text = "Обзор...";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCheckIn.Location = new System.Drawing.Point(262, 297);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(105, 32);
            this.btnCheckIn.TabIndex = 10;
            this.btnCheckIn.Text = "Регистрация";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCancelCheckIn
            // 
            this.btnCancelCheckIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCheckIn.Location = new System.Drawing.Point(373, 297);
            this.btnCancelCheckIn.Name = "btnCancelCheckIn";
            this.btnCancelCheckIn.Size = new System.Drawing.Size(105, 32);
            this.btnCancelCheckIn.TabIndex = 11;
            this.btnCancelCheckIn.Text = "Отмена";
            this.btnCancelCheckIn.UseVisualStyleBackColor = true;
            // 
            // pbUserPhoto
            // 
            this.pbUserPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbUserPhoto.Image = global::Messenger.WinForms.Properties.Resources.BzcvL1m7NKQ;
            this.pbUserPhoto.Location = new System.Drawing.Point(328, 158);
            this.pbUserPhoto.Name = "pbUserPhoto";
            this.pbUserPhoto.Size = new System.Drawing.Size(88, 122);
            this.pbUserPhoto.TabIndex = 12;
            this.pbUserPhoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(42, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Логин:";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Location = new System.Drawing.Point(204, 52);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(100, 20);
            this.txtUserLogin.TabIndex = 14;
            // 
            // UserCheckInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbUserPhoto);
            this.Controls.Add(this.btnCancelCheckIn);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.txtUserTimeDelMes);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserSecondName);
            this.Controls.Add(this.txtUserFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserCheckInControl";
            this.Size = new System.Drawing.Size(492, 342);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).EndInit();
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
        private System.Windows.Forms.TextBox txtUserTimeDelMes;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCancelCheckIn;
        private System.Windows.Forms.PictureBox pbUserPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserLogin;
    }
}
