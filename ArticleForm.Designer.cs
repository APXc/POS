namespace Pos_PointOfSales
{
    partial class ArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.TB_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_barcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_rapidcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_salesPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_purchasePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_salesTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_purchaseTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_notes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BTN_reload = new System.Windows.Forms.Button();
            this.L_change = new System.Windows.Forms.Label();
            this.BTN_clouse = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.DGV_transation = new System.Windows.Forms.DataGridView();
            this.BTN_action = new System.Windows.Forms.Button();
            this.CB_isInvectory = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_transation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(82, 35);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(176, 20);
            this.TB_id.TabIndex = 1;
            this.TB_id.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // TB_code
            // 
            this.TB_code.Location = new System.Drawing.Point(82, 61);
            this.TB_code.Name = "TB_code";
            this.TB_code.Size = new System.Drawing.Size(176, 20);
            this.TB_code.TabIndex = 3;
            this.TB_code.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code";
            // 
            // TB_barcode
            // 
            this.TB_barcode.Location = new System.Drawing.Point(82, 87);
            this.TB_barcode.Name = "TB_barcode";
            this.TB_barcode.Size = new System.Drawing.Size(176, 20);
            this.TB_barcode.TabIndex = 5;
            this.TB_barcode.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barcode";
            // 
            // TB_rapidcode
            // 
            this.TB_rapidcode.Location = new System.Drawing.Point(82, 113);
            this.TB_rapidcode.Name = "TB_rapidcode";
            this.TB_rapidcode.Size = new System.Drawing.Size(176, 20);
            this.TB_rapidcode.TabIndex = 7;
            this.TB_rapidcode.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rapidcode";
            // 
            // TB_description
            // 
            this.TB_description.Location = new System.Drawing.Point(82, 139);
            this.TB_description.Name = "TB_description";
            this.TB_description.Size = new System.Drawing.Size(176, 20);
            this.TB_description.TabIndex = 9;
            this.TB_description.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // TB_salesPrice
            // 
            this.TB_salesPrice.Location = new System.Drawing.Point(449, 38);
            this.TB_salesPrice.Name = "TB_salesPrice";
            this.TB_salesPrice.Size = new System.Drawing.Size(176, 20);
            this.TB_salesPrice.TabIndex = 11;
            this.TB_salesPrice.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sales Price";
            // 
            // TB_purchasePrice
            // 
            this.TB_purchasePrice.Location = new System.Drawing.Point(449, 64);
            this.TB_purchasePrice.Name = "TB_purchasePrice";
            this.TB_purchasePrice.Size = new System.Drawing.Size(176, 20);
            this.TB_purchasePrice.TabIndex = 13;
            this.TB_purchasePrice.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Purchase Price";
            // 
            // TB_salesTax
            // 
            this.TB_salesTax.Location = new System.Drawing.Point(449, 90);
            this.TB_salesTax.Name = "TB_salesTax";
            this.TB_salesTax.Size = new System.Drawing.Size(176, 20);
            this.TB_salesTax.TabIndex = 15;
            this.TB_salesTax.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sales Tax";
            // 
            // TB_purchaseTax
            // 
            this.TB_purchaseTax.Location = new System.Drawing.Point(449, 116);
            this.TB_purchaseTax.Name = "TB_purchaseTax";
            this.TB_purchaseTax.Size = new System.Drawing.Size(176, 20);
            this.TB_purchaseTax.TabIndex = 17;
            this.TB_purchaseTax.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Purchase Tax";
            // 
            // TB_notes
            // 
            this.TB_notes.Location = new System.Drawing.Point(15, 188);
            this.TB_notes.Multiline = true;
            this.TB_notes.Name = "TB_notes";
            this.TB_notes.Size = new System.Drawing.Size(610, 85);
            this.TB_notes.TabIndex = 21;
            this.TB_notes.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Notes";
            // 
            // BTN_reload
            // 
            this.BTN_reload.Location = new System.Drawing.Point(15, 532);
            this.BTN_reload.Name = "BTN_reload";
            this.BTN_reload.Size = new System.Drawing.Size(120, 23);
            this.BTN_reload.TabIndex = 49;
            this.BTN_reload.Text = "Reload";
            this.BTN_reload.UseVisualStyleBackColor = true;
            this.BTN_reload.Click += new System.EventHandler(this.BTN_reload_Click);
            // 
            // L_change
            // 
            this.L_change.AutoSize = true;
            this.L_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_change.ForeColor = System.Drawing.Color.Brown;
            this.L_change.Location = new System.Drawing.Point(247, 9);
            this.L_change.Name = "L_change";
            this.L_change.Size = new System.Drawing.Size(125, 13);
            this.L_change.TabIndex = 48;
            this.L_change.Text = "Change is not Saved";
            // 
            // BTN_clouse
            // 
            this.BTN_clouse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_clouse.Location = new System.Drawing.Point(368, 532);
            this.BTN_clouse.Name = "BTN_clouse";
            this.BTN_clouse.Size = new System.Drawing.Size(120, 23);
            this.BTN_clouse.TabIndex = 47;
            this.BTN_clouse.Text = "Clouse";
            this.BTN_clouse.UseVisualStyleBackColor = true;
            this.BTN_clouse.Click += new System.EventHandler(this.BTN_clouse_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Transaction";
            // 
            // DGV_transation
            // 
            this.DGV_transation.AllowUserToAddRows = false;
            this.DGV_transation.AllowUserToDeleteRows = false;
            this.DGV_transation.AllowUserToOrderColumns = true;
            this.DGV_transation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_transation.Location = new System.Drawing.Point(14, 300);
            this.DGV_transation.Name = "DGV_transation";
            this.DGV_transation.ReadOnly = true;
            this.DGV_transation.Size = new System.Drawing.Size(611, 212);
            this.DGV_transation.TabIndex = 45;
            // 
            // BTN_action
            // 
            this.BTN_action.Location = new System.Drawing.Point(505, 532);
            this.BTN_action.Name = "BTN_action";
            this.BTN_action.Size = new System.Drawing.Size(120, 23);
            this.BTN_action.TabIndex = 44;
            this.BTN_action.Text = "Action";
            this.BTN_action.UseVisualStyleBackColor = true;
            this.BTN_action.Click += new System.EventHandler(this.BTN_action_Click);
            // 
            // CB_isInvectory
            // 
            this.CB_isInvectory.AutoSize = true;
            this.CB_isInvectory.Location = new System.Drawing.Point(449, 152);
            this.CB_isInvectory.Name = "CB_isInvectory";
            this.CB_isInvectory.Size = new System.Drawing.Size(80, 17);
            this.CB_isInvectory.TabIndex = 50;
            this.CB_isInvectory.Text = "is Invectory";
            this.CB_isInvectory.UseVisualStyleBackColor = true;
            this.CB_isInvectory.CheckedChanged += new System.EventHandler(this.ModifyValue);
            // 
            // ArticleForm
            // 
            this.AcceptButton = this.BTN_action;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_clouse;
            this.ClientSize = new System.Drawing.Size(639, 565);
            this.Controls.Add(this.CB_isInvectory);
            this.Controls.Add(this.BTN_reload);
            this.Controls.Add(this.L_change);
            this.Controls.Add(this.BTN_clouse);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DGV_transation);
            this.Controls.Add(this.BTN_action);
            this.Controls.Add(this.TB_notes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_purchaseTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_salesTax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_purchasePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_salesPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_rapidcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_barcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticleForm";
            this.Text = "ArticleForm";
            this.Load += new System.EventHandler(this.ArticleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_transation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.TextBox TB_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_barcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_rapidcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_salesPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_purchasePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_salesTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_purchaseTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_notes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTN_reload;
        private System.Windows.Forms.Label L_change;
        private System.Windows.Forms.Button BTN_clouse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DGV_transation;
        private System.Windows.Forms.Button BTN_action;
        private System.Windows.Forms.CheckBox CB_isInvectory;
    }
}