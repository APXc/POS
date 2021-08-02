namespace Pos_PointOfSales
{
    partial class FindCostumerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCostumerForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_surname = new System.Windows.Forms.TextBox();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_action = new System.Windows.Forms.Button();
            this.BTN_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 466);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.SelectRowByUser);
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(13, 56);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(192, 20);
            this.TB_name.TabIndex = 1;
            this.TB_name.TextChanged += new System.EventHandler(this.filter_name);
            // 
            // TB_surname
            // 
            this.TB_surname.Location = new System.Drawing.Point(211, 56);
            this.TB_surname.Name = "TB_surname";
            this.TB_surname.Size = new System.Drawing.Size(192, 20);
            this.TB_surname.TabIndex = 2;
            this.TB_surname.TextChanged += new System.EventHandler(this.filter_surname);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(409, 56);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(192, 20);
            this.TB_id.TabIndex = 3;
            this.TB_id.TextChanged += new System.EventHandler(this.filter_id);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filter";
            // 
            // BTN_action
            // 
            this.BTN_action.Location = new System.Drawing.Point(1053, 565);
            this.BTN_action.Name = "BTN_action";
            this.BTN_action.Size = new System.Drawing.Size(174, 38);
            this.BTN_action.TabIndex = 8;
            this.BTN_action.Text = "Created a New Costumer";
            this.BTN_action.UseVisualStyleBackColor = true;
            this.BTN_action.Click += new System.EventHandler(this.BTN_action_Click);
            // 
            // BTN_close
            // 
            this.BTN_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_close.Location = new System.Drawing.Point(873, 565);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(174, 38);
            this.BTN_close.TabIndex = 9;
            this.BTN_close.Text = "Close";
            this.BTN_close.UseVisualStyleBackColor = true;
            this.BTN_close.Click += new System.EventHandler(this.BTN_clouse_Click);
            // 
            // FindCostumerForm
            // 
            this.AcceptButton = this.BTN_action;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_close;
            this.ClientSize = new System.Drawing.Size(1237, 615);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindCostumerForm";
            this.Text = "FindCostumerForm";
            this.Load += new System.EventHandler(this.FindCostumerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_surname;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_action;
        private System.Windows.Forms.Button BTN_close;
    }
}