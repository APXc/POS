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
    class article
    {
        public string code { get; set; }
        public string barcode { get; set; }
        public string rapidcode { get; set; }
        public int id { get; set; }
        public bool isInvectory { get; set; }
        public string description { get; set; }
        public string notes { get; set; }
        public double salesPrice { get; set; } 
        public double purchasePrice { get; set; }
        public double salesTax { get; set; }
        public double purchaseTax { get; set; }


        public article Add(string code, string barcode, string rapidcode, bool isInvectory, string description, string notes, double salesPrice, double purchasePrice, double salesTax, double purchaseTax)
        {
            string vectorBool = isInvectory ? "Y" : "N";
            string query = $"INSERT INTO[dbo].[Article] ([code], [barcode], [rapidcode], [isInvectory], [description], [notes] , [salesPrice], [purchasePrice], [salesTax], [purchaseTax]) VALUES( '{code}' , '{barcode}' , '{rapidcode}', '{vectorBool}', '{description}', '{notes}', {salesPrice}, {purchasePrice}, {salesTax}, {purchaseTax})";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Article] where [code] = '{code}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.code = row[0]["code"].ToString();
            this.barcode = row[0]["barcode"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.description = row[0]["description"].ToString();
            this.notes = row[0]["notes"].ToString();
            this.salesPrice = Convert.ToDouble(row[0]["salesPrice"]); 
            this.purchasePrice = Convert.ToDouble(row[0]["purchasePrice"]);
            this.salesTax = Convert.ToDouble(row[0]["salesTax"]);
            this.purchaseTax = Convert.ToDouble(row[0]["purchaseTax"]);
            if (row[0]["isInvectory"].ToString() == "Y")
            {
                this.isInvectory = true;
            }
            else
            {
                this.isInvectory = false;
            }
            return this;
        }
        public article SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Article] where Id={id};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.code = row[0]["code"].ToString();
            this.barcode = row[0]["barcode"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.description = row[0]["description"].ToString();
            this.notes = row[0]["notes"].ToString();
            this.salesPrice = Convert.ToDouble(row[0]["salesPrice"]);
            this.purchasePrice = Convert.ToDouble(row[0]["purchasePrice"]);
            this.salesTax = Convert.ToDouble(row[0]["salesTax"]);
            this.purchaseTax = Convert.ToDouble(row[0]["purchaseTax"]);
            if (row[0]["isInvectory"].ToString() == "Y")
            {
                this.isInvectory = true;
            }
            else
            {
                this.isInvectory = false;
            }
            return this;
        }
        public void Update()
        {
            relactionDb db = new relactionDb();
            string vectorBool = isInvectory ? "Y" : "N";
            string query = $"UPDATE [dbo].[Article] SET [code] = '{code}' , [barcode] = '{barcode}', [rapidcode] = '{rapidcode}', [isInvectory] = '{vectorBool}', [description] = '{description}', [notes] = '{notes}', [salesPrice] = {salesPrice}, [purchasePrice] = {purchasePrice}, [salesTax] ={salesTax}, [purchaseTax]  = {purchaseTax} WHERE Id = {id};";
            db.voidQuery(Global.settings.conn, query);
        }

        public static DataTable FindAll()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Article];";
            DataTable dt = db.queryToTable(Global.settings.conn, query);
            return dt;
        }

        public static List<article> ListArticle()
        {

            List<article> articles = new List<article>();
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Article];";
            DataRow[] rows = db.query(Global.settings.conn, query);

            for (int i = 0; i < rows.Length; i++)
            {
                article vector = new article();
                vector = vector.SetByKey(Convert.ToInt32(rows[i]["Id"]));
                articles.Add(vector);
            }

            return articles;
        }

        public void Print()
        {
            Console.WriteLine($"Article {id} - {code} ");
        }
    }
}
