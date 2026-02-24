namespace Point_of_Sale
{
    partial class CartRow
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
            this.label16 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.numericUpDownQTY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(4, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 25);
            this.label16.TabIndex = 15;
            this.label16.Text = "QTY";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(103, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(161, 30);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "฿0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(257, 67);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "ใบชาอู่หลง เกรด AA ก้านอ่อน 240 กรัม ตรา ทีอีเอ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownQTY
            // 
            this.numericUpDownQTY.BackColor = System.Drawing.Color.White;
            this.numericUpDownQTY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownQTY.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numericUpDownQTY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDownQTY.Location = new System.Drawing.Point(54, 68);
            this.numericUpDownQTY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQTY.Name = "numericUpDownQTY";
            this.numericUpDownQTY.Size = new System.Drawing.Size(43, 29);
            this.numericUpDownQTY.TabIndex = 14;
            this.numericUpDownQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQTY.ValueChanged += new System.EventHandler(this.QTY_ValueChanged);
            // 
            // CartRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.numericUpDownQTY);
            this.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "CartRow";
            this.Size = new System.Drawing.Size(265, 100);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numericUpDownQTY;
    }
}
