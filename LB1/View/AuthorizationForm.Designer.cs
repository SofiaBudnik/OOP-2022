
namespace Lab1
{
    partial class AuthorizationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ConfirmAuthButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(204, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЛОГИН";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(204, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ПАРОЛЬ";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(279, 218);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(189, 22);
            this.LoginBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(279, 253);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(189, 22);
            this.PasswordBox.TabIndex = 3;
            // 
            // ConfirmAuthButton
            // 
            this.ConfirmAuthButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmAuthButton.Location = new System.Drawing.Point(300, 305);
            this.ConfirmAuthButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmAuthButton.Name = "ConfirmAuthButton";
            this.ConfirmAuthButton.Size = new System.Drawing.Size(144, 43);
            this.ConfirmAuthButton.TabIndex = 4;
            this.ConfirmAuthButton.Text = "ВОЙТИ";
            this.ConfirmAuthButton.UseVisualStyleBackColor = false;
            this.ConfirmAuthButton.Click += new System.EventHandler(this.ConfirmAuthButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.Location = new System.Drawing.Point(11, 10);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 26);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 544);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmAuthButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ConfirmAuthButton;
        private System.Windows.Forms.Button BackButton;
    }
}