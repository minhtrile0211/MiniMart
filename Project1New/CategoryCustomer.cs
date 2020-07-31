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
    public partial class CategoryCustomer : Form
    {
        public CategoryCustomer()
        {
            InitializeComponent();
        }

        DataTable tbCustomer;

        private void CategoryCustomer_Load(object sender, EventArgs e)
        {
            txt_CusID.Enabled = false;
            btn_Save.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from customer";
            tbCustomer = Function.GetDataToTable(sql); 
            dgvCus.DataSource = tbCustomer; 
            dgvCus.Columns[0].HeaderText = "Customer ID";
            dgvCus.Columns[1].HeaderText = "Customer Name";
            dgvCus.Columns[2].HeaderText = "Address";
            dgvCus.Columns[3].HeaderText = "Phone";
            dgvCus.Columns[0].Width = 100;
            dgvCus.Columns[1].Width = 150;
            dgvCus.Columns[2].Width = 150;
            dgvCus.Columns[3].Width = 150;
            dgvCus.AllowUserToAddRows = false;
            dgvCus.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvCus_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("New addition mode!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CusID.Focus();
                return;
            }
            if (tbCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_CusID.Text = dgvCus.CurrentRow.Cells["cusID"].Value.ToString();
            txt_Cusname.Text = dgvCus.CurrentRow.Cells["cusName"].Value.ToString();
            txt_address.Text = dgvCus.CurrentRow.Cells["cusAddress"].Value.ToString();
            mtbPhone.Text = dgvCus.CurrentRow.Cells["cusPhone"].Value.ToString();
            btn_edit.Enabled = true;
            btn_del.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_Save.Enabled = true;
            btn_add.Enabled = false;
            ResetValues();
            txt_CusID.Enabled = true;
            txt_CusID.Focus();

        }

        private void ResetValues()
        {
            txt_CusID.Text = "";
            txt_Cusname.Text = "";
            txt_address.Text = "";
            mtbPhone.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_CusID.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter a guest code !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CusID.Focus();
                return;
            }
            if (txt_Cusname.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter a guest name !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cusname.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter an address !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_address.Focus();
                return;
            }
            if (mtbPhone.Text == "(  )    -")
            {
                MessageBox.Show("You must enter the phone !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbPhone.Focus();
                return;
            }

            sql = "SELECT cusID FROM customer WHERE cusID=N'" + txt_CusID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("This guest code already exists !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CusID.Focus();
                return;
            }
            sql = "INSERT INTO customer VALUES (N'" + txt_CusID.Text.Trim() +
                "',N'" + txt_Cusname.Text.Trim() + "',N'" + txt_address.Text.Trim() + "','" + mtbPhone.Text + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_Save.Enabled = false;
            txt_CusID.Enabled = false;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No more data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_CusID.Text.Trim() == "")
            {
                MessageBox.Show("You have not selected any records !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete this record ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE customer WHERE cusID=N'" + txt_CusID.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No more data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_CusID.Text == "")
            {
                MessageBox.Show("You must select the record to edit !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Cusname.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter a customer name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cusname.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter an address !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_address.Focus();
                return;
            }
            if (mtbPhone.Text == "(  )    -")
            {
                MessageBox.Show("You must enter the phone !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbPhone.Focus();
                return;
            }
            sql = "UPDATE customer SET cusName=N'" + txt_Cusname.Text.Trim().ToString() + "',cusAddress=N'" +
                txt_address.Text.Trim().ToString() + "',cusPhone='" + mtbPhone.Text.ToString() +
                "' WHERE cusID=N'" + txt_CusID.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            MessageBox.Show("Information edited!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
