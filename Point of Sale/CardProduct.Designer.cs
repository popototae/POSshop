namespace Point_of_Sale
{
    partial class CardProduct
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.Location = new System.Drawing.Point(4, 148);
            this.lblName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 54);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ใบชาอู่หลง เกรด AA ก้านอ่อน 240 กรัม ตรา ทีอีเอ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(4, 210);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 30);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "฿0.00";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(89)))), ((int)(((byte)(204)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(129, 205);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(52, 35);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // picProduct
            // 
            this.picProduct.Image = global::Point_of_Sale.Properties.Resources.noImage;
            this.picProduct.Location = new System.Drawing.Point(9, 8);
            this.picProduct.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(172, 132);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // CardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picProduct);
            this.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.Name = "CardProduct";
            this.Size = new System.Drawing.Size(189, 248);
            this.Click += new System.EventHandler(this.CardProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
    }
}
