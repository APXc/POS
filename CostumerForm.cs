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
    public partial class CostumerForm : Form
    {
        private int id { get; set; }
        private bool creation { get; set; }
        private costumer client { get; set; }
        public CostumerForm()
        {
            InitializeComponent();
            creation = true;
            L_change.Visible = true;
            client = new costumer();
        }
        public CostumerForm(int id)
        {
            InitializeComponent();
            creation = false;
            this.id = id;
            client = new costumer();
            setCostumer();

        }

        private void setCostumer ()
        {
            client.SetByKey(this.id);
            L_change.Visible = false;
            TB_name.Text = client.name;
            TB_surname.Text = client.surname;
            TB_fiscalCode.Text = client.fiscalCode;
            TB_address.Text = client.address;
            TB_state.Text = client.state;
            TB_phoneNumber.Text = client.phoneNumber;
            TB_email.Text = client.email;
            TB_notes.Text = client.notes;
            TB_mktgId.Text = client.mktgId;
            TB_standardDiScont.Text = client.standardDiScont.ToString();
        }

        private void CostumerForm_Load(object sender, EventArgs e)
        {
            if (creation)
            {
                L_change.Visible = true;
                TB_id.Enabled = false;
                TB_id.Visible = false;
                label5.Visible = false;
            }
        }

        private void ModifyValue(object sender, EventArgs e)
        {
            L_change.Visible = true;

            client.name = TB_name.Text;
            client.surname = TB_surname.Text;
            client.fiscalCode = TB_fiscalCode.Text;
            client.address = TB_address.Text;
            client.state = TB_state.Text;
            client.phoneNumber = TB_phoneNumber.Text;
            client.email = TB_email.Text;
            client.notes = TB_notes.Text;
            client.mktgId = TB_mktgId.Text;
            client.standardDiScont = TB_standardDiScont.Text != "" ? Convert.ToInt32(TB_standardDiScont.Text) : 0;

        }

        private void BTN_action_Click(object sender, EventArgs e)
        {
            if(creation && TB_id.Text.Length == 0)
            {

                if(TB_name.Text != null && TB_surname.Text != null)
                {
                    costumer costumer = new costumer();
                    costumer = costumer.Add(TB_name.Text, TB_surname.Text, TB_fiscalCode.Text, TB_address.Text, TB_state.Text, TB_phoneNumber.Text, TB_email.Text, TB_notes.Text, TB_mktgId.Text, Convert.ToInt32(TB_standardDiScont.Text));
                    client = costumer;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                client.Update();
            }
        }

        private void BTN_clouse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_reload_Click(object sender, EventArgs e)
        {
            setCostumer();
        }
    }
}
