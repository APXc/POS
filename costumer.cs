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
    class costumer
    {
        public string name {get; set;}
        public string surname { get; set; }
        public int id { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string fiscalCode { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string mktgId { get; set; }
        public string notes { get; set; }
        public int standardDiScont { get; set; }

        public costumer addCompany(string name, string surname, string fiscalCode, string address, string state, string phoneNumber, string email, string notes, string mktgId, int standardDiScont)
        {
            string query = $"INSERT INTO[dbo].[Costumer] ([Name],[Surname],[FiscalCode],[Address],[State],[PhoneNumber],[Email],[Notes],[MktgId], [standardDiScont]) VALUES( {name} , {surname}, {fiscalCode} , {address}, {state}, { phoneNumber}, {email}, {notes}, {mktgId}, {standardDiScont})";
            relactionDb db = new relactionDb();
            db.voidQuery(Global.settings.conn, query);
            query = $"Select * from [dbo].[Company] where [NameCompany] = '{name}' and [Surname] = {surname};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["Name"].ToString();
            this.surname = row[0]["Surname"].ToString();
            this.fiscalCode = row[0]["FiscalCode"].ToString();
            this.address = row[0]["Address"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.state = row[0]["State"].ToString();
            this.phoneNumber = row[0]["PhoneNumber"].ToString();
            this.email = row[0]["Email"].ToString();
            this.notes = row[0]["Notes"].ToString();
            this.mktgId = row[0]["MktgId"].ToString();
            this.standardDiScont = Convert.ToInt32(row[0]["standardDiScont"]);
            return this;
        }
        public costumer SetByKey(int id)
        {
            relactionDb db = new relactionDb();
            string query = $"Select * from [dbo].[Costumer] where id={id};";
            DataRow[] row = db.query(Global.settings.conn, query);
            this.name = row[0]["Name"].ToString();
            this.surname = row[0]["Surname"].ToString();
            this.fiscalCode = row[0]["FiscalCode"].ToString();
            this.address = row[0]["Address"].ToString();
            this.id = Convert.ToInt32(row[0]["id"]);
            this.state = row[0]["State"].ToString();
            this.phoneNumber = row[0]["PhoneNumber"].ToString();
            this.email = row[0]["Email"].ToString();
            this.notes = row[0]["Notes"].ToString();
            this.mktgId = row[0]["MktgId"].ToString();
            this.standardDiScont = Convert.ToInt32(row[0]["standardDiScont"]);
            return this;
        }
        public void Update()
        {
            relactionDb db = new relactionDb();
            string query = $"UPDATE [dbo].[Costumer] SET [Name] =  '{name}', [Surname] = '{surname}', [FiscalCode]=  '{fiscalCode}', [Address] = '{ address} ',[State] = '{state}',[PhoneNumber] = '{phoneNumber}',[Email] = '{email}',[Notes] = '{notes}', [MktgId] = '{mktgId}', [standardDiScont] = '{standardDiScont}'  WHERE Id = {id};";
            db.voidQuery(Global.settings.conn, query);
        }

    }
}
