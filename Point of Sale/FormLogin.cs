using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class FormLogin : Form
    {
        SqlConnection connection;
        const string strConnPath = "ConnectionString.ini";
        public FormLogin()
        {
            InitializeComponent();
        }
        public static class LoggedInUser
        {
            public static int Emp_ID { get; set; }
            public static string Emp_Fname { get; set; }
            public static string Emp_Lname { get; set; }
            public static string Emp_Role { get; set; }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string strConnectionString = "";
            if (File.Exists(strConnPath))
                strConnectionString = File.ReadAllText(strConnPath, Encoding.GetEncoding("windows-874"));
            connection = new SqlConnection(strConnectionString);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblStatus.Text = "กรุณากรอกข้อมูลพนักงานและรหัสผ่าน";
                return;
            }

            try
            {
                connection.Open();
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                string col = Regex.IsMatch(username, emailPattern) ? "Emp_Email" : "Emp_ID";
                string query = $"SELECT * FROM Employees WHERE {col} = @Emp_Username AND Emp_Password = @Emp_Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Emp_Username", username);
                    cmd.Parameters.AddWithValue("@Emp_Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            LoggedInUser.Emp_ID = Convert.ToInt32(reader["Emp_ID"]);
                            LoggedInUser.Emp_Fname = reader["Emp_Fname"].ToString();
                            LoggedInUser.Emp_Lname = reader["Emp_Lname"].ToString();
                            LoggedInUser.Emp_Role = reader["Emp_Role"].ToString();
                        }

                        Form1 mainForm = new Form1(this);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblStatus.Text = "ข้อมูลพนักงานหรือรหัสผ่านไม่ถูกต้อง!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPass.Checked ? '\0' : '*';
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
