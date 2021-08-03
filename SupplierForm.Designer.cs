namespace Pos_PointOfSales
{
    partial class SupplierForm
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
            this.BTN_reload = new System.Windows.Forms.Button();
            this.L_change = new System.Windows.Forms.Label();
            this.BTN_clouse = new System.Windows.Forms.Button();
            this.TB_notes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_fiscalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_transation = new System.Windows.Forms.DataGridView();
            this.BTN_action = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_transation)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_reload
            // 
            this.BTN_reload.Location = new System.Drawing.Point(15, 531);
            this.BTN_reload.Name = "BTN_reload";
            this.BTN_reload.Size = new System.Drawing.Size(120, 23);
            this.BTN_reload.TabIndex = 43;
            this.BTN_reload.Text = "Reload";
            this.BTN_reload.UseVisualStyleBackColor = true;
            this.BTN_reload.Click += new System.EventHandler(this.BTN_reload_Click);
            // 
            // L_change
            // 
            this.L_change.AutoSize = true;
            this.L_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_change.ForeColor = System.Drawing.Color.Brown;
            this.L_change.Location = new System.Drawing.Point(207, 9);
            this.L_change.Name = "L_change";
            this.L_change.Size = new System.Drawing.Size(125, 13);
            this.L_change.TabIndex = 42;
            this.L_change.Text = "Change is not Saved";
            // 
            // BTN_clouse
            // 
            this.BTN_clouse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_clouse.Location = new System.Drawing.Point(279, 531);
            this.BTN_clouse.Name = "BTN_clouse";
            this.BTN_clouse.Size = new System.Drawing.Size(120, 23);
            this.BTN_clouse.TabIndex = 41;
            this.BTN_clouse.Text = "Clouse";
            this.BTN_clouse.UseVisualStyleBackColor = true;
            this.BTN_clouse.Click += new System.EventHandler(this.BTN_clouse_Click);
            // 
            // TB_notes
            // 
            this.TB_notes.Location = new System.Drawing.Point(65, 160);
            this.TB_notes.Multiline = true;
            this.TB_notes.Name = "TB_notes";
            this.TB_notes.Size = new System.Drawing.Size(460, 89);
            this.TB_notes.TabIndex = 40;
            this.TB_notes.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Notes";
            // 
            // TB_fiscalCode
            // 
            this.TB_fiscalCode.Location = new System.Drawing.Point(356, 27);
            this.TB_fiscalCode.Name = "TB_fiscalCode";
            this.TB_fiscalCode.Size = new System.Drawing.Size(169, 20);
            this.TB_fiscalCode.TabIndex = 38;
            this.TB_fiscalCode.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Fiscal Code";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(65, 26);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(169, 20);
            this.TB_id.TabIndex = 36;
            this.TB_id.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(65, 52);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(169, 20);
            this.TB_name.TabIndex = 34;
            this.TB_name.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Transaction";
            // 
            // DGV_transation
            // 
            this.DGV_transation.AllowUserToAddRows = false;
            this.DGV_transation.AllowUserToDeleteRows = false;
            this.DGV_transation.AllowUserToOrderColumns = true;
            this.DGV_transation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_transation.Location = new System.Drawing.Point(15, 271);
            this.DGV_transation.Name = "DGV_transation";
            this.DGV_transation.ReadOnly = true;
            this.DGV_transation.Size = new System.Drawing.Size(510, 243);
            this.DGV_transation.TabIndex = 31;
            // 
            // BTN_action
            // 
            this.BTN_action.Location = new System.Drawing.Point(405, 531);
            this.BTN_action.Name = "BTN_action";
            this.BTN_action.Size = new System.Drawing.Size(120, 23);
            this.BTN_action.TabIndex = 30;
            this.BTN_action.Text = "Action";
            this.BTN_action.UseVisualStyleBackColor = true;
            this.BTN_action.Click += new System.EventHandler(this.BTN_action_Click);
            // 
            // SupplierForm
            // 
            this.AcceptButton = this.BTN_action;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_clouse;
            this.ClientSize = new System.Drawing.Size(547, 581);
            this.Controls.Add(this.BTN_reload);
            this.Controls.Add(this.L_change);
            this.Controls.Add(this.BTN_clouse);
            this.Controls.Add(this.TB_notes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TB_fiscalCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_transation);
            this.Controls.Add(this.BTN_action);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_transation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_reload;
        private System.Windows.Forms.Label L_change;
        private System.Windows.Forms.Button BTN_clouse;
        private System.Windows.Forms.TextBox TB_notes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_fiscalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_transation;
        private System.Windows.Forms.Button BTN_action;
    }
}