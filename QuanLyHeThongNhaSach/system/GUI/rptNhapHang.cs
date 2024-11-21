using BUS;
using ET;
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
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class rptNhapHang : Form
    {
        ET_ChiTietNhapHang bl = new ET_ChiTietNhapHang();
        ET_NhapHang nh = new ET_NhapHang();
        ET_NhanSu ns = new ET_NhanSu();
        string maNH = null;
        public rptNhapHang( ET_NhanSu ns, string maNH)
        {
            this.ns = ns;
            InitializeComponent();
            this.maNH = maNH;
        }



        private void rptNhapHang_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            List<ET_ChiTietNhapHang> list_ct = BUS_ChiTietNhapHang.Instance.ChiTietNhapHang(maNH);
            List<ET_NhanSu> list_ns = new List<ET_NhanSu> { ns };
            //List<ET_NhapHang> list_bl = new List<ET_NhapHang> { nh };

            rptBCNhapHang.LocalReport.ReportPath = "Report/DSChiTietNhapHang.rdlc";
            var source_ctl = new ReportDataSource("NhapHangDataSet", list_ct);
            var source_ns = new ReportDataSource("NhanSuDataSet", list_ns);
           // var source_l = new ReportDataSource("BangLuongReport", list_bl);
            rptBCNhapHang.LocalReport.DataSources.Clear();
            //rptBCNhapHang.LocalReport.DataSources.Add(source_l);
            rptBCNhapHang.LocalReport.DataSources.Add(source_ctl);
            rptBCNhapHang.LocalReport.DataSources.Add(source_ns);
            this.rptBCNhapHang.RefreshReport();

            PrinterSettings printerSettings = new PrinterSettings();
            PageSettings pageSettings = new PageSettings();
            pageSettings.Landscape = true;  // Đặt chiều ngang

            // Áp dụng PageSettings vào ReportViewer
            rptBCNhapHang.SetPageSettings(pageSettings);
        }
    }
}
