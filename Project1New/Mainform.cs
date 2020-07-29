using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1New.Class;

namespace Project1New
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Function.Disconnect(); 
           Application.Exit(); 
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorytype categorytype = new Categorytype();
            categorytype.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEmployee categoryEmployee = new CategoryEmployee();
            categoryEmployee.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryCustomer categoryCustomer = new CategoryCustomer();
            categoryCustomer.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryProduct categoryProduct = new CategoryProduct();
            categoryProduct.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.ShowDialog();
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FindInvoice findInvoice = new FindInvoice();
            findInvoice.ShowDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
