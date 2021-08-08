namespace Pos_PointOfSales
{
    partial class PaymentForm
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
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_action = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_reload
            // 
            this.BTN_reload.Location = new System.Drawing.Point(25, 102);
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
            this.L_change.Location = new System.Drawing.Point(358, 42);
            this.L_change.Name = "L_change";
            this.L_change.Size = new System.Drawing.Size(125, 13);
            this.L_change.TabIndex = 42;
            this.L_change.Text = "Change is not Saved";
            // 
            // BTN_clouse
            // 
            this.BTN_clouse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_clouse.Location = new System.Drawing.Point(289, 102);
            this.BTN_clouse.Name = "BTN_clouse";
            this.BTN_clouse.Size = new System.Drawing.Size(120, 23);
            this.BTN_clouse.TabIndex = 41;
            this.BTN_clouse.Text = "Clouse";
            this.BTN_clouse.UseVisualStyleBackColor = true;
            this.BTN_clouse.Click += new System.EventHandler(this.BTN_clouse_Click);
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
            // BTN_action
            // 
            this.BTN_action.Location = new System.Drawing.Point(415, 102);
            this.BTN_action.Name = "BTN_action";
            this.BTN_action.Size = new System.Drawing.Size(120, 23);
            this.BTN_action.TabIndex = 30;
            this.BTN_action.Text = "Action";
            this.BTN_action.UseVisualStyleBackColor = true;
            this.BTN_action.Click += new System.EventHandler(this.BTN_action_Click);
            // 
            // PaymentForm
            // 
            this.AcceptButton = this.BTN_action;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_clouse;
            this.ClientSize = new System.Drawing.Size(547, 142);
            this.Controls.Add(this.BTN_reload);
            this.Controls.Add(this.L_change);
            this.Controls.Add(this.BTN_clouse);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_action);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_reload;
        private System.Windows.Forms.Label L_change;
        private System.Windows.Forms.Button BTN_clouse;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_action;
    }
}