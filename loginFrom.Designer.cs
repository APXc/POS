namespace Pos_PointOfSales
{
    partial class loginFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFrom));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_username = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_login = new System.Windows.Forms.Button();
            this.BTN_clouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // TB_username
            // 
            resources.ApplyResources(this.TB_username, "TB_username");
            this.TB_username.Name = "TB_username";
            // 
            // TB_password
            // 
            resources.ApplyResources(this.TB_password, "TB_password");
            this.TB_password.Name = "TB_password";
            this.TB_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BTN_login
            // 
            resources.ApplyResources(this.BTN_login, "BTN_login");
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // BTN_clouse
            // 
            resources.ApplyResources(this.BTN_clouse, "BTN_clouse");
            this.BTN_clouse.Name = "BTN_clouse";
            this.BTN_clouse.UseVisualStyleBackColor = true;
            this.BTN_clouse.Click += new System.EventHandler(this.BTN_clouse_Click);
            // 
            // loginFrom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_clouse);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "loginFrom";
            this.Load += new System.EventHandler(this.loginFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_username;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Button BTN_clouse;
    }
}