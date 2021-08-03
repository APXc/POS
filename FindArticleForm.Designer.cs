namespace Pos_PointOfSales
{
    partial class FindArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindArticleForm));
            this.BTN_close = new System.Windows.Forms.Button();
            this.BTN_action = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.TB_barcode = new System.Windows.Forms.TextBox();
            this.TB_code = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_rapidcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_close
            // 
            this.BTN_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_close.Location = new System.Drawing.Point(873, 565);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(174, 38);
            this.BTN_close.TabIndex = 28;
            this.BTN_close.Text = "Close";
            this.BTN_close.UseVisualStyleBackColor = true;
            // 
            // BTN_action
            // 
            this.BTN_action.Location = new System.Drawing.Point(1053, 565);
            this.BTN_action.Name = "BTN_action";
            this.BTN_action.Size = new System.Drawing.Size(174, 38);
            this.BTN_action.TabIndex = 27;
            this.BTN_action.Text = "Created a New Article";
            this.BTN_action.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Barcode";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(607, 56);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(192, 20);
            this.TB_id.TabIndex = 23;
            // 
            // TB_barcode
            // 
            this.TB_barcode.Location = new System.Drawing.Point(211, 56);
            this.TB_barcode.Name = "TB_barcode";
            this.TB_barcode.Size = new System.Drawing.Size(192, 20);
            this.TB_barcode.TabIndex = 22;
            // 
            // TB_code
            // 
            this.TB_code.Location = new System.Drawing.Point(13, 56);
            this.TB_code.Name = "TB_code";
            this.TB_code.Size = new System.Drawing.Size(192, 20);
            this.TB_code.TabIndex = 21;
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
            this.dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Rapidcode";
            // 
            // TB_rapidcode
            // 
            this.TB_rapidcode.Location = new System.Drawing.Point(409, 56);
            this.TB_rapidcode.Name = "TB_rapidcode";
            this.TB_rapidcode.Size = new System.Drawing.Size(192, 20);
            this.TB_rapidcode.TabIndex = 30;
            // 
            // FindArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_rapidcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_close);
            this.Controls.Add(this.BTN_action);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.TB_barcode);
            this.Controls.Add(this.TB_code);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindArticleForm";
            this.Text = "FindArticleForm";
            this.Load += new System.EventHandler(this.FindArticleForm_Load);
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
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.TextBox TB_barcode;
        private System.Windows.Forms.TextBox TB_code;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_rapidcode;
    }
}