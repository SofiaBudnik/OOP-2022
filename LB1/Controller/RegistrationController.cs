using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab1
{
    public class RegistrationController
    {
        Database db = Program.database;

        public RegistrationController() { }

        public void RegistrateClient(string id, string login, string password, string firstName, string surname, string patronymic, string phoneNumber, string email, string snp, string passportID, string company)
        {
            db.AddClient(
                id,
                login,
                password,
                firstName,
                surname,
                patronymic,
                phoneNumber,
                email,
                snp,
                passportID,
                company);
        }
    }
}
