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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new LicenseForm();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fm = new FindCostumerForm();
            fm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fm = new FindSupplierForm();
            fm.Show();
        }
    }
}
