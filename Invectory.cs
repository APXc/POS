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
    class Invectory
    {
        public int id { get; set; }
        public string name { get; set; }

        public Invectory Add(string name)
        {
            string query = $"INSERT INTO[dbo].[Invectory] ([name]) VALUES( '{name}')";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Invectory] where [name] = '{name}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["name"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            return this;
        }
        public Invectory SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Invectory] where id={id};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["name"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            return this;
        }
        public void Update()
        {
            relactionDb db = new relactionDb();
            string query = $"UPDATE [dbo].[Invectory] SET [name] =  '{name}' WHERE Id = {id};";
            db.voidQuery(Global.settings.conn, query);
        }

        public static DataTable FindAll()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Invectory];";
            DataTable dt = db.queryToTable(Global.settings.conn, query);
            return dt;
        }

        public static List<Invectory> ListInvectory()
        {

            List<Invectory> Invectorys = new List<Invectory>();
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Invectory];";
            DataRow[] rows = db.query(Global.settings.conn, query);

            for (int i = 0; i < rows.Length; i++)
            {
                Invectory vector = new Invectory();
                vector = vector.SetByKey(Convert.ToInt32(rows[i]["Id"]));
                Invectorys.Add(vector);
            }

            return Invectorys;
        }

        public void Print()
        {
            Console.WriteLine($"Invectory {id} - {name} ");
        }
    }
}
