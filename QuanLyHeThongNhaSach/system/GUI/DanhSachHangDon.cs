using BUS;
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
    public partial class DanhSachHangDon : Form
    {
        BUS_BatLoi batLoi = new BUS_BatLoi();
        public DanhSachHangDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DanhSachHangDon_Load(object sender, EventArgs e)
        {
            BUS_HoaDon.Instance.xemDanhSachHoaDon(dgvLichSuHoaDon);
        }

        private void dgvLichSuHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLichSuHoaDon.CurrentCell.RowIndex;
                string mahh = dgvLichSuHoaDon.Rows[dong].Cells[0].Value.ToString();
                BUS_CTHoaDon.Instance.xemChiTietHoaDon(dgvDSHangHoa, mahh);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNV.Text == "")
                {
                    if (CheckThongTin() == true)
                    {                        
                        dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTheoSoDienThoai(txtSDT.Text);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckThongTin()
        {
            bool flag = false;
            if (batLoi.KT_SoKiTu(txtSDT.Text, 10) == false || batLoi.KT_ChuoiSoDT(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại có 10 số bắt đàu là số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Clear();               
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}
