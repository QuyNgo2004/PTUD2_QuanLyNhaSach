using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LichSuNhapHang : Form
    {
        public LichSuNhapHang()
        {
            InitializeComponent();
        }

        BUS_NhaPhanPhoi npp = BUS_NhaPhanPhoi.Instance;
        BUS_HangHoa hh = BUS_HangHoa.Instance;
        BUS_NhapHang nh = BUS_NhapHang.Instance;
        BUS_ChiTietNhapHang ct = BUS_ChiTietNhapHang.Instance;

        private void LichSuNhapHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhapHang();
        }

        private void HienThiDanhSachNhapHang()
        {
            nh.XemDSNH(dgvLSNH);
        }

        private void HienThiDanhSachChiTiet(string maNH)
        {
            ct.XemDSCTNHTM(dgvDSHangHoa, maNH);
        }

        /// <summary>
        /// button thoát.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboMaNPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (nh.XemDSNH(cboMaNPP.SelectedValue.ToString()).Count() > 0)
            //    {

            //        cboCaTruc.DataSource = ct.Load_CaTruc(cboCN.SelectedValue.ToString());
            //        cboCaTruc.DisplayMember = "Tên";
            //        cboCaTruc.ValueMember = "Mã";
            //        ctct.hienThiCTCaTruc(dgvDSCaTruc, int.Parse(cboCaTruc.SelectedValue.ToString()));
            //    }
            //    else
            //    {
            //        cboCaTruc.DataSource = null;
            //        dgvDSCaTruc.DataSource = null;
            //    }
            //    txtMaNS.Text = null;
            //    txtTenNS.Text = null;
            //    ns.hienThiNhanSu(dgvNV, cboCN.SelectedValue.ToString());
            //    //ctct.hienThiCTCaTruc(dgvDSCaTruc,int.Parse(cboCaTruc.SelectedValue.ToString()));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLSNH.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_NhapHang.Instance.XoaNhapHang(dgvLSNH);
                    BUS_NhapHang.Instance.XemDSNH(dgvLSNH);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLSNH_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLSNH.CurrentRow != null)
                {
                    int dong = dgvLSNH.CurrentCell.RowIndex;
                    // Lấy mã nhập hàng từ cột tương ứng trong dòng đang chọn
                    string maNH = dgvLSNH.Rows[dong].Cells[0].Value.ToString();

                    // Gọi phương thức HienThiDanhSachChiTiet với maNH
                    HienThiDanhSachChiTiet(maNH);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMaHH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaHH.Text.Length > 12 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã chức vụ quá 13 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
