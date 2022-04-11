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
    public partial class AccountInteractionForm : Form
    {
        AccountController account = new AccountController();
        ClientController client = new ClientController();
        public AccountInteractionForm(string number, Client cl)
        {
            InitializeComponent();
            account.GetAccount(number);
            account.GetNumbers(RecipientBox);
            client.ActiveClient = cl;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AccountInteractionForm_Load(object sender, EventArgs e)
        {
            AmountBox.AppendText($"{account.ActiveAccount.Sum}");
            SavingBox.AppendText($"{account.ActiveAccount.SavingSum}");
            AccumulationBox.AppendText($"{account.ActiveAccount.AccumulationSum}");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveBox.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                account.OnSaving(Convert.ToDouble(SaveBox.Text));
                account.ActiveAccount = account.GetAccount(account.ActiveAccount.AccountNumber);
                SaveBox.Text = "";
                AmountBox.Clear();
                SavingBox.Clear();
                AmountBox.AppendText($"{account.ActiveAccount.Sum}");
                SavingBox.AppendText($"{account.ActiveAccount.SavingSum}");
            }
        }

        private void CashOutButton_Click(object sender, EventArgs e)
        {
            if (CashOutBox.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                account.CashOut(Convert.ToDouble(CashOutBox.Text));
                account.ActiveAccount = account.GetAccount(account.ActiveAccount.AccountNumber);
                CashOutBox.Text = "";
                AmountBox.Clear();
                AmountBox.AppendText($"{account.ActiveAccount.Sum}");
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (TransferSumBox.Text == "" || RecipientBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if (Convert.ToDouble(TransferSumBox.Text) <= account.ActiveAccount.Sum)
                {
                    account.Transfer(RecipientBox.SelectedItem.ToString(), Convert.ToDouble(TransferSumBox.Text));
                    account.ActiveAccount = account.GetAccount(account.ActiveAccount.AccountNumber);
                    TransferSumBox.Text = "";
                    AmountBox.Clear();
                    AmountBox.AppendText($"{account.ActiveAccount.Sum}");
                    MessageBox.Show($"Transfer from {account.ActiveAccount.AccountNumber} to {RecipientBox.SelectedItem.ToString()} is done.");
                }
                else MessageBox.Show("Not enough money on your account");
            }
        }

        private void AccumulateButton_Click(object sender, EventArgs e)
        {
            if (AccumulationSumBox.Text == "" || PercentBox.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if (Convert.ToDouble(PercentBox.Text) <= 100)
                {
                    if (Convert.ToDouble(AccumulationSumBox.Text) + Convert.ToDouble(AccumulationSumBox.Text) * 0.01 * Convert.ToDouble(PercentBox.Text) <= account.ActiveAccount.Sum)
                    {
                        account.Accumulation(Convert.ToDouble(AccumulationSumBox.Text), Convert.ToDouble(PercentBox.Text));
                        account.ActiveAccount = account.GetAccount(account.ActiveAccount.AccountNumber);
                        AmountBox.Clear();
                        AccumulationBox.Clear();
                        AmountBox.AppendText($"{account.ActiveAccount.Sum}");
                        AccumulationBox.AppendText($"{account.ActiveAccount.AccumulationSum}");
                        AccumulationSumBox.Text = "";
                        PercentBox.Text = "";
                    }
                    else MessageBox.Show("Not enough money on your account");
                }
                else MessageBox.Show("Too big percent.");
            }
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            account.Block();
            MessageBox.Show("The account was blocked.");
            this.Close();
            this.Dispose();
        }

        private void FreezeButton_Click(object sender, EventArgs e)
        {
            if (account.ActiveAccount.Active)
            {
                account.Freeze();
                account.ActiveAccount = account.GetAccount(account.ActiveAccount.AccountNumber);
                FreezeButton.Text = "Unfreeze";
                Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = false);
                FreezeButton.Visible = true;
                BackButton.Visible = true;
            }
            else
            {
                account.Unfreeze();
                account.ActiveAccount = account.GetAccount(account.ActiveAccount.AccountNumber);
                FreezeButton.Text = "Freeze";
                Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = true);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SaveBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CashOutBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                        char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void TransferSumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void AccumulationSumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void PercentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}