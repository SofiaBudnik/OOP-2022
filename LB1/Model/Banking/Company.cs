using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Company
    {
        Database db = Program.database;
        public List<Account> Accounts = new List<Account>();
        public string CompanyId { get; set; }
        string Type { get; set; }
        public string Name { get; set; }
        string UNP { get; set; }
        string BIC { get; set; }
        string Adress { get; set; }

        public Company() { }

        public Company(string type, string name, string unp, string bic, string adress)
        {
            this.CompanyId = Guid.NewGuid().ToString();
            this.Type = type;
            this.Name = name;
            this.UNP = unp;
            this.BIC = bic;
            this.Adress = adress;
            foreach (Account i in db.Accounts) if (this.Name == i.CompanyName) Accounts.Add(i);
        }

        public Company GetCompany(string companyId, string type, string name, string unp, string bic, string adress)
        {
            this.CompanyId = companyId;
            this.Type = type;
            this.Name = name;
            this.UNP = unp;
            this.BIC = bic;
            this.Adress = adress;
            foreach (Account i in db.Accounts) if (this.Name == i.CompanyName) Accounts.Add(i);
            return this;
        }

        public void Transfer(string numberSender, string numberOfRecepient, double sum)
        {
            Accounts[Accounts.BinarySearch(db.GetAccount(numberSender))].Transfer(numberSender, numberOfRecepient, sum);
        }

        public void CreateAccount(double sum, string bankName)
        {
            Account New = new Account(this.CompanyId, sum, bankName);
            db.AddAccount(New.Id, New.AccountNumber, New.UserID, New.BankName, New.CompanyName, New.Sum, New.SavingSum, New.AccumulationSum, New.Active);
        }
    }
}
