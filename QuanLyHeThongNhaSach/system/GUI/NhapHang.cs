using BUS;
using DevExpress.Utils.Extensions;
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
    public partial class NhapHang : Form
    {
        private BUS_HangHoa hh = BUS_HangHoa.Instance;
        private BUS_NhapHang nh = BUS_NhapHang.Instance;
        private BUS_NhaPhanPhoi npp = BUS_NhaPhanPhoi.Instance;
        private List<ET_ChiTietNhapHang> danhSachSanPham = new List<ET_ChiTietNhapHang>();
        private BindingSource bindingSourceSanPham = new BindingSource();

        public NhapHang()
        {
            InitializeComponent();
        }

        public bool KTraMa(string maKH)
        {
            if (maKH.Equals(dgvDSNhapHang.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaHH.Text.Length == 0 || txtSLNhap.Text.Length == 0 || txtGhiChu.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private Menu mainForm;

        public NhapHang(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            //HienThiDanhSachNhapHang();

            txtMaNH.Text = BUS_NhapHang.Instance.TaoMaHangTuDong();
            //txtMaHH.Text = BUS_HangHoa.Instance.TaoMaHangTuDong();
            try
            {

                cboTenNPP.DataSource = npp.loadnpp();
                cboTenNPP.DisplayMember = "TenNPP";
                cboTenNPP.ValueMember = "MaNPP";
                cboTenNPP_SelectedIndexChanged(sender, e);
                bindingSourceSanPham.DataSource = danhSachSanPham;
                dgvDSNhapHang.DataSource = bindingSourceSanPham;
                dgvDSNhapHang.AutoGenerateColumns = true;
                dgvDSNhapHang.Columns["MaNH"].Visible = false;
                dgvDSNhapHang.Columns["MaCTNCC"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSachNhapHang()
        {
              nh.XemDSNH(dgvDSNhapHang);
        }

        /// <summary>
        /// Thanh công cụ.
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

        private void btnThemHHMoi_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new HangHoa());
        }

        private void btnLSNhapHang_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new LichSuNhapHang());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    string maHH = txtMaHH.Text;
                    //string tenHH = txtTenHangHoa.Text;
                    int soLuong = int.Parse(txtSLNhap.Text);
                    //string ghiChu = txtGhiChu.Text;

                    var sanPhamTonTai = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == maHH);

                    if (sanPhamTonTai != null)
                    {
                        // Nếu sản phẩm đã tồn tại, tăng số lượng và cập nhật thành tiền
                        sanPhamTonTai.SoLuong += soLuong;
                        sanPhamTonTai.ghiChu = txtGhiChu.Text;
                    }
                    else
                    {
                        // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới vào danh sách
                        ET_ChiTietNhapHang sanPhamMoi = new ET_ChiTietNhapHang { MaHH = txtMaHH.Text, SoLuong = soLuong, GhiChu = txtGhiChu.Text, TenHangHoa = txtTenHangHoa.Text, MaNH = txtMaNH.Text };
                        danhSachSanPham.Add(sanPhamMoi);
                    }
                    bindingSourceSanPham.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtMaHH_Validated(object sender, EventArgs e)
        {

            ET_HangHoa eT_HngHoa = hh.TimNPP(txtMaNPP.Text, txtMaHH.Text);
           if (eT_HngHoa != null)
           {
               txtTenHangHoa.Text = eT_HngHoa.TenHH;
                    cboTenNPP.Enabled = true;
           }
           else
           {
               MessageBox.Show("Không tìm thấy sản phẩm ở nhà phân phối đã chọn !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ET_HangHoa etNPP = hh.TimHH(txtMaHH.Text);
                txtMaHH.Text = string.Empty;
               // txtMaNPP.Text = etNPP.NhaPP;
               // cboTenNPP.SelectedIndex = cboTenNPP.FindForm(txtMaNPP.Text);
           }
        }

        private void cboTenNPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNPP.Text = cboTenNPP.SelectedValue.ToString();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                //if (KtraBoTrong() == true)
                //{
                BUS_NhapHang.Instance.ThemNhapHang(new ET_NhapHang(txtMaNH.Text, txtMaNPP.Text, dtpNgayNH.Value));
                for (int i = 0; i < dgvDSNhapHang.Rows.Count; i++)
                {
                    //int dong = dgvDSNhapHang.CurrentCell.RowIndex;
                    // Lấy mã nhập hàng từ cột tương ứng trong dòng đang chọn
                    string soLuong = dgvDSNhapHang.Rows[i].Cells[3].Value.ToString();
                    string ghiChu = dgvDSNhapHang.Rows[i].Cells[4].Value.ToString();

                    // Gọi phương thức HienThiDanhSachChiTiet với maNH
                    HienThiDanhSachNhapHang();

                    ET_NhapHang nh = new ET_NhapHang();

                }
                
                //}
                //else
                //{
                //    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ email !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {

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

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGhiChu.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 150 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSLNhap_Validated(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSLNhap.Text, out decimal soLuong))
            {
                if (soLuong < 1 || soLuong > 50)
                {
                    MessageBox.Show("Số lượng hàng hóa nhập phải lớn hơn 1 và nhỏ hơn 59.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSLNhap.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị hợp lệ.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSLNhap.Focus();
            }
        }
    }
}
