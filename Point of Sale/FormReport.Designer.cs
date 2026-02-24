namespace Point_of_Sale
{
    partial class FormReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radioDay = new System.Windows.Forms.RadioButton();
            this.radioMonthly = new System.Windows.Forms.RadioButton();
            this.radioYear = new System.Windows.Forms.RadioButton();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioWeek = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 70);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LINE Seed Sans TH", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "สรุปยอดขาย",
            "สรุปกำไรสุทธิ"});
            this.cmbCategory.Location = new System.Drawing.Point(28, 166);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(251, 38);
            this.cmbCategory.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(23, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "ประเภทรายงาน";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Point_of_Sale.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(810, 583);
            this.reportViewer1.TabIndex = 21;
            // 
            // radioDay
            // 
            this.radioDay.AutoSize = true;
            this.radioDay.BackColor = System.Drawing.Color.White;
            this.radioDay.Checked = true;
            this.radioDay.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioDay.Location = new System.Drawing.Point(22, 33);
            this.radioDay.Name = "radioDay";
            this.radioDay.Size = new System.Drawing.Size(82, 34);
            this.radioDay.TabIndex = 24;
            this.radioDay.TabStop = true;
            this.radioDay.Text = "รายวัน";
            this.radioDay.UseVisualStyleBackColor = false;
            // 
            // radioMonthly
            // 
            this.radioMonthly.AutoSize = true;
            this.radioMonthly.BackColor = System.Drawing.Color.White;
            this.radioMonthly.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioMonthly.Location = new System.Drawing.Point(127, 73);
            this.radioMonthly.Name = "radioMonthly";
            this.radioMonthly.Size = new System.Drawing.Size(100, 34);
            this.radioMonthly.TabIndex = 25;
            this.radioMonthly.Text = "รายเดือน";
            this.radioMonthly.UseVisualStyleBackColor = false;
            // 
            // radioYear
            // 
            this.radioYear.AutoSize = true;
            this.radioYear.BackColor = System.Drawing.Color.White;
            this.radioYear.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioYear.Location = new System.Drawing.Point(23, 73);
            this.radioYear.Name = "radioYear";
            this.radioYear.Size = new System.Drawing.Size(72, 34);
            this.radioYear.TabIndex = 26;
            this.radioYear.Text = "รายปี";
            this.radioYear.UseVisualStyleBackColor = false;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimeStart.CustomFormat = "";
            this.dateTimeStart.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(119, 368);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(160, 38);
            this.dateTimeStart.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(23, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "ตั้งแต่วันที่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(23, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "จนถึงวันที่";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimeEnd.CustomFormat = "";
            this.dateTimeEnd.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEnd.Location = new System.Drawing.Point(119, 415);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(160, 38);
            this.dateTimeEnd.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(89)))), ((int)(((byte)(204)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("LINE Seed Sans TH", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(67, 495);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 37);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "สืบค้นรายงาน";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioWeek
            // 
            this.radioWeek.AutoSize = true;
            this.radioWeek.BackColor = System.Drawing.Color.White;
            this.radioWeek.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioWeek.Location = new System.Drawing.Point(126, 33);
            this.radioWeek.Name = "radioWeek";
            this.radioWeek.Size = new System.Drawing.Size(115, 34);
            this.radioWeek.TabIndex = 61;
            this.radioWeek.Text = "รายสัปดาห์";
            this.radioWeek.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimeStart);
            this.panel2.Controls.Add(this.dateTimeEnd);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(846, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 673);
            this.panel2.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWeek);
            this.groupBox1.Controls.Add(this.radioDay);
            this.groupBox1.Controls.Add(this.radioYear);
            this.groupBox1.Controls.Add(this.radioMonthly);
            this.groupBox1.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(28, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 118);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "การรายงาน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LINE Seed Sans TH", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(21, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 38);
            this.label4.TabIndex = 61;
            this.label4.Text = "Details";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("LINE Seed Sans TH", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReport";
            this.Size = new System.Drawing.Size(1173, 711);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton radioDay;
        private System.Windows.Forms.RadioButton radioMonthly;
        private System.Windows.Forms.RadioButton radioYear;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioWeek;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
