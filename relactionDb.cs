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
    class relactionDb
    {
        public void voidQuery(SqlConnection conn, string query)
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
                   // MessageBox.Show("Operazione Completata", "Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }
        public DataRow[] query(SqlConnection conn, string query)
        {
            DataRow[] row;
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
                            SqlDataReader testest = sql.ExecuteReader();
                           
                            DataTable dataTable = new DataTable();
                            dataTable.Load(testest);
                            row = dataTable.Select();
                           
                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show("Errore in fase di Aggiunta in SQL Server", "Errore Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                        catch (Exception en)
                        {
                            Console.WriteLine(en);
                            MessageBox.Show("Errore");


                            try
                            {
                                transaction.Rollback();
                                return null;
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.Message, "Rollback Exception");
                                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                Console.WriteLine("  Message: {0}", ex2.Message);
                                return null;
                            }
                        }
                        transaction.Commit();
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show("Errore in fase di Aggiunta Formaro Valore Errato", "Errore formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Errore in fase di Aggiunta in SQL Server", "Errore Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    catch (InvalidOperationException e)
                    {
                        MessageBox.Show("Errore in fase di Essecurzione Operazione", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Errore Gennerico", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Errore Conessione DB", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                    scope.Complete();
                    //MessageBox.Show("Operazione Completata", "Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return row;
                }
            }
            catch
            {
                return null;
            }
            
          
        }

        public DataTable queryToTable(SqlConnection conn, string query)
        {
            DataTable dataTable = new DataTable();
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
                            SqlDataReader testest = sql.ExecuteReader();

                           
                            dataTable.Load(testest);
                            

                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show("Errore in fase di Aggiunta in SQL Server", "Errore Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                        catch (Exception en)
                        {
                            Console.WriteLine(en);
                            MessageBox.Show("Errore");


                            try
                            {
                                transaction.Rollback();
                                return null;
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.Message, "Rollback Exception");
                                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                Console.WriteLine("  Message: {0}", ex2.Message);
                                return null;
                            }
                        }
                        transaction.Commit();
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show("Errore in fase di Aggiunta Formaro Valore Errato", "Errore formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Errore in fase di Aggiunta in SQL Server", "Errore Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    catch (InvalidOperationException e)
                    {
                        MessageBox.Show("Errore in fase di Essecurzione Operazione", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Errore Gennerico", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Errore Conessione DB", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(Convert.ToString(e), "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                    scope.Complete();
                    //MessageBox.Show("Operazione Completata", "Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dataTable;
                }
            }
            catch
            {
                return null;
            }


        }
    }

}


