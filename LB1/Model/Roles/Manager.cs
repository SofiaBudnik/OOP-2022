using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab1
{
    public class Manager : Operator 
    {
        Database db = Program.database;

        public Manager() { }

        public Manager(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public Manager GetManager(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;
            return this;
        }

        public void ConfirmCredit(string creditNumber)
        {
            db.UpdateConfirmCredit(creditNumber);
        }

        public void DeclineCredit(string number)
        {
            db.UpdateDeclineCredit(number);
        }

        public void ConfirmInstallment(string installmentNumber)
        {
            db.UpdateConfirmInstallment(installmentNumber);
        }

        public void DeclineInstallment(string number)
        {
            db.UpdateDeclineInstallment(number);
        }
    }
}
