namespace Point_of_Sale
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.formOrders = new Point_of_Sale.FormOrders();
            this.formProduct = new Point_of_Sale.FormProduct();
            this.formMembership = new Point_of_Sale.FormMembership();
            this.formAccount = new Point_of_Sale.FormAccount();
            this.formReport = new Point_of_Sale.FormReport();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnMembership);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 711);
            this.panel1.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::Point_of_Sale.Properties.Resources.account;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 616);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(235, 42);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LINE Seed Sans TH ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 101);
            this.label1.TabIndex = 5;
            this.label1.Text = "POS";
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::Point_of_Sale.Properties.Resources.report;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 357);
            this.btnReport.Margin = new System.Windows.Forms.Padding(6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(235, 42);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Point_of_Sale.Properties.Resources.grid;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 249);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(235, 42);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnMembership
            // 
            this.btnMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.ForeColor = System.Drawing.Color.White;
            this.btnMembership.Image = global::Point_of_Sale.Properties.Resources.users;
            this.btnMembership.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembership.Location = new System.Drawing.Point(0, 303);
            this.btnMembership.Margin = new System.Windows.Forms.Padding(6);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMembership.Size = new System.Drawing.Size(235, 42);
            this.btnMembership.TabIndex = 2;
            this.btnMembership.Text = "Membership";
            this.btnMembership.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembership.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembership.UseVisualStyleBackColor = true;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::Point_of_Sale.Properties.Resources.cart;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 195);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(6);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(235, 42);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // formOrders
            // 
            this.formOrders.BackColor = System.Drawing.SystemColors.Control;
            this.formOrders.Connection = null;
            this.formOrders.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.formOrders.Location = new System.Drawing.Point(236, 0);
            this.formOrders.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.formOrders.Name = "formOrders";
            this.formOrders.Size = new System.Drawing.Size(1173, 711);
            this.formOrders.TabIndex = 1;
            // 
            // formProduct
            // 
            this.formProduct.Connection = null;
            this.formProduct.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.formProduct.Location = new System.Drawing.Point(236, 0);
            this.formProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.formProduct.Name = "formProduct";
            this.formProduct.Size = new System.Drawing.Size(1173, 711);
            this.formProduct.TabIndex = 2;
            // 
            // formMembership
            // 
            this.formMembership.Connection = null;
            this.formMembership.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.formMembership.Location = new System.Drawing.Point(236, 0);
            this.formMembership.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.formMembership.Name = "formMembership";
            this.formMembership.Size = new System.Drawing.Size(1173, 711);
            this.formMembership.TabIndex = 3;
            // 
            // formAccount
            // 
            this.formAccount.Connection = null;
            this.formAccount.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.formAccount.Location = new System.Drawing.Point(236, 0);
            this.formAccount.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.formAccount.Name = "formAccount";
            this.formAccount.Size = new System.Drawing.Size(1173, 711);
            this.formAccount.TabIndex = 5;
            // 
            // formReport
            // 
            this.formReport.Connection = null;
            this.formReport.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formReport.Location = new System.Drawing.Point(236, 0);
            this.formReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formReport.Name = "formReport";
            this.formReport.Size = new System.Drawing.Size(1173, 711);
            this.formReport.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 711);
            this.Controls.Add(this.formOrders);
            this.Controls.Add(this.formProduct);
            this.Controls.Add(this.formMembership);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formReport);
            this.Controls.Add(this.formAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1357, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnMembership;
        private FormOrders formOrders;
        private FormProduct formProduct;
        private System.Windows.Forms.Button btnReport;
        private FormMembership formMembership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccount;
        private FormAccount formAccount;
        private FormReport formReport;
    }
}

