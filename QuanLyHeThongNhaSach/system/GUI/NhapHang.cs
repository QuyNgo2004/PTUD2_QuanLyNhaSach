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
            HienThiDanhSachNhapHang(); //cái này để load mã tự động nè, đừng có xóa dùng toai =)))

            txtMaNH.Text = BUS_NhapHang.Instance.TaoMaHangTuDong();
            try
            {

                //cboTenNPP.DataSource = npp.loadnpp();
                //cboTenNPP.DisplayMember = "TenNPP";
                //cboTenNPP.ValueMember = "MaNPP";
                //cboTenNPP_SelectedIndexChanged(sender, e);
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
            //nh.XemDSNH(dgvDSNhapHang, txtMaNPP.Text);
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
            ET_HangHoa eT_HngHoa = hh.TimHangHoaTheoMa(txtMaHH.Text);
            if (eT_HngHoa != null)
            {
                txtTenHangHoa.Text = eT_HngHoa.TenHH;
                txtMaNPP.Text = eT_HngHoa.NhaPP;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm đã chọn !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHH.Text = string.Empty;
                txtMaNPP.Text = string.Empty;
                //txtMaNPP.Text = etNPP.NhaPP;
                // cboTenNPP.SelectedIndex = cboTenNPP.FindForm(txtMaNPP.Text);
            }
        }

        //private void cboTenNPP_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtMaNPP.Text = cboTenNPP.SelectedValue.ToString();
        //}

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Xác nhận nhập hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                ET_NhapHang nhapHang = null;
                try
                {
                    // Step 1: Initialize ET_NhapHang with necessary details
                    nhapHang = new ET_NhapHang(
                        BUS_NhapHang.Instance.TaoMaHangTuDong(), // Generate unique import ID
                        txtMaNPP.Text,                           // Get distributor ID from textbox
                        DateTime.Now                             // Set current date
                    );

                    // Step 2: Add the import entry through the BUS layer
                    bool nhapHangAdded = BUS_NhapHang.Instance.ThemNhapHang(nhapHang);

                    if (nhapHangAdded)
                    {
                        // Step 3: If import entry is successfully added, add each product detail
                        foreach (DataGridViewRow row in dgvDSNhapHang.Rows)
                        {
                            if (row.Cells["maHH"].Value != null && row.Cells["SoLuong"].Value != null)
                            {
                                string maHH = row.Cells["maHH"].Value.ToString();            // Get product ID
                                int soLuongNhap = Convert.ToInt32(row.Cells["SoLuong"].Value); // Get import quantity

                                // Create import detail entry
                                ET_ChiTietNhapHang ctNhapHang = new ET_ChiTietNhapHang(
                                    nhapHang.MaNH,                // Import ID
                                    maHH,                         // Product ID
                                    "",                           // Notes (optional)
                                    "",                           // Product name if needed
                                    0,                            // Assuming a maCTNCC if necessary
                                    soLuongNhap                   // Quantity to import
                                );

                                // Add import detail through the BUS layer
                                BUS_ChiTietNhapHang.Instance.ThemChiTiet(ctNhapHang);

                                // Optionally update inventory after import, or handle as needed
                            }
                        }

                        // Step 4: Clear the data grid after import is complete
                        dgvDSNhapHang.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                try
                {
                    // Kiểm tra xem mã hàng hóa có tồn tại hay không
                    string maHangHoa = txtMaHH.Text;

                    // Tìm sản phẩm có mã hàng hóa khớp trong danh sách
                    var sanPhamXoa = danhSachSanPham.FirstOrDefault(hh => hh.MaHH == maHangHoa);

                    if (sanPhamXoa != null)
                    {
                        // Xóa sản phẩm khỏi danh sách
                        danhSachSanPham.Remove(sanPhamXoa);

                        // Cập nhật lại DataGridView
                        bindingSourceSanPham.ResetBindings(false);

                        // Xóa các ô nhập liệu để cho biết sản phẩm đã bị xóa
                        txtMaNPP.Clear();
                        txtMaHH.Clear();
                        txtTenHangHoa.Clear();
                        txtSLNhap.Clear();
                        txtGhiChu.Clear();

                        MessageBox.Show("Hoàn tất xóa dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa hàng hóa" +
                        ": " + ex.Message);
                }
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
                if (soLuong < 1 || soLuong > 59)
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                try
                {
                    string maNPP = txtMaNPP.Text;
                    string maHH = txtMaHH.Text;
                    string tenHH = txtTenHangHoa.Text;
                    int soLuong = int.Parse(txtSLNhap.Text);
                    string ghiChu = txtGhiChu.Text;

                    // Tìm sản phẩm trong danh sách sản phẩm
                    var sanPhamTonTai = danhSachSanPham.FirstOrDefault(hh => hh.MaHH == maHH);

                    if (sanPhamTonTai != null)
                    {
                        // Cập nhật các thuộc tính của sản phẩm
                        sanPhamTonTai.TenHangHoa = tenHH;
                        sanPhamTonTai.SoLuong = soLuong;
                        sanPhamTonTai.GhiChu = ghiChu;

                        // Refresh DataGridView
                        bindingSourceSanPham.ResetBindings(false);

                        // Clear input fields
                        //cboTenNPP.DataSource = npp.loadnpp();
                        //cboTenNPP.DisplayMember = "TenNPP";
                        //cboTenNPP.ValueMember = "MaNPP";
                        txtMaHH.Clear();
                        txtTenHangHoa.Clear();
                        txtSLNhap.Clear();
                        txtGhiChu.Clear();

                        MessageBox.Show("Hoàn tất sửa dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu đã chọn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message);
                }
            }
        }

        private void dgvDSNhapHang_Click(object sender, EventArgs e)
        {
            int a = dgvDSNhapHang.CurrentCell.RowIndex;

            txtMaHH.Text = dgvDSNhapHang.Rows[a].Cells[1].Value?.ToString() ?? "";
            txtTenHangHoa.Text = dgvDSNhapHang.Rows[a].Cells[2].Value?.ToString() ?? "";
            txtSLNhap.Text = dgvDSNhapHang.Rows[a].Cells[3].Value?.ToString() ?? "";
            txtGhiChu.Text = dgvDSNhapHang.Rows[a].Cells[4].Value?.ToString() ?? "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNPP.Clear();
            txtMaHH.Clear();
            txtTenHangHoa.Clear();
            txtSLNhap.Clear();
            txtGhiChu.Clear();
        }
    }
}


