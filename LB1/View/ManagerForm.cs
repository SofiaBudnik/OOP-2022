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
    public partial class ManagerForm : Form
    {
        ManagerController manager = new ManagerController();
        public ManagerForm(ManagerController man)
        {
            InitializeComponent();
            manager = man;
            manager.GetSalaryProjects(SalaryProjectsBox);
            manager.GetCredits(CreditsBox);
            manager.GetInstallments(InstallmentsBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
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

        private void ShowProjectsButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            manager.GetSalaryProjects(InfoRichBox);
        }

        private void ShowCreditsButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            manager.GetCredits(InfoRichBox);
        }

        private void ShowInstallmentsButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            manager.GetInstallments(InfoRichBox);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (SalaryProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.ConfirmSalaryProject(SalaryProjectsBox.SelectedItem.ToString());
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if (SalaryProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.DeclineSalaryProject(SalaryProjectsBox.SelectedItem.ToString());
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            if (SalaryProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.GetSalaryProjects(InfoRichBox, SalaryProjectsBox.SelectedItem.ToString());
        }

        private void ConfirmButton1_Click(object sender, EventArgs e)
        {
            if (CreditsBox.SelectedIndex == -1) MessageBox.Show("Choose the credit.");
            else manager.ConfirmCredit(CreditsBox.SelectedItem.ToString());
        }

        private void DeclineButton1_Click(object sender, EventArgs e)
        {
            if (CreditsBox.SelectedIndex == -1) MessageBox.Show("Choose the credit.");
            else manager.DeclineCredit(CreditsBox.SelectedItem.ToString());
        }

        private void ShowButton1_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            if (CreditsBox.SelectedIndex == -1) MessageBox.Show("Choose the credit.");
            else manager.GetCredits(InfoRichBox, CreditsBox.SelectedItem.ToString());
        }

        private void ConfirmButton2_Click(object sender, EventArgs e)
        {
            if (InstallmentsBox.SelectedIndex == -1) MessageBox.Show("Choose the installment.");
            else manager.ConfirmInstallment(InstallmentsBox.SelectedItem.ToString());
        }

        private void DeclineButton2_Click(object sender, EventArgs e)
        {
            if (InstallmentsBox.SelectedIndex == -1) MessageBox.Show("Choose the installment.");
            else manager.DeclineInstallment(InstallmentsBox.SelectedItem.ToString());
        }

        private void ShowButton2_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            if (InstallmentsBox.SelectedIndex == -1) MessageBox.Show("Choose the installment.");
            else manager.GetInstallments(InfoRichBox, InstallmentsBox.SelectedItem.ToString());
        }
    }
}
