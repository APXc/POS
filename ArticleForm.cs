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
    public partial class ArticleForm : Form
    {
        private int id { get; set; }
        private bool creation { get; set; }
        private article article { get; set; }
        private bool isFirst { get; set; }
        public ArticleForm()
        {
            InitializeComponent();
            creation = true;
        }
        public ArticleForm(int id)
        {
            InitializeComponent();
            creation = false;
            this.id = id;
            isFirst = true;
        }

        private void ArticleForm_Load(object sender, EventArgs e)
        {
            this.article = new article();

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
                setArticle(id);
                isFirst = false;
            }
        }
        private void setArticle(int id)
        {
            article = article.SetByKey(id);

            TB_id.Text = id.ToString();
            TB_code.Text = article.code;
            TB_barcode.Text = article.barcode;
            TB_rapidcode.Text = article.rapidcode;
            TB_description.Text = article.description; 
            TB_notes.Text = article.notes;
            TB_salesPrice.Text = article.salesPrice.ToString();
            TB_salesTax.Text = article.salesTax.ToString();
            TB_purchasePrice.Text = article.purchasePrice.ToString();
            TB_purchaseTax.Text = article.purchaseTax.ToString();
            CB_isInvectory.Checked = article.isInvectory;
        }

        private void ModifyValue(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                L_change.Visible = true;

                article.code = TB_code.Text;
                article.barcode = TB_barcode.Text ;
                article.rapidcode = TB_rapidcode.Text ;
                article.notes = TB_notes.Text;
                article.salesPrice = Convert.ToDouble(TB_salesPrice.Text);
                article.salesTax = Convert.ToDouble(TB_salesTax.Text);
                article.purchasePrice = Convert.ToDouble(TB_purchasePrice.Text);
                article.purchaseTax = Convert.ToDouble(TB_purchaseTax.Text);
                article.description = TB_description.Text;
                article.isInvectory = CB_isInvectory.Checked;

            }

        }

        private void BTN_action_Click(object sender, EventArgs e)
        {
            if (creation && TB_id.Text.Length == 0)
            {

                if (TB_code.Text != null)
                {
                    article article = new article();
                    article = article.Add(TB_code.Text, TB_barcode.Text, TB_rapidcode.Text, CB_isInvectory.Checked, TB_description.Text, TB_notes.Text, Convert.ToDouble(TB_salesPrice.Text), Convert.ToDouble(TB_purchasePrice.Text), Convert.ToDouble(TB_salesTax.Text), Convert.ToDouble(TB_purchaseTax.Text)) ;
                    this.article = article;
                    setArticle(article.id);

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                article.Update();
            }
        }

        private void BTN_clouse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_reload_Click(object sender, EventArgs e)
        {
            isFirst = true;
            setArticle(this.id);
            isFirst = false;
        }
    }
}
