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
    class supplier
    {
        public string name { get; set; }
        public string fiscalCode { get; set; }
        public string notes { get; set; }
        public int id { get; set; }

        public supplier Add(string name, string fiscalCode, string notes)
        {
            string query = $"INSERT INTO[dbo].[Supplier] ([name], [fiscalCode], [notes]) VALUES( '{name}' , '{fiscalCode}' , '{notes}')";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Supplier] where [name] = '{name}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["name"].ToString();
            this.fiscalCode = row[0]["fiscalCode"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.notes = row[0]["notes"].ToString();
            return this;
        }
        public supplier SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Supplier] where id={id};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["name"].ToString();
            this.fiscalCode = row[0]["fiscalCode"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.notes = row[0]["notes"].ToString();
            return this;
        }
        public void Update()
        {
            relactionDb db = new relactionDb();
            string query = $"UPDATE [dbo].[Supplier] SET [name] =  '{name}',  [fiscalCode] =  '{fiscalCode}', [notes] = '{notes}' WHERE Id = {id};";
            db.voidQuery(Global.settings.conn, query);
        }

        public DataTable FindAll()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Supplier];";
            DataTable dt = db.queryToTable(Global.settings.conn, query);
            return dt;
        }

        public void Print()
        {
            Console.WriteLine($"Supplier {id} - {name} ");
        }
    }
}
