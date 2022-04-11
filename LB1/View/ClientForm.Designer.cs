
namespace Lab1
{
    partial class ClientForm
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
            this.BankAccountsButton = new System.Windows.Forms.Button();
            this.CreditsInstallmentsButton = new System.Windows.Forms.Button();
            this.SalaryProjectButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BankAccountsButton
            // 
            this.BankAccountsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BankAccountsButton.Location = new System.Drawing.Point(85, 117);
            this.BankAccountsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BankAccountsButton.Name = "BankAccountsButton";
            this.BankAccountsButton.Size = new System.Drawing.Size(180, 28);
            this.BankAccountsButton.TabIndex = 0;
            this.BankAccountsButton.Text = "Банковские счета";
            this.BankAccountsButton.UseVisualStyleBackColor = false;
            this.BankAccountsButton.Click += new System.EventHandler(this.BankAccountsButton_Click);
            // 
            // CreditsInstallmentsButton
            // 
            this.CreditsInstallmentsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreditsInstallmentsButton.Location = new System.Drawing.Point(85, 192);
            this.CreditsInstallmentsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreditsInstallmentsButton.Name = "CreditsInstallmentsButton";
            this.CreditsInstallmentsButton.Size = new System.Drawing.Size(180, 31);
            this.CreditsInstallmentsButton.TabIndex = 1;
            this.CreditsInstallmentsButton.Text = "Кредиты и рассрочки";
            this.CreditsInstallmentsButton.UseVisualStyleBackColor = false;
            this.CreditsInstallmentsButton.Click += new System.EventHandler(this.CreditsInstallmentsButton_Click);
            // 
            // SalaryProjectButton
            // 
            this.SalaryProjectButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SalaryProjectButton.Location = new System.Drawing.Point(85, 280);
            this.SalaryProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryProjectButton.Name = "SalaryProjectButton";
            this.SalaryProjectButton.Size = new System.Drawing.Size(180, 29);
            this.SalaryProjectButton.TabIndex = 2;
            this.SalaryProjectButton.Text = "Зарплатный проект";
            this.SalaryProjectButton.UseVisualStyleBackColor = false;
            this.SalaryProjectButton.Click += new System.EventHandler(this.SalaryProjectButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogoutButton.Location = new System.Drawing.Point(587, 506);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(154, 26);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Выйти из аккаунта";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(332, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Управление страрыми счетами и создание новых";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(332, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Просмотр ваших кредитов/рассрочек, возможность взять новый кредит/рассрочку";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(332, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Возможность оставить заявку на зарплатный проект";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SalaryProjectButton);
            this.Controls.Add(this.CreditsInstallmentsButton);
            this.Controls.Add(this.BankAccountsButton);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientForm";
            this.Text = "FinancialSystemManagement";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BankAccountsButton;
        private System.Windows.Forms.Button CreditsInstallmentsButton;
        private System.Windows.Forms.Button SalaryProjectButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}