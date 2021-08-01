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
    class user
    {
        public string username { get; set;}
        public int id { get; set; }
        private string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public user addUser(string new_username, string new_pass, string new_name, string new_surname )
        {
            string query = $"INSERT INTO [dbo].[users]([username],[password],[name],[surname]) VALUES('{new_username}','{new_pass}','{new_name}','{new_surname}')";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[users] where [username] = '{new_username}'and [password] = '{new_pass}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.username = row[0]["username"].ToString();
            this.password = row[0]["password"].ToString();
            this.name = row[0]["name"].ToString();
            this.surname = row[0]["surname"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            return this;
        }

        public user GetUser(string username)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[users] where [username] = '{username}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.username = row[0]["username"].ToString();
            this.password = row[0]["password"].ToString();
            this.name = row[0]["name"].ToString();
            this.surname = row[0]["surname"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            return this;
        }

    }
    class login
    {
        public bool test(string username, string password)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[users] where [username] = '{username}';";
            DataRow[] row = db.query(Global.settings.conn, query);

            if (password == row[0]["password"].ToString())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
