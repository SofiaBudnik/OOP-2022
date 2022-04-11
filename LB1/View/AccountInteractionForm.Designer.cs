
namespace Lab1
{
    partial class AccountInteractionForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveBox = new System.Windows.Forms.TextBox();
            this.CashOutBox = new System.Windows.Forms.TextBox();
            this.CashOutButton = new System.Windows.Forms.Button();
            this.TransferSumBox = new System.Windows.Forms.TextBox();
            this.RecipientBox = new System.Windows.Forms.ComboBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.AccumulateButton = new System.Windows.Forms.Button();
            this.AccumulationSumBox = new System.Windows.Forms.TextBox();
            this.PercentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BlockButton = new System.Windows.Forms.Button();
            this.FreezeButton = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.RichTextBox();
            this.AccumulationBox = new System.Windows.Forms.RichTextBox();
            this.SavingBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма на счету";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма на хранении ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма на накоплении";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.Location = new System.Drawing.Point(670, 473);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 25);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.Location = new System.Drawing.Point(303, 110);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 31);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Хранение";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveBox
            // 
            this.SaveBox.Location = new System.Drawing.Point(279, 84);
            this.SaveBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(133, 22);
            this.SaveBox.TabIndex = 26;
            this.SaveBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaveBox_KeyPress_1);
            // 
            // CashOutBox
            // 
            this.CashOutBox.Location = new System.Drawing.Point(554, 84);
            this.CashOutBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashOutBox.Name = "CashOutBox";
            this.CashOutBox.Size = new System.Drawing.Size(133, 22);
            this.CashOutBox.TabIndex = 27;
            this.CashOutBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashOutBox_KeyPress);
            // 
            // CashOutButton
            // 
            this.CashOutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CashOutButton.Location = new System.Drawing.Point(577, 110);
            this.CashOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashOutButton.Name = "CashOutButton";
            this.CashOutButton.Size = new System.Drawing.Size(82, 31);
            this.CashOutButton.TabIndex = 28;
            this.CashOutButton.Text = "Снять";
            this.CashOutButton.UseVisualStyleBackColor = false;
            this.CashOutButton.Click += new System.EventHandler(this.CashOutButton_Click);
            // 
            // TransferSumBox
            // 
            this.TransferSumBox.Location = new System.Drawing.Point(135, 255);
            this.TransferSumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferSumBox.Name = "TransferSumBox";
            this.TransferSumBox.Size = new System.Drawing.Size(108, 22);
            this.TransferSumBox.TabIndex = 29;
            this.TransferSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferSumBox_KeyPress);
            // 
            // RecipientBox
            // 
            this.RecipientBox.FormattingEnabled = true;
            this.RecipientBox.Location = new System.Drawing.Point(135, 294);
            this.RecipientBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipientBox.Name = "RecipientBox";
            this.RecipientBox.Size = new System.Drawing.Size(108, 24);
            this.RecipientBox.TabIndex = 30;
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.TransferButton.Location = new System.Drawing.Point(134, 327);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(109, 29);
            this.TransferButton.TabIndex = 33;
            this.TransferButton.Text = "Перевести";
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // AccumulateButton
            // 
            this.AccumulateButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AccumulateButton.Location = new System.Drawing.Point(467, 325);
            this.AccumulateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccumulateButton.Name = "AccumulateButton";
            this.AccumulateButton.Size = new System.Drawing.Size(108, 31);
            this.AccumulateButton.TabIndex = 34;
            this.AccumulateButton.Text = "Готово";
            this.AccumulateButton.UseVisualStyleBackColor = false;
            this.AccumulateButton.Click += new System.EventHandler(this.AccumulateButton_Click);
            // 
            // AccumulationSumBox
            // 
            this.AccumulationSumBox.Location = new System.Drawing.Point(467, 255);
            this.AccumulationSumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccumulationSumBox.Name = "AccumulationSumBox";
            this.AccumulationSumBox.Size = new System.Drawing.Size(108, 22);
            this.AccumulationSumBox.TabIndex = 35;
            this.AccumulationSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccumulationSumBox_KeyPress);
            // 
            // PercentBox
            // 
            this.PercentBox.Location = new System.Drawing.Point(467, 289);
            this.PercentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PercentBox.Name = "PercentBox";
            this.PercentBox.Size = new System.Drawing.Size(108, 22);
            this.PercentBox.TabIndex = 36;
            this.PercentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Сумма перевода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Получатель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(328, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Сумма накопления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(328, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Процент";
            // 
            // BlockButton
            // 
            this.BlockButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BlockButton.Location = new System.Drawing.Point(12, 473);
            this.BlockButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(213, 25);
            this.BlockButton.TabIndex = 41;
            this.BlockButton.Text = "ЗАБЛОКИРОВАТЬ АККАУНТ";
            this.BlockButton.UseVisualStyleBackColor = false;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // FreezeButton
            // 
            this.FreezeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FreezeButton.Location = new System.Drawing.Point(268, 473);
            this.FreezeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FreezeButton.Name = "FreezeButton";
            this.FreezeButton.Size = new System.Drawing.Size(230, 25);
            this.FreezeButton.TabIndex = 42;
            this.FreezeButton.Text = "ЗАМОРОЗИТЬ АККАУНТ";
            this.FreezeButton.UseVisualStyleBackColor = false;
            this.FreezeButton.Click += new System.EventHandler(this.FreezeButton_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(34, 56);
            this.AmountBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(150, 23);
            this.AmountBox.TabIndex = 43;
            this.AmountBox.Text = "";
            // 
            // AccumulationBox
            // 
            this.AccumulationBox.Location = new System.Drawing.Point(34, 165);
            this.AccumulationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccumulationBox.Name = "AccumulationBox";
            this.AccumulationBox.Size = new System.Drawing.Size(150, 23);
            this.AccumulationBox.TabIndex = 44;
            this.AccumulationBox.Text = "";
            // 
            // SavingBox
            // 
            this.SavingBox.Location = new System.Drawing.Point(34, 108);
            this.SavingBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavingBox.Name = "SavingBox";
            this.SavingBox.Size = new System.Drawing.Size(150, 23);
            this.SavingBox.TabIndex = 45;
            this.SavingBox.Text = "";
            // 
            // AccountInteractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 509);
            this.Controls.Add(this.SavingBox);
            this.Controls.Add(this.AccumulationBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.FreezeButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PercentBox);
            this.Controls.Add(this.AccumulationSumBox);
            this.Controls.Add(this.AccumulateButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.RecipientBox);
            this.Controls.Add(this.TransferSumBox);
            this.Controls.Add(this.CashOutButton);
            this.Controls.Add(this.CashOutBox);
            this.Controls.Add(this.SaveBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountInteractionForm";
            this.Text = "AccountInteraction";
            this.Load += new System.EventHandler(this.AccountInteractionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SaveBox;
        private System.Windows.Forms.TextBox CashOutBox;
        private System.Windows.Forms.Button CashOutButton;
        private System.Windows.Forms.TextBox TransferSumBox;
        private System.Windows.Forms.ComboBox RecipientBox;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button AccumulateButton;
        private System.Windows.Forms.TextBox AccumulationSumBox;
        private System.Windows.Forms.TextBox PercentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Button FreezeButton;
        private System.Windows.Forms.RichTextBox AmountBox;
        private System.Windows.Forms.RichTextBox AccumulationBox;
        private System.Windows.Forms.RichTextBox SavingBox;
    }
}