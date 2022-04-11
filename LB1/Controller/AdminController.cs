using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class AdminController
    {
        Database db = Program.database;
        public Administrator admin = null;

        public Administrator GetAdmin(string login)
        {
            admin = db.GetAdmin(login);
            return admin;
        }

        public void CheckAllLogs(System.Windows.Forms.RichTextBox rich)
        {
            admin.CheckAllLogs();
            foreach (string i in admin.Logs) rich.AppendText($"{i}\n");
        }
    }
}
