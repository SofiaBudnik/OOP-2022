
namespace Lab1
{
    partial class ManagerForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SalaryProjectsBox = new System.Windows.Forms.ComboBox();
            this.ShowCreditsButton = new System.Windows.Forms.Button();
            this.ShowProjectsButton = new System.Windows.Forms.Button();
            this.InfoRichBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowButton1 = new System.Windows.Forms.Button();
            this.DeclineButton1 = new System.Windows.Forms.Button();
            this.ConfirmButton1 = new System.Windows.Forms.Button();
            this.CreditsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowButton2 = new System.Windows.Forms.Button();
            this.DeclineButton2 = new System.Windows.Forms.Button();
            this.ConfirmButton2 = new System.Windows.Forms.Button();
            this.InstallmentsBox = new System.Windows.Forms.ComboBox();
            this.ShowInstallmentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogoutButton.Location = new System.Drawing.Point(675, 491);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(147, 26);
            this.LogoutButton.TabIndex = 18;
            this.LogoutButton.Text = "Выйти из аккаунта";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(530, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Заявки на зарплатный проект";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowButton.Location = new System.Drawing.Point(748, 101);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(93, 29);
            this.ShowButton.TabIndex = 16;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeclineButton.Location = new System.Drawing.Point(646, 101);
            this.DeclineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(93, 29);
            this.DeclineButton.TabIndex = 15;
            this.DeclineButton.Text = "Отказать";
            this.DeclineButton.UseVisualStyleBackColor = false;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmButton.Location = new System.Drawing.Point(533, 101);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(107, 29);
            this.ConfirmButton.TabIndex = 14;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SalaryProjectsBox
            // 
            this.SalaryProjectsBox.FormattingEnabled = true;
            this.SalaryProjectsBox.Location = new System.Drawing.Point(533, 63);
            this.SalaryProjectsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryProjectsBox.Name = "SalaryProjectsBox";
            this.SalaryProjectsBox.Size = new System.Drawing.Size(160, 24);
            this.SalaryProjectsBox.TabIndex = 13;
            // 
            // ShowCreditsButton
            // 
            this.ShowCreditsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowCreditsButton.Location = new System.Drawing.Point(197, 400);
            this.ShowCreditsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowCreditsButton.Name = "ShowCreditsButton";
            this.ShowCreditsButton.Size = new System.Drawing.Size(138, 61);
            this.ShowCreditsButton.TabIndex = 12;
            this.ShowCreditsButton.Text = "Просмотр кредитов";
            this.ShowCreditsButton.UseVisualStyleBackColor = false;
            this.ShowCreditsButton.Click += new System.EventHandler(this.ShowCreditsButton_Click);
            // 
            // ShowProjectsButton
            // 
            this.ShowProjectsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowProjectsButton.Location = new System.Drawing.Point(12, 400);
            this.ShowProjectsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowProjectsButton.Name = "ShowProjectsButton";
            this.ShowProjectsButton.Size = new System.Drawing.Size(140, 61);
            this.ShowProjectsButton.TabIndex = 11;
            this.ShowProjectsButton.Text = "Просмотр зарплатных проектов";
            this.ShowProjectsButton.UseVisualStyleBackColor = false;
            this.ShowProjectsButton.Click += new System.EventHandler(this.ShowProjectsButton_Click);
            // 
            // InfoRichBox
            // 
            this.InfoRichBox.Location = new System.Drawing.Point(12, 26);
            this.InfoRichBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoRichBox.Name = "InfoRichBox";
            this.InfoRichBox.Size = new System.Drawing.Size(499, 370);
            this.InfoRichBox.TabIndex = 10;
            this.InfoRichBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(530, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Заявки на кредит";
            // 
            // ShowButton1
            // 
            this.ShowButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowButton1.Location = new System.Drawing.Point(748, 211);
            this.ShowButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowButton1.Name = "ShowButton1";
            this.ShowButton1.Size = new System.Drawing.Size(93, 29);
            this.ShowButton1.TabIndex = 22;
            this.ShowButton1.Text = "Показать";
            this.ShowButton1.UseVisualStyleBackColor = false;
            this.ShowButton1.Click += new System.EventHandler(this.ShowButton1_Click);
            // 
            // DeclineButton1
            // 
            this.DeclineButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeclineButton1.Location = new System.Drawing.Point(646, 211);
            this.DeclineButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeclineButton1.Name = "DeclineButton1";
            this.DeclineButton1.Size = new System.Drawing.Size(93, 29);
            this.DeclineButton1.TabIndex = 21;
            this.DeclineButton1.Text = "Отказать";
            this.DeclineButton1.UseVisualStyleBackColor = false;
            this.DeclineButton1.Click += new System.EventHandler(this.DeclineButton1_Click);
            // 
            // ConfirmButton1
            // 
            this.ConfirmButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmButton1.Location = new System.Drawing.Point(533, 211);
            this.ConfirmButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton1.Name = "ConfirmButton1";
            this.ConfirmButton1.Size = new System.Drawing.Size(107, 29);
            this.ConfirmButton1.TabIndex = 20;
            this.ConfirmButton1.Text = "Подтвердить";
            this.ConfirmButton1.UseVisualStyleBackColor = false;
            this.ConfirmButton1.Click += new System.EventHandler(this.ConfirmButton1_Click);
            // 
            // CreditsBox
            // 
            this.CreditsBox.FormattingEnabled = true;
            this.CreditsBox.Location = new System.Drawing.Point(533, 172);
            this.CreditsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreditsBox.Name = "CreditsBox";
            this.CreditsBox.Size = new System.Drawing.Size(160, 24);
            this.CreditsBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(530, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Заявки на рассрочку";
            // 
            // ShowButton2
            // 
            this.ShowButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowButton2.Location = new System.Drawing.Point(748, 329);
            this.ShowButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowButton2.Name = "ShowButton2";
            this.ShowButton2.Size = new System.Drawing.Size(93, 29);
            this.ShowButton2.TabIndex = 27;
            this.ShowButton2.Text = "Показать";
            this.ShowButton2.UseVisualStyleBackColor = false;
            this.ShowButton2.Click += new System.EventHandler(this.ShowButton2_Click);
            // 
            // DeclineButton2
            // 
            this.DeclineButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeclineButton2.Location = new System.Drawing.Point(646, 329);
            this.DeclineButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeclineButton2.Name = "DeclineButton2";
            this.DeclineButton2.Size = new System.Drawing.Size(93, 29);
            this.DeclineButton2.TabIndex = 26;
            this.DeclineButton2.Text = "Отказать";
            this.DeclineButton2.UseVisualStyleBackColor = false;
            this.DeclineButton2.Click += new System.EventHandler(this.DeclineButton2_Click);
            // 
            // ConfirmButton2
            // 
            this.ConfirmButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmButton2.Location = new System.Drawing.Point(533, 329);
            this.ConfirmButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton2.Name = "ConfirmButton2";
            this.ConfirmButton2.Size = new System.Drawing.Size(107, 29);
            this.ConfirmButton2.TabIndex = 25;
            this.ConfirmButton2.Text = "Подтвердить";
            this.ConfirmButton2.UseVisualStyleBackColor = false;
            this.ConfirmButton2.Click += new System.EventHandler(this.ConfirmButton2_Click);
            // 
            // InstallmentsBox
            // 
            this.InstallmentsBox.FormattingEnabled = true;
            this.InstallmentsBox.Location = new System.Drawing.Point(533, 291);
            this.InstallmentsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstallmentsBox.Name = "InstallmentsBox";
            this.InstallmentsBox.Size = new System.Drawing.Size(160, 24);
            this.InstallmentsBox.TabIndex = 24;
            // 
            // ShowInstallmentsButton
            // 
            this.ShowInstallmentsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowInstallmentsButton.Location = new System.Drawing.Point(373, 400);
            this.ShowInstallmentsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowInstallmentsButton.Name = "ShowInstallmentsButton";
            this.ShowInstallmentsButton.Size = new System.Drawing.Size(138, 61);
            this.ShowInstallmentsButton.TabIndex = 29;
            this.ShowInstallmentsButton.Text = "Просмотр рассрочек";
            this.ShowInstallmentsButton.UseVisualStyleBackColor = false;
            this.ShowInstallmentsButton.Click += new System.EventHandler(this.ShowInstallmentsButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 537);
            this.Controls.Add(this.ShowInstallmentsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowButton2);
            this.Controls.Add(this.DeclineButton2);
            this.Controls.Add(this.ConfirmButton2);
            this.Controls.Add(this.InstallmentsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowButton1);
            this.Controls.Add(this.DeclineButton1);
            this.Controls.Add(this.ConfirmButton1);
            this.Controls.Add(this.CreditsBox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SalaryProjectsBox);
            this.Controls.Add(this.ShowCreditsButton);
            this.Controls.Add(this.ShowProjectsButton);
            this.Controls.Add(this.InfoRichBox);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ComboBox SalaryProjectsBox;
        private System.Windows.Forms.Button ShowCreditsButton;
        private System.Windows.Forms.Button ShowProjectsButton;
        private System.Windows.Forms.RichTextBox InfoRichBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowButton1;
        private System.Windows.Forms.Button DeclineButton1;
        private System.Windows.Forms.Button ConfirmButton1;
        private System.Windows.Forms.ComboBox CreditsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowButton2;
        private System.Windows.Forms.Button DeclineButton2;
        private System.Windows.Forms.Button ConfirmButton2;
        private System.Windows.Forms.ComboBox InstallmentsBox;
        private System.Windows.Forms.Button ShowInstallmentsButton;
    }
}