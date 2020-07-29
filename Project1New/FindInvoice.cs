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

namespace Project1New
{
    public partial class FindInvoice : Form
    {
        public FindInvoice()
        {
            InitializeComponent();
        }

        DataTable tbFind;

        private void FindInvoice_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvInvoice.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txt_invoiceID.Focus();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_invoiceID.Text == "") && (txt_month.Text == "") && (txt_year.Text == "") &&
               (txt_EmpID.Text == "") && (txt_CusID.Text == ""))
            {
                MessageBox.Show("Please enter a search term !!!", "Request ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM bill WHERE 1=1";
            if (txt_invoiceID.Text != "")
                sql = sql + " AND billNo Like N'%" + txt_invoiceID.Text + "%'";
            if (txt_month.Text != "")
                sql = sql + " AND MONTH(datesale) =" + txt_month.Text;
            if (txt_year.Text != "")
                sql = sql + " AND YEAR(datesale) =" + txt_year.Text;
            if (txt_EmpID.Text != "")
                sql = sql + " AND employID Like N'%" + txt_EmpID.Text + "%'";
            if (txt_CusID.Text != "")
                sql = sql + " AND cusID Like N'%" + txt_CusID.Text + "%'";
            tbFind = Function.GetDataToTable(sql);
            if (tbFind.Rows.Count == 0)
            {
                MessageBox.Show("There are no records that meet the conditions !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Yes, " + tbFind.Rows.Count + " the record satisfies the condition!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvInvoice.DataSource = tbFind;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvInvoice.Columns[0].HeaderText = "Invoice No";
            dgvInvoice.Columns[1].HeaderText = "Employee";
            dgvInvoice.Columns[2].HeaderText = "Date of Sale";
            dgvInvoice.Columns[3].HeaderText = "Customer ID";
            dgvInvoice.Columns[4].HeaderText = "Total";
            dgvInvoice.Columns[0].Width = 150;
            dgvInvoice.Columns[1].Width = 100;
            dgvInvoice.Columns[2].Width = 80;
            dgvInvoice.Columns[3].Width = 80;
            dgvInvoice.Columns[4].Width = 80;
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        DataTable tbInvoicesale;

        private void LoadDataGridView1()
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
            dgvInvoice.Columns[5].HeaderText = "Discount %";
            dgvInvoice.Columns[6].HeaderText = "Price";
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

        private void btn_Findagain_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvInvoice.DataSource = null;
        }

        private void txt_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
