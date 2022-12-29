using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace Pos_PointOfSales
{
    public partial class LicenseForm : Form
    {
        private const String filename = @"D:/Project/Pos_PointOfSales/LICENSE.txt";
        public LicenseForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Global.settings.lang);
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                textBox1.Text = textBox1.Text + "\r\n" + line; 
            }
            this.label1.Text = $"software {Global.settings.name} - version {Global.settings.version}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
