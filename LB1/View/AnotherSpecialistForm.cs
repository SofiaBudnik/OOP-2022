using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab1
{
    public partial class AnotherSpecialistForm : Form
    {
        AnotherSpecialistController spec = new AnotherSpecialistController();
        public AnotherSpecialistForm(AnotherSpecialistController sp)
        {
            InitializeComponent();
            spec = sp;
            spec.GetAccounts(ToBox);
            spec.GetMyAccounts(FromBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AnotherSpecialistForm_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            Thread myThread = new Thread(welcomeForm.Open);
            myThread.Start();
            this.Close();
            this.Dispose();
        }

        private void TakeSalaryProjectButton_Click(object sender, EventArgs e)
        {
            if (SumBox.Text == "") MessageBox.Show("Fill in the sum.");
            else
            {
                spec.TakeSalaryProject(Convert.ToDouble(SumBox.Text));
                SumBox.Text = "";
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (FromBox.SelectedIndex == -1 || ToBox.SelectedIndex == -1 || SumBox1.Text == "") MessageBox.Show("Choose all the fields.");
            else
            {
                spec.Transfer(FromBox.SelectedItem.ToString(), ToBox.SelectedItem.ToString(), Convert.ToDouble(SumBox1.Text));
                SumBox.Text = "";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
        }

        private void SumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void SumBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void FromBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            spec.GetAccount(FromBox, InfoRichBox);
        }

        private void ToBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            spec.GetAccount(ToBox, InfoRichBox);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
