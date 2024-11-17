using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms; // Dùng cho ReportViewer
using System.Data;                 // Dùng cho DataTable
using System.Data.SqlClient;
using BUS;       // Dùng cho SqlConnection và SqlCommand


namespace GUI
{
    public partial class InHoaDon : Form
    {
        private string maHD;
        public InHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {

            try
            {
                // Lấy dữ liệu từ BUS_Report
                DataTable dt = BUS_Report.Instance.GetDataInHoaDon(maHD);
                dt = RemoveDuplicateRows(dt, "tenHH");
                // Gắn dữ liệu vào ReportViewer
                ReportDataSource rds = new ReportDataSource("InHoaDon", dt); // "InHoaDon" là tên DataSet trong RDLC
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable RemoveDuplicateRows(DataTable dt, string columnName)
        {
            HashSet<string> seen = new HashSet<string>();
            DataTable distinctTable = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                string value = row[columnName].ToString();
                if (seen.Add(value)) // Chỉ thêm nếu chưa tồn tại
                {
                    distinctTable.Rows.Add(row.ItemArray);
                }
            }

            return distinctTable;
        }
    }
}
