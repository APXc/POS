using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_PointOfSales
{
    public partial class Form1 : Form
    {
        private lang Lang = new lang();
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Global.settings.lang);
            TB_test.Text = Global.company.NameCompany;
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
