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
    public partial class OperatorForm : Form
    {
        OperatorController Operator = null;
        public OperatorForm(OperatorController op)
        {
            InitializeComponent();
            Operator = op;
            Operator.GetSalaryProjects(SalaryProjectsBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {

        }

        private void ShowProjectsButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            Operator.GetSalaryProjects(InfoRichBox);
        }

        private void ShowLogsButton_Click(object sender, EventArgs e)
        {
            InfoRichBox.Clear();
            Operator.GetLogs(InfoRichBox);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            Thread myThread = new Thread(welcomeForm.Open);
            myThread.Start();
            this.Close();
            this.Dispose();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (SalaryProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else Operator.ConfirmSalaryProject(SalaryProjectsBox.SelectedItem.ToString());
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if (SalaryProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else Operator.DeclineSalaryProject(SalaryProjectsBox.SelectedItem.ToString());
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (SalaryProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else Operator.GetSalPrj(InfoRichBox, SalaryProjectsBox.SelectedItem.ToString());
        }
    }
}
