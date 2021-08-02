namespace Pos_PointOfSales
{
    partial class CostumerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumerForm));
            this.BTN_action = new System.Windows.Forms.Button();
            this.DGV_transation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_state = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_fiscalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_phoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_mktgId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_standardDiScont = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_notes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BTN_clouse = new System.Windows.Forms.Button();
            this.L_change = new System.Windows.Forms.Label();
            this.BTN_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_transation)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_action
            // 
            this.BTN_action.Location = new System.Drawing.Point(402, 533);
            this.BTN_action.Name = "BTN_action";
            this.BTN_action.Size = new System.Drawing.Size(120, 23);
            this.BTN_action.TabIndex = 0;
            this.BTN_action.Text = "Action";
            this.BTN_action.UseVisualStyleBackColor = true;
            // 
            // DGV_transation
            // 
            this.DGV_transation.AllowUserToAddRows = false;
            this.DGV_transation.AllowUserToDeleteRows = false;
            this.DGV_transation.AllowUserToOrderColumns = true;
            this.DGV_transation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_transation.Location = new System.Drawing.Point(12, 273);
            this.DGV_transation.Name = "DGV_transation";
            this.DGV_transation.ReadOnly = true;
            this.DGV_transation.Size = new System.Drawing.Size(510, 243);
            this.DGV_transation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(62, 54);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(169, 20);
            this.TB_name.TabIndex = 4;
            this.TB_name.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // TB_surname
            // 
            this.TB_surname.Location = new System.Drawing.Point(62, 80);
            this.TB_surname.Name = "TB_surname";
            this.TB_surname.Size = new System.Drawing.Size(169, 20);
            this.TB_surname.TabIndex = 6;
            this.TB_surname.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(62, 28);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(169, 20);
            this.TB_id.TabIndex = 10;
            this.TB_id.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // TB_address
            // 
            this.TB_address.Location = new System.Drawing.Point(62, 107);
            this.TB_address.Name = "TB_address";
            this.TB_address.Size = new System.Drawing.Size(169, 20);
            this.TB_address.TabIndex = 12;
            this.TB_address.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // TB_state
            // 
            this.TB_state.Location = new System.Drawing.Point(62, 133);
            this.TB_state.Name = "TB_state";
            this.TB_state.Size = new System.Drawing.Size(169, 20);
            this.TB_state.TabIndex = 14;
            this.TB_state.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "State";
            // 
            // TB_fiscalCode
            // 
            this.TB_fiscalCode.Location = new System.Drawing.Point(353, 29);
            this.TB_fiscalCode.Name = "TB_fiscalCode";
            this.TB_fiscalCode.Size = new System.Drawing.Size(169, 20);
            this.TB_fiscalCode.TabIndex = 16;
            this.TB_fiscalCode.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fiscal Code";
            // 
            // TB_phoneNumber
            // 
            this.TB_phoneNumber.Location = new System.Drawing.Point(353, 58);
            this.TB_phoneNumber.Name = "TB_phoneNumber";
            this.TB_phoneNumber.Size = new System.Drawing.Size(169, 20);
            this.TB_phoneNumber.TabIndex = 18;
            this.TB_phoneNumber.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone Number";
            // 
            // TB_email
            // 
            this.TB_email.Location = new System.Drawing.Point(353, 84);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(169, 20);
            this.TB_email.TabIndex = 20;
            this.TB_email.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email";
            // 
            // TB_mktgId
            // 
            this.TB_mktgId.Location = new System.Drawing.Point(353, 110);
            this.TB_mktgId.Name = "TB_mktgId";
            this.TB_mktgId.Size = new System.Drawing.Size(169, 20);
            this.TB_mktgId.TabIndex = 22;
            this.TB_mktgId.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "MKTG ID";
            // 
            // TB_standardDiScont
            // 
            this.TB_standardDiScont.Location = new System.Drawing.Point(353, 136);
            this.TB_standardDiScont.Name = "TB_standardDiScont";
            this.TB_standardDiScont.Size = new System.Drawing.Size(169, 20);
            this.TB_standardDiScont.TabIndex = 24;
            this.TB_standardDiScont.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Standard Discont";
            // 
            // TB_notes
            // 
            this.TB_notes.Location = new System.Drawing.Point(62, 162);
            this.TB_notes.Multiline = true;
            this.TB_notes.Name = "TB_notes";
            this.TB_notes.Size = new System.Drawing.Size(460, 89);
            this.TB_notes.TabIndex = 26;
            this.TB_notes.TextChanged += new System.EventHandler(this.ModifyValue);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Notes";
            // 
            // BTN_clouse
            // 
            this.BTN_clouse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_clouse.Location = new System.Drawing.Point(276, 533);
            this.BTN_clouse.Name = "BTN_clouse";
            this.BTN_clouse.Size = new System.Drawing.Size(120, 23);
            this.BTN_clouse.TabIndex = 27;
            this.BTN_clouse.Text = "Clouse";
            this.BTN_clouse.UseVisualStyleBackColor = true;
            this.BTN_clouse.Click += new System.EventHandler(this.BTN_clouse_Click);
            // 
            // L_change
            // 
            this.L_change.AutoSize = true;
            this.L_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_change.ForeColor = System.Drawing.Color.Brown;
            this.L_change.Location = new System.Drawing.Point(222, 9);
            this.L_change.Name = "L_change";
            this.L_change.Size = new System.Drawing.Size(125, 13);
            this.L_change.TabIndex = 28;
            this.L_change.Text = "Change is not Saved";
            // 
            // BTN_reload
            // 
            this.BTN_reload.Location = new System.Drawing.Point(12, 533);
            this.BTN_reload.Name = "BTN_reload";
            this.BTN_reload.Size = new System.Drawing.Size(120, 23);
            this.BTN_reload.TabIndex = 29;
            this.BTN_reload.Text = "Reload";
            this.BTN_reload.UseVisualStyleBackColor = true;
            this.BTN_reload.Click += new System.EventHandler(this.BTN_reload_Click);
            // 
            // CostumerForm
            // 
            this.AcceptButton = this.BTN_action;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_clouse;
            this.ClientSize = new System.Drawing.Size(534, 568);
            this.Controls.Add(this.BTN_reload);
            this.Controls.Add(this.L_change);
            this.Controls.Add(this.BTN_clouse);
            this.Controls.Add(this.TB_notes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TB_standardDiScont);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_mktgId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_phoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_fiscalCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_state);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_transation);
            this.Controls.Add(this.BTN_action);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CostumerForm";
            this.Text = "CostumerForm";
            this.Load += new System.EventHandler(this.CostumerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_transation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_action;
        private System.Windows.Forms.DataGridView DGV_transation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_fiscalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_phoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_mktgId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_standardDiScont;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_notes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BTN_clouse;
        private System.Windows.Forms.Label L_change;
        private System.Windows.Forms.Button BTN_reload;
    }
}