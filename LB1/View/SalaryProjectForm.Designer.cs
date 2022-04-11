
namespace Lab1
{
    partial class SalaryProjectForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SalaryProjectSumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.Location = new System.Drawing.Point(632, 301);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 25);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SalaryProjectSumBox
            // 
            this.SalaryProjectSumBox.Location = new System.Drawing.Point(298, 110);
            this.SalaryProjectSumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryProjectSumBox.Name = "SalaryProjectSumBox";
            this.SalaryProjectSumBox.Size = new System.Drawing.Size(148, 22);
            this.SalaryProjectSumBox.TabIndex = 23;
            this.SalaryProjectSumBox.TextChanged += new System.EventHandler(this.SalaryProjectSumBox_TextChanged);
            this.SalaryProjectSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryProjectSumBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(211, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Сумма";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmButton.Location = new System.Drawing.Point(214, 153);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(232, 30);
            this.ConfirmButton.TabIndex = 25;
            this.ConfirmButton.Text = "Готово";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(152, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Подать заявку на зарплатный проект";
            // 
            // SalaryProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalaryProjectSumBox);
            this.Controls.Add(this.BackButton);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalaryProjectForm";
            this.Text = "SalaryProjectForm";
            this.Load += new System.EventHandler(this.SalaryProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox SalaryProjectSumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label2;
    }
}