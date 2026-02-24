using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        const string strConnPath = "ConnectionString.ini";
        public FormLogin formLogin;
        public bool isForceClose = false;
        public Form1(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string strConnectionString = "";
                if (File.Exists(strConnPath))
                    strConnectionString = File.ReadAllText(strConnPath, Encoding.GetEncoding("windows-874"));

                connection = new SqlConnection(strConnectionString);
                connection.Open();
                formOrders.Connection = connection;
                formProduct.Connection = connection;
                formMembership.Connection = connection;
                formReport.Connection = connection;
                formAccount.Connection = connection;
                formOrders.LoadProducts();
                formProduct.LoadProducts();
                formProduct.LoadComboboxData();
                formMembership.LoadMembership();
                formAccount.LoadAccountEmp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("มีข้อผิดพลาด! " + ex.Message, "ข้อผิดพลาด",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            if (!isForceClose) // ถ้าไม่ได้ปิดโปรแกรมด้วยปุ่มปิด
            {
                DialogResult result = MessageBox.Show("คุณต้องการปิดโปรแกรมหรือไม่?", "ยืนยันการปิด",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                formLogin.Close();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            formOrders.LoadProducts();
            formOrders.Show();
            formProduct.Hide();
            formMembership.Hide();
            formReport.Hide();
            formAccount.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            formOrders.Hide();
            formProduct.Show();
            formMembership.Hide();
            formReport.Hide();
            formAccount.Hide();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            formOrders.Hide();
            formProduct.Hide();
            formMembership.Show();
            formReport.Hide();
            formAccount.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            formOrders.Hide();
            formProduct.Hide();
            formMembership.Hide();
            formReport.Show();
            formAccount.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            formOrders.Hide();
            formProduct.Hide();
            formMembership.Hide();
            formReport.Hide();
            formAccount.Show();
        }
    }
}