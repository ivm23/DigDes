namespace Messenger.WinForms
{
    partial class StartForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnMainEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(96, 134);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(129, 55);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Зарегистрироваться";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnMainEnter
            // 
            this.btnMainEnter.Location = new System.Drawing.Point(96, 63);
            this.btnMainEnter.Name = "btnMainEnter";
            this.btnMainEnter.Size = new System.Drawing.Size(129, 54);
            this.btnMainEnter.TabIndex = 2;
            this.btnMainEnter.Text = "Войти";
            this.btnMainEnter.UseVisualStyleBackColor = true;
            this.btnMainEnter.Click += new System.EventHandler(this.btnMainEnter_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 288);
            this.Controls.Add(this.btnMainEnter);
            this.Controls.Add(this.btnCheckIn);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            //this.Click += new System.EventHandler();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnMainEnter;
    }
}

