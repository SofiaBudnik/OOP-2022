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
    public partial class AccountForm : Form
    {
        ClientController actClient = null;
        public AccountForm(ClientController cl)
        {
            InitializeComponent();
            actClient = cl;
            actClient.GetAccounts(AccountBox);
            actClient.GetBanks(BanksBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (AmountBox.Text == "" || BanksBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else if ((Convert.ToDouble(AmountBox.Text)) > double.MaxValue) MessageBox.Show("Too big value.");
            else
            {
                actClient.CreateAccount(Convert.ToDouble(AmountBox.Text), BanksBox.SelectedItem.ToString(), "-");
                AccountBox.Items.Clear();
                actClient.GetAccounts(AccountBox);
                AmountBox.Text = "";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void InteractionButton_Click(object sender, EventArgs e)
        {
            if (AccountBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose the account number");
            }
            else
            {
                string number = AccountBox.SelectedItem.ToString();
                AccountInteractionForm accinterForm = new AccountInteractionForm(number, actClient.ActiveClient);
                Thread myThread = new Thread(accinterForm.Open);
                myThread.Start();
            }
        }

        private void AmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
