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
using static Point_of_Sale.FormLogin;

namespace Point_of_Sale
{
    public partial class FormAccount : UserControl
    {
        private DataTable originalDataTable;
        public SqlConnection Connection { get; set; }
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            lblEmpName.Text = LoggedInUser.Emp_Fname + " " + LoggedInUser.Emp_Lname;
            if (LoggedInUser.Emp_Role == "Admin")
            {
                cmbRole.Enabled = true;
                txtSalary.ReadOnly = false;
                btnDelete.Visible = true;
            }
            else
            {
                txtID.Text = LoggedInUser.Emp_ID.ToString();
                btnSave.Text = "Save";
            }
        }
        public void LoadAccountEmp()
        {
            try
            {
                string query = @"
                        SELECT 
                            Emp_ID AS ID,
                            Emp_Fname AS ชื่อ,
                            Emp_Lname AS นามสกุล,
                            Emp_Hnumber,
                            Emp_Villageno,
                            Emp_Alley,
                            Emp_Street,
                            Emp_District,
                            Emp_SubDistrict,
                            Emp_Province,
                            Emp_Poscode,
                            Emp_Email AS Email,
                            Emp_Role AS ตำแหน่ง,
                            Emp_Firstdate AS วันที่เริ่มทำงาน,
                            Emp_Tel AS เบอร์โทร,
                            Emp_Salary AS เงินเดือน,
                            Emp_Password
                        FROM Employees";

                if (LoggedInUser.Emp_Role != "Admin") // ถ้าไม่ใช่ Admin ให้แสดงข้อมูลของตัวเองเท่านั้น
                {
                    query += $" WHERE Emp_ID = {LoggedInUser.Emp_ID}";
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    originalDataTable = new DataTable();
                    adapter.Fill(originalDataTable);
                    dataGridView1.DataSource = originalDataTable;
                }
                SetColumnWidths();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด! " + ex.Message, "ข้อผิดพลาด",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }
        private void SetColumnWidths()
        {
            dataGridView1.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;// ปรับความกว้างตามเนื้อหาทั้งหมด
            dataGridView1.Columns["ชื่อ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ปรับความกว้างตามพื้นที่ที่เหลือ
            dataGridView1.Columns["นามสกุล"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["ตำแหน่ง"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["เงินเดือน"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["เบอร์โทร"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["วันที่เริ่มทำงาน"].Visible = false;
            dataGridView1.Columns["Emp_Province"].Visible = false;
            dataGridView1.Columns["Emp_Hnumber"].Visible = false;
            dataGridView1.Columns["Emp_Villageno"].Visible = false;
            dataGridView1.Columns["Emp_Alley"].Visible = false;
            dataGridView1.Columns["Emp_Street"].Visible = false;
            dataGridView1.Columns["Emp_District"].Visible = false;
            dataGridView1.Columns["Emp_SubDistrict"].Visible = false;
            dataGridView1.Columns["Emp_Poscode"].Visible = false;
            dataGridView1.Columns["Emp_Password"].Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (this.Parent != null && this.Parent is Form1 parentForm)
            {
                parentForm.isForceClose = true;
                parentForm.formLogin.Show();
                parentForm.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // แสดงข้อมูลในฟอร์ม
                if (row.Cells["ID"].Value.ToString() == LoggedInUser.Emp_ID.ToString())
                {
                    txtPass.ReadOnly = false;
                    txtPass.PasswordChar = '\0';
                }
                else
                {
                    txtPass.ReadOnly = true;
                    txtPass.PasswordChar = '*';
                }
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtFName.Text = row.Cells["ชื่อ"].Value.ToString();
                txtLName.Text = row.Cells["นามสกุล"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTell.Text = row.Cells["เบอร์โทร"].Value.ToString();
                txtPass.Text = row.Cells["Emp_Password"].Value.ToString();
                cmbRole.Text = row.Cells["ตำแหน่ง"].Value.ToString();
                txtSalary.Text = row.Cells["เงินเดือน"].Value.ToString();
                txtHno.Text = row.Cells["Emp_Hnumber"].Value.ToString();
                txtVino.Text = row.Cells["Emp_Villageno"].Value.ToString();
                txtAlley.Text = row.Cells["Emp_Alley"].Value.ToString();
                txtStreet.Text = row.Cells["Emp_Street"].Value.ToString();
                txtDist.Text = row.Cells["Emp_District"].Value.ToString();
                txtSubDist.Text = row.Cells["Emp_SubDistrict"].Value.ToString();
                txtProv.Text = row.Cells["Emp_Province"].Value.ToString();
                txtPosCode.Text = row.Cells["Emp_Poscode"].Value.ToString();
                txtFirstdate.Text = row.Cells["วันที่เริ่มทำงาน"].Value.ToString();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                btnSave.Text = "Add";
                txtPass.ReadOnly = false;
            }
            else
            {
                btnSave.Text = "Save";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (
                    string.IsNullOrEmpty(txtFName.Text) ||
                    string.IsNullOrEmpty(txtLName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtPass.Text) ||
                    string.IsNullOrEmpty(txtTell.Text) ||
                    string.IsNullOrEmpty(cmbRole.Text) ||
                    string.IsNullOrEmpty(txtSalary.Text) ||
                    string.IsNullOrEmpty(txtHno.Text) ||
                    string.IsNullOrEmpty(txtVino.Text) ||
                    string.IsNullOrEmpty(txtAlley.Text) ||
                    string.IsNullOrEmpty(txtStreet.Text) ||
                    string.IsNullOrEmpty(txtDist.Text) ||
                    string.IsNullOrEmpty(txtSubDist.Text) ||
                    string.IsNullOrEmpty(txtProv.Text) ||
                    string.IsNullOrEmpty(txtPosCode.Text) )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "แจ้งเตือน");
                return;
            }
            bool isSave = btnSave.Text == "Save";
            string query;
            if (isSave)
            {
                query = @"
                        UPDATE Employees SET 
                            Emp_Fname = @Emp_Fname,
                            Emp_Lname = @Emp_Lname,
                            Emp_Hnumber = @Emp_Hnumber,
                            Emp_Villageno = @Emp_Villageno,
                            Emp_Alley = @Emp_Alley,
                            Emp_Street = @Emp_Street,
                            Emp_District = @Emp_District,
                            Emp_Password = @Emp_Password,
                            Emp_SubDistrict = @Emp_SubDistrict,
                            Emp_Province = @Emp_Province,
                            Emp_Poscode = @Emp_Poscode,
                            Emp_Email = @Emp_Email,
                            Emp_Role = @Emp_Role,
                            Emp_Tel = @Emp_Tel,
                            Emp_Salary = @Emp_Salary
                        WHERE Emp_ID = @Emp_ID";
            }
            else
            {
                query = @"
                        INSERT INTO Employees (
                            Emp_Fname,
                            Emp_Lname,
                            Emp_Hnumber,
                            Emp_Villageno,
                            Emp_Alley,
                            Emp_Street,
                            Emp_District,
                            Emp_SubDistrict,
                            Emp_Province,
                            Emp_Poscode,
                            Emp_Email,
                            Emp_Role,
                            Emp_Firstdate,
                            Emp_Tel,
                            Emp_Salary,
                            Emp_Password
                        ) 
                        VALUES (
                            @Emp_Fname,
                            @Emp_Lname,
                            @Emp_Hnumber,
                            @Emp_Villageno,
                            @Emp_Alley,
                            @Emp_Street,
                            @Emp_District,
                            @Emp_SubDistrict,
                            @Emp_Province,
                            @Emp_Poscode,
                            @Emp_Email,
                            @Emp_Role,
                            @Emp_Firstdate,
                            @Emp_Tel,
                            @Emp_Salary,
                            @Emp_Password       
                        )";
            }

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                if (isSave)
                {
                    command.Parameters.AddWithValue("@Emp_ID", txtID.Text);
                }
                else
                {
                    command.Parameters.AddWithValue("@Emp_Firstdate", DateTime.Now);
                }
                command.Parameters.AddWithValue("@Emp_Fname", txtFName.Text);
                command.Parameters.AddWithValue("@Emp_Lname", txtLName.Text);
                command.Parameters.AddWithValue("@Emp_Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Emp_Tel", txtTell.Text);
                command.Parameters.AddWithValue("@Emp_Role", cmbRole.Text);
                command.Parameters.AddWithValue("@Emp_Salary", txtSalary.Text);
                command.Parameters.AddWithValue("@Emp_Hnumber", txtHno.Text);
                command.Parameters.AddWithValue("@Emp_Villageno", txtVino.Text);
                command.Parameters.AddWithValue("@Emp_Alley", txtAlley.Text);
                command.Parameters.AddWithValue("@Emp_Street", txtStreet.Text);
                command.Parameters.AddWithValue("@Emp_District", txtDist.Text);
                command.Parameters.AddWithValue("@Emp_SubDistrict", txtSubDist.Text);
                command.Parameters.AddWithValue("@Emp_Province", txtProv.Text);
                command.Parameters.AddWithValue("@Emp_Poscode", txtPosCode.Text);
                command.Parameters.AddWithValue("@Emp_Password", txtPass.Text);

                command.ExecuteNonQuery();
            }
            if (isSave)
                MessageBox.Show("ข้อมูลที่แก้ไขถูกบันทึกแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            else
                MessageBox.Show("ข้อมูลถูกเพิ่มเข้าระบบแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            LoadAccountEmp();
            btnClearFrom.PerformClick();
        }

        private void btnClearFrom_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.Emp_Role == "Admin")
            {
                txtID.Text = "";
            }
            txtFName.Text = "";
            txtLName.Text = "";
            txtPass.Text = "";
            txtEmail.Text = "";
            txtTell.Text = "";
            cmbRole.Text = "";
            txtSalary.Text = "";
            cmbRole.Text = "";
            txtHno.Text = "";
            txtVino.Text = "";
            txtAlley.Text = "";
            txtStreet.Text = "";
            txtDist.Text = "";
            txtSubDist.Text = "";
            txtProv.Text = "";
            txtPosCode.Text = "";
            txtFirstdate.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการลบ", "แจ้งเตือน");
                return;
            }
            DialogResult result = MessageBox.Show(
                "คุณแน่ใจหรือไม่ว่าต้องการลบข้อมูลนี้?",
                "ยืนยันการลบ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Employees WHERE Emp_ID = @Emp_ID;", Connection))
                {
                    command.Parameters.AddWithValue("@Emp_ID", txtID.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadAccountEmp();
            btnClearFrom.PerformClick();
        }
    }
}
