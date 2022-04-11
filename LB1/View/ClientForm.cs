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
    public partial class ClientForm : Form
    {
        ClientController actClient = null;
        public ClientForm(ClientController cl)
        {
            InitializeComponent();
            actClient = cl;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
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

        private void BankAccountsButton_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm(actClient);
            Thread myThread = new Thread(accountForm.Open);
            myThread.Start();
        }

        private void CreditsInstallmentsButton_Click(object sender, EventArgs e)
        {
            CreditandInstallmentForm credinstForm = new CreditandInstallmentForm(actClient);
            Thread myThread = new Thread(credinstForm.Open);
            myThread.Start();;
        }

        private void SalaryProjectButton_Click(object sender, EventArgs e)
        {
            SalaryProjectForm spForm = new SalaryProjectForm(actClient);
            Thread myThread = new Thread(spForm.Open);
            myThread.Start();
        }
    }
}
