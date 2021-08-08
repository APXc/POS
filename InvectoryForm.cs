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
    public partial class InvectoryForm : Form
    {

        private int id { get; set; }
        private bool creation { get; set; }
        private Invectory invectory { get; set; }
        private bool isFirst { get; set; }

        public InvectoryForm()
        {
            InitializeComponent();
            creation = true;
        }
        public InvectoryForm( int id)
        {
            InitializeComponent();
            creation = false;
            this.id = id;
            isFirst = true;
        }

        private void InvectoryForm_Load(object sender, EventArgs e)
        {
            this.invectory = new Invectory();

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
            invectory = invectory.SetByKey(id);

            TB_id.Text = id.ToString();
            TB_name.Text = invectory.name;
         
        }

        private void ModifyValue(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                L_change.Visible = true;

                invectory.name = TB_name.Text;
               
            }

        }

        private void BTN_action_Click(object sender, EventArgs e)
        {
            if (creation && TB_id.Text.Length == 0)
            {

                if (TB_name.Text != null)
                {
                    Invectory invectory = new Invectory();
                    invectory = invectory.Add(TB_name.Text);
                    this.invectory = invectory;
                    setVendor(invectory.id);
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                invectory.Update();
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
