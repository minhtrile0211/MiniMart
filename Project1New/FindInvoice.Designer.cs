namespace Project1New
{
    partial class FindInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInvoice));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_invoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CusID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "FIND INVOICE";
            // 
            // txt_invoiceID
            // 
            this.txt_invoiceID.Location = new System.Drawing.Point(132, 50);
            this.txt_invoiceID.Multiline = true;
            this.txt_invoiceID.Name = "txt_invoiceID";
            this.txt_invoiceID.Size = new System.Drawing.Size(176, 20);
            this.txt_invoiceID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Invoice No:";
            // 
            // txt_CusID
            // 
            this.txt_CusID.Location = new System.Drawing.Point(462, 51);
            this.txt_CusID.Multiline = true;
            this.txt_CusID.Name = "txt_CusID";
            this.txt_CusID.Size = new System.Drawing.Size(176, 20);
            this.txt_CusID.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.Location = new System.Drawing.Point(344, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Customer ID:";
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Location = new System.Drawing.Point(462, 86);
            this.txt_EmpID.Multiline = true;
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(176, 20);
            this.txt_EmpID.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(337, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(64, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Month:";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(132, 83);
            this.txt_month.Multiline = true;
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(58, 20);
            this.txt_month.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(196, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Year:";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(250, 83);
            this.txt_year.Multiline = true;
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(58, 20);
            this.txt_year.TabIndex = 36;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(14, 109);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(624, 132);
            this.dgvInvoice.TabIndex = 46;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_cancle.Location = new System.Drawing.Point(535, 247);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(103, 38);
            this.btn_cancle.TabIndex = 50;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Location = new System.Drawing.Point(413, 248);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(116, 37);
            this.btn_edit.TabIndex = 49;
            this.btn_edit.Text = "FIND";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // FindInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 294);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_EmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CusID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_invoiceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindInvoice";
            this.Text = "FindInvoice";
            this.Load += new System.EventHandler(this.FindInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_invoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CusID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_edit;
    }
}