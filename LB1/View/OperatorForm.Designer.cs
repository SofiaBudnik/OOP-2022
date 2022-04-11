
namespace Lab1
{
    partial class OperatorForm
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
            this.InfoRichBox = new System.Windows.Forms.RichTextBox();
            this.ShowProjectsButton = new System.Windows.Forms.Button();
            this.ShowLogsButton = new System.Windows.Forms.Button();
            this.SalaryProjectsBox = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoRichBox
            // 
            this.InfoRichBox.Location = new System.Drawing.Point(321, 7);
            this.InfoRichBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoRichBox.Name = "InfoRichBox";
            this.InfoRichBox.Size = new System.Drawing.Size(513, 410);
            this.InfoRichBox.TabIndex = 0;
            this.InfoRichBox.Text = "";
            // 
            // ShowProjectsButton
            // 
            this.ShowProjectsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowProjectsButton.Location = new System.Drawing.Point(599, 421);
            this.ShowProjectsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowProjectsButton.Name = "ShowProjectsButton";
            this.ShowProjectsButton.Size = new System.Drawing.Size(235, 31);
            this.ShowProjectsButton.TabIndex = 1;
            this.ShowProjectsButton.Text = "Показать зарплатные проекты";
            this.ShowProjectsButton.UseVisualStyleBackColor = false;
            this.ShowProjectsButton.Click += new System.EventHandler(this.ShowProjectsButton_Click);
            // 
            // ShowLogsButton
            // 
            this.ShowLogsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowLogsButton.Location = new System.Drawing.Point(321, 421);
            this.ShowLogsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowLogsButton.Name = "ShowLogsButton";
            this.ShowLogsButton.Size = new System.Drawing.Size(240, 31);
            this.ShowLogsButton.TabIndex = 2;
            this.ShowLogsButton.Text = "Показать логи";
            this.ShowLogsButton.UseVisualStyleBackColor = false;
            this.ShowLogsButton.Click += new System.EventHandler(this.ShowLogsButton_Click);
            // 
            // SalaryProjectsBox
            // 
            this.SalaryProjectsBox.FormattingEnabled = true;
            this.SalaryProjectsBox.Location = new System.Drawing.Point(14, 82);
            this.SalaryProjectsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryProjectsBox.Name = "SalaryProjectsBox";
            this.SalaryProjectsBox.Size = new System.Drawing.Size(160, 24);
            this.SalaryProjectsBox.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmButton.Location = new System.Drawing.Point(14, 121);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(105, 29);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeclineButton.Location = new System.Drawing.Point(171, 121);
            this.DeclineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(102, 29);
            this.DeclineButton.TabIndex = 5;
            this.DeclineButton.Text = "Отклонить";
            this.DeclineButton.UseVisualStyleBackColor = false;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowButton.Location = new System.Drawing.Point(180, 82);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(93, 29);
            this.ShowButton.TabIndex = 6;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Заявки на зарплатный проект";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogoutButton.Location = new System.Drawing.Point(691, 518);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(153, 26);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Выйти из аккаунта";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 555);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SalaryProjectsBox);
            this.Controls.Add(this.ShowLogsButton);
            this.Controls.Add(this.ShowProjectsButton);
            this.Controls.Add(this.InfoRichBox);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OperatorForm";
            this.Text = "FinancialSystemManagement(Operator)";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoRichBox;
        private System.Windows.Forms.Button ShowProjectsButton;
        private System.Windows.Forms.Button ShowLogsButton;
        private System.Windows.Forms.ComboBox SalaryProjectsBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButton;
    }
}