namespace Pos_PointOfSales
{
    partial class RecepitForm
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
            this.components = new System.ComponentModel.Container();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.CB_costumer = new System.Windows.Forms.ComboBox();
            this.CB_Payment = new System.Windows.Forms.ComboBox();
            this.CB_Discount = new System.Windows.Forms.ComboBox();
            this.TB_total = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Action = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.recepitRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepitRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(12, 37);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(200, 20);
            this.DTP_date.TabIndex = 0;
            this.DTP_date.Value = new System.DateTime(2021, 8, 9, 22, 34, 35, 0);
            // 
            // CB_costumer
            // 
            this.CB_costumer.FormattingEnabled = true;
            this.CB_costumer.Location = new System.Drawing.Point(13, 84);
            this.CB_costumer.Name = "CB_costumer";
            this.CB_costumer.Size = new System.Drawing.Size(199, 21);
            this.CB_costumer.TabIndex = 1;
            // 
            // CB_Payment
            // 
            this.CB_Payment.FormattingEnabled = true;
            this.CB_Payment.Location = new System.Drawing.Point(13, 145);
            this.CB_Payment.Name = "CB_Payment";
            this.CB_Payment.Size = new System.Drawing.Size(200, 21);
            this.CB_Payment.TabIndex = 2;
            // 
            // CB_Discount
            // 
            this.CB_Discount.FormattingEnabled = true;
            this.CB_Discount.Location = new System.Drawing.Point(16, 202);
            this.CB_Discount.Name = "CB_Discount";
            this.CB_Discount.Size = new System.Drawing.Size(200, 21);
            this.CB_Discount.TabIndex = 3;
            // 
            // TB_total
            // 
            this.TB_total.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_total.Location = new System.Drawing.Point(13, 280);
            this.TB_total.Name = "TB_total";
            this.TB_total.Size = new System.Drawing.Size(199, 20);
            this.TB_total.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 539);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellChange);
            // 
            // BTN_Action
            // 
            this.BTN_Action.Location = new System.Drawing.Point(909, 580);
            this.BTN_Action.Name = "BTN_Action";
            this.BTN_Action.Size = new System.Drawing.Size(123, 23);
            this.BTN_Action.TabIndex = 6;
            this.BTN_Action.Text = "Action";
            this.BTN_Action.UseVisualStyleBackColor = true;
            this.BTN_Action.Click += new System.EventHandler(this.BTN_Action_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(780, 580);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(123, 23);
            this.BTN_Close.TabIndex = 7;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Costumer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total";
            // 
            // recepitRowBindingSource
            // 
            this.recepitRowBindingSource.DataSource = typeof(Pos_PointOfSales.RecepitRow);
            // 
            // RecepitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 615);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Action);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TB_total);
            this.Controls.Add(this.CB_Discount);
            this.Controls.Add(this.CB_Payment);
            this.Controls.Add(this.CB_costumer);
            this.Controls.Add(this.DTP_date);
            this.Name = "RecepitForm";
            this.Text = "RecepitForm";
            this.Load += new System.EventHandler(this.RecepitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepitRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_date;
        private System.Windows.Forms.ComboBox CB_costumer;
        private System.Windows.Forms.ComboBox CB_Payment;
        private System.Windows.Forms.ComboBox CB_Discount;
        private System.Windows.Forms.TextBox TB_total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource recepitRowBindingSource;
        private System.Windows.Forms.Button BTN_Action;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}