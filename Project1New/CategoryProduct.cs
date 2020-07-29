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
    public partial class CategoryProduct : Form
    {
        public CategoryProduct()
        {
            InitializeComponent();
        }

        DataTable tbProduct;

        private void CategoryProduct_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from type";
            txt_proID.Enabled = false;
            btn_Save.Enabled = false;

            LoadDataGridView();
            Function.FillCombo(sql, cbb_Type, "typeID", "typeName");
            cbb_Type.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txt_proID.Text = "";
            txt_proName.Text = "";
            cbb_Type.Text = "";
            txt_amount.Text = "0";
            txt_import.Text = "0";
            txt_sale.Text = "0";
            txt_amount.Enabled = true;
            txt_import.Enabled = false;
            txt_sale.Enabled = false;
            txt_Pic.Text = "";
            pictureBox1.Image = null;
            txt_Note.Text = "";
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from product";
            tbProduct = Function.GetDataToTable(sql);
            dgvPro.DataSource = tbProduct;
            dgvPro.Columns[0].HeaderText = "Product ID";
            dgvPro.Columns[1].HeaderText = "Product Name";
            dgvPro.Columns[2].HeaderText = "Type";
            dgvPro.Columns[3].HeaderText = "Amount";
            dgvPro.Columns[4].HeaderText = "Import unit price";
            dgvPro.Columns[5].HeaderText = "Sale unit price";
            dgvPro.Columns[6].HeaderText = "Picture";
            dgvPro.Columns[7].HeaderText = "Note";
            dgvPro.Columns[0].Width = 80;
            dgvPro.Columns[1].Width = 140;
            dgvPro.Columns[2].Width = 80;
            dgvPro.Columns[3].Width = 80;
            dgvPro.Columns[4].Width = 100;
            dgvPro.Columns[5].Width = 100;
            dgvPro.Columns[6].Width = 200;
            dgvPro.Columns[7].Width = 300;
            dgvPro.AllowUserToAddRows = false;
            dgvPro.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPro_Click(object sender, EventArgs e)
        {
            string type;
            string sql;
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("New addition mode!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_proID.Focus();
                return;
            }
            if (tbProduct.Rows.Count == 0)
            {
                MessageBox.Show("No data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_proID.Text = dgvPro.CurrentRow.Cells["proID"].Value.ToString();
            txt_proName.Text = dgvPro.CurrentRow.Cells["proName"].Value.ToString();
            type = dgvPro.CurrentRow.Cells["proType"].Value.ToString();
            sql = "SELECT typeName FROM type WHERE typeID=N'" + type + "'";
            cbb_Type.Text = Function.GetFieldValues(sql);
            txt_amount.Text = dgvPro.CurrentRow.Cells["amount"].Value.ToString();
            txt_import.Text = dgvPro.CurrentRow.Cells["importunitprice"].Value.ToString();
            txt_sale.Text = dgvPro.CurrentRow.Cells["saleunitprice"].Value.ToString();
            sql = "SELECT picture FROM product WHERE proID=N'" + txt_proID.Text + "'";
            txt_Pic.Text = Function.GetFieldValues(sql);
            pictureBox1.Image = Image.FromFile(txt_Pic.Text);
            sql = "SELECT note FROM product WHERE proID = N'" + txt_proID.Text + "'";
            txt_Note.Text = Function.GetFieldValues(sql);
            btn_edit.Enabled = true;
            btn_del.Enabled = true;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_del.Enabled = false;
            btn_Save.Enabled = true;
            btn_add.Enabled = false;
            ResetValues();
            txt_proID.Enabled = true;
            txt_proID.Focus();
            txt_amount.Enabled = true;
            txt_import.Enabled = true;
            txt_sale.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_proID.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter the product code !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_proID.Focus();
                return;
            }
            if (txt_proName.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter a product name !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_proName.Focus();
                return;
            }
            if (cbb_Type.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_Type.Focus();
                return;
            }
            if (txt_Pic.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must select a picture for the product !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Open.Focus();
                return;
            }
            sql = "SELECT proID FROM product WHERE proID=N'" + txt_proID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("This product code already exists, you must select another product code !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_proID.Focus();
                return;
            }
            sql = "INSERT INTO product(proID,proName,proType,amount,importunitprice,saleunitprice,picture,note) VALUES(N'"
                + txt_proID.Text.Trim() + "',N'" + txt_proName.Text.Trim() +
                "',N'" + cbb_Type.SelectedValue.ToString() +
                "'," + txt_amount.Text.Trim() + "," + txt_import.Text +
                "," + txt_sale.Text + ",'" + txt_Pic.Text + "',N'" + txt_Note.Text.Trim() + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btn_del.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_Save.Enabled = false;
            txt_proID.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbProduct.Rows.Count == 0)
            {
                MessageBox.Show("No more data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_proID.Text == "")
            {
                MessageBox.Show("You have not selected any records !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_proID.Focus();
                return;
            }
            if (txt_proName.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter a product name !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_proName.Focus();
                return;
            }
            if (cbb_Type.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must enter type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_Type.Focus();
                return;
            }
            if (txt_Pic.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must be an illustrator of the product !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Pic.Focus();
                return;
            }
            sql = "UPDATE product SET proName=N'" + txt_proName.Text.Trim().ToString() +
                "',proType=N'" + cbb_Type.SelectedValue.ToString() +
                "',amount=" + txt_amount.Text +
                ",picture='" + txt_Pic.Text + "',note=N'" + txt_Note.Text + "' WHERE proID=N'" + txt_proID.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbProduct.Rows.Count == 0)
            {
                MessageBox.Show("No more data !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_proID.Text == "")
            {
                MessageBox.Show("You have not selected any records !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete this record ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE product WHERE proID=N'" + txt_proID.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Choose artwork for the product";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                txt_Pic.Text = dlgOpen.FileName;
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_proID.Text == "") && (txt_proName.Text == "") && (cbb_Type.Text == ""))
            {
                MessageBox.Show("Please enter your search criteria !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from product WHERE 1=1";
            if (txt_proID.Text != "")
                sql += " AND proID LIKE N'%" + txt_proID.Text + "%'";
            if (txt_proName.Text != "")
                sql += " AND proName LIKE N'%" + txt_proName.Text + "%'";
            if (cbb_Type.Text != "")
                sql += " AND proType LIKE N'%" + cbb_Type.SelectedValue + "%'";
            tbProduct = Function.GetDataToTable(sql);
            if (tbProduct.Rows.Count == 0)
                MessageBox.Show("There are no records that match the search criteria !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Yes " + tbProduct.Rows.Count + "  the record satisfies the condition !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPro.DataSource = tbProduct;
            ResetValues();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT proID,proName,proType,amount,importunitprice,saleunitprice,picture,note FROM product";
            tbProduct = Function.GetDataToTable(sql);
            dgvPro.DataSource = tbProduct;
        }
    }
}
