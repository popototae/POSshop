using System;
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
using Microsoft.Reporting.WinForms;

namespace Point_of_Sale
{
    public partial class FormReport : UserControl
    {
        public SqlConnection Connection { get; set; }
        public FormReport()
        {
            InitializeComponent();
        }

        private void ShowReport(string reportType, DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(reportType, Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            ReportDataSource reportDataSource = new ReportDataSource(reportType, dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            string rdlcName;
            if (reportType == "GetDailySalesSummary") rdlcName = "SalesReportDaily";
            else if (reportType == "GetWeeklySalesSummary") rdlcName = "SalesReportWeekly";
            else if (reportType == "GetMonthlySalesSummary") rdlcName = "SalesReportMonthly";
            else if (reportType == "GetYearlySalesSummary") rdlcName = "SalesReportYearly";
            else if (reportType == "GetDailyProfitSummary") rdlcName = "ProfitReportDaily";
            else if (reportType == "GetWeeklyProfitSummary") rdlcName = "ProfitReportWeekly";
            else if (reportType == "GetMonthlyProfitSummary") rdlcName = "ProfitReportMonthly";
            else rdlcName = "ProfitReportYearly";

            reportViewer1.LocalReport.ReportEmbeddedResource = $"Point_of_Sale.{rdlcName}.rdlc";
            reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "สรุปยอดขาย")
            {
                if (radioDay.Checked)
                {
                    ShowReport("GetDailySalesSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
                else if (radioWeek.Checked)
                {
                    ShowReport("GetWeeklySalesSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
                else if (radioMonthly.Checked)
                {
                    ShowReport("GetMonthlySalesSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
                else if (radioYear.Checked)
                {
                    ShowReport("GetYearlySalesSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
            }
            else if(cmbCategory.Text == "สรุปกำไรสุทธิ")
            {
                if (radioDay.Checked)
                {
                    ShowReport("GetDailyProfitSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
                else if (radioWeek.Checked)
                {
                    ShowReport("GetWeeklyProfitSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
                else if (radioMonthly.Checked)
                {
                    ShowReport("GetMonthlyProfitSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
                else if (radioYear.Checked)
                {
                    ShowReport("GetYearlyProfitSummary", dateTimeStart.Value.Date, dateTimeEnd.Value.Date);
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกประเภทรายงาน", "แจ้งเตือน", MessageBoxButtons.OK);
            }
        }
    }
}
