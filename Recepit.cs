using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Data.Common;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Pos_PointOfSales
{
    class Recepit
    {
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public costumer costumer { get; set; }
        public Decimal count { get; set; }
        public Discount discount { get; set; }
        public Payment payment { get; set; }
        public List<RecepitRow> row { get; set; }
        public string SecureKey { get; set; }

        public void Add(DateTime dateTime, costumer costumer, decimal count, Discount discount, Payment payment, List<RecepitRow> rows)
        {

            this.SecureKey = Security.Encrypt($"start::costumer::{costumer.name}::datetime::{dateTime.ToLongDateString()}::user::{Global.user.username}::point::{count.ToString()}::end", Global.user.username, Global.user.name);
            string query = $"INSERT INTO [dbo].[Recepit]([dateTime] ,[CostumerID] ,[count] ,[DiscountID] ,[PaymentID], [securekey]) VALUES( '{dateTime}' , '{costumer.id}' , '{count}', '{discount.id }', '{this.SecureKey}')";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Recepit] where [dateTime] = '{dateTime}' and [CostumerID]  = {costumer.id} and [securekey]  = '{this.SecureKey}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.id = Convert.ToInt32(row[0]["id"]);
            this.count = Convert.ToDecimal(row[0]["count"]);
            this.costumer = new costumer();
            this.costumer = this.costumer.SetByKey(Convert.ToInt32(row[0]["CostumerID"]));
            this.payment = new Payment();
            this.payment = this.payment.SetByKey(Convert.ToInt32(row[0]["PaymentID"]));
            this.discount = new Discount();
            if(row[0]["DiscountID"].ToString() != null)
            {
                this.discount = this.discount.SetByKey(Convert.ToInt32(row[0]["DiscountID"]));
            }
            this.dateTime =  DateTime.Parse(row[0]["dateTime"].ToString());
            
            foreach (RecepitRow recepitRow in rows)
            {
                recepitRow.fatherID = this.id;
                recepitRow.Add();
            }
            this.row = RecepitRow.ListRecepitRowForRecepit(this.id);

        }

        public Recepit SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Recepit] where [id] = '{id}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.id = Convert.ToInt32(row[0]["id"]);
            this.count = Convert.ToDecimal(row[0]["count"]);
            this.costumer = new costumer();
            this.costumer = this.costumer.SetByKey(Convert.ToInt32(row[0]["CostumerID"]));
            this.payment = new Payment();
            this.payment = this.payment.SetByKey(Convert.ToInt32(row[0]["PaymentID"]));
            this.discount = new Discount();
            if (row[0]["DiscountID"].ToString() != null)
            {
                this.discount = this.discount.SetByKey(Convert.ToInt32(row[0]["DiscountID"]));
            }
            this.dateTime = DateTime.Parse(row[0]["dateTime"].ToString());
            this.row = RecepitRow.ListRecepitRowForRecepit(this.id);
            this.SecureKey = row[0]["securekey"].ToString();
            return this;
        }

        public static DataTable FindAll()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Recepit];";
            DataTable dt = db.queryToTable(Global.settings.conn, query);
            return dt;
        }

        public static List<Recepit> AllListRecepit()
        {

            List<Recepit> Recepit = new List<Recepit>();
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Recepit];";
            DataRow[] rows = db.query(Global.settings.conn, query);

            for (int i = 0; i < rows.Length; i++)
            {
                Recepit vector = new Recepit();
                vector = vector.SetByKey(Convert.ToInt32(rows[i]["Id"]));
                Recepit.Add(vector);
            }

            return Recepit;
        }
        public void Update()
        {

        }
 
    }

    class RecepitRow
    {
        public int id { get; set; }
        public int fatherID { get; set; }
        public int linenum { get; set; }
        public article article { get; set; }
        public int qta { get; set; }
        public Invectory Invectory { get; set; }
        public decimal value { get; set; }
        public decimal valuetotax { get; set; }

        public RecepitRow Add(int fatherID, article article, int qta, Invectory invectory, decimal value, decimal valuetotax, int linenum)
        {
            string query = $"INSERT INTO [dbo].[RecepitRow]([FatherID], [qta], [value], [valueToTax] ,[articleID] ,[invectoryID], [linenum]) VALUES( '{fatherID}' , '{qta}' , '{value}', '{valuetotax}', '{article.id}', '{invectory.id}', '{linenum}' )";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[RecepitRow] where [FatherID] = '{fatherID}' and  [linenum] = '{linenum}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.fatherID = Convert.ToInt32(row[0]["FatherID"]);
            this.qta = Convert.ToInt32(row[0]["qta"]); ;
            this.id = Convert.ToInt32(row[0]["id"]);
            this.value = Convert.ToDecimal(row[0]["value"]);
            this.valuetotax = Convert.ToDecimal(row[0]["valueToTax"]);
            this.article = new article();
            this.article = this.article.SetByKey(Convert.ToInt32(row[0]["articleID"]));
            this.Invectory = new Invectory();
            this.Invectory = this.Invectory.SetByKey(Convert.ToInt32(row[0]["invectoryID"]));
            this.linenum = Convert.ToInt32(row[0]["linenum"]);
            return this;


        }
        public void Add()
        {
            string query = $"INSERT INTO [dbo].[RecepitRow]([FatherID], [qta], [value], [valueToTax] ,[articleID] ,[invectoryID], [linenum]) VALUES( '{this.fatherID}' , '{this.qta}' , '{this.value}', '{this.valuetotax}', '{this.article.id}', '{this.Invectory.id}', '{this.linenum}' )";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[RecepitRow] where [FatherID] = '{fatherID}' and  [linenum] = '{linenum}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.id = Convert.ToInt32(row[0]["id"]);

        }

        public RecepitRow SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[RecepitRow] where id={id};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.fatherID = Convert.ToInt32(row[0]["FatherID"]);
            this.qta = Convert.ToInt32(row[0]["qta"]); ;
            this.id = Convert.ToInt32(row[0]["id"]);
            this.value = Convert.ToDecimal(row[0]["value"]);
            this.valuetotax = Convert.ToDecimal(row[0]["valueToTax"]);
            this.article = new article();
            this.article = this.article.SetByKey(Convert.ToInt32(row[0]["articleID"]));
            this.Invectory = new Invectory();
            this.Invectory = this.Invectory.SetByKey(Convert.ToInt32(row[0]["invectoryID"]));
            this.linenum = Convert.ToInt32(row[0]["linenum"]);
            return this;
        }

        public void Update()
        {

        }

        public DataTable FindAll()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[RecepitRow];";
            DataTable dt = db.queryToTable(Global.settings.conn, query);
            return dt;
        }

        public static List<RecepitRow> ListRecepitRowForRecepit(int fatherID)
        {

            List<RecepitRow> Recepitrows = new List<RecepitRow>();
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[RecepitRow] where [FatherID] = '{fatherID}';";
            DataRow[] rows = db.query(Global.settings.conn, query);

            for (int i = 0; i < rows.Length; i++)
            {
                RecepitRow vector = new RecepitRow();
                vector = vector.SetByKey(Convert.ToInt32(rows[i]["Id"]));
                Recepitrows.Add(vector);
            }

            return Recepitrows;
        }

        public void Print()
        {
            Console.WriteLine($"RowRecepit {id} - {fatherID} ");
        }


    }
}
