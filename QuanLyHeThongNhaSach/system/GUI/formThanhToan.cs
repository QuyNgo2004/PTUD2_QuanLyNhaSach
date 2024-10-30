using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formThanhToan : Form
    {
        BUS_KhachHang kh = BUS_KhachHang.Instance;
        BUS_HangHoa hh = BUS_HangHoa.Instance;
        public formThanhToan()
        {
            InitializeComponent();
        }

        private void btnLSHoaDon_Click(object sender, EventArgs e)
        {
            Menu form = (Menu)this.ParentForm;
            form.openChildForm(new DanhSachHangDon());
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            //txtSDT_Validated(sender, e);
        }

        private void txtSDT_Validated(object sender, EventArgs e)
        {
            ET_KhachHang et = kh.TimKhachHangTheoSDT(txtSDT.Text);
            if (et != null)
            {
                txtMaKH.Text = et.MaKH;
                txtTenKH.Text = et.HotenKH;
                txtDiaChi.Text = et.DiachiKH;
            }
        }

        private void txtMaHang_Validated(object sender, EventArgs e)
        {
            ET_HangHoa et = hh.TimHangHoaTheoMa(txtMaHang.Text);
            if (et != null)
            {
                txtTenHang.Text = et.TenHH;
            }
        }
    }
}
