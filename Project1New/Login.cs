using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project1New
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O26Q4UE;Initial Catalog=CuaHang;Integrated Security=True");
                SqlCommand com = new SqlCommand("Select * from login where userlogin=@userad and password=@pw", con);
                con.Open();
                com.Parameters.AddWithValue("@userad", txtUser.Text);
                com.Parameters.AddWithValue("@pw", txtPassword.Text);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Welcome!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mainform mainform = new Mainform();
                    mainform.Show();
                }
                else
                {
                    MessageBox.Show("Please check your User or Password!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkPass.Checked;
            switch (check)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    txtPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
