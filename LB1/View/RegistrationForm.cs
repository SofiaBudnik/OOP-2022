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
    public partial class RegistrationForm : Form
    {
        RegistrationController reg = new RegistrationController();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            Thread myThread = new Thread(welcomeForm.Open);
            myThread.Start();
            this.Close();
            this.Dispose();
        }

        private void ConfirmRegButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || SurnameBox.Text == "" || PatronymicBox.Text == "" ||
                EmailBox.Text == "" || PasswordBox.Text == "" || PasswordConfirmBox.Text == "" ||
                LoginBox.Text == "" || CompanyBox.Text == "" || PSNBox.Text == "" ||
                IdentNumbBox.Text == "" || PhNumbBox.Text == "")
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else if (PasswordBox.Text != PasswordConfirmBox.Text)
            {
                MessageBox.Show("Passwords don't match");
            }
            else
            {
                string id = Guid.NewGuid().ToString();
                reg.RegistrateClient(id, LoginBox.Text, PasswordBox.Text, NameBox.Text, SurnameBox.Text, PatronymicBox.Text,
                    PhNumbBox.Text, EmailBox.Text, PSNBox.Text, IdentNumbBox.Text, CompanyBox.Text);
                MessageBox.Show("Successfully");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
