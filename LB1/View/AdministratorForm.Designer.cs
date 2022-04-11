
namespace Lab1
{
    partial class AdministratorForm
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
            this.LogsBox = new System.Windows.Forms.RichTextBox();
            this.ShowLogsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogoutButton.Location = new System.Drawing.Point(11, 10);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(156, 26);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Выйти из аккаунта";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LogsBox
            // 
            this.LogsBox.Location = new System.Drawing.Point(67, 49);
            this.LogsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogsBox.Name = "LogsBox";
            this.LogsBox.Size = new System.Drawing.Size(573, 362);
            this.LogsBox.TabIndex = 5;
            this.LogsBox.Text = "";
            // 
            // ShowLogsButton
            // 
            this.ShowLogsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowLogsButton.Location = new System.Drawing.Point(530, 425);
            this.ShowLogsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowLogsButton.Name = "ShowLogsButton";
            this.ShowLogsButton.Size = new System.Drawing.Size(174, 45);
            this.ShowLogsButton.TabIndex = 6;
            this.ShowLogsButton.Text = "Просмотр логов";
            this.ShowLogsButton.UseVisualStyleBackColor = false;
            this.ShowLogsButton.Click += new System.EventHandler(this.ShowLogsButton_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 481);
            this.Controls.Add(this.ShowLogsButton);
            this.Controls.Add(this.LogsBox);
            this.Controls.Add(this.LogoutButton);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.RichTextBox LogsBox;
        private System.Windows.Forms.Button ShowLogsButton;
    }
}