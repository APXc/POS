﻿using System;
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
    public partial class RecepitForm : Form
    {

        private static Dictionary<string, article> keysArticle = new Dictionary<string, article>();
        private static Dictionary<string, Invectory> keysInvectory = new Dictionary<string, Invectory>();
        private static Dictionary<string, costumer> keysCostumer = new Dictionary<string, costumer>();
        private static Dictionary<string, Payment> keysPayment = new Dictionary<string, Payment>();
        private static Dictionary<string, Discount> keysDiscount = new Dictionary<string, Discount>();
        public RecepitForm()
        {
            InitializeComponent();
         
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CellChange(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            var s = dataGridView1.CurrentRow.Cells[0];

            article article = keysArticle[s.Value.ToString()];

            dataGridView1.CurrentRow.Cells[3].Value = article.salesPrice * Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value != null ? dataGridView1.CurrentRow.Cells[1].Value : 0);
            dataGridView1.CurrentRow.Cells[4].Value = dataGridView1.CurrentRow.Cells[3].Value != null ? (Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value) * article.salesTax) / 100 : 0;
            dataGridView1.CurrentRow.Cells[5].Value = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value) + Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);

        }

        private void SetDataGrid()
        {
            DataGridViewComboBoxColumn ArticleColum;
            ArticleColum = CreateComboBoxColumn();
            foreach (article article in article.ListArticle())
            {
                ArticleColum.Items.Add(article.code);
                keysArticle.Add(article.code, article);

            }
            ArticleColum.HeaderText = "Article";
            dataGridView1.Columns.Add(ArticleColum);

            DataGridViewColumn Qtacolumn = new DataGridViewColumn();
            Qtacolumn.HeaderText = "Qta";
            Qtacolumn.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(Qtacolumn);

            DataGridViewComboBoxColumn invectorcloum;
            invectorcloum = CreateComboBoxColumn();
            foreach (Invectory invectory in Invectory.ListInvectory())
            {
                invectorcloum.Items.Add(invectory.name);
                keysInvectory.Add(invectory.name, invectory);
            }
            invectorcloum.HeaderText = "Invectory";
            dataGridView1.Columns.Add(invectorcloum);

            DataGridViewColumn ValueColumn = new DataGridViewColumn();
            ValueColumn.HeaderText = "Value";
            ValueColumn.CellTemplate = new DataGridViewTextBoxCell();
            ValueColumn.ReadOnly = true;
            dataGridView1.Columns.Add(ValueColumn);

            DataGridViewColumn TaxValueColumn = new DataGridViewColumn();
            TaxValueColumn.HeaderText = "Tax Value";
            TaxValueColumn.CellTemplate = new DataGridViewTextBoxCell();
            TaxValueColumn.ReadOnly = true;
            dataGridView1.Columns.Add(TaxValueColumn);

            DataGridViewColumn TotalColumn = new DataGridViewColumn();
            TotalColumn.HeaderText = "Total";
            TotalColumn.CellTemplate = new DataGridViewTextBoxCell();
            TotalColumn.ReadOnly = true;
            dataGridView1.Columns.Add(TotalColumn);


        }

        private void SetCB()
        {
            foreach (costumer costumer in costumer.ListCostumers())
            {
                CB_costumer.Items.Add($"{costumer.name} {costumer.surname}");
                keysCostumer.Add($"{costumer.name} {costumer.surname}", costumer);
            }

            foreach (Payment payment in Payment.ListPayment())
            {
                CB_Payment.Items.Add(payment.name);
                keysPayment.Add(payment.name, payment);
            }

            foreach (Discount discount in Discount.ListDiscount())
            {
                CB_Discount.Items.Add(discount.code);
                keysDiscount.Add(discount.code, discount);
            }
        }

        private DataGridViewComboBoxColumn CreateComboBoxColumn()
        {
            DataGridViewComboBoxColumn column =
                new DataGridViewComboBoxColumn();
            {
                
                column.DropDownWidth = 160;
                column.Width = 90;
                column.MaxDropDownItems = 3;
                column.FlatStyle = FlatStyle.Flat;
            }
            return column;
        }

        private void RecepitForm_Load(object sender, EventArgs e)
        {
            SetDataGrid();
            SetCB();

        }
    }
}
