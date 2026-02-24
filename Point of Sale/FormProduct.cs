using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Point_of_Sale
{
    public partial class FormProduct : UserControl
    {
        public SqlConnection Connection { get; set; }
        private Dictionary<string, List<KeyValuePair<int, string>>> categoryTypeMap = new Dictionary<string, List<KeyValuePair<int, string>>>();
        private DataTable originalDataTable;
        public FormProduct()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            try
            {
                string query = @"
                        SELECT 
                            p.Product_ID AS ID, p.Product_Name AS Name, 
                            p.Product_Price AS Price, Product_Pic, Product_Desc,
                            t.ProductType_Name, c.ProductCatagory_Name AS Category, p.Product_Status AS Status,
                            p.Product_Cost
                        FROM 
                            Products p
                        INNER JOIN 
                            Product_Type t ON p.ProductType_ID = t.ProductType_ID
                        INNER JOIN 
                            Product_Catagory c ON t.ProductCatagory_ID = c.ProductCatagory_ID";
                        
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
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ปรับความกว้างตามพื้นที่ที่เหลือ
            dataGridView1.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Product_Cost"].Visible = false;
            dataGridView1.Columns["Product_Pic"].Visible = false;
            dataGridView1.Columns["Product_Desc"].Visible = false;
            dataGridView1.Columns["ProductType_Name"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ตรวจสอบว่าไม่ใช่ header
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // แสดงข้อมูลในฟอร์ม
                txtProductID.Text = row.Cells["ID"].Value.ToString();
                txtProductName.Text = row.Cells["Name"].Value.ToString();
                txtPrice.Text = Convert.ToDecimal(row.Cells["Price"].Value).ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                cmbType.Text = row.Cells["ProductType_Name"].Value.ToString();
                txtDesc.Text = row.Cells["Product_Desc"].Value.ToString();
                txtCost.Text = row.Cells["Product_Cost"].Value.ToString();
                string imgPath = row.Cells["Product_Pic"].Value.ToString();
                if (File.Exists(imgPath))
                {
                    picProduct.ImageLocation = imgPath;
                }
                else
                {
                    picProduct.ImageLocation = null;
                    picProduct.Image = Properties.Resources.noImage;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSave = btnSave.Text == "Save";
            string query;
            if (isSave)
            { 
                query = @"
                        UPDATE Products SET 
                            Product_Name = @Product_Name, 
                            Product_Price = @Product_Price, 
                            Product_Status = @Product_Status,
                            ProductType_ID = @ProductType_ID,
                            Product_Desc = @Product_Desc,
                            Product_Pic = @Product_Pic,
                            Product_Cost = @Product_Cost
                        WHERE Product_ID = @Product_ID";
            }
            else
            {
                query = @"
                        INSERT INTO Products (
                            Product_Name, 
                            Product_Price, 
                            Product_Status, 
                            ProductType_ID, 
                            Product_Desc,
                            Product_Pic,
                            Product_Cost
                        ) 
                        VALUES (
                            @Product_Name, 
                            @Product_Price, 
                            @Product_Status, 
                            @ProductType_ID, 
                            @Product_Desc,
                            @Product_Pic,
                            @Product_Cost
                        )";

                if (txtProductName.Text == "" || txtPrice.Text == "" || cmbStatus.SelectedIndex == -1 ||
                    cmbCategory.SelectedIndex == -1 || cmbType.SelectedIndex == -1)
                {
                    MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน!");
                    return;
                }
            }

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                if (!string.IsNullOrWhiteSpace(picProduct.ImageLocation))
                {
                    string filePath = picProduct.ImageLocation;
                    string fileExtension = Path.GetExtension(filePath); // ดึงนามสกุลไฟล์
                    string uniqueFileName = Guid.NewGuid().ToString() + fileExtension; // สร้างชื่อไฟล์ใหม่
                    string destinationPath = Path.Combine("Images", uniqueFileName);

                    if (!File.Exists(destinationPath))
                        File.Copy(filePath, destinationPath, true);

                    command.Parameters.AddWithValue("@Product_Pic", destinationPath);
                }
                else
                {
                    command.Parameters.AddWithValue("@Product_Pic", "");
                }
                if (isSave)
                {
                    command.Parameters.AddWithValue("@Product_ID", txtProductID.Text);
                }
                command.Parameters.AddWithValue("@Product_Name", txtProductName.Text);
                command.Parameters.AddWithValue("@Product_Cost", txtCost.Text);
                command.Parameters.AddWithValue("@Product_Price", txtPrice.Text);
                command.Parameters.AddWithValue("@Product_Status", cmbStatus.Text);
                command.Parameters.AddWithValue("@ProductType_ID", cmbType.SelectedValue);
                command.Parameters.AddWithValue("@Product_Desc", txtDesc.Text);
                
                command.ExecuteNonQuery();
            }
            if (isSave)
                MessageBox.Show("ข้อมูลที่แก้ไขถูกบันทึกแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            else
                MessageBox.Show("ข้อมูลถูกเพิ่มเข้าระบบแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            btnClearFrom.PerformClick();
            LoadProducts();
        }

        public void LoadComboboxData()
        {
            string query = @"
                    SELECT c.ProductCatagory_Name, t.ProductType_ID, t.ProductType_Name
                    FROM Product_Catagory c
                    INNER JOIN Product_Type t ON c.ProductCatagory_ID = t.ProductCatagory_ID";
            using (SqlCommand categoryCommand = new SqlCommand(query, Connection)) // ดึงข้อมูล Category และ Type
            {
                using (SqlDataReader reader = categoryCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["ProductCatagory_Name"].ToString();
                        int typeID = reader.GetInt32(reader.GetOrdinal("ProductType_ID"));
                        string typeName = reader["ProductType_Name"].ToString();

                        if (!categoryTypeMap.ContainsKey(category))
                        {
                            categoryTypeMap[category] = new List<KeyValuePair<int, string>>();
                        }
                        categoryTypeMap[category].Add(new KeyValuePair<int, string>(typeID, typeName));
                    }
                }
            }
            cmbCategory.Items.AddRange(categoryTypeMap.Keys.ToArray());
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                if (categoryTypeMap.ContainsKey(selectedCategory))
                {
                    cmbType.DataSource = categoryTypeMap[selectedCategory]; 
                    cmbType.DisplayMember = "Value"; // แสดงชื่อ Type
                    cmbType.ValueMember = "Key"; // ใช้ TypeID เป็นค่า Value
                }
                else
                {
                    cmbType.DataSource = null; // ล้างข้อมูล Type หากไม่มี Category ที่เลือก
                }
            }
        }

        private void btnClearFrom_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtCost.Text = "";
            txtProductID.Text = "";
            txtDesc.Text = "";
            cmbStatus.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            picProduct.ImageLocation = null;
            picProduct.Image = Properties.Resources.noImage;
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine("Images", fileName);
                    picProduct.ImageLocation = filePath;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการลบ", "แจ้งเตือน");
                return;
            }
            DialogResult result = MessageBox.Show(
                "คุณแน่ใจหรือไม่ว่าต้องการลบข้อมูลนี้?",
                "ยืนยันการลบ",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Product_ID = @Product_ID;", Connection))
                {
                    command.Parameters.AddWithValue("@Product_ID", txtProductID.Text);
                    command.ExecuteNonQuery();
                }
                string picPath = picProduct.ImageLocation;
                if (File.Exists(picPath)) File.Delete(picPath);
            }
            LoadProducts();
            btnClearFrom.PerformClick();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            decimal temp;
            if(!decimal.TryParse(txtPrice.Text, out temp))
            {
                if (txtPrice.Text.Length < 2)
                {
                    txtPrice.Text = "";
                }
                else
                {
                    txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1); // ลบตัวสุดท้าย
                    txtPrice.SelectionStart = txtPrice.Text.Length; // กำหนด cursor ให้อยู่ตำแหน่งสุดท้าย
                }
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                btnSave.Text = "Add";
            }
            else
            {
                btnSave.Text = "Save";
            }
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
                    if (row["Name"].ToString().ToLower().Contains(searchText))
                    {
                        filteredDataTable.ImportRow(row); // นำแถวที่ตรงเงื่อนไขมาใส่ใน DataTable ใหม่
                    }
                }
                // แสดงข้อมูลที่กรองแล้วใน DataGridView
                dataGridView1.DataSource = filteredDataTable;
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            decimal temp;
            if (!decimal.TryParse(txtCost.Text, out temp))
            {
                if (txtCost.Text.Length < 2)
                {
                    txtCost.Text = "";
                }
                else
                {
                    txtCost.Text = txtCost.Text.Remove(txtCost.Text.Length - 1); // ลบตัวสุดท้าย
                    txtCost.SelectionStart = txtCost.Text.Length; // กำหนด cursor ให้อยู่ตำแหน่งสุดท้าย
                }
            }
        }
    }
}
