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
        BUS_HoaDon hd = BUS_HoaDon.Instance;
        private List<ET_SanPhamThanhToan> danhSachSanPham = new List<ET_SanPhamThanhToan>();
        private BindingSource bindingSourceSanPham = new BindingSource();
        private string maNS = string.Empty;
        public formThanhToan(string maNS)
        {
            InitializeComponent();
            this.maNS = maNS;
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
            
        }

        private void formThanhToan_Load(object sender, EventArgs e)
        {
            bindingSourceSanPham.DataSource = danhSachSanPham;
            dgvHangHoa.DataSource = bindingSourceSanPham;
            dgvHangHoa.AutoGenerateColumns = true;
            hh.XemDSHH(cbbMaHang);
        }

        private void txtSoLuong_Validated(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                int donGia = int.Parse(txtDonGia.Text);
                int soLuong = int.Parse(txtSoLuong.Text);
                double thanhTien = donGia * soLuong;
                txtThanhTien.Text = thanhTien.ToString();
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHH = cbbMaHang.Text;
            string tenHH = txtTenHang.Text;
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            string khuyenMai = cbbKhuyenMai.Text;
            double thanhTien = double.Parse(txtThanhTien.Text);

            var sanPhamTonTai = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == maHH);

            if (sanPhamTonTai != null)
            {
                // Nếu sản phẩm đã tồn tại, tăng số lượng và cập nhật thành tiền
                sanPhamTonTai.SoLuong += soLuong;
                sanPhamTonTai.ThanhTien = sanPhamTonTai.DonGia * sanPhamTonTai.SoLuong;
            }
            else
            {
                // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới vào danh sách
                ET_SanPhamThanhToan sanPhamMoi = new ET_SanPhamThanhToan(maHH, tenHH, donGia, soLuong, khuyenMai, thanhTien);
                danhSachSanPham.Add(sanPhamMoi);
            }
            bindingSourceSanPham.ResetBindings(false);

            ShowTongTien();
            cbbMaHang.SelectedIndex = 0;
            txtTenHang.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            cbbKhuyenMai.Text = "";
            txtThanhTien.Clear();
        }

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvHangHoa.CurrentCell.RowIndex;
                cbbMaHang.Text = dgvHangHoa.Rows[dong].Cells[0].Value.ToString();
                txtTenHang.Text = dgvHangHoa.Rows[dong].Cells[1].Value.ToString();
                txtDonGia.Text = dgvHangHoa.Rows[dong].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvHangHoa.Rows[dong].Cells[3].Value.ToString();
                cbbKhuyenMai.Text = dgvHangHoa.Rows[dong].Cells[4].Value.ToString();
                txtThanhTien.Text = dgvHangHoa.Rows[dong].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi chọn dòng dữ liệu"+ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                try
                {
                    // Kiểm tra xem mã hàng hóa có tồn tại hay không
                    string maHangXoa = cbbMaHang.Text;

                    // Tìm sản phẩm có mã hàng hóa khớp trong danh sách
                    var sanPhamXoa = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == maHangXoa);

                    if (sanPhamXoa != null)
                    {
                        // Xóa sản phẩm khỏi danh sách
                        danhSachSanPham.Remove(sanPhamXoa);

                        // Cập nhật lại DataGridView
                        bindingSourceSanPham.ResetBindings(false);

                        ShowTongTien();

                        // Xóa các ô nhập liệu để cho biết sản phẩm đã bị xóa
                        cbbMaHang.SelectedIndex = 0;
                        txtTenHang.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        cbbKhuyenMai.Text = "";
                        txtThanhTien.Clear();

                        MessageBox.Show("Đã xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                try
                {
                    // Lấy mã hàng hóa của sản phẩm cần sửa
                    string maHH = cbbMaHang.Text;

                    // Tìm sản phẩm trong danh sách dựa trên mã hàng hóa
                    var sanPhamSua = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == maHH);

                    if (sanPhamSua != null)
                    {
                        // Cập nhật thông tin sản phẩm dựa trên dữ liệu từ các TextBox
                        sanPhamSua.TenHH = txtTenHang.Text;
                        sanPhamSua.DonGia = int.Parse(txtDonGia.Text);
                        sanPhamSua.SoLuong = int.Parse(txtSoLuong.Text);
                        sanPhamSua.KhuyenMai = cbbKhuyenMai.Text;

                        // Cập nhật lại thành tiền dựa trên số lượng và đơn giá mới
                        sanPhamSua.ThanhTien = sanPhamSua.DonGia * sanPhamSua.SoLuong;

                        // Cập nhật lại DataGridView
                        bindingSourceSanPham.ResetBindings(false);

                        ShowTongTien();
                        cbbMaHang.SelectedIndex = 0;
                        txtTenHang.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        cbbKhuyenMai.Text = "";
                        txtThanhTien.Clear();

                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message);
                }
            }
        }

        private double TinhTongTien()
        {
            double tongTien = danhSachSanPham.Sum(sp => sp.ThanhTien);
            return tongTien;
        }

        private void ShowTongTien()
        {
            // Tính tổng tiền dựa trên thuộc tính ThanhTien của mỗi sản phẩm
            double tongTien = danhSachSanPham.Sum(sp => sp.ThanhTien);

            // Hiển thị tổng tiền vào TextBox txtTongTien
            txtTongTien.Text = tongTien.ToString("N2"); // Định dạng hiển thị số có 2 chữ số thập phân
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn thanh toán?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                ET_HoaDon hoaDon = null;
                try
                {
                    // Bước 1: Tạo đối tượng ET_HoaDon từ thông tin trên form
                    hoaDon = new ET_HoaDon(
                        hd.AutoMa_HoaDon(),                   // Mã hóa đơn duy nhất
                        "NS01",         //txtMaNhanVien.Text  // Lấy mã nhân viên từ textbox
                        txtMaKH.Text,                         // Lấy mã khách hàng từ textbox
                        TinhTongTien(),                       // Tổng tiền từ hàm TinhTongTien
                        DateTime.Now,                         // Ngày hiện tại
                        " "                                   // Ghi chú từ textbox
                    );
                    //MessageBox.Show(hoaDon.MaHD);
                    // Bước 2: Thêm hóa đơn thông qua lớp BUS
                    bool hoaDonAdded = BUS_HoaDon.Instance.themHoaDon(hoaDon);

                    if (hoaDonAdded)
                    {
                        // Bước 3: Nếu hóa đơn được thêm thành công, thêm các chi tiết hóa đơn
                        foreach (DataGridViewRow row in dgvHangHoa.Rows)
                        {
                            if (row.Cells["maHH"].Value != null && row.Cells["SoLuong"].Value != null)
                            {
                                ET_CTHoaDon ctHoaDon = new ET_CTHoaDon(
                                    hoaDon.MaHD,                              // Mã hóa đơn
                                    row.Cells["maHH"].Value.ToString(),       // Mã hàng hóa từ DataGridView
                                    Convert.ToInt32(row.Cells["SoLuong"].Value)    // Số lượng từ DataGridView
                                );

                                // Thêm chi tiết hóa đơn thông qua lớp BUS
                                BUS_CTHoaDon.Instance.themCTHoaDon(ctHoaDon);
                            }
                        }
                        dgvHangHoa.DataSource = null;
                        // Bước 4: Hiển thị thông báo thành công
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn làm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                txtSDT.Clear();
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
                cbbMaHang.SelectedIndex = 0;
                txtTenHang.Clear();
                txtDonGia.Clear();
                txtSoLuong.Clear();
                cbbKhuyenMai.Text = "";
                txtThanhTien.Clear();
                dgvHangHoa.DataSource = null;
                txtTongTien.Clear();
            }
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ET_HangHoa et = hh.TimHangHoaTheoMa(cbbMaHang.Text);
            if (et != null)
            {
                txtTenHang.Text = et.TenHH;
                txtDonGia.Text = et.GiaHH.ToString();
            }
            
        }

        private void cbbMaHang_Enter(object sender, EventArgs e)
        {
            cbbMaHang_SelectedIndexChanged (sender, e);            
        }
    }
}
