using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Point_of_Sale
{
    public partial class FormRegister : Form
    {
        private SqlConnection connection;
        public FormRegister()
        {
            InitializeComponent();
        }
        public FormRegister(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFName.Text) ||
                string.IsNullOrEmpty(txtLName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                lblStatus1.Text = "กรุณากรอกข้อมูลให้ครบถ้วน!";
            }
            else
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    lblStatus1.Text = "กรุณากรอกข้อมูล Email ให้ถูกต้อง!";
                    return;
                }
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (
                    string.IsNullOrEmpty(txtHno.Text) ||
                    string.IsNullOrEmpty(txtVino.Text) ||
                    string.IsNullOrEmpty(txtAlley.Text) ||
                    string.IsNullOrEmpty(txtStreet.Text) ||
                    string.IsNullOrEmpty(txtDist.Text) ||
                    string.IsNullOrEmpty(txtSubDist.Text) ||
                    string.IsNullOrEmpty(txtProv.Text) ||
                    string.IsNullOrEmpty(txtPosCode.Text))
            {
                lblStatus2.Text = "กรุณากรอกข้อมูลให้ครบถ้วน!";
                return;
            }
            string query = @"
                        INSERT INTO Members (
                            Mem_Fname,
                            Mem_Lname,
                            Mem_Hnumber,
                            Mem_Villageno,
                            Mem_Alley,
                            Mem_Street,
                            Mem_District,
                            Mem_SubDistrict,
                            Mem_Province,
                            Mem_Poscode,
                            Mem_Registerdate,
                            Mem_Email,
                            Mem_Status
                        ) 
                        VALUES (
                            @Mem_Fname,
                            @Mem_Lname,
                            @Mem_Hnumber,
                            @Mem_Villageno,
                            @Mem_Alley,
                            @Mem_Street,
                            @Mem_District,
                            @Mem_SubDistrict,
                            @Mem_Province,
                            @Mem_Poscode,
                            @Mem_Registerdate,
                            @Mem_Email,
                            'Unlock'
                        )";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@Mem_Registerdate", DateTime.Now);
                command.Parameters.AddWithValue("@Mem_Fname", txtFName.Text);
                command.Parameters.AddWithValue("@Mem_Lname", txtLName.Text);
                command.Parameters.AddWithValue("@Mem_Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Mem_Hnumber", txtHno.Text);
                command.Parameters.AddWithValue("@Mem_Villageno", txtVino.Text);
                command.Parameters.AddWithValue("@Mem_Alley", txtAlley.Text);
                command.Parameters.AddWithValue("@Mem_Street", txtStreet.Text);
                command.Parameters.AddWithValue("@Mem_District", txtDist.Text);
                command.Parameters.AddWithValue("@Mem_SubDistrict", txtSubDist.Text);
                command.Parameters.AddWithValue("@Mem_Province", txtProv.Text);
                command.Parameters.AddWithValue("@Mem_Poscode", txtPosCode.Text);

                command.ExecuteNonQuery();
            }
            MessageBox.Show("ลงทะเบียนสมาชิกเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
