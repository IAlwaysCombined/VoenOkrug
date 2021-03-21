namespace VoenOkrug
{
    partial class Form1
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
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLoginAuthorization = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPasswordAuthorization = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.25F);
            this.labelAuthorization.Location = new System.Drawing.Point(606, 124);
            this.labelAuthorization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(774, 134);
            this.labelAuthorization.TabIndex = 0;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelLogin.Location = new System.Drawing.Point(619, 406);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(166, 59);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLoginAuthorization
            // 
            this.textBoxLoginAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.textBoxLoginAuthorization.Location = new System.Drawing.Point(629, 469);
            this.textBoxLoginAuthorization.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginAuthorization.Name = "textBoxLoginAuthorization";
            this.textBoxLoginAuthorization.Size = new System.Drawing.Size(795, 65);
            this.textBoxLoginAuthorization.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelPassword.Location = new System.Drawing.Point(619, 538);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(202, 59);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPasswordAuthorization
            // 
            this.textBoxPasswordAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.textBoxPasswordAuthorization.Location = new System.Drawing.Point(629, 601);
            this.textBoxPasswordAuthorization.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordAuthorization.Name = "textBoxPasswordAuthorization";
            this.textBoxPasswordAuthorization.Size = new System.Drawing.Size(795, 65);
            this.textBoxPasswordAuthorization.TabIndex = 4;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.buttonEnter.Location = new System.Drawing.Point(628, 674);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(796, 89);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPasswordAuthorization);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLoginAuthorization);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelAuthorization);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLoginAuthorization;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPasswordAuthorization;
        private System.Windows.Forms.Button buttonEnter;
    }
}

