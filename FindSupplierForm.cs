using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_PointOfSales
{
    public partial class FindSupplierForm : Form
    {
        public FindSupplierForm()
        {
            InitializeComponent();
        }

        private void FindSupplierForm_Load(object sender, EventArgs e)
        {
            supplier supplier = new supplier();
            dataGridView1.DataSource = supplier.FindAll();
            dataGridView1.AutoGenerateColumns = true;
            DataRow[] row = supplier.FindAll().Select();
            if (row.Length == 0)
            {
                Form form = new SupplierForm();
                form.Show();
                this.Close();
            }
        }

        private void filter_name(object sender, EventArgs e)
        {
            filter("Name", TB_name.Text);
        }
        private void filter_fiscalCode(object sender, EventArgs e)
        {
            filter("fiscalCode", TB_surname.Text);
        }
        private void filter_id(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"[id] = {Convert.ToInt32(TB_id.Text)}");
        }

        private void filter(string columnName, string filterValue)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '%%{1}%%'", columnName, filterValue);
        }
        private void BTN_action_Click(object sender, EventArgs e)
        {
            Form form = new SupplierForm();
            form.Show();
            this.Close();
        }

        private void BTN_clouse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectRowByUser(object sender, EventArgs e)
        {


            var a = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            var s = dataGridView1.CurrentRow.Cells[0];
            try
            {
                //Console.WriteLine($"selcet {s.Value.ToString()}");
                Form form = new SupplierForm(Convert.ToInt32(s.Value));
                form.Show();

            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Errore Selezione Non Consentita", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ea)
            {
                MessageBox.Show("Errore Formaro Valore Errato", "Errore formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Convert.ToString(ea), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ea)
            {
                MessageBox.Show("Errore in fase di Essecurzione Operazione", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Convert.ToString(ea), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ea)
            {
                MessageBox.Show("Errore Gennerico", "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Convert.ToString(ea), "Errore Operativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

    }
}
