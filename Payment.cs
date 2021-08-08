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
    class Payment
    {
        public int id { get; set; }
        public string name { get; set; }

        public Payment Add(string name)
        {
            string query = $"INSERT INTO[dbo].[Payment] ([name]) VALUES( '{name}')";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Payment] where [name] = '{name}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["name"].ToString();    
            this.id = Convert.ToInt32(row[0]["id"]);
            return this;
        }
        public Payment SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Payment] where id={id};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["name"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            return this;
        }
        public void Update()
        {
            relactionDb db = new relactionDb();
            string query = $"UPDATE [dbo].[Payment] SET [name] =  '{name}' WHERE Id = {id};";
            db.voidQuery(Global.settings.conn, query);
        }

        public DataTable FindAll()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Payment];";
            DataTable dt = db.queryToTable(Global.settings.conn, query);
            return dt;
        }

        public void Print()
        {
            Console.WriteLine($"Payment {id} - {name} ");
        }


    }
}
