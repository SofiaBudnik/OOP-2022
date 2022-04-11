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
    public partial class SalaryProjectForm : Form
    {
        ClientController actClient = null;
        public SalaryProjectForm(ClientController cl)
        {
            InitializeComponent();
            actClient = cl;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void SalaryProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(SalaryProjectSumBox.Text)) > double.MaxValue) MessageBox.Show("Too big value.");
            else
            {
                actClient.CreateSalaryProject(Convert.ToDouble(SalaryProjectSumBox.Text));
                SalaryProjectSumBox.Text = "";
                MessageBox.Show("Заявка на зарплатный проект отправлена");
            }
            
        }

        private void SalaryProjectSumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SalaryProjectSumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
