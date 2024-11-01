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
        private List<ET_SanPhamThanhToan> listSanPhamThanhToan = new List<ET_SanPhamThanhToan>();
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
                txtDonGia.Text = et.GiaHH.ToString();
            }
        }

        private void formThanhToan_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSoLuong_Validated(object sender, EventArgs e)
        {
            try
            {
                double a = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
                txtThanhTien.Text = a.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi tính thành tiền vui lòng xem lại"+ ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_SanPhamThanhToan eT_SanPhamThanhToan = new ET_SanPhamThanhToan(txtMaHang.Text,txtTenHang.Text,int.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text),cbbKhuyenMai.Text, double.Parse(txtThanhTien.Text));
            listSanPhamThanhToan.Add(eT_SanPhamThanhToan);
            dgvHangHoa.DataSource = listSanPhamThanhToan;
        }
    }
}
