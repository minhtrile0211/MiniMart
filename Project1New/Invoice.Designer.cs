namespace Project1New
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_CusPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CusAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Cusname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_CusID = new System.Windows.Forms.ComboBox();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_EmpID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_invoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Unitprice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_prodName = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_proID = new System.Windows.Forms.ComboBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lb_table = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btc_Find = new System.Windows.Forms.Button();
            this.cbb_Find = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_addCus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(355, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "INVOICE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_CusPhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_CusAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Cusname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbb_CusID);
            this.groupBox1.Controls.Add(this.txt_EmpName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbb_EmpID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_invoiceID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 30);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_CusPhone
            // 
            this.txt_CusPhone.Location = new System.Drawing.Point(618, 121);
            this.txt_CusPhone.Name = "txt_CusPhone";
            this.txt_CusPhone.Size = new System.Drawing.Size(219, 30);
            this.txt_CusPhone.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.Location = new System.Drawing.Point(468, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "Customer Phone:";
            // 
            // txt_CusAddress
            // 
            this.txt_CusAddress.Location = new System.Drawing.Point(618, 87);
            this.txt_CusAddress.Name = "txt_CusAddress";
            this.txt_CusAddress.Size = new System.Drawing.Size(219, 30);
            this.txt_CusAddress.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label8.Location = new System.Drawing.Point(451, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 29;
            this.label8.Text = "Customer Address:";
            // 
            // txt_Cusname
            // 
            this.txt_Cusname.Location = new System.Drawing.Point(618, 54);
            this.txt_Cusname.Name = "txt_Cusname";
            this.txt_Cusname.Size = new System.Drawing.Size(219, 30);
            this.txt_Cusname.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label7.Location = new System.Drawing.Point(470, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Customer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.Location = new System.Drawing.Point(496, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Customer ID:";
            // 
            // cbb_CusID
            // 
            this.cbb_CusID.FormattingEnabled = true;
            this.cbb_CusID.Location = new System.Drawing.Point(618, 18);
            this.cbb_CusID.Name = "cbb_CusID";
            this.cbb_CusID.Size = new System.Drawing.Size(219, 30);
            this.cbb_CusID.TabIndex = 25;
            this.cbb_CusID.SelectedIndexChanged += new System.EventHandler(this.cbb_CusID_SelectedIndexChanged);
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(154, 121);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(239, 30);
            this.txt_EmpName.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Employee Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.Location = new System.Drawing.Point(32, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Employee ID:";
            // 
            // cbb_EmpID
            // 
            this.cbb_EmpID.FormattingEnabled = true;
            this.cbb_EmpID.Location = new System.Drawing.Point(154, 87);
            this.cbb_EmpID.Name = "cbb_EmpID";
            this.cbb_EmpID.Size = new System.Drawing.Size(239, 30);
            this.cbb_EmpID.TabIndex = 20;
            this.cbb_EmpID.SelectedIndexChanged += new System.EventHandler(this.cbb_EmpID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(41, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date of sale:";
            // 
            // txt_invoiceID
            // 
            this.txt_invoiceID.Location = new System.Drawing.Point(154, 18);
            this.txt_invoiceID.Name = "txt_invoiceID";
            this.txt_invoiceID.ReadOnly = true;
            this.txt_invoiceID.Size = new System.Drawing.Size(239, 30);
            this.txt_invoiceID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Invoice No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Price);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_Unitprice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_discount);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_prodName);
            this.groupBox2.Controls.Add(this.txt_Amount);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbb_proID);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.groupBox2.Location = new System.Drawing.Point(13, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 109);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Product:";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(687, 65);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(149, 30);
            this.txt_Price.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label16.Location = new System.Drawing.Point(625, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 22);
            this.label16.TabIndex = 41;
            this.label16.Text = "Price:";
            // 
            // txt_Unitprice
            // 
            this.txt_Unitprice.Location = new System.Drawing.Point(687, 24);
            this.txt_Unitprice.Name = "txt_Unitprice";
            this.txt_Unitprice.Size = new System.Drawing.Size(149, 30);
            this.txt_Unitprice.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label14.Location = new System.Drawing.Point(587, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 22);
            this.label14.TabIndex = 38;
            this.label14.Text = "Unit Price:";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(419, 65);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(149, 30);
            this.txt_discount.TabIndex = 37;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label13.Location = new System.Drawing.Point(329, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 22);
            this.label13.TabIndex = 36;
            this.label13.Text = "Discount:";
            // 
            // txt_prodName
            // 
            this.txt_prodName.Location = new System.Drawing.Point(419, 24);
            this.txt_prodName.Name = "txt_prodName";
            this.txt_prodName.Size = new System.Drawing.Size(149, 30);
            this.txt_prodName.TabIndex = 34;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(131, 65);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(140, 30);
            this.txt_Amount.TabIndex = 33;
            this.txt_Amount.TextChanged += new System.EventHandler(this.txt_Amount_TextChanged);
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label12.Location = new System.Drawing.Point(287, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 22);
            this.label12.TabIndex = 33;
            this.label12.Text = "Product Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label11.Location = new System.Drawing.Point(34, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 22);
            this.label11.TabIndex = 35;
            this.label11.Text = "Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label10.Location = new System.Drawing.Point(9, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 22);
            this.label10.TabIndex = 34;
            this.label10.Text = "Product ID:";
            // 
            // cbb_proID
            // 
            this.cbb_proID.FormattingEnabled = true;
            this.cbb_proID.Location = new System.Drawing.Point(131, 29);
            this.cbb_proID.Name = "cbb_proID";
            this.cbb_proID.Size = new System.Drawing.Size(140, 30);
            this.cbb_proID.TabIndex = 33;
            this.cbb_proID.SelectedIndexChanged += new System.EventHandler(this.cbb_proID_SelectedIndexChanged);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(22, 428);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(838, 171);
            this.dgvInvoice.TabIndex = 8;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            this.dgvInvoice.Click += new System.EventHandler(this.btn_edit_Click);
            this.dgvInvoice.DoubleClick += new System.EventHandler(this.btn_add_Click);
            this.dgvInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvInvoice_KeyPress);
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(711, 605);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(149, 20);
            this.txt_Total.TabIndex = 43;
            // 
            // lb_table
            // 
            this.lb_table.AutoSize = true;
            this.lb_table.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lb_table.Location = new System.Drawing.Point(660, 605);
            this.lb_table.Name = "lb_table";
            this.lb_table.Size = new System.Drawing.Size(57, 22);
            this.lb_table.TabIndex = 42;
            this.lb_table.Text = "Total:";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(724, 366);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 37);
            this.btn_Save.TabIndex = 48;
            this.btn_Save.Text = "Add Product";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_cancle.Location = new System.Drawing.Point(758, 632);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(103, 36);
            this.btn_cancle.TabIndex = 47;
            this.btn_cancle.Text = "CANCEL";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_add.Location = new System.Drawing.Point(277, 207);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(128, 36);
            this.btn_add.TabIndex = 44;
            this.btn_add.Text = "New Invoice";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Print.Location = new System.Drawing.Point(664, 632);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(88, 36);
            this.btn_Print.TabIndex = 50;
            this.btn_Print.Text = "PRINT";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click_1);
            // 
            // btc_Find
            // 
            this.btc_Find.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btc_Find.Location = new System.Drawing.Point(260, 637);
            this.btc_Find.Name = "btc_Find";
            this.btc_Find.Size = new System.Drawing.Size(75, 30);
            this.btc_Find.TabIndex = 51;
            this.btc_Find.Text = "FIND";
            this.btc_Find.UseVisualStyleBackColor = true;
            this.btc_Find.Click += new System.EventHandler(this.btc_Find_Click);
            // 
            // cbb_Find
            // 
            this.cbb_Find.FormattingEnabled = true;
            this.cbb_Find.Location = new System.Drawing.Point(22, 642);
            this.cbb_Find.Name = "cbb_Find";
            this.cbb_Find.Size = new System.Drawing.Size(232, 21);
            this.cbb_Find.TabIndex = 34;
            this.cbb_Find.DropDown += new System.EventHandler(this.cbb_Find_DropDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label17.Location = new System.Drawing.Point(18, 617);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 22);
            this.label17.TabIndex = 52;
            this.label17.Text = "Invoice No:";
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_del.Location = new System.Drawing.Point(467, 632);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(187, 36);
            this.btn_del.TabIndex = 53;
            this.btn_del.Text = "DELETE INVOICE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label18.Location = new System.Drawing.Point(22, 403);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 22);
            this.label18.TabIndex = 54;
            this.label18.Text = "Product list selected:";
            // 
            // btn_addCus
            // 
            this.btn_addCus.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_addCus.Location = new System.Drawing.Point(705, 207);
            this.btn_addCus.Name = "btn_addCus";
            this.btn_addCus.Size = new System.Drawing.Size(144, 37);
            this.btn_addCus.TabIndex = 55;
            this.btn_addCus.Text = "New Customer";
            this.btn_addCus.UseVisualStyleBackColor = true;
            this.btn_addCus.Click += new System.EventHandler(this.btn_addCus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(467, 601);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(187, 29);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "DELETE ROW";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnSave_Click);
            this.btnEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEdit_KeyDown);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 673);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_addCus);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbb_Find);
            this.Controls.Add(this.btc_Find);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lb_table);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Invoice_FormClosing);
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_invoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_EmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_CusID;
        private System.Windows.Forms.TextBox txt_Cusname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CusPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CusAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Unitprice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_prodName;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_proID;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lb_table;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btc_Find;
        private System.Windows.Forms.ComboBox cbb_Find;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_addCus;
        private System.Windows.Forms.Button btnEdit;
    }
}