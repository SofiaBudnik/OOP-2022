using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using GenericParsing;

namespace Lab1
{
    public class Transfer
    {
        Database db = Program.database;

        public Transfer() { }

        public void TransferTo(string numberSender, string numberOfRecepient, double sum)
        {
            DataRow[] row = db.tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{numberSender}'");
            if (sum <= Convert.ToDouble(row[0]["Sum"]))
            {
                row[0]["Sum"] = Convert.ToDouble(row[0]["Sum"]) - sum;
                row = db.tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{numberOfRecepient}'");
                row[0]["Sum"] = Convert.ToDouble(row[0]["Sum"]) + sum;
                db.UpdateBase();
            }
            else MessageBox.Show("Too big sum for transfer.");
        }
    }
}
