using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class CreditandInstallmentForm : Form
    {
        ClientController client = new ClientController();
        CreditInstallmentController crinst = new CreditInstallmentController();
        public CreditandInstallmentForm(ClientController cl)
        {
            InitializeComponent();
            client = cl;
            client.GetBanks(BankBox1);
            client.GetBanks(BankBox2);
            crinst.GetMonths(MonthsBox1);
            crinst.GetMonths(MonthsBox2);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void CreditandInstallmentForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ConfirmButton1_Click(object sender, EventArgs e)
        {
            if (AmountBox1.Text == "" || BankBox1.SelectedIndex == -1 || MonthsBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else if ((Convert.ToDouble(AmountBox1.Text)) > double.MaxValue) MessageBox.Show("Too big value.");
            else
            {
                MessageBox.Show("The request has been sent.");
                client.CreateCredit(Convert.ToDouble(AmountBox1.Text), BankBox1.SelectedItem.ToString(), Convert.ToInt16(MonthsBox1.SelectedItem));
                AmountBox1.Text = "";
            }
        }

        private void ConfirmButton2_Click(object sender, EventArgs e)
        {
            if (AmountBox2.Text == "" || BankBox2.SelectedIndex == -1 || MonthsBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else if ((Convert.ToDouble(AmountBox2.Text)) > double.MaxValue) MessageBox.Show("Too big value.");
            else
            {
                MessageBox.Show("The request has been sent.");
                client.CreateInstallment(Convert.ToDouble(AmountBox2.Text), BankBox2.SelectedItem.ToString(), Convert.ToInt16(MonthsBox2.SelectedItem));
                AmountBox2.Text = "";
            }
        }

        private void MyCreditsButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            client.GetCredits(InfoRichBox);
        }

        private void MyInstallmentsButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            client.GetInstallments(InfoRichBox);
        }

        private void AmountBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void AmountBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
