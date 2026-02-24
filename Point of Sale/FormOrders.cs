using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Point_of_Sale
{
    public partial class FormOrders : UserControl
    {
        public SqlConnection Connection {  get; set; }
        public class Product
        {
            public int ID { get; set; }
            public string ProductName { get; set; } 
            public decimal Price { get; set; }
            public decimal Qty { get; set; }
        }
        public List<Product> products = new List<Product>();
        private decimal totalAmount;
        private string membershipID;
        private string membershipName = "-- No selected --";
        private bool membershipLock = false;

        public FormOrders()
        {
            InitializeComponent();
        }
        public void addCart(int id, string name, decimal price)
        {
            foreach (Control control in flpOrderCart.Controls)
            {
                CartRow cartRow = (CartRow)control;
                if (((CartRow)control).ID == id)
                {
                    cartRow.QTY++;
                    countTotal();
                    foreach (Product product in products)
                    {
                        if (product.ID == id)
                        {
                            product.Qty = cartRow.QTY;
                            return;
                        }
                    }
                }   
            }
            products.Add(new Product { ID = id, ProductName = name, Price = price, Qty = 1 });
            flpOrderCart.Controls.Add(new CartRow(id, name, price));

            countTotal();
        }

        public void LoadProducts()
        {
            string query = "SELECT Product_ID, Product_Name, Product_Price, Product_Pic, Product_Status, ProductType_ID FROM Products";
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    flpProductList.Controls.Clear();
                    txtSearch.Text = "";
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Product_ID"]);
                        string name = reader["Product_Name"].ToString();
                        decimal price = Convert.ToDecimal(reader["Product_Price"]);
                        string img = reader["Product_Pic"].ToString();
                        string status = reader["Product_Status"].ToString();
                        if (status == "available")
                            flpProductList.Controls.Add(new CardProduct(id, name, price, img));
                    }
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in flpProductList.Controls)
            {
                CardProduct cardProduct = (CardProduct)control;
                if (cardProduct.Visible)
                    addCart(cardProduct.ID, cardProduct.productName, cardProduct.Price);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            if (searchText == "")
            {
                lblSearch.Text = "search";
            }
            else
            {
                lblSearch.Text = "";
            }

            foreach (Control control in flpProductList.Controls)
            {
                CardProduct cardProduct = (CardProduct)control;
                if (cardProduct.productName.ToLower().Contains(searchText))
                {
                    cardProduct.Visible = true;
                }
                else
                {
                    cardProduct.Visible = false;
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            flpOrderCart.Controls.Clear();
            products.Clear();
            countTotal();
        }

        private void btnContinue_Click(object snder, EventArgs e)
        {
            if (string.IsNullOrEmpty(membershipID))
            {
                MessageBox.Show("กรุณาระบุสมาชิก", "แจ้งเตือน");
                return;
            }
            if (membershipLock)
            {
                MessageBox.Show("สมาชิกท่านนี้ถูกล็อกและไม่สามารถทำรายการได้", "สมาชิกถูกล็อก", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormPayment formPayment = new FormPayment(membershipID, totalAmount);
            formPayment.Connection = Connection;
            formPayment.products = this.products;
            formPayment.ShowDialog();
            if(formPayment.DialogResult == DialogResult.OK)
            {
                btnRemoveAll.PerformClick();
            }
        }

        private void flpOrderCart_ControlAdded(object sender, ControlEventArgs e)
        {
            int i = 0;
            foreach (Control control in flpOrderCart.Controls)
            {
                CartRow cartRow = ((CartRow)control);
                cartRow.isOdd(i % 2 == 0); // สลับสี order row เวลามีการเพิ่มสินค้าลงตระกร้า
                i++;
            }
        }

        private void flpOrderCart_ControlRemoved(object sender, ControlEventArgs e)
        {
            int i = 0;
            foreach (Control control in flpOrderCart.Controls)
            {
                CartRow cartRow = ((CartRow)control);
                cartRow.isOdd(i % 2 == 0); // สลับสี order row เวลามีการลบสินค้าออกจากตระกร้า
                i++;
            }
        }

        public void countTotal()
        {
            totalAmount = 0;
            foreach (Control control in flpOrderCart.Controls)
            {
                CartRow cartRow = ((CartRow)control);
                totalAmount += cartRow.Price * cartRow.QTY;
            }
            lblSubtotal.Text = "฿" + (totalAmount * 100m/107m).ToString("N2");
            lblVat.Text = "฿" + (totalAmount * 7m / 107m).ToString("N2");
            lblTotal.Text = "฿" + totalAmount.ToString("N2");
        }

        private void picCustIcon_Click(object sender, EventArgs e)
        {
            btnMembership.PerformClick();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            FormSelectCust formSelectCust = new FormSelectCust(Connection);
            formSelectCust.ShowDialog();
            membershipName = formSelectCust.CustSelectName != null ? formSelectCust.CustSelectName : membershipName;
            membershipID = formSelectCust.CustSelectID != null ? formSelectCust.CustSelectID : membershipID;
            membershipLock = formSelectCust.CustSelectLock ? true : false;
            btnMembership.Text = membershipName;
        }
    }
}
