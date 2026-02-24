using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using static Point_of_Sale.FormLogin;
using static Point_of_Sale.FormOrders;

namespace Point_of_Sale
{
    public partial class FormPayment : Form
    {
        private decimal received;
        private decimal totalAmount;
        private string membershipID;
        private int paymentTypeID = 1;

        public SqlConnection Connection { get; set; }
        public List<Product> products = new List<Product>();

        public FormPayment(string id, decimal totalAmount)
        {
            InitializeComponent();
            this.membershipID = id;
            this.totalAmount = totalAmount;
        }
        private void FormPayment_Load(object sender, EventArgs e)
        {
            lblTotalAmount.Text = "฿" + totalAmount.ToString("N2");
            foreach (Control control in panelPayMethod.Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += (sen, ev) => btnEnter((Button)control);
                    control.MouseLeave += (sen, ev) => btnLeave((Button)control);
                }
            }
            foreach (Product product in products)
            {             
                dataGridSummary.Rows.Add(product.ProductName, product.Qty, product.Price, product.Price * product.Qty);
            }
            dataGridSummary.Columns["QTY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridSummary.Columns["unitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridSummary.Columns["totalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridSummary.ClearSelection();
            dataGridSummary.Font = new Font("LINE Seed Sans TH", 12);

            lblSubtotal.Text = "฿" + (totalAmount * 100m / 107m).ToString("N2");
            lblVat.Text = "฿" + (totalAmount * 7m / 107m).ToString("N2");
            lblTotal.Text = "฿" + totalAmount.ToString("N2");
        }
        private void FormPayment_Shown(object sender, EventArgs e)
        {
            txtReceived.Focus();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            paymentTypeID = 1;
            btnActive();
        }
        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            paymentTypeID = 2;
            btnActive();
        }
        private void btnPromptPay_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            paymentTypeID = 3;
            btnActive();
        }
        private void btnActive()
        {
            foreach (Control control in panelPayMethod.Controls)
            {
                if (control is Button)
                {   
                    control.ForeColor = Color.Black;
                    control.BackColor = Color.White;
                }
            }

            if (tabControl1.SelectedIndex == 0)
            {
                btnCash.ForeColor = Color.White;
                btnCash.BackColor = Color.FromArgb(48, 65, 102);
            }
            else if (tabControl1.SelectedIndex == 1) 
            {
                btnCreditCard.ForeColor = Color.White;
                btnCreditCard.BackColor = Color.FromArgb(48, 65, 102);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                btnPromptPay.ForeColor = Color.White;
                btnPromptPay.BackColor = Color.FromArgb(48, 65, 102);
            }
        }

        private void btnEnter(Button btn)
        {
            if (btn.BackColor == Color.White)
            {
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(48, 65, 102); 
            }
        }
        private void btnLeave(Button btn)
        {
            btnActive();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExact_Click(object sender, EventArgs e)
        {
            received = totalAmount;
            txtReceived.Text = received.ToString("N2");
        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            decimal temp;
            if (decimal.TryParse(txtReceived.Text, out temp))
            {
                received = temp;
                if (received - totalAmount > 0)
                {
                    lblChange.Text = "฿" + (received - totalAmount).ToString("N2");
                }
                else
                {
                    lblChange.Text = "฿0";
                }
            }
            else
            {
                if (txtReceived.Text.Length < 2)
                {
                    txtReceived.Text = "";
                    received = 0;
                }
                else
                {
                    txtReceived.Text = txtReceived.Text.Remove(txtReceived.Text.Length - 1); // ลบตัวสุดท้าย
                    txtReceived.SelectionStart = txtReceived.Text.Length; // กำหนด cursor ให้อยู่ตำแหน่งสุดท้าย
                }
            }
        }

        private void pic20_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) updateReceived(20);
            else updateReceived(-20);
        }

        private void pic50_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) updateReceived(50);
            else updateReceived(-50);
        }

        private void pic100_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) updateReceived(100);
            else updateReceived(-100);
        }

        private void pic500_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) updateReceived(500);
            else updateReceived(-500);
        }

        private void pic1000_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) updateReceived(1000);
            else updateReceived(-1000);
        }

        private void updateReceived(int cash)
        {
            txtReceived.Focus();
            txtReceived.Text = (received += cash).ToString("N2");
            txtReceived.SelectionStart = txtReceived.Text.Length; // กำหนด cursor ให้อยู่ตำแหน่งสุดท้าย
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string orderQuery = @"
                        INSERT INTO Orders (
                            Member_ID,
                            Emp_ID,
                            Order_Date,
                            Order_Status,
                            Order_TotalAmount
                        ) 
                        VALUES (
                            @Member_ID,
                            @Emp_ID,
                            @Order_Date,
                            @Order_Status,
                            @Order_TotalAmount
                        );
                        SELECT SCOPE_IDENTITY();";
            int orderId;
            using (SqlCommand command = new SqlCommand(orderQuery, Connection))
            {
                command.Parameters.AddWithValue("@Member_ID", membershipID);
                command.Parameters.AddWithValue("@Emp_ID", LoggedInUser.Emp_ID);
                command.Parameters.AddWithValue("@Order_Date", DateTime.Now);
                command.Parameters.AddWithValue("@Order_Status", "Completed");
                command.Parameters.AddWithValue("@Order_TotalAmount", totalAmount);

                orderId = Convert.ToInt32(command.ExecuteScalar());
            }

            string orderProductQuery = @"
                        INSERT INTO Order_Products (
                            Order_ID, 
                            Product_ID, 
                            OP_QTY
                        )
                        VALUES (
                            @Order_ID, 
                            @Product_ID,
                            @OP_QTY
                        );";

            foreach (Product product in products)
            {
                using (SqlCommand command = new SqlCommand(orderProductQuery, Connection))
                {
                    command.Parameters.AddWithValue("@Order_ID", orderId);
                    command.Parameters.AddWithValue("@Product_ID", product.ID);
                    command.Parameters.AddWithValue("@OP_QTY", product.Qty);

                    command.ExecuteNonQuery();
                }

               
            }
            string paymentQuery = @"
                        INSERT INTO Payments (
                            Order_ID,
                            PaymentType_ID,
                            Payment_Cost,
                            Payment_Date,
                            Payment_Status
                        ) 
                        VALUES (
                            @Order_ID,
                            @PaymentType_ID,
                            @Payment_Cost,
                            @Payment_Date,
                            @Payment_Status
                        )";
            using (SqlCommand command = new SqlCommand(paymentQuery, Connection))
            {
                command.Parameters.AddWithValue("@Order_ID", orderId);
                command.Parameters.AddWithValue("@PaymentType_ID", paymentTypeID);
                command.Parameters.AddWithValue("@Payment_Cost", totalAmount);
                command.Parameters.AddWithValue("@Payment_Date", DateTime.Now);
                command.Parameters.AddWithValue("@Payment_Status", "Completed");

                command.ExecuteNonQuery();
            }

            MessageBox.Show("ทำรายการเสร็จสิ้น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
