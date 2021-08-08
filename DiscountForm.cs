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
    public partial class DiscountForm : Form
    {

        private int id { get; set; }
        private bool creation { get; set; }
        private Discount discount { get; set; }
        private bool isFirst { get; set; }

        public DiscountForm()
        {
            InitializeComponent();
            creation = true;
        }
        public DiscountForm( int id)
        {
            InitializeComponent();
            creation = false;
            this.id = id;
            isFirst = true;
        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {
            this.discount = new Discount();

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
            discount = discount.SetByKey(id);

            TB_id.Text = id.ToString();
            TB_name.Text = discount.code;
            TB_notes.Text = discount.notes;
            TB_fiscalCode.Text = discount.discont.ToString();
        }

        private void ModifyValue(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                L_change.Visible = true;

                discount.code = TB_name.Text;
                discount.discont = Convert.ToInt32(TB_fiscalCode.Text);
                discount.notes = TB_notes.Text;
                
            }

        }

        private void BTN_action_Click(object sender, EventArgs e)
        {
            if (creation && TB_id.Text.Length == 0)
            {

                if (TB_name.Text != null)
                {
                    Discount discount = new Discount();
                    discount = discount.Add(TB_name.Text, Convert.ToInt32(TB_fiscalCode.Text), TB_notes.Text);
                    this.discount = discount;
                    setVendor(discount.id);
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                discount.Update();
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

        private void SupplierForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
