using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Pos_PointOfSales
{
    class Discount
    {
        public string code { get; set; }
        public int discont { get; set; }
        public string notes { get; set; }
        public int id { get; set; }

        public Discount Add(string code, int discont, string notes)
        {
            string query = $"INSERT INTO[dbo].[Discount] ([code], [discont], [notes]) VALUES( '{code}' , '{discont}' , '{notes}')";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Discount] where [code] = '{code}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.code = row[0]["code"].ToString();
            this.discont = Convert.ToInt32(row[0]["discont"]);
            this.id = Convert.ToInt32(row[0]["id"]);
            this.notes = row[0]["notes"].ToString();
            return this;
        }
        public Discount SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Discount] where id={id};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.code = row[0]["code"].ToString();
            this.discont = Convert.ToInt32(row[0]["discont"]);
            this.id = Convert.ToInt32(row[0]["id"]);
            this.notes = row[0]["notes"].ToString();
            return this;
        }
        public void Update()
        {
            relactionDb db = new relactionDb();
            string query = $"UPDATE [dbo].[Discount] SET [code] =  '{code}',  [discont] =  '{discont}', [notes] = '{notes}' WHERE Id = {id};";
            db.voidQuery(Global.settings.conn, query);
        }

        public DataTable FindAll()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Discount];";
            DataTable dt = db.queryToTable(Global.settings.conn, query);
            return dt;
        }

        public void Print()
        {
            Console.WriteLine($"Discount {id} - {code} ");
        }
    }
}
