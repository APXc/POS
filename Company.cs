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
    class Company
    {
        public int id { get; set; }
        public string NameCompany { get; set; }
        public string TaxCode { get; set; }
        public string FiscalCode { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string legalString { get; set; }
        public string OptionalString { get; set; }

        public Company addCompany(string name_company, string tax_code, string fiscal_code, string address, string state, string phone_number, string email, string legal_string, string optional_string)
        {
            string query = $"INSERT INTO [dbo].[Company]([NameCompany], [TaxCode], [FiscalCode], [Address] ,[State] ,[PhoneNumber] ,[email] ,[legalString] ,[OptionalString]) VALUES ('{name_company}', '{tax_code}', '{fiscal_code}','{ address} ',  '{state}', '{phone_number} ', '{email}',' {legal_string}', '{optional_string}');";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Company] where [NameCompany] = '{name_company}';";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.NameCompany = row[0]["NameCompany"].ToString();
            this.TaxCode = row[0]["TaxCode"].ToString();
            this.FiscalCode = row[0]["FiscalCode"].ToString();
            this.Address = row[0]["Address"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.State = row[0]["State"].ToString();
            this.PhoneNumber = row[0]["PhoneNumber"].ToString();
            this.email = row[0]["email"].ToString();
            this.legalString = row[0]["legalString"].ToString();
            this.legalString = row[0]["OptionalString"].ToString();
            return this;
        }
        public Company SetUnique()
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Company] where id=1;";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.NameCompany = row[0]["NameCompany"].ToString();
            this.TaxCode = row[0]["TaxCode"].ToString();
            this.FiscalCode = row[0]["FiscalCode"].ToString();
            this.Address = row[0]["Address"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.State = row[0]["State"].ToString();
            this.PhoneNumber = row[0]["PhoneNumber"].ToString();
            this.email = row[0]["email"].ToString();
            this.legalString = row[0]["legalString"].ToString();
            this.legalString = row[0]["OptionalString"].ToString();
            return this;
        }
        public void Update()
        {
            relactionDb db = new relactionDb();
            string query = $"UPDATE [dbo].[Company] SET [NameCompany] =  '{NameCompany}', [TaxCode] = '{TaxCode}', [FiscalCode]=  '{FiscalCode}', [Address] = '{ Address} ',[State] = '{State}',[PhoneNumber] = '{PhoneNumber}',[email] = '{email}',[legalString] = '{legalString}', [OptionalString] = '{OptionalString}'  WHERE Id = {id};";
            db.voidQuery(Global.settings.conn, query);
        }
    }
}
