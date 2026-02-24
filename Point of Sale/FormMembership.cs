using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class FormMembership : UserControl
    {
        public SqlConnection Connection { get; set; }
        private DataTable originalDataTable;
        public FormMembership()
        {
            InitializeComponent();
        }
        public void LoadMembership()
        {
            try
            {
                string query = @"
                        SELECT 
                            Mem_ID AS ID,
                            Mem_Fname AS ชื่อ,
                            Mem_Lname AS นามสกุล,
                            Mem_Email AS Email,
                            Mem_Province AS จังหวัด,
                            Mem_Registerdate AS RegisDate,
                            Mem_Hnumber, Mem_Villageno,
                            Mem_Alley, Mem_Street, Mem_District,
                            Mem_SubDistrict, Mem_Poscode, Mem_Status AS สถานะ
                        FROM Members";

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
            dataGridView1.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["สถานะ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["RegisDate"].Visible = false;
            dataGridView1.Columns["จังหวัด"].Visible = false;
            dataGridView1.Columns["Mem_Hnumber"].Visible = false;
            dataGridView1.Columns["Mem_Villageno"].Visible = false;
            dataGridView1.Columns["Mem_Alley"].Visible = false;
            dataGridView1.Columns["Mem_Street"].Visible = false;
            dataGridView1.Columns["Mem_District"].Visible = false;
            dataGridView1.Columns["Mem_SubDistrict"].Visible = false;
            dataGridView1.Columns["Mem_Poscode"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // แสดงข้อมูลในฟอร์ม
                txtMemID.Text = row.Cells["ID"].Value.ToString();
                txtFName.Text = row.Cells["ชื่อ"].Value.ToString();
                txtLName.Text = row.Cells["นามสกุล"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cmbStatus.Text = row.Cells["สถานะ"].Value.ToString(); 
                txtHno.Text = row.Cells["Mem_Hnumber"].Value.ToString();
                txtVino.Text = row.Cells["Mem_Villageno"].Value.ToString();
                txtAlley.Text = row.Cells["Mem_Alley"].Value.ToString();
                txtStreet.Text = row.Cells["Mem_Street"].Value.ToString();
                txtDist.Text = row.Cells["Mem_District"].Value.ToString();
                txtSubDist.Text = row.Cells["Mem_SubDistrict"].Value.ToString();
                txtProv.Text = row.Cells["จังหวัด"].Value.ToString();
                txtPosCode.Text = row.Cells["Mem_Poscode"].Value.ToString();
                txtRegisDate.Text = row.Cells["RegisDate"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!", "แจ้งเตือน");
                return;
            }
            bool isSave = btnSave.Text == "Save";
            string query;
            if (isSave)
            {
                query = @"
                        UPDATE Members SET 
                            Mem_Fname = @Mem_Fname,
                            Mem_Lname = @Mem_Lname,
                            Mem_Hnumber = @Mem_Hnumber,
                            Mem_Villageno = @Mem_Villageno,
                            Mem_Alley = @Mem_Alley,
                            Mem_Street = @Mem_Street,
                            Mem_District = @Mem_District,
                            Mem_SubDistrict = @Mem_SubDistrict,
                            Mem_Province = @Mem_Province,
                            Mem_Poscode = @Mem_Poscode,
                            Mem_Email = @Mem_Email,
                            Mem_Status = @Mem_Status
                        WHERE Mem_ID = @Mem_ID";
            }
            else
            {
                query = @"
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
                            @Mem_Status
                        )";
            }

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                if (isSave)
                {
                    command.Parameters.AddWithValue("@Mem_ID", txtMemID.Text);
                }
                else
                {
                    command.Parameters.AddWithValue("@Mem_Registerdate", DateTime.Now);
                }
                command.Parameters.AddWithValue("@Mem_Fname", txtFName.Text);
                command.Parameters.AddWithValue("@Mem_Lname", txtLName.Text);
                command.Parameters.AddWithValue("@Mem_Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Mem_Status", cmbStatus.Text);
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
            if (isSave)
                MessageBox.Show("ข้อมูลที่แก้ไขถูกบันทึกแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            else
                MessageBox.Show("ข้อมูลถูกเพิ่มเข้าระบบแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            btnClearFrom.PerformClick();
            LoadMembership();
        }

        private void txtMemID_TextChanged(object sender, EventArgs e)
        {
            if (txtMemID.Text == "")
            {
                btnSave.Text = "Add";
            }
            else
            {
                btnSave.Text = "Save";
            }
        }

        private void btnClearFrom_Click(object sender, EventArgs e)
        {
            txtMemID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            cmbStatus.SelectedIndex = -1;
            txtHno.Text = "";
            txtVino.Text = "";
            txtAlley.Text = "";
            txtStreet.Text = "";
            txtDist.Text = "";
            txtSubDist.Text = "";
            txtProv.Text = "";
            txtPosCode.Text = "";
            txtRegisDate.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            if (searchText == "")
            {
                lblSearch.Text = "search";
                dataGridView1.DataSource = originalDataTable;
            }
            else
            {
                lblSearch.Text = "";
                DataTable filteredDataTable = originalDataTable.Clone(); // สร้าง DataTable ใหม่ที่มีโครงสร้างเหมือนเดิม
                foreach (DataRow row in originalDataTable.Rows)
                {
                    // ตรวจสอบว่าคำค้นหาตรงกับคอลัมน์ใดๆ หรือไม่
                    if (row["FName"].ToString().ToLower().Contains(searchText) ||
                        row["LName"].ToString().ToLower().Contains(searchText))
                    {
                        filteredDataTable.ImportRow(row); // นำแถวที่ตรงเงื่อนไขมาใส่ใน DataTable ใหม่
                    }
                }

                // แสดงข้อมูลที่กรองแล้วใน DataGridView
                dataGridView1.DataSource = filteredDataTable;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMemID.Text == "")
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
                using (SqlCommand command = new SqlCommand("DELETE FROM Members WHERE Mem_ID = @Mem_ID;", Connection))
                {
                    command.Parameters.AddWithValue("@Mem_ID", txtMemID.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadMembership();
            btnClearFrom.PerformClick();
        }
    }
}
