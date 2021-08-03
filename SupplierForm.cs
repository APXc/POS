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
    public partial class SupplierForm : Form
    {

        private int id { get; set; }
        private bool creation { get; set; }
        private supplier supplier { get; set; }
        private bool isFirst { get; set; }

        public SupplierForm()
        {
            InitializeComponent();
            creation = true;
        }
        public SupplierForm( int id)
        {
            InitializeComponent();
            creation = false;
            this.id = id;
            isFirst = true;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            this.supplier = new supplier();

            if (creation)
            {
                L_change.Visible = true;
                TB_id.Enabled = false;
                TB_id.Visible = false;
                label5.Visible = false;
            }
            else
            {
                TB_id.Text = id.ToString();
                setVendor(id);
                isFirst = false;
            }

        }

        private void setVendor( int id)
        {
            supplier = supplier.SetByKey(id);

            TB_id.Text = id.ToString();
            TB_name.Text = supplier.name;
            TB_notes.Text = supplier.notes;
            TB_fiscalCode.Text = supplier.fiscalCode;
        }

        private void ModifyValue(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                L_change.Visible = true;

                supplier.name = TB_name.Text;
                supplier.fiscalCode = TB_fiscalCode.Text;
                supplier.notes = TB_notes.Text;
                
            }

        }

        private void BTN_action_Click(object sender, EventArgs e)
        {
            if (creation && TB_id.Text.Length == 0)
            {

                if (TB_name.Text != null)
                {
                    supplier supplier = new supplier();
                    supplier = supplier.Add(TB_name.Text, TB_fiscalCode.Text, TB_notes.Text);
                    this.supplier = supplier;
                    setVendor(supplier.id);
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                supplier.Update();
            }
        }

        private void BTN_clouse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_reload_Click(object sender, EventArgs e)
        {
            isFirst = true;
            setVendor(this.id);
            isFirst = false;
        }



    }
}
