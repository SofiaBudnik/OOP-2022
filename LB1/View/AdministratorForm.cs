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
    public partial class AdministratorForm : Form
    {
        AdminController admin = new AdminController();
        public AdministratorForm(AdminController adm)
        {
            InitializeComponent();
            admin = adm;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
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

        private void ShowLogsButton_Click(object sender, EventArgs e)
        {
            admin.CheckAllLogs(LogsBox);
        }
    }
}
