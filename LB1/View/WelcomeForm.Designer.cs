
namespace Lab1
{
    partial class WelcomeForm
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
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AuthorizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AuthorizationButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AuthorizationButton.Location = new System.Drawing.Point(-2, 267);
            this.AuthorizationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(752, 57);
            this.AuthorizationButton.TabIndex = 0;
            this.AuthorizationButton.Text = "Войти";
            this.AuthorizationButton.UseVisualStyleBackColor = false;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RegistrationButton.ForeColor = System.Drawing.SystemColors.Info;
            this.RegistrationButton.Location = new System.Drawing.Point(-2, 201);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(752, 62);
            this.RegistrationButton.TabIndex = 1;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(-2, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "БАНКОВСКАЯ СИСТЕМА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.AuthorizationButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WelcomeForm";
            this.Text = "Банковская система";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label label1;
    }
}

