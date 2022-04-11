
namespace Lab1
{
    partial class AccountForm
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
            this.BanksBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.AccountBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InteractionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BanksBox
            // 
            this.BanksBox.FormattingEnabled = true;
            this.BanksBox.Location = new System.Drawing.Point(141, 50);
            this.BanksBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BanksBox.Name = "BanksBox";
            this.BanksBox.Size = new System.Drawing.Size(178, 24);
            this.BanksBox.TabIndex = 1;
            this.BanksBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "БАНК";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.ForeColor = System.Drawing.SystemColors.Info;
            this.BackButton.Location = new System.Drawing.Point(684, 373);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 25);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(141, 91);
            this.AmountBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(178, 22);
            this.AmountBox.TabIndex = 21;
            this.AmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountBox_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "СУММА";
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenButton.Location = new System.Drawing.Point(371, 130);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(241, 32);
            this.OpenButton.TabIndex = 23;
            this.OpenButton.Text = "ОТКРЫТЬ НОВЫЙ СЧЁТ ";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // AccountBox
            // 
            this.AccountBox.FormattingEnabled = true;
            this.AccountBox.Location = new System.Drawing.Point(141, 234);
            this.AccountBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(178, 24);
            this.AccountBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(11, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "ВЫБЕРИТЕ СЧЁТ";
            // 
            // InteractionButton
            // 
            this.InteractionButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.InteractionButton.Location = new System.Drawing.Point(371, 275);
            this.InteractionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InteractionButton.Name = "InteractionButton";
            this.InteractionButton.Size = new System.Drawing.Size(241, 30);
            this.InteractionButton.TabIndex = 26;
            this.InteractionButton.Text = "ПЕРЕЙТИ К ИТЕРАЦИЯМ";
            this.InteractionButton.UseVisualStyleBackColor = false;
            this.InteractionButton.Click += new System.EventHandler(this.InteractionButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 409);
            this.Controls.Add(this.InteractionButton);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BanksBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountForm";
            this.Text = "BankAccounts";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox BanksBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox AccountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InteractionButton;
    }
}