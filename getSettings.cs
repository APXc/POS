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
 
    class getSettings
    {
        private const String filename = @"D:/Project/Pos_PointOfSales/SetApp.xml";
        private static Dictionary<string, int> SETTING = new Dictionary<string, int>(){
            {"lang", 0},
            {"name", 1},
            {"version", 2},
            {"database", 3 },
            {"server", 4 },
            {"userdb", 5 },
            {"passworddb", 6 }
        };
        public string lang { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string database { get; set; }
        public string server { get; set; }
        public string userdb { get; set; }
        public string passworddb { get; set; }
        public SqlConnection conn { get; set; }


        public void init()
        {
            XmlTextReader reader = null;
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            string str = null;
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("set");
            this.lang = xmlnode[0].ChildNodes.Item(SETTING["lang"]).InnerText.Trim();
            this.name = xmlnode[0].ChildNodes.Item(SETTING["name"]).InnerText.Trim();
            this.version = xmlnode[0].ChildNodes.Item(SETTING["version"]).InnerText.Trim();
            this.database = xmlnode[0].ChildNodes.Item(SETTING["database"]).InnerText.Trim();
            this.server = xmlnode[0].ChildNodes.Item(SETTING["server"]).InnerText.Trim();
            this.userdb = xmlnode[0].ChildNodes.Item(SETTING["userdb"]).InnerText.Trim();
            this.passworddb = xmlnode[0].ChildNodes.Item(SETTING["passworddb"]).InnerText.Trim();
            this.conn = ConnectionDb();
            this.DataBaseTest();
        }

        private void DataBaseTest()
        {
            string TestUser = "IF OBJECT_ID(N'dbo.users', N'U') IS NULL BEGIN  CREATE TABLE users([Id] [bigint] IDENTITY(1,1) NOT NULL, [username] [varchar](255) NOT NULL unique, [password] [varchar](255) NOT NULL,[name] [varchar](255) NOT NULL,[surname] [varchar](255) NOT NULL); END;";
            string TestCompany = "IF OBJECT_ID(N'dbo.Company', N'U') IS NULL BEGIN  CREATE TABLE Company(Id [bigint] IDENTITY(1,1) NOT NULL, NameCompany [varchar](255) NOT NULL, TaxCode [varchar](255) NOT NULL,FiscalCode [varchar](255) NOT NULL,Address [varchar](255) NOT NULL, State [varchar](255) NOT NULL, PhoneNumber [varchar](255) NOT NULL , email [varchar](255) NOT NULL,  legalString [varchar](255) NOT NULL, OptionalString  [varchar](255) NOT NULL); END;";
            string TestCostumer = "IF OBJECT_ID(N'dbo.Costumer', N'U') IS NULL BEGIN  CREATE TABLE Costumer(Id [bigint] IDENTITY(1,1) NOT NULL, Name [varchar](255) NOT NULL, Surname [varchar](255) NOT NULL, FiscalCode [varchar](255), Address [varchar](255), State [varchar](255), PhoneNumber [varchar](255) , Email [varchar](255),  Notes [varchar](255), MktgId  [varchar](255), standardDiScont [bigint]); END;";
            string TestSupplier = "IF OBJECT_ID(N'dbo.Supplier', N'U') IS NULL BEGIN  CREATE TABLE Supplier([Id] [bigint] IDENTITY(1,1) NOT NULL, [name] [varchar](255) NOT NULL unique, [notes] [varchar](255),[fiscalCode] [varchar](255)); END;";
            string TestArticle = "IF OBJECT_ID(N'dbo.Article', N'U') IS NULL BEGIN  CREATE TABLE Article([Id] [bigint] IDENTITY(1,1) NOT NULL, [code] [varchar](255) NOT NULL unique, [barcode] [varchar](255) NOT NULL unique, [rapidcode] [varchar](255) NOT NULL unique, [notes] [varchar](255) ,  [description] [varchar](255) , [isInvectory] [char] not null, [salesPrice] money, [purchasePrice] money, [salesTax] money, [purchaseTax] money); END;";
            string TestDiscont = "IF OBJECT_ID(N'dbo.Discount', N'U') IS NULL BEGIN  CREATE TABLE Discount([Id] [bigint] IDENTITY(1,1) NOT NULL, [code] [varchar](255) NOT NULL unique, [discont] [bigint] NOT NULL, [notes] [varchar](255)); END;";
            string TestPayment = "IF OBJECT_ID(N'dbo.Payment', N'U') IS NULL BEGIN  CREATE TABLE Payment([Id] [bigint] IDENTITY(1,1) NOT NULL, [name] [varchar](255) NOT NULL unique); END;";
            string TestInvectory = "IF OBJECT_ID(N'dbo.Invectory', N'U') IS NULL BEGIN  CREATE TABLE Invectory([Id] [bigint] IDENTITY(1,1) NOT NULL, [name] [varchar](255) NOT NULL unique); END;";
            string TestRecepit = "IF OBJECT_ID(N'dbo.Recepit', N'U') IS NULL BEGIN   CREATE TABLE Recepit([Id] [bigint] IDENTITY(1,1) NOT NULL, [dateTime] [DateTime] NOT NULL, CostumerID bigint NOT NULL, count decimal not null, DiscountID bigint NOT NULL,  PaymentID bigint NOT NULL, securekey varchar(255) unique not null); END;";
            string TestRecepitRow = "IF OBJECT_ID(N'dbo.RecepitRow', N'U') IS NULL BEGIN  CREATE TABLE RecepitRow([Id] [bigint] IDENTITY(1,1) NOT NULL, FatherID bigint NOT NULL, qta int not null, linenum int not null, ,value decimal not null,valueToTax decimal, articleID bigint NOT NULL,  invectoryID bigint NOT NULL); END;";
            TestOnDB(TestUser);
            TestOnDB(TestCompany);
            TestOnDB(TestCostumer);
            TestOnDB(TestSupplier);
            TestOnDB(TestArticle);
            TestOnDB(TestDiscont);
            TestOnDB(TestPayment);
            TestOnDB(TestInvectory);
            TestOnDB(TestRecepit);
            TestOnDB(TestRecepitRow);
        }
        internal string GetConnectionString()
        {
            string returnValue = null;
            ConnectionStringSettings settings =new ConnectionStringSettings("Alfa" ,$"Data Source={this.server};Initial Catalog={this.database};Persist Security Info=True;User ID={this.userdb};Password={this.passworddb}");
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        public SqlConnection ConnectionDb()
        {
            return new SqlConnection(GetConnectionString());
        }

        public void TestOnDB(string query)
        {
            try
            {
                using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
                {
                    try
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        if (conn.State.Equals(null))
                        {
                            MessageBox.Show("Errore di Conessione a Data Base");
                        }
                        SqlCommand sql = new SqlCommand(query, conn);
                        sql.Transaction = transaction;
                        sql.CommandType = CommandType.Text;
                        try
                        {
                            sql.ExecuteNonQuery();
                            transaction.Commit();

                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show("Errore in fase di Aggiunta in SQL Server", "Errore Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception en)
                        {
                            Console.WriteLine(en);
                            MessageBox.Show("Errore");

                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show("Rollback Exception Type: {0}", ex2.Message);
                                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                Console.WriteLine("  Message: {0}", ex2.Message);
                            }
                        }
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show("Errore in fase di Aggiunta Formaro Valore Errato", "Errore formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (TimeoutException e)
                    {
                        MessageBox.Show("Errore in fase di connessione SQL Server", "Errore Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Errore in fase di Aggiunta in SQL Server", "Errore Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (InvalidOperationException e)
                    {
                        MessageBox.Show("Errore in fase di Essecurzione Operazione", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Errore Gennerico", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Errore Conessione DB", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    scope.Complete();
                    //MessageBox.Show("Operazione Completata", "Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

    }

}
