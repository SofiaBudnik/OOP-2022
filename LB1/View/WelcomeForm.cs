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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authForm = new AuthorizationForm();
            Thread myThread = new Thread(authForm.Open);
            myThread.Start();
            this.Close();
            this.Dispose();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            Thread myThread = new Thread(regForm.Open);
            myThread.Start();
            this.Close();
            this.Dispose();
        }
    }
}
