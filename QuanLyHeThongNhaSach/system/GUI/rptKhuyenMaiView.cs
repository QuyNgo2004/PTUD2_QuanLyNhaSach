using BUS;
using ET;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class rptKhuyenMaiView : Form
    {
        private ET_NhanSu ns_r = new ET_NhanSu();
        public rptKhuyenMaiView(ET_NhanSu ns)
        {
            InitializeComponent();
            this.ns_r = ns;
        }

        private void rptKhuyenMaiView_Load(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            List<ET_KhuyenMaiReport> list = BUS_ChiTietKhuyenMai.Instance.CTKM_Load_Now_Report(now);
            List<ET_NhanSu> list_ns = new List<ET_NhanSu>();
            list_ns.Add(ns_r);
            rptBCKhuyenMai.LocalReport.ReportPath = "Report/rptKhuyenMai.rdlc";
            var source = new ReportDataSource("KhuyenMaiReport", list);
            var source_ns = new ReportDataSource("NhanSuReport", list_ns);
            rptBCKhuyenMai.LocalReport.DataSources.Clear();
            rptBCKhuyenMai.LocalReport.DataSources.Add(source);
            rptBCKhuyenMai.LocalReport.DataSources.Add(source_ns);
            this.rptBCKhuyenMai.RefreshReport();

            PrinterSettings printerSettings = new PrinterSettings();
            PageSettings pageSettings = new PageSettings();
            pageSettings.Landscape = true;  // Đặt chiều ngang

            // Áp dụng PageSettings vào ReportViewer
            rptBCKhuyenMai.SetPageSettings(pageSettings);
        }
    }
}
