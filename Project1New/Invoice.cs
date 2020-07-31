using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project1New.Class;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace Project1New
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        DataTable tbInvoicesale;

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.billNo,a.proID, b.proName, a.amount, b.saleunitprice, a.discount,a.price FROM detailbill AS a, product AS b WHERE a.billNo = N'" + txt_invoiceID.Text + "' AND a.proID=b.proID";
            tbInvoicesale = Function.GetDataToTable(sql);
            dgvInvoice.DataSource = tbInvoicesale;
            dgvInvoice.Columns[0].HeaderText = "Invoice ID";
            dgvInvoice.Columns[1].HeaderText = "Product ID";
            dgvInvoice.Columns[2].HeaderText = "Product Name";
            dgvInvoice.Columns[3].HeaderText = "Amount";
            dgvInvoice.Columns[4].HeaderText = "Unit price";
            dgvInvoice.Columns[5].HeaderText = "Discount (%)";
            dgvInvoice.Columns[6].HeaderText = "Price(VND)";
            dgvInvoice.Columns[0].Width = 150;
            dgvInvoice.Columns[1].Width = 130;
            dgvInvoice.Columns[2].Width = 80;
            dgvInvoice.Columns[3].Width = 90;
            dgvInvoice.Columns[4].Width = 90;
            dgvInvoice.Columns[5].Width = 90;
            dgvInvoice.Columns[6].Width = 90;
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadDataGridView1()
        {
            string sql;
            sql = "SELECT a.billNo,a.proID, b.proName, a.amount, a.unitprice, a.discount,a.price FROM billbackup AS a, product AS b WHERE a.billNo = N'" + txt_invoiceID.Text + "' AND a.proID=b.proID";
            tbInvoicesale = Function.GetDataToTable(sql);
            dgvInvoice.DataSource = tbInvoicesale;
            dgvInvoice.Columns[0].HeaderText = "Invoice ID";
            dgvInvoice.Columns[1].HeaderText = "Product ID";
            dgvInvoice.Columns[2].HeaderText = "Product Name";
            dgvInvoice.Columns[3].HeaderText = "Amount";
            dgvInvoice.Columns[4].HeaderText = "Unit price";
            dgvInvoice.Columns[5].HeaderText = "Discount (%)";
            dgvInvoice.Columns[6].HeaderText = "Price(VND)";
            dgvInvoice.Columns[0].Width = 150;
            dgvInvoice.Columns[1].Width = 130;
            dgvInvoice.Columns[2].Width = 80;
            dgvInvoice.Columns[3].Width = 90;
            dgvInvoice.Columns[4].Width = 90;
            dgvInvoice.Columns[5].Width = 90;
            dgvInvoice.Columns[6].Width = 90;
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_Save.Enabled = false;
            btn_Print.Enabled = false;
            txt_invoiceID.ReadOnly = true;
            txt_EmpName.ReadOnly = true;
            txt_Cusname.ReadOnly = true;
            txt_CusAddress.ReadOnly = true;
            txt_CusPhone.ReadOnly = true;
            txt_prodName.ReadOnly = true;
            txt_Unitprice.ReadOnly = true;
            txt_Price.ReadOnly = true;
            txt_Total.ReadOnly = true;
            txt_discount.Text = "0";
            txt_Total.Text = "0";
            txt_Total.Enabled = false;
            txt_invoiceID.Enabled = false;
            txt_EmpName.Enabled = false;
            cbb_CusID.Enabled = false;
            cbb_EmpID.Enabled = false;
            cbb_proID.Enabled = false;
            txt_CusAddress.Enabled = false;
            txt_CusPhone.Enabled = false;
            txt_Cusname.Enabled = false;
            txt_prodName.Enabled = false;
            txt_Price.Enabled = false;
            dateTimePicker1.Enabled = false;
            txt_Unitprice.Enabled = false;
            Function.FillCombo("SELECT cusID, cusName FROM Customer", cbb_CusID, "cusID", "cusID");
            cbb_CusID.SelectedIndex = -1;
            Function.FillCombo("SELECT employID, employName FROM employee", cbb_EmpID, "employID", "cusName");
            cbb_EmpID.SelectedIndex = -1;
            Function.FillCombo("SELECT proID, proName FROM product", cbb_proID, "proID", "proID");
            cbb_proID.SelectedIndex = -1;

            if (txt_invoiceID.Text != "")
            {
                LoadInfoHoaDon();
                btn_Print.Enabled = true;
            }
            LoadDataGridView();
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT datesale FROM bill WHERE billNo = N'" + txt_invoiceID.Text + "'";
            dateTimePicker1.Value = DateTime.Parse(Function.GetFieldValues(str));
            str = "SELECT employID FROM bill WHERE billNo = N'" + txt_invoiceID.Text + "'";
            cbb_EmpID.SelectedValue = Function.GetFieldValues(str);
            str = "SELECT cusID FROM bill WHERE billNo = N'" + txt_invoiceID.Text + "'";
            cbb_CusID.SelectedValue = Function.GetFieldValues(str);
            str = "SELECT proID FROM product WHERE proID = N'" + cbb_proID.Text + "'";
            cbb_proID.SelectedValue = Function.GetFieldValues(str);
            str = "SELECT total FROM bill WHERE billNo = N'" + txt_invoiceID.Text + "'";
            txt_Total.Text = Function.GetFieldValues(str);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = false;
            btn_Save.Enabled = true;
            btn_Print.Enabled = false;
            btn_add.Enabled = false;
            cbb_EmpID.Enabled = true;
            cbb_CusID.Enabled = true;
            cbb_proID.Enabled = true;
            ResetValues();
            txt_invoiceID.Text = Function.CreateKey("Invoice:");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txt_invoiceID.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cbb_EmpID.Text = "";
            cbb_CusID.Text = "";
            txt_Total.Text = "0";
            cbb_proID.Text = "";
            txt_Amount.Text = "";
            txt_discount.Text = "0";
            txt_Price.Text = "0";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            cbb_proID.Enabled = true;
            string sql;
            sql = "SELECT billNo FROM bill WHERE billNo=N'" + txt_invoiceID.Text + "'";
            if (!Function.CheckKey(sql))
            {
                if (cbb_EmpID.Text.Length == 0)
                {
                    MessageBox.Show("You must enter an employee !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_EmpID.Focus();
                    return;
                }
                if (cbb_CusID.Text.Length == 0)
                {
                    MessageBox.Show("You must enter a customer !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_CusID.Focus();
                    return;
                }
                sql = "INSERT INTO bill(billNo, datesale, employID, cusID, total) VALUES (N'" + txt_invoiceID.Text.Trim() + "','" +
                        dateTimePicker1.Value + "',N'" + cbb_EmpID.SelectedValue + "',N'" +
                        cbb_CusID.SelectedValue + "'," + txt_Total.Text + ")";
                Function.RunSQL(sql);
            }
            double sl, amount, total, newtotal;
            if (cbb_proID.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter the product code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_proID.Focus();
                return;
            }
            if ((txt_Amount.Text.Trim().Length == 0) || (txt_Amount.Text == "0"))
            {
                MessageBox.Show("You must enter a quantity !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Amount.Text = "";
                txt_Amount.Focus();
                return;
            }
            if (txt_discount.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter a discount !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_discount.Focus();
                return;
            }
            sql = "SELECT proID FROM detailbill WHERE proID=N'" + cbb_proID.SelectedValue + "' AND billNo = N'" + txt_invoiceID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("This product already exists, you must enter another code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesrow();
                cbb_proID.Focus();
                return;
            }

            sql = "SELECT proID FROM billbackup WHERE proID=N'" + cbb_proID.SelectedValue + "' AND billNo = N'" + txt_invoiceID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("This product already exists, you must enter another code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesrow();
                cbb_proID.Focus();
                return;
            }


            sl = Convert.ToDouble(Function.GetFieldValues("SELECT amount FROM product WHERE proID = N'" + cbb_proID.SelectedValue + "'"));
            if (Convert.ToDouble(txt_Amount.Text) > sl)
            {
                MessageBox.Show("The number of product available is " + sl, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Amount.Text = "";
                txt_Amount.Focus();
                return;
            }
            sql = "INSERT INTO detailbill(billNo,proID,amount,unitprice, discount,price) VALUES(N'" + txt_invoiceID.Text.Trim() + "',N'" + cbb_proID.SelectedValue + "'," + txt_Amount.Text + "," + txt_Unitprice.Text + "," + txt_discount.Text + "," + txt_Price.Text + ")";
            Function.RunSQL(sql);
            sql = "INSERT INTO billbackup(billNo,proID,amount,unitprice, discount,price) VALUES(N'" + txt_invoiceID.Text.Trim() + "',N'" + cbb_proID.SelectedValue + "'," + txt_Amount.Text + "," + txt_Unitprice.Text + "," + txt_discount.Text + "," + txt_Price.Text + ")";
            Function.RunSQL(sql);
            LoadDataGridView();
            MessageBox.Show("The product added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            amount = sl - Convert.ToDouble(txt_Amount.Text);
            sql = "UPDATE product SET amount =" + amount + " WHERE proID= N'" + cbb_proID.SelectedValue + "'";
            Function.RunSQL(sql);
            total = Convert.ToDouble(Function.GetFieldValues("SELECT total FROM bill WHERE billNo = N'" + txt_invoiceID.Text + "'"));
            newtotal = total + Convert.ToDouble(txt_Price.Text);
            sql = "UPDATE bill SET total =" + newtotal + " WHERE billNo = N'" + txt_invoiceID.Text + "'";
            Function.RunSQL(sql);
            txt_Total.Text = newtotal.ToString();
            ResetValuesrow();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_Print.Enabled = true;
        }

        private void ResetValuesrow()
        {
            cbb_proID.Text = "";
            txt_Amount.Text = "";
            txt_discount.Text = "0";
            txt_Price.Text = "0";
        }

        private void cbb_proID_SelectedIndexCrowed(object sender, EventArgs e)
        {
            string str;
            if (cbb_proID.Text == "")
            {
                txt_prodName.Text = "";
                txt_Unitprice.Text = "";
            }

            str = "SELECT proName FROM product WHERE proID =N'" + cbb_proID.SelectedValue + "'";
            txt_prodName.Text = Function.GetFieldValues(str);
            str = "SELECT saleunitprice FROM product WHERE proID =N'" + cbb_proID.SelectedValue + "'";
            txt_Unitprice.Text = Function.GetFieldValues(str);
        }

        private void cbb_proID_TextCrowed(object sender, EventArgs e)
        {

        }

        private void txt_Amount_TextCrowed(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txt_Amount.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_Amount.Text);
            if (txt_discount.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_discount.Text);
            if (txt_Unitprice.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_Unitprice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_Price.Text = tt.ToString();
        }

        private void txt_discount_TextCrowed(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txt_Amount.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_Amount.Text);
            if (txt_discount.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_discount.Text);
            if (txt_Unitprice.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_Unitprice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_Price.Text = tt.ToString();
        }

        private void cbb_CusID_SelectedIndexCrowed(object sender, EventArgs e)
        {
            string str;
            if (cbb_CusID.Text == "")
            {
                txt_Cusname.Text = "";
                txt_CusAddress.Text = "";
                txt_CusPhone.Text = "";
            }

            str = "Select cusName from customer where cusID = N'" + cbb_CusID.SelectedValue + "'";
            txt_Cusname.Text = Function.GetFieldValues(str);
            str = "Select cusAddress from customer where cusID = N'" + cbb_CusID.SelectedValue + "'";
            txt_CusAddress.Text = Function.GetFieldValues(str);
            str = "Select cusPhone from customer where cusID= N'" + cbb_CusID.SelectedValue + "'";
            txt_CusPhone.Text = Function.GetFieldValues(str);
        }

        private void cbb_EmpID_SelectedIndexCrowed(object sender, EventArgs e)
        {
            string str;
            if (cbb_EmpID.Text == "")
            {
                txt_EmpName.Text = "";
            }
            str = "Select employName from employee where employID =N'" + cbb_EmpID.SelectedValue + "'";
            txt_EmpName.Text = Function.GetFieldValues(str);
        }

        private void cbb_EmpID_TextCrowed(object sender, EventArgs e)
        {

        }

        private void cbb_EmpID_SelectedValueCrowed(object sender, EventArgs e)
        {

        }

        private void dgvInvoice_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
        }

        private void btn_Print_Click_1(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int row = 0, col = 0;
            DataTable tbInvoice, tbProduct;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "T - Mini Mart.";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "01 Vo VAN NGAN Street";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Phone: (028)75432xxx";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "INVOICE";

            sql = "SELECT a.billNo, a.datesale, a.total, b.cusName, b.cusAddress, b.cusPhone, c.employName FROM bill AS a, customer AS b, employee AS c WHERE a.billNo = N'" + txt_invoiceID.Text + "' AND a.cusID = b.cusID AND a.employID = c.employID";
            tbInvoice = Function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Invoice Code:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tbInvoice.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Customer:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tbInvoice.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Address:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tbInvoice.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Phone Number:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tbInvoice.Rows[0][5].ToString();

            sql = "SELECT b.proName, a.amount, a.unitprice, a.discount, a.price " +
                  "FROM billbackup AS a , product AS b WHERE a.billNo = N'" +
                  txt_invoiceID.Text + "' AND a.proID = b.proID";
            tbProduct = Function.GetDataToTable(sql);

            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "No.";
            exRange.Range["B11:B11"].Value = "Product";
            exRange.Range["C11:C11"].Value = "Amount";
            exRange.Range["D11:D11"].Value = "Unit Price";
            exRange.Range["E11:E11"].Value = "Discount(%)";
            exRange.Range["F11:F11"].Value = "Price (VND)";
            for (row = 0; row < tbProduct.Rows.Count; row++)
            {
                exSheet.Cells[1][row + 12] = row + 1;
                for (col = 0; col < tbProduct.Columns.Count; col++)
                {
                    exSheet.Cells[col + 2][row + 12] = tbProduct.Rows[row][col].ToString();
                    if (col == 3) exSheet.Cells[col + 2][row + 12] = tbProduct.Rows[row][col].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[col][row + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Total Price:";
            exRange = exSheet.Cells[col + 1][row + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tbInvoice.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][row + 15];
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][row + 17];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tbInvoice.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "HCM, " + d.Day + "/" + d.Month + "/" + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Cashier";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tbInvoice.Rows[0][6];
            exSheet.Name = "Import Invoice";
            exApp.Visible = true;
        }

        private void LoadInfoFind()
        {

        }

        private void btc_Find_Click(object sender, EventArgs e)
        {
            if (cbb_Find.Text == "")
            {
                MessageBox.Show("You must select an invoice code to find", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_Find.Focus();
                return;
            }
            txt_invoiceID.Text = cbb_Find.Text;
            LoadInfoHoaDon();
            LoadDataGridView1();
            btn_del.Enabled = true;
            btn_Save.Enabled = true;
            btn_Print.Enabled = true;
            cbb_Find.SelectedIndex = -1;
        }

        private void cbb_EmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbb_EmpID.Text == "")
            {
                txt_EmpName.Text = "";
            }
            str = "Select employName from employee where employID =N'" + cbb_EmpID.SelectedValue + "'";
            txt_EmpName.Text = Function.GetFieldValues(str);
        }

        private void cbb_CusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbb_CusID.Text == "")
            {
                txt_Cusname.Text = "";
                txt_CusPhone.Text = "";
                txt_CusPhone.Text = "";
            }
            str = "Select cusName from customer where cusID = N'" + cbb_CusID.SelectedValue + "'";
            txt_Cusname.Text = Function.GetFieldValues(str);
            str = "Select cusAddress from customer where cusID = N'" + cbb_CusID.SelectedValue + "'";
            txt_CusAddress.Text = Function.GetFieldValues(str);
            str = "Select cusPhone from customer where cusID= N'" + cbb_CusID.SelectedValue + "'";
            txt_CusPhone.Text = Function.GetFieldValues(str);
        }

        private void cbb_proID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbb_proID.Text == "")
            {
                txt_prodName.Text = "";
                txt_Unitprice.Text = "";
            }
            str = "SELECT proName FROM product WHERE proID =N'" + cbb_proID.SelectedValue + "'";
            txt_prodName.Text = Function.GetFieldValues(str);
            str = "SELECT saleunitprice FROM product WHERE proID =N'" + cbb_proID.SelectedValue + "'";
            txt_Unitprice.Text = Function.GetFieldValues(str);
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txt_Amount.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_Amount.Text);
            if (txt_discount.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_discount.Text);
            if (txt_Unitprice.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_Unitprice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_Price.Text = tt.ToString();
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txt_Amount.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_Amount.Text);
            if (txt_discount.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_discount.Text);
            if (txt_Unitprice.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_Unitprice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_Price.Text = tt.ToString();
        }

        private void cbb_Find_DropDown(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT billNo FROM bill", cbb_Find, "billNo", "billNo");
            cbb_Find.SelectedIndex = -1;
        }

        private void Invoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int r = dgvInvoice.CurrentCell.RowIndex;
            this.txt_invoiceID.Text = dgvInvoice.Rows[r].Cells[0].Value.ToString();
            this.cbb_proID.Text = dgvInvoice.Rows[r].Cells[1].Value.ToString();
            this.txt_prodName.Text = dgvInvoice.Rows[r].Cells[2].Value.ToString();
            this.txt_Amount.Text = dgvInvoice.Rows[r].Cells[3].Value.ToString();
            this.txt_Unitprice.Text = dgvInvoice.Rows[r].Cells[4].Value.ToString();
            this.txt_discount.Text = dgvInvoice.Rows[r].Cells[5].Value.ToString();
            this.txt_Price.Text = dgvInvoice.Rows[r].Cells[6].Value.ToString();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            double sl, amount, delamount;
            if (MessageBox.Show("Are you sure you want to delete ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT proID,amount FROM detailbill WHERE billNo = N'" + txt_invoiceID.Text + "'";
                DataTable tbProduct = Function.GetDataToTable(sql);
                for (int row = 0; row <= tbProduct.Rows.Count - 1; row++)
                {
                    sl = Convert.ToDouble(Function.GetFieldValues("SELECT amount FROM product WHERE proID = N'" + tbProduct.Rows[row][0].ToString() + "'"));
                    delamount = Convert.ToDouble(tbProduct.Rows[row][1].ToString());
                    amount = sl + delamount;
                    sql = "UPDATE product SET amount =" + amount + " WHERE proID= N'" + tbProduct.Rows[row][0].ToString() + "'";
                    Function.RunSQL(sql);
                }

                sql = "DELETE detailbill WHERE billNo=N'" + txt_invoiceID.Text + "'";
                Function.RunSQL(sql);

                sql = "DELETE bill WHERE billNo=N'" + txt_invoiceID.Text + "'";
                Function.RunSQL(sql);
                ResetValues();
                LoadDataGridView();
                btn_del.Enabled = false;
                btn_Print.Enabled = false;
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_SaveInv_Click(object sender, EventArgs e)
        {

        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {

            CategoryCustomer categoryCustomer = new CategoryCustomer();
            categoryCustomer.ShowDialog();
            Function.FillCombo("SELECT cusID, cusName FROM Customer", cbb_CusID, "cusID", "cusID");
            cbb_CusID.SelectedIndex = -1;
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvInvoice.CurrentCell.RowIndex;
            this.txt_invoiceID.Text = dgvInvoice.Rows[r].Cells[0].Value.ToString();
            this.cbb_proID.Text = dgvInvoice.Rows[r].Cells[1].Value.ToString();
            this.txt_prodName.Text = dgvInvoice.Rows[r].Cells[2].Value.ToString();
            this.txt_Amount.Text = dgvInvoice.Rows[r].Cells[3].Value.ToString();
            this.txt_Unitprice.Text = dgvInvoice.Rows[r].Cells[4].Value.ToString();
            this.txt_discount.Text = dgvInvoice.Rows[r].Cells[5].Value.ToString();
            this.txt_Price.Text = dgvInvoice.Rows[r].Cells[6].Value.ToString();

            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want delete row(s) ?", "Answer",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    sql = "DELETE detailbill WHERE proID=N'" + cbb_proID.Text + "'";
                    Function.RunSQL(sql);
                    LoadDataGridView();
                    MessageBox.Show("Deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Do not delete records !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double total, newtotal;
            int sum = 0;
            for(int i =0; i<= dgvInvoice.Rows.Count-1;i++)
            {
                sum = sum + int.Parse(dgvInvoice.Rows[i].Cells[6].Value.ToString());
            }
            txt_Total.Text = sum.ToString();
            total = Convert.ToDouble(Function.GetFieldValues("SELECT total FROM bill WHERE billNo = N'" + txt_invoiceID.Text + "'"));
            newtotal = total - Convert.ToDouble(txt_Price.Text);
            sql = "UPDATE bill SET total =" + newtotal + " WHERE billNo = N'" + txt_invoiceID.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEdit_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cbb_Find_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
