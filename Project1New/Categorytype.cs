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
    public partial class Categorytype : Form
    {
        public Categorytype()
        {
            InitializeComponent();
        }

        DataTable tblCL;

        private void Categorytype_Load(object sender, EventArgs e)
        {
            txt_typeID.Enabled = false;
            btn_Save.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT typeID, typeName FROM type";
            tblCL = Class.Function.GetDataToTable(sql);
            dgvType.DataSource = tblCL;
            dgvType.Columns[0].HeaderText = "Type ID";
            dgvType.Columns[1].HeaderText = "Type Name";
            dgvType.Columns[0].Width = 100;
            dgvType.Columns[1].Width = 300;
            dgvType.AllowUserToAddRows = false;
            dgvType.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvType_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_typeID.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_typeID.Text = dgvType.CurrentRow.Cells["typeID"].Value.ToString();
            txt_typename.Text = dgvType.CurrentRow.Cells["typeName"].Value.ToString();
            btn_edit.Enabled = true;
            btn_del.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_Save.Enabled = true;
            btn_add.Enabled = false;
            ResetValue();
            txt_typeID.Enabled = true;
            txt_typeID.Focus();
        }

        private void ResetValue()
        {
            txt_typeID.Text = "";
            txt_typename.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string sql; 
            if (txt_typeID.Text.Trim().Length == 0) 
            {
                MessageBox.Show("You must enter type code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_typeID.Focus();
                return;
            }
            if (txt_typename.Text.Trim().Length == 0) 
            {
                MessageBox.Show("You must enter a type name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_typename.Focus();
                return;
            }
            sql = "Select typeID From type where typeID =N'" + txt_typeID.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("This type code already exists, you must enter another code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_typeID.Focus();
                return;
            }

            sql = "INSERT INTO type VALUES(N'" +
                txt_typeID.Text + "',N'" + txt_typename.Text + "')";
            Class.Function.RunSQL(sql); 
            LoadDataGridView(); 
            ResetValue();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_Save.Enabled = false;
            txt_typeID.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql; 
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("No more data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_typeID.Text == "") 
            {
                MessageBox.Show("You have not selected any records", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_typename.Text.Trim().Length == 0) 
            {
                MessageBox.Show("You have not entered the type name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE type SET typeName=N'" +
                txt_typename.Text.ToString() +
                "' WHERE typeID=N'" + txt_typeID.Text + "'";
            Class.Function.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("No more data", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_typeID.Text == "") 
            {
                MessageBox.Show("You have not selected any records", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete??", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE type WHERE typeID=N'" + txt_typeID.Text + "'";
                Class.Function.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
