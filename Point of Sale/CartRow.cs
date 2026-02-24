using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Point_of_Sale.FormOrders;

namespace Point_of_Sale
{
    public partial class CartRow : UserControl
    {
        public int ID { get; set; }
        public string productName {  get; set; }
        public decimal Price { get; set; }
        private int _qty = 1;
        public int QTY 
        {
            get
            {
                return _qty;
            }
            set
            {
                if (value <= numericUpDownQTY.Maximum)
                {
                    _qty = value;
                    numericUpDownQTY.Value = value;
                }
            }
        }
        public CartRow()
        {
            InitializeComponent();
        }
        public CartRow(int i, string productName, decimal price)
        {
            InitializeComponent();
            numericUpDownQTY.MouseWheel += (sender, e) => ((HandledMouseEventArgs)e).Handled = true; // ยกเลิกการ scroll numericQTY ด้วยเมาส์
            ID = i;
            this.productName = productName;
            lblName.Text = productName;
            Price = price;
            lblPrice.Text = "฿" + price.ToString("N2");
        }

        public void isOdd(bool odd)
        {
            if (odd) 
            {
                this.BackColor = SystemColors.Control;
                numericUpDownQTY.BackColor = SystemColors.Control;
            } else 
            {
                this.BackColor = Color.White;
                numericUpDownQTY.BackColor = Color.White;
            }
            
        }

        private void QTY_ValueChanged(object sender, EventArgs e)
        {
            FormOrders formOrder = (FormOrders)((Panel)((FlowLayoutPanel)this.Parent).Parent).Parent;
            if (numericUpDownQTY.Value == 0)
            {
                if (this.Parent.Parent.Parent != null) // FlowLayoutPanel > Panel > FormOrders
                {
                    ((FlowLayoutPanel)this.Parent).Controls.Remove(this);
                    foreach(Product product in formOrder.products.ToList())
                    {
                        if (product.ID == this.ID)
                        {
                            formOrder.products.Remove(product);
                        }
                    }
                }
            }
            else
            {
                _qty = (int)numericUpDownQTY.Value;
                foreach (Product product in formOrder.products.ToList())
                {
                    if (product.ID == this.ID)
                    {
                        product.Qty = _qty;
                    }
                }
            }
            formOrder.countTotal();
        }
    }
}
