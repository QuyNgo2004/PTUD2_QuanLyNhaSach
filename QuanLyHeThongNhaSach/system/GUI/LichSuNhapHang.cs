using BUS;
using DevExpress.Data.Linq.Helpers;
using ET;
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
            BUS_NhapHang.Instance.layMaNhaPhanPhoi(cboMaNPP);
        }

        private void HienThiDanhSachNhapHang()
        {
            //if (cboMaNPP.SelectedValue != null)
            //{
            //    nh.XemDSNH(dgvLSNH, cboMaNPP.SelectedValue.ToString());
            //}
            nh.XemDSLSNH(cboMaNPP.Text);
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
            try
            {
                // Kiểm tra giá trị SelectedValue
                if (cboMaNPP.SelectedValue == null || string.IsNullOrEmpty(cboMaNPP.SelectedValue.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn một nhà phân phối hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách nhập hàng từ nhà phân phối
                string maNPP = cboMaNPP.SelectedValue.ToString();
                var danhSachNhapHang = nh.XemDSLSNH(maNPP);

                // Kiểm tra dữ liệu trả về
                if (danhSachNhapHang != null && danhSachNhapHang.Count() > 0)
                {
                    // Hiển thị danh sách nhập hàng lên DataGridView
                    dgvLSNH.DataSource = danhSachNhapHang;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi chi tiết
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (dgvLSNH.SelectedRows.Count > 0)
            //{
            //    DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (d == DialogResult.Yes)
            //    {
            //       // BUS_NhapHang.Instance.XoaNhapHang(dgvLSNH);
            //        BUS_NhapHang.Instance.XemDSNH(dgvLSNH, cboMaNPP.SelectedValue.ToString());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgvLSNH_Click(object sender, EventArgs e)
        {
            try
            {
                string mahh = dgvLSNH.CurrentRow.Cells[0].Value.ToString();
                BUS_ChiTietNhapHang.Instance.XemDSCTNH(dgvDSHangHoa, mahh);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //Menu formMenu = (Menu)this.ParentForm;
            //formMenu.openChildForm(new RpNhapHang());
            if (dgvLSNH.CurrentRow != null)
            {
                try
                {
                    ET_NhanSu ns = new ET_NhanSu();
                    ns = BUS_NhanSu.Instance.TimNhanSu(Program.maNS);
                    rptNhapHang r = new rptNhapHang(ns, dgvLSNH.CurrentRow.Cells[0].Value.ToString());
                    r.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn chọn lịch sử nhập hàng cần in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
