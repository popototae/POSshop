namespace Point_of_Sale
{
    partial class FormOrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.flpProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMembership = new System.Windows.Forms.Button();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picCustIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flpOrderCart = new System.Windows.Forms.FlowLayoutPanel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProductList
            // 
            this.flpProductList.AutoScroll = true;
            this.flpProductList.BackColor = System.Drawing.SystemColors.Control;
            this.flpProductList.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.flpProductList.Location = new System.Drawing.Point(3, 104);
            this.flpProductList.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.flpProductList.Name = "flpProductList";
            this.flpProductList.Size = new System.Drawing.Size(837, 588);
            this.flpProductList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LINE Seed Sans TH", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMembership);
            this.panel1.Controls.Add(this.lblVat);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.picCustIcon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.flpOrderCart);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.btnRemoveAll);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(846, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 673);
            this.panel1.TabIndex = 2;
            // 
            // btnMembership
            // 
            this.btnMembership.BackColor = System.Drawing.Color.Transparent;
            this.btnMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembership.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMembership.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.Location = new System.Drawing.Point(23, 48);
            this.btnMembership.Margin = new System.Windows.Forms.Padding(0);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(219, 36);
            this.btnMembership.TabIndex = 13;
            this.btnMembership.Text = "-- No selected --";
            this.btnMembership.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMembership.UseVisualStyleBackColor = false;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // lblVat
            // 
            this.lblVat.Location = new System.Drawing.Point(165, 535);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(120, 30);
            this.lblVat.TabIndex = 17;
            this.lblVat.Text = "฿0.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(165, 505);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(120, 30);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "฿0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vat (7%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Subtotal";
            // 
            // picCustIcon
            // 
            this.picCustIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCustIcon.Image = ((System.Drawing.Image)(resources.GetObject("picCustIcon.Image")));
            this.picCustIcon.Location = new System.Drawing.Point(238, 20);
            this.picCustIcon.Name = "picCustIcon";
            this.picCustIcon.Size = new System.Drawing.Size(64, 64);
            this.picCustIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustIcon.TabIndex = 11;
            this.picCustIcon.TabStop = false;
            this.picCustIcon.Click += new System.EventHandler(this.picCustIcon_Click);
            // 
            // label4
            // 
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(115, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Membership";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpOrderCart
            // 
            this.flpOrderCart.AutoScroll = true;
            this.flpOrderCart.Location = new System.Drawing.Point(17, 103);
            this.flpOrderCart.Name = "flpOrderCart";
            this.flpOrderCart.Size = new System.Drawing.Size(290, 390);
            this.flpOrderCart.TabIndex = 10;
            this.flpOrderCart.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpOrderCart_ControlAdded);
            this.flpOrderCart.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flpOrderCart_ControlRemoved);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(89)))), ((int)(((byte)(204)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(165, 620);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(120, 35);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(50)))));
            this.btnRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.Location = new System.Drawing.Point(21, 620);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(120, 35);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Text = "Remove all";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotal.Location = new System.Drawing.Point(165, 576);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 30);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "฿0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(16, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LINE Seed Sans TH", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cart";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSelectAll);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(18, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 70);
            this.panel2.TabIndex = 4;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSelectAll.Location = new System.Drawing.Point(706, 19);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(89, 32);
            this.btnSelectAll.TabIndex = 12;
            this.btnSelectAll.Text = "select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(89)))), ((int)(((byte)(204)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(660, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 36);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Enabled = false;
            this.lblSearch.Location = new System.Drawing.Point(466, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 30);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(462, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 31);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(89)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(459, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 36);
            this.panel3.TabIndex = 1;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpProductList);
            this.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FormOrders";
            this.Size = new System.Drawing.Size(1173, 711);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpOrderCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picCustIcon;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblSubtotal;
    }
}
