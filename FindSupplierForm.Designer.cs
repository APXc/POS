namespace Pos_PointOfSales
{
    partial class FindSupplierForm
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
            this.BTN_close = new System.Windows.Forms.Button();
            this.BTN_action = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.TB_surname = new System.Windows.Forms.TextBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_close
            // 
            this.BTN_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_close.Location = new System.Drawing.Point(873, 569);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(174, 38);
            this.BTN_close.TabIndex = 19;
            this.BTN_close.Text = "Close";
            this.BTN_close.UseVisualStyleBackColor = true;
            this.BTN_close.Click += new System.EventHandler(this.BTN_clouse_Click);
            // 
            // BTN_action
            // 
            this.BTN_action.Location = new System.Drawing.Point(1053, 569);
            this.BTN_action.Name = "BTN_action";
            this.BTN_action.Size = new System.Drawing.Size(174, 38);
            this.BTN_action.TabIndex = 18;
            this.BTN_action.Text = "Created a New Vendor";
            this.BTN_action.UseVisualStyleBackColor = true;
            this.BTN_action.Click += new System.EventHandler(this.BTN_action_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(409, 60);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(192, 20);
            this.TB_id.TabIndex = 13;
            this.TB_id.TextChanged += new System.EventHandler(this.filter_id);
            // 
            // TB_surname
            // 
            this.TB_surname.Location = new System.Drawing.Point(211, 60);
            this.TB_surname.Name = "TB_surname";
            this.TB_surname.Size = new System.Drawing.Size(192, 20);
            this.TB_surname.TabIndex = 12;
            this.TB_surname.TextChanged += new System.EventHandler(this.filter_fiscalCode);
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(13, 60);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(192, 20);
            this.TB_name.TabIndex = 11;
            this.TB_name.TextChanged += new System.EventHandler(this.filter_name);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 466);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.SelectRowByUser);
            // 
            // FindSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 617);
            this.Controls.Add(this.BTN_close);
            this.Controls.Add(this.BTN_action);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.TB_surname);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FindSupplierForm";
            this.Text = "FindSupplierForm";
            this.Load += new System.EventHandler(this.FindSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_close;
        private System.Windows.Forms.Button BTN_action;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.TextBox TB_surname;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}