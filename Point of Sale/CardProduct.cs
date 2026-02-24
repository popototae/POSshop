using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class CardProduct : UserControl
    {
        public int ID { get; set; }
        public string productName { get; set; }
        public decimal Price { get; set; }
        public CardProduct()
        {
            InitializeComponent();
        }
        public CardProduct(int id, string productName, decimal price, string img)
        {
            InitializeComponent();
            controls_click();
            ID = id;
            this.productName = productName;
            lblName.Text = productName;
            Price = price;
            lblPrice.Text = "฿" + price.ToString("N2");

            string imgPath = img;
            if (File.Exists(imgPath))
                picProduct.ImageLocation = imgPath;
        }

        private void controls_click()
        {
            foreach (Control control in this.Controls)
            {
                if (control != btnAddToCart)
                {
                    control.Click += (sender, e) =>
                    {
                        btnAddToCart.PerformClick();
                    };
                }
            }
        }

        private void CardProduct_Click(object sender, EventArgs e)
        {
            btnAddToCart.PerformClick();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent != null) // flowLayoutPanel > FormOrders
            {
                FormOrders formOrder = (FormOrders)this.Parent.Parent; 
                formOrder.addCart(ID, productName, Price);
            }
        }
    }
}
