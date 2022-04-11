
namespace Lab1
{
    partial class AnotherSpecialistForm
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
            this.SumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TakeSalaryProjectButton = new System.Windows.Forms.Button();
            this.FromBox = new System.Windows.Forms.ComboBox();
            this.ToBox = new System.Windows.Forms.ComboBox();
            this.SumBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.InfoRichBox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogoutButton.Location = new System.Drawing.Point(601, 496);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(141, 26);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Выйти из аккаунта";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SumBox
            // 
            this.SumBox.Location = new System.Drawing.Point(131, 112);
            this.SumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SumBox.Name = "SumBox";
            this.SumBox.Size = new System.Drawing.Size(137, 22);
            this.SumBox.TabIndex = 5;
            this.SumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(70, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сумма";
            // 
            // TakeSalaryProjectButton
            // 
            this.TakeSalaryProjectButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.TakeSalaryProjectButton.Location = new System.Drawing.Point(91, 150);
            this.TakeSalaryProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TakeSalaryProjectButton.Name = "TakeSalaryProjectButton";
            this.TakeSalaryProjectButton.Size = new System.Drawing.Size(170, 32);
            this.TakeSalaryProjectButton.TabIndex = 7;
            this.TakeSalaryProjectButton.Text = "Отправить заявку";
            this.TakeSalaryProjectButton.UseVisualStyleBackColor = false;
            this.TakeSalaryProjectButton.Click += new System.EventHandler(this.TakeSalaryProjectButton_Click);
            // 
            // FromBox
            // 
            this.FromBox.FormattingEnabled = true;
            this.FromBox.Location = new System.Drawing.Point(110, 336);
            this.FromBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(158, 24);
            this.FromBox.TabIndex = 8;
            this.FromBox.SelectedIndexChanged += new System.EventHandler(this.FromBox_SelectedIndexChanged_1);
            // 
            // ToBox
            // 
            this.ToBox.FormattingEnabled = true;
            this.ToBox.Location = new System.Drawing.Point(110, 376);
            this.ToBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(158, 24);
            this.ToBox.TabIndex = 9;
            this.ToBox.SelectedIndexChanged += new System.EventHandler(this.ToBox_SelectedIndexChanged_1);
            // 
            // SumBox1
            // 
            this.SumBox1.Location = new System.Drawing.Point(110, 417);
            this.SumBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SumBox1.Name = "SumBox1";
            this.SumBox1.Size = new System.Drawing.Size(158, 22);
            this.SumBox1.TabIndex = 10;
            this.SumBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Отправитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Получатель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(12, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Сумма";
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.TransferButton.Location = new System.Drawing.Point(110, 452);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(119, 36);
            this.TransferButton.TabIndex = 14;
            this.TransferButton.Text = "Перевести";
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // InfoRichBox
            // 
            this.InfoRichBox.Location = new System.Drawing.Point(343, 31);
            this.InfoRichBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoRichBox.Name = "InfoRichBox";
            this.InfoRichBox.Size = new System.Drawing.Size(399, 352);
            this.InfoRichBox.TabIndex = 15;
            this.InfoRichBox.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearButton.Location = new System.Drawing.Point(343, 391);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 26);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(97, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Запрплатный проект";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(128, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Трансфер";
            // 
            // AnotherSpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.InfoRichBox);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumBox1);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.TakeSalaryProjectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumBox);
            this.Controls.Add(this.LogoutButton);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnotherSpecialistForm";
            this.Text = "AnotherSpecialistForm";
            this.Load += new System.EventHandler(this.AnotherSpecialistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TextBox SumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TakeSalaryProjectButton;
        private System.Windows.Forms.ComboBox FromBox;
        private System.Windows.Forms.ComboBox ToBox;
        private System.Windows.Forms.TextBox SumBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.RichTextBox InfoRichBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}