using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab1
{
    public class AnotherSpecialist : User
    {
        Database db = Program.database;
        SalaryProject SProject = new SalaryProject();
        Transfer STransfer = new Transfer();
        public List<Account> Accounts = new List<Account>();
        public string CompanyName;

        public AnotherSpecialist() { }

        public AnotherSpecialist(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public AnotherSpecialist GetAnotherSpecialist(string userID, string login, string password, string companyName)
        {
            this.UserID = userID;
            this.Login = login;
            this.Password = password;
            this.CompanyName = companyName;
            return this;
        }

        public void Update()
        {
            foreach (Account i in db.Accounts) if (i.CompanyName == this.CompanyName) Accounts.Add(i);
        }

        public void TransferTo(string numberSender, string numberOfRecepient, double sum)
        {
            STransfer.TransferTo(numberSender, numberOfRecepient, sum);
        }

        public void TakeSalaryProject(double sum)
        {
            SProject = new SalaryProject(this.UserID, sum);
            db.AddSalaryProect(SProject.Id, SProject.SalaryProjectNumber, SProject.UserID, SProject.Sum, SProject.Approved, SProject.Cancelled);
        }
    }
}
