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

namespace GUI
{
    public partial class rptBangLuongView : Form
    {
        ET_BangLuong bl = new ET_BangLuong();
        ET_NhanSu ns = new ET_NhanSu();
        public rptBangLuongView(ET_BangLuong eT_Bang,ET_NhanSu eT_NhanSu)
        {
            bl = eT_Bang;
            ns = eT_NhanSu;
            InitializeComponent();
        }

        private void rptBCKhuyenMai_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            List<ET_ChiTietLuong> list_ct = BUS_ChiTietLuong.Instance.XemBangLuong_Report(bl.MaBangLuong);
            List<ET_NhanSu> list_ns = new List<ET_NhanSu> { ns};
            List<ET_BangLuong> list_bl = new List<ET_BangLuong> { bl };

            rptBCBangLuong.LocalReport.ReportPath = "rptBangLuong.rdlc";
            var source_ctl = new ReportDataSource("LuongReport", list_ct);
            var source_ns = new ReportDataSource("NhanSuReport", list_ns);
            var source_l = new ReportDataSource("BangLuongReport", list_bl);
            rptBCBangLuong.LocalReport.DataSources.Clear();
            rptBCBangLuong.LocalReport.DataSources.Add(source_l);
            rptBCBangLuong.LocalReport.DataSources.Add(source_ctl);
            rptBCBangLuong.LocalReport.DataSources.Add(source_ns);
            this.rptBCBangLuong.RefreshReport();

            PrinterSettings printerSettings = new PrinterSettings();
            PageSettings pageSettings = new PageSettings();
            pageSettings.Landscape = true;  // Đặt chiều ngang

            // Áp dụng PageSettings vào ReportViewer
            rptBCBangLuong.SetPageSettings(pageSettings);
        }
    }
}
