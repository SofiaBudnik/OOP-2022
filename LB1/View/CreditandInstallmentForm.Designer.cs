
namespace Lab1
{
    partial class CreditandInstallmentForm
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
            this.MyCreditsButton = new System.Windows.Forms.Button();
            this.MyInstallmentsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BankBox1 = new System.Windows.Forms.ComboBox();
            this.AmountBox1 = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.MonthsBox1 = new System.Windows.Forms.ComboBox();
            this.BankBox2 = new System.Windows.Forms.ComboBox();
            this.MonthsBox2 = new System.Windows.Forms.ComboBox();
            this.AmountBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmButton1 = new System.Windows.Forms.Button();
            this.ConfirmButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoRichBox
            // 
            this.InfoRichBox.Location = new System.Drawing.Point(34, 54);
            this.InfoRichBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoRichBox.Name = "InfoRichBox";
            this.InfoRichBox.Size = new System.Drawing.Size(363, 418);
            this.InfoRichBox.TabIndex = 0;
            this.InfoRichBox.Text = "";
            // 
            // MyCreditsButton
            // 
            this.MyCreditsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.MyCreditsButton.Location = new System.Drawing.Point(257, 476);
            this.MyCreditsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyCreditsButton.Name = "MyCreditsButton";
            this.MyCreditsButton.Size = new System.Drawing.Size(140, 42);
            this.MyCreditsButton.TabIndex = 1;
            this.MyCreditsButton.Text = "Показать мои кредиты";
            this.MyCreditsButton.UseVisualStyleBackColor = false;
            this.MyCreditsButton.Click += new System.EventHandler(this.MyCreditsButton_Click);
            // 
            // MyInstallmentsButton
            // 
            this.MyInstallmentsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.MyInstallmentsButton.Location = new System.Drawing.Point(34, 476);
            this.MyInstallmentsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyInstallmentsButton.Name = "MyInstallmentsButton";
            this.MyInstallmentsButton.Size = new System.Drawing.Size(140, 42);
            this.MyInstallmentsButton.TabIndex = 2;
            this.MyInstallmentsButton.Text = "Показать мои рассрочки";
            this.MyInstallmentsButton.UseVisualStyleBackColor = false;
            this.MyInstallmentsButton.Click += new System.EventHandler(this.MyInstallmentsButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(419, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Взять кредит";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(670, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Взять рассрочку";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BankBox1
            // 
            this.BankBox1.FormattingEnabled = true;
            this.BankBox1.Location = new System.Drawing.Point(419, 118);
            this.BankBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BankBox1.Name = "BankBox1";
            this.BankBox1.Size = new System.Drawing.Size(177, 24);
            this.BankBox1.TabIndex = 5;
            // 
            // AmountBox1
            // 
            this.AmountBox1.Location = new System.Drawing.Point(419, 224);
            this.AmountBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountBox1.Name = "AmountBox1";
            this.AmountBox1.Size = new System.Drawing.Size(177, 22);
            this.AmountBox1.TabIndex = 9;
            this.AmountBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountBox1_KeyPress);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.Location = new System.Drawing.Point(11, 10);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 25);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MonthsBox1
            // 
            this.MonthsBox1.FormattingEnabled = true;
            this.MonthsBox1.Location = new System.Drawing.Point(419, 172);
            this.MonthsBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthsBox1.Name = "MonthsBox1";
            this.MonthsBox1.Size = new System.Drawing.Size(177, 24);
            this.MonthsBox1.TabIndex = 22;
            // 
            // BankBox2
            // 
            this.BankBox2.FormattingEnabled = true;
            this.BankBox2.Location = new System.Drawing.Point(667, 288);
            this.BankBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BankBox2.Name = "BankBox2";
            this.BankBox2.Size = new System.Drawing.Size(177, 24);
            this.BankBox2.TabIndex = 23;
            // 
            // MonthsBox2
            // 
            this.MonthsBox2.FormattingEnabled = true;
            this.MonthsBox2.Location = new System.Drawing.Point(667, 342);
            this.MonthsBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthsBox2.Name = "MonthsBox2";
            this.MonthsBox2.Size = new System.Drawing.Size(177, 24);
            this.MonthsBox2.TabIndex = 24;
            // 
            // AmountBox2
            // 
            this.AmountBox2.Location = new System.Drawing.Point(667, 394);
            this.AmountBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountBox2.Name = "AmountBox2";
            this.AmountBox2.Size = new System.Drawing.Size(177, 22);
            this.AmountBox2.TabIndex = 25;
            this.AmountBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(421, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Банк";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(667, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Банк";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(419, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Месяцы";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(667, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Месяцы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(419, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Сумма";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(667, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Сумма";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfirmButton1
            // 
            this.ConfirmButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmButton1.Location = new System.Drawing.Point(452, 271);
            this.ConfirmButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton1.Name = "ConfirmButton1";
            this.ConfirmButton1.Size = new System.Drawing.Size(105, 31);
            this.ConfirmButton1.TabIndex = 32;
            this.ConfirmButton1.Text = "Готово";
            this.ConfirmButton1.UseVisualStyleBackColor = false;
            this.ConfirmButton1.Click += new System.EventHandler(this.ConfirmButton1_Click);
            // 
            // ConfirmButton2
            // 
            this.ConfirmButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmButton2.Location = new System.Drawing.Point(704, 441);
            this.ConfirmButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton2.Name = "ConfirmButton2";
            this.ConfirmButton2.Size = new System.Drawing.Size(105, 31);
            this.ConfirmButton2.TabIndex = 33;
            this.ConfirmButton2.Text = "Готово";
            this.ConfirmButton2.UseVisualStyleBackColor = false;
            this.ConfirmButton2.Click += new System.EventHandler(this.ConfirmButton2_Click);
            // 
            // CreditandInstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 546);
            this.Controls.Add(this.ConfirmButton2);
            this.Controls.Add(this.ConfirmButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountBox2);
            this.Controls.Add(this.MonthsBox2);
            this.Controls.Add(this.BankBox2);
            this.Controls.Add(this.MonthsBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AmountBox1);
            this.Controls.Add(this.BankBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyInstallmentsButton);
            this.Controls.Add(this.MyCreditsButton);
            this.Controls.Add(this.InfoRichBox);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreditandInstallmentForm";
            this.Text = "CreditandInstallment";
            this.Load += new System.EventHandler(this.CreditandInstallmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoRichBox;
        private System.Windows.Forms.Button MyCreditsButton;
        private System.Windows.Forms.Button MyInstallmentsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BankBox1;
        private System.Windows.Forms.TextBox AmountBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox MonthsBox1;
        private System.Windows.Forms.ComboBox BankBox2;
        private System.Windows.Forms.ComboBox MonthsBox2;
        private System.Windows.Forms.TextBox AmountBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ConfirmButton1;
        private System.Windows.Forms.Button ConfirmButton2;
    }
}