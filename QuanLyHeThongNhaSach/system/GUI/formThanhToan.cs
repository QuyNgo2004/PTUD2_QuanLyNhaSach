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
        BUS_BatLoi batLoi = new BUS_BatLoi();
        BUS_KhuyenMai km = BUS_KhuyenMai.Instance;
        private List<ET_SanPhamThanhToan> danhSachSanPham = new List<ET_SanPhamThanhToan>();
        private BindingSource bindingSourceSanPham = new BindingSource();
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
            if (CheckThongTin() == true)
            {
                ET_KhachHang et = kh.TimKhachHangTheoSDT(txtSDT.Text);
                if (et != null)
                {
                    txtMaKH.Text = et.MaKH;
                    txtTenKH.Text = et.HotenKH;
                    txtDiaChi.Text = et.DiachiKH;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có SDT này", "Thông báo");
                    txtSDT.Focus();
                }
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
            cbbKhuyenMai.DataSource = km.LoadKM_All();
            cbbKhuyenMai.DisplayMember = "TenKM";
            cbbKhuyenMai.ValueMember = "GiảmGiá";
            cbbKhuyenMai.SelectedIndex = 0;
        }

        private void txtSoLuong_Validated(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập số hay không
            try
            {
                if (batLoi.KT_ChuoiSo(txtSoLuong.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập ký tự số", "Thông báo");
                    txtSoLuong.Clear();  // Nếu nhập không phải số thì làm sạch ô
                    return;
                }
                else
                {
                    // Lấy giá trị đơn giá và số lượng từ TextBox
                    int donGia = int.Parse(txtDonGia.Text);
                    int soLuong = int.Parse(txtSoLuong.Text);

                    // Lấy giá trị giảm giá từ ComboBox (Giả sử giá trị giảm giá là %)
                    int giamGia = Convert.ToInt32(cbbKhuyenMai.SelectedValue); // Giá trị giảm giá từ ComboBox

                    // Tính số lượng thực tế tính tiền (số lượng mua thực tế)
                    int soLuongTinhTien = soLuong;

                    // Kiểm tra loại khuyến mãi
                    if (giamGia == 0)
                    {
                        // Tặng sản phẩm: tăng gấp đôi số lượng để hiển thị trong giỏ hàng
                        soLuong *= 2; // Số lượng trong giỏ hàng sẽ gấp đôi (bao gồm tặng kèm)
                    }

                    // Tính thành tiền
                    double thanhTien = donGia * soLuongTinhTien; // Tính theo số lượng mua thực tế

                    // Nếu giảm giá, tính lại giá trị thanh toán
                    if (giamGia > 0)
                    {
                        thanhTien = donGia * soLuongTinhTien * (1 - (giamGia / 100.0)); // Áp dụng giảm giá
                    }

                    // Cập nhật lại giá trị thành tiền vào TextBox
                    txtThanhTien.Text = thanhTien.ToString();  // Hiển thị thành tiền đã tính toán
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong != null && int.Parse(txtSoLuong.Text ) != 0)
                {
                    // Lấy thông tin từ các trường trên form
                    string maHH = cbbMaHang.Text;
                    string tenHH = txtTenHang.Text;
                    int donGia = int.Parse(txtDonGia.Text);
                    int giamGia = Convert.ToInt32(cbbKhuyenMai.SelectedValue); // Lấy giá trị giảm giá từ comboBox (0: tặng sản phẩm)
                    int soLuong = int.Parse(txtSoLuong.Text);

                    // Tính số lượng thực tế tính tiền (số lượng mua thực tế)
                    int soLuongTinhTien = soLuong;

                    // Kiểm tra loại khuyến mãi
                    if (giamGia == 0)
                    {
                        // Tặng sản phẩm: tăng gấp đôi số lượng để hiển thị trong giỏ hàng
                        soLuong *= 2; // Số lượng trong giỏ hàng sẽ gấp đôi (bao gồm tặng kèm)
                    }

                    // Tính thành tiền
                    double thanhTien = donGia * soLuongTinhTien; // Tính theo số lượng mua thực tế

                    // Nếu giảm giá, tính lại giá trị thanh toán
                    if (giamGia > 0)
                    {
                        thanhTien = donGia * soLuongTinhTien * (1 - (giamGia / 100.0)); // Áp dụng giảm giá
                    }

                    string khuyenMai = cbbKhuyenMai.Text; // Lấy tên khuyến mãi từ combobox

                    // Kiểm tra nếu sản phẩm đã có trong danh sách (dgvHangHoa)
                    var sanPhamTonTai = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == maHH);

                    if (sanPhamTonTai != null)
                    {
                        // Nếu sản phẩm đã tồn tại trong giỏ hàng, cập nhật số lượng và thành tiền
                        sanPhamTonTai.SoLuong += soLuong;
                        sanPhamTonTai.ThanhTien += thanhTien; // Cộng dồn thành tiền
                    }
                    else
                    {
                        // Nếu sản phẩm chưa tồn tại trong giỏ hàng, thêm sản phẩm mới vào danh sách
                        ET_SanPhamThanhToan sanPhamMoi = new ET_SanPhamThanhToan(maHH, tenHH, donGia, soLuong, khuyenMai, thanhTien);
                        danhSachSanPham.Add(sanPhamMoi);
                    }

                    // Cập nhật lại DataGridView với danh sách sản phẩm                    

                    bindingSourceSanPham.ResetBindings(false);

                    ShowTongTien();
                    cbbMaHang.SelectedIndex = 0;
                    txtTenHang.Clear();
                    txtDonGia.Clear();
                    txtSoLuong.Clear();
                    cbbKhuyenMai.SelectedIndex = 0;
                    txtThanhTien.Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bạn chưa nhập số lượng mua!", "Thông báo");
                txtSoLuong.Focus();
            }
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

                MessageBox.Show("Lỗi khi chọn dòng dữ liệu" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        cbbKhuyenMai.SelectedIndex = 0;
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
                    string maHH = cbbMaHang.Text;
                    string tenHH = txtTenHang.Text;
                    int donGia = int.Parse(txtDonGia.Text);
                    int giamGia = Convert.ToInt32(cbbKhuyenMai.SelectedValue); // Lấy giá trị giảm giá từ comboBox (0: tặng sản phẩm)
                    int soLuong = int.Parse(txtSoLuong.Text);

                    // Tính số lượng thực tế tính tiền (số lượng mua thực tế)
                    int soLuongTinhTien = soLuong;

                    // Kiểm tra loại khuyến mãi
                    if (giamGia == 0)
                    {
                        // Tặng sản phẩm: tăng gấp đôi số lượng để hiển thị trong giỏ hàng
                        soLuong *= 2; // Số lượng trong giỏ hàng sẽ gấp đôi (bao gồm tặng kèm)
                    }

                    // Tính thành tiền
                    double thanhTien = donGia * soLuongTinhTien; // Tính theo số lượng mua thực tế

                    // Nếu giảm giá, tính lại giá trị thanh toán
                    if (giamGia > 0)
                    {
                        thanhTien = donGia * soLuongTinhTien * (1 - (giamGia / 100.0)); // Áp dụng giảm giá
                    }

                    string khuyenMai = cbbKhuyenMai.Text; // Lấy tên khuyến mãi từ combobox

                    // Tìm sản phẩm trong danh sách sản phẩm
                    var sanPhamTonTai = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == maHH);

                    if (sanPhamTonTai != null)
                    {
                        // Nếu sản phẩm đã tồn tại, cập nhật số lượng và thành tiền
                        sanPhamTonTai.SoLuong = soLuong;
                        sanPhamTonTai.ThanhTien = thanhTien; // Cập nhật lại thành tiền cho sản phẩm
                        sanPhamTonTai.KhuyenMai = khuyenMai; // Cập nhật khuyến mãi
                        // Cập nhật lại DataGridView
                        bindingSourceSanPham.ResetBindings(false);

                        ShowTongTien();
                        cbbMaHang.SelectedIndex = 0;
                        txtTenHang.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        cbbKhuyenMai.SelectedIndex = 0;
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
            DialogResult dar = MessageBox.Show("Bạn có muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                ET_HoaDon hoaDon = null;
                try
                {
                    // Bước 1: Tạo đối tượng ET_HoaDon từ thông tin trên form
                    hoaDon = new ET_HoaDon(
                        hd.AutoMa_HoaDon(),                   // Mã hóa đơn duy nhất
                        Program.maNS,
                        txtMaKH.Text,                         // Lấy mã khách hàng từ textbox
                        TinhTongTien(),                       // Tổng tiền từ hàm TinhTongTien
                        DateTime.Now,                         // Ngày hiện tại
                        ""                                    // Ghi chú từ textbox
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
                                string maHH = row.Cells["maHH"].Value.ToString();
                                int soLuongMua = Convert.ToInt32(row.Cells["SoLuong"].Value);

                                // Kiểm tra số lượng tồn trong kho
                                int soLuongTon = BUS_HangHoa.Instance.GetSoLuongTon(maHH);
                                if (soLuongTon < soLuongMua)
                                {
                                    MessageBox.Show($"Sản phẩm {maHH} không đủ số lượng trong kho (còn lại: {soLuongTon}).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return; // Kết thúc giao dịch nếu không đủ số lượng tồn
                                }

                                // Tạo chi tiết hóa đơn nếu đủ tồn kho
                                ET_CTHoaDon ctHoaDon = new ET_CTHoaDon(
                                    hoaDon.MaHD,                  // Mã hóa đơn
                                    maHH,                         // Mã hàng hóa
                                    soLuongMua                    // Số lượng mua
                                );

                                // Thêm chi tiết hóa đơn thông qua lớp BUS
                                BUS_CTHoaDon.Instance.themCTHoaDon(ctHoaDon);

                                // Cập nhật số lượng tồn mới trong CSDL
                                int soLuongMoi = soLuongTon - soLuongMua;
                                BUS_HangHoa.Instance.UpdateSoLuongTon(maHH, soLuongMoi);
                            }
                        }
                        dgvHangHoa.DataSource = null;
                        txtTongTien.Clear();
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
                cbbKhuyenMai.SelectedIndex = 0;
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
            try
            {
                if (cbbMaHang.Text != "")
                {
                    ET_HangHoa et = hh.TimHangHoaTheoMa(cbbMaHang.Text);
                    if (et != null)
                    {
                        txtTenHang.Text = et.TenHH;
                        txtDonGia.Text = et.GiaHH.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cbbMaHang_Enter(object sender, EventArgs e)
        {
            cbbMaHang_SelectedIndexChanged(sender, e);
        }

        private bool CheckThongTin()
        {
            bool flag = false;
            if (batLoi.KT_SoKiTu(txtSDT.Text, 10) == false || batLoi.KT_ChuoiSoDT(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại có 10 số bắt đàu là số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Clear();
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private bool CheckThongTin1()
        {
            bool flag = false;
            if (batLoi.KT_ChuoiSo(cbbMaHang.Text) == false || batLoi.KT_SoKiTu(cbbMaHang.Text,13) == false)
            {
                MessageBox.Show("Nhập mã hàng là số và đúng 13 ký tự", "Thông báo");
                cbbMaHang.SelectedIndex = 0;
                txtTenHang.Clear();
                txtDonGia.Clear();
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbKhuyenMai.SelectedIndex != -1) // Kiểm tra nếu có lựa chọn hợp lệ
                {
                    if (txtSoLuong.Text != "")
                    {
                        // Lấy giá trị giảm giá từ ComboBox (GiảmGiá được thiết lập là ValueMember)
                        int giamGia = Convert.ToInt32(cbbKhuyenMai.SelectedValue);

                        // Lấy giá trị từ các TextBox
                        int donGia = int.Parse(txtDonGia.Text);
                        int soLuong = int.Parse(txtSoLuong.Text);

                        double thanhTien = donGia * soLuong;  // Tính thành tiền ban đầu (không có giảm giá)

                        // Nếu có giảm giá, tính lại thành tiền
                        if (giamGia > 0)
                        {
                            thanhTien = donGia * soLuong * (1 - (giamGia / 100.0));  // Áp dụng giảm giá theo phần trăm
                        }
                        else if (giamGia == 0)  // Nếu giảm giá bằng 0, tính theo số lượng tặng
                        {
                            int soLuongTinhTien = soLuong;
                            soLuong *= 2;  // Tăng gấp đôi số lượng nếu là khuyến mãi tặng sản phẩm
                            thanhTien = donGia * soLuongTinhTien;  // Tính lại thành tiền với số lượng mới
                        }

                        // Cập nhật lại thành tiền vào TextBox
                        txtThanhTien.Text = thanhTien.ToString();  // Hiển thị thành tiền với định dạng số
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbbMaHang_Validated(object sender, EventArgs e)
        {
            if (CheckThongTin1() == true)
            {
                ET_HangHoa et = hh.TimHangHoaTheoMa(cbbMaHang.Text);
                if (et != null)
                {
                    txtTenHang.Text = et.TenHH;
                    txtDonGia.Text = et.GiaHH.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã này", "Thông báo");
                    cbbMaHang.SelectedIndex = 0;
                    txtTenHang.Clear();
                    txtDonGia.Clear();
                }
            }
        }
    }
}
