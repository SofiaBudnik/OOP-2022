using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1
{
    public class Operator : User
    {
        Database db = Program.database;
        List<SalaryProject> SProjects = new List<SalaryProject>();
        public List<string> AccLogs = new List<string>();

        public Operator() { }

        public Operator(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public Operator GetOperator(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;
            return this;
        }

        public void Update()
        {
            foreach (SalaryProject i in db.SalaryProjects) SProjects.Add(i);
        }

        public void GetStatistics()
        {
            foreach (string i in File.ReadAllLines("AccountLogs.txt")) AccLogs.Add(i);
        }

        public void ConfirmSalaryProject(string sProjectNumber)
        {
            db.UpdateConfirmSalPrj(sProjectNumber);
        }

        public void DeclineSalaryProject(string number)
        {
            db.UpdateDeclineSalPrj(number);
        }
    }
}
