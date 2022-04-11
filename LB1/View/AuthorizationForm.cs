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
    public partial class AuthorizationForm : Form
    {
        AuthController auth = new AuthController();
        ClientController actClient = new ClientController();
        OperatorController op = new OperatorController();
        ManagerController manager = new ManagerController();
        AnotherSpecialistController another = new AnotherSpecialistController();
        AdminController admin = new AdminController();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
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

        private void ConfirmAuthButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if (auth.Auth(LoginBox.Text, PasswordBox.Text).UserID != new Client().UserID)
                {
                    actClient.GetClient(LoginBox.Text);
                    ClientForm clientForm = new ClientForm(actClient);
                    Thread myThread = new Thread(clientForm.Open);
                    myThread.Start();
                    this.Close();
                    this.Dispose();
                }
                else if (auth.AuthOp(LoginBox.Text, PasswordBox.Text).UserID != new Operator().UserID)
                {
                    op.GetOperator(LoginBox.Text);
                    OperatorForm operatorForm = new OperatorForm(op);
                    Thread myThread = new Thread(operatorForm.Open);
                    myThread.Start();
                    this.Close();
                    this.Dispose();
                }
                else if (auth.AuthMan(LoginBox.Text, PasswordBox.Text).UserID != new Manager().UserID)
                {
                    manager.GetManager(LoginBox.Text);
                    ManagerForm managerForm = new ManagerForm(manager);
                    Thread myThread = new Thread(managerForm.Open);
                    myThread.Start();
                    this.Close();
                    this.Dispose();
                }
                else if (auth.AuthAnSp(LoginBox.Text, PasswordBox.Text).UserID != new AnotherSpecialist().UserID)
                {
                    another.GetSpecialist(LoginBox.Text);
                    AnotherSpecialistForm anspecForm = new AnotherSpecialistForm(another);
                    Thread myThread = new Thread(anspecForm.Open);
                    myThread.Start();
                    this.Close();
                    this.Dispose();
                }
                else if (auth.AuthAdm(LoginBox.Text, PasswordBox.Text).UserID != new Administrator().UserID)
                {
                    admin.GetAdmin(LoginBox.Text);
                    AdministratorForm adminForm = new AdministratorForm(admin);
                    Thread myThread = new Thread(adminForm.Open);
                    myThread.Start();
                    this.Close();
                    this.Dispose();
                }
                else MessageBox.Show("Check login or password");
            }
        }
    }
}
