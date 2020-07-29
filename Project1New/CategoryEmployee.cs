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
    public partial class CategoryEmployee : Form
    {
        public CategoryEmployee()
        {
            InitializeComponent();
        }

        DataTable tbEmployee;

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT employID, employName, employGender, employAddress, employPhone, employDOB FROM employee";
            tbEmployee = Function.GetDataToTable(sql);
            dgvEmploy.DataSource = tbEmployee;
            dgvEmploy.Columns[0].HeaderText = "Employee ID";
            dgvEmploy.Columns[1].HeaderText = "Employee Name";
            dgvEmploy.Columns[2].HeaderText = "Gender";
            dgvEmploy.Columns[3].HeaderText = "Address";
            dgvEmploy.Columns[4].HeaderText = "Phone number";
            dgvEmploy.Columns[5].HeaderText = "Date of birth";
            dgvEmploy.Columns[0].Width = 100;
            dgvEmploy.Columns[1].Width = 150;
            dgvEmploy.Columns[2].Width = 100;
            dgvEmploy.Columns[3].Width = 150;
            dgvEmploy.Columns[4].Width = 100;
            dgvEmploy.Columns[5].Width = 100;
            dgvEmploy.AllowUserToAddRows = false;
            dgvEmploy.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvEmploy_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("New addition !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_emplID.Focus();
                return;
            }
            if (tbEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_emplID.Text = dgvEmploy.CurrentRow.Cells["employID"].Value.ToString();
            txt_emplname.Text = dgvEmploy.CurrentRow.Cells["employName"].Value.ToString();
            if (dgvEmploy.CurrentRow.Cells["employGender"].Value.ToString() == "Male") checkMale.Checked = true;
            else checkMale.Checked = false;
            txt_address.Text = dgvEmploy.CurrentRow.Cells["employAddress"].Value.ToString();
            mtbPhone.Text = dgvEmploy.CurrentRow.Cells["employPhone"].Value.ToString();
            dateTimePicker1.Value = (DateTime)dgvEmploy.CurrentRow.Cells["employDOB"].Value;
            btn_edit.Enabled = true;
            btn_del.Enabled = true;
        }

        private void CategoryEmployee_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txt_emplID.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_Save.Enabled = true;
            btn_add.Enabled = false;
            ResetValues();
            txt_emplID.Enabled = true;
            txt_emplID.Focus();
        }

        private void ResetValues()
        {
            txt_emplID.Text = "";
            txt_emplname.Text = "";
            checkMale.Checked = false;
            txt_address.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            mtbPhone.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txt_emplID.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter an employee ID !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_emplID.Focus();
                return;
            }
            if (txt_emplname.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter an employee name !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_emplname.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter an address !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (mtbPhone.Text == "(   )     -")
            {
                MessageBox.Show("You must enter the phone !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
                return;
            }

            if (checkMale.Checked == true)
                gt = "Male";
            else
                gt = "Female";
            sql = "SELECT employID FROM employee WHERE employID=N'" + txt_emplID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("This employee code already exists, you must enter another code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_emplID.Focus();
                txt_emplID.Text = "";
                return;
            }
            sql = "INSERT INTO employee(employID,employName,employGender, employAddress,employPhone, employDOB) VALUES (N'" + txt_emplID.Text.Trim() + "',N'" + txt_emplname.Text.Trim() + "',N'" + gt + "',N'" + txt_address.Text.Trim() + "','" + mtbPhone.Text + "','" + dateTimePicker1.Value + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_Save.Enabled = false;
            txt_emplID.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tbEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_emplID.Text == "")
            {
                MessageBox.Show("You must enter ID !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_emplname.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter name !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_emplname.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter address !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (mtbPhone.Text == "(   )     -")
            {
                MessageBox.Show("You must enter phone number !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
                return;
            }
            if (checkMale.Checked == true)
                gt = "Male";
            else
                gt = "Female";
            sql = "UPDATE employee SET employName=N'" + txt_emplname.Text.Trim().ToString() +
                    "',employAddress=N'" + txt_address.Text.Trim().ToString() +
                    "',employPhone='" + mtbPhone.Text.ToString() + "',employGender=N'" + gt +
                    "',employDOB='" + dateTimePicker1.Value +
                    "' WHERE employID=N'" + txt_emplID.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No more data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_emplID.Text == "")
            {
                MessageBox.Show("You have not selected any records", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("You may want to delete ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE employee WHERE employID=N'" + txt_emplID.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmploy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtbPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_emplname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emplID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
