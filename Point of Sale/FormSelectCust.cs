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

namespace Point_of_Sale
{
    public partial class FormSelectCust : Form
    {
        private string selectID;
        private string selectName;
        private bool selectLockStatus;
        private SqlConnection connection;
        private DataTable originalDataTable;
        public string CustSelectID { get; set; }
        public string CustSelectName { get; set; }
        public bool CustSelectLock { get; set; }
        public FormSelectCust()
        {
            InitializeComponent();
        }
        public FormSelectCust(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void FormSelectCust_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTableData();
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
        private void LoadTableData()
        {
            string query = @"
                        SELECT 
                            Mem_ID AS ID,
                            Mem_Fname AS ชื่อ,
                            Mem_Lname AS นามสกุล,
                            Mem_Email AS Email,
                            Mem_Status AS สถานะ
                        FROM Members";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                originalDataTable = new DataTable();
                adapter.Fill(originalDataTable);
                dataGridView1.DataSource = originalDataTable;
            }
            SetColumnWidths();
        }

        private void SetColumnWidths()
        {
            dataGridView1.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;// ปรับความกว้างตามเนื้อหาทั้งหมด
            dataGridView1.Columns["ชื่อ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ปรับความกว้างตามพื้นที่ที่เหลือ
            dataGridView1.Columns["นามสกุล"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["สถานะ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ตรวจสอบว่าไม่ใช่คลิกส่วน Header
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectName = row.Cells["ชื่อ"].Value.ToString() + " " +
                            row.Cells["นามสกุล"].Value.ToString();
                selectID = row.Cells["ID"].Value.ToString();
                if (row.Cells["สถานะ"].Value.ToString().Equals("Lock"))
                {
                    selectLockStatus = true;
                }
                else
                {
                    selectLockStatus = false;
                }

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CustSelectID = selectID;
            CustSelectName = selectName;
            CustSelectLock = selectLockStatus;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustSelectID = null;
            CustSelectName = null;
            this.Close();
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
                    if (row["ชื่อ"].ToString().ToLower().Contains(searchText) ||
                        row["นามสกุล"].ToString().ToLower().Contains(searchText))
                    {
                        filteredDataTable.ImportRow(row); // นำแถวที่ตรงเงื่อนไขมาใส่ใน DataTable ใหม่
                    }
                }

                // แสดงข้อมูลที่กรองแล้วใน DataGridView
                dataGridView1.DataSource = filteredDataTable;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister(connection);
            formRegister.ShowDialog();
            LoadTableData();
        }
    }
}
