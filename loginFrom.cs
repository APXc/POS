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
    public partial class loginFrom : Form
    {
        private getSettings sett = new getSettings();
        public loginFrom()
        {
            InitializeComponent();
            sett.init();
            Global.settings = sett;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(sett.lang);
          

        }

        private void actionLogin()
        {
            login login = new login();
            if (login.test(TB_username.Text, TB_password.Text))
            {
                Global.Loged = true;
                user us = new user();
                us = us.GetUser(TB_username.Text);
                Global.user = us;
                Company company = new Company();
                company = company.SetUnique();
                Global.company = company;
                this.Close();
            }
            else
            {
                MessageBox.Show("the credential is Incorect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            actionLogin();


        }

        private void BTN_clouse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PressEnter (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                actionLogin();
            }
           
        }

        private void loginFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
