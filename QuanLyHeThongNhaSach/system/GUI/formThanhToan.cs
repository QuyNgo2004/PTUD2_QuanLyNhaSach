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
        BUS_ChiTietKhuyenMai ctkm = BUS_ChiTietKhuyenMai.Instance;
        private List<ET_SanPhamThanhToan> danhSachSanPham = new List<ET_SanPhamThanhToan>();
        private BindingSource bindingSourceSanPham = new BindingSource();
        private string maNS = string.Empty;
        public formThanhToan(string maNS)
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
                    txtSDT.Clear();
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiaChi.Clear();
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
            cbbMaHang_Validated(sender, e);
            //cbbKhuyenMai.DataSource = km.LoadKM_All();
            //cbbKhuyenMai.DisplayMember = "TenKM";
            //cbbKhuyenMai.ValueMember = "GiảmGiá";
            //cbbKhuyenMai.SelectedIndex = 0;
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

                    ET_KhuyenMai eT_KhuyenMai = new ET_KhuyenMai();
                    // Lấy giá trị giảm giá từ ComboBox (Giả sử giá trị giảm giá là %)
                    if (cbbKhuyenMai.SelectedValue == null)
                    {
                        eT_KhuyenMai.MaGiamGia = 0;
                    } 
                    else
                    {
                        eT_KhuyenMai = km.KM_TimMa(cbbKhuyenMai.SelectedValue.ToString());
                    }
                    // Tính thành tiền
                    double thanhTien = donGia * soLuong; // Tính theo số lượng mua thực tế

                    // Nếu giảm giá, tính lại giá trị thanh toán
                    if (eT_KhuyenMai.MaGiamGia > 0)
                    {
                        thanhTien = donGia * soLuong * (1 - (eT_KhuyenMai.MaGiamGia / 100.0)); // Áp dụng giảm giá
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
            DialogResult dar = MessageBox.Show("Bạn có muốn thêm?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                try
                {
                    if (txtSoLuong != null && int.Parse(txtSoLuong.Text) != 0)
                    {
                        //Tim ma khuyến mãi
                        ET_KhuyenMai eT_KhuyenMai = new ET_KhuyenMai();
                        if (cbbKhuyenMai.SelectedValue == null)
                        {
                            eT_KhuyenMai.MaGiamGia = 0;
                            eT_KhuyenMai.MaHH = null;
                        }
                        else
                        {
                            eT_KhuyenMai = km.KM_TimMa(cbbKhuyenMai.SelectedValue.ToString());
                        }
                        // Lấy thông tin từ các trường trên form
                        string maHH = cbbMaHang.Text;
                        string tenHH = txtTenHang.Text;
                        int donGia = int.Parse(txtDonGia.Text);
                        int giamGia = Convert.ToInt32(eT_KhuyenMai.MaGiamGia); // Lấy giá trị giảm giá từ comboBox (0: tặng sản phẩm)
                        int soLuong = int.Parse(txtSoLuong.Text);

                        // Tính số lượng thực tế tính tiền (số lượng mua thực tế)
                        int soLuongTinhTien = soLuong;

                        // Kiểm tra loại khuyến mãi
                        if (eT_KhuyenMai.MaHH == null)
                        {
                            // Tính thành tiền
                            double thanhTien = donGia * soLuong; // Tính theo số lượng mua thực tế

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
                        }
                        else
                        {
                            ET_HangHoa hhKM = new ET_HangHoa();
                            hhKM = hh.TimHH(eT_KhuyenMai.MaHH);
                            // Kiểm tra nếu sản phẩm đã có trong danh sách (dgvHangHoa)
                            var sanPhamTonTai_KM = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == eT_KhuyenMai.MaHH);

                            if (sanPhamTonTai_KM != null)
                            {
                                // Nếu sản phẩm đã tồn tại trong giỏ hàng, cập nhật số lượng và thành tiền
                                sanPhamTonTai_KM.SoLuong += soLuong;
                                sanPhamTonTai_KM.ThanhTien += 0; // Cộng dồn thành tiền
                            }
                            else
                            {
                                // Nếu sản phẩm chưa tồn tại trong giỏ hàng, thêm sản phẩm mới vào danh sách
                                ET_SanPhamThanhToan sanPhamKM = new ET_SanPhamThanhToan(hhKM.MaHH, hhKM.TenHH, 0, soLuong, null, 0);
                                danhSachSanPham.Add(sanPhamKM);
                            }
                            // Tính thành tiền
                            double thanhTien = donGia * soLuong; // Tính theo số lượng mua thực tế

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
                        }

                        // Cập nhật lại DataGridView với danh sách sản phẩm                    
                        bindingSourceSanPham.ResetBindings(false);

                        ShowTongTien();
                        cbbMaHang.SelectedIndex = 0;
                        txtTenHang.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        cbbKhuyenMai.SelectedIndex = -1;
                        txtThanhTien.Clear();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Có lỗi khi thêm sản phẩm: " + ex.Message, "Thông báo");
                    txtSoLuong.Focus();
                }
            }
        }

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHangHoa.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để thực hiện thao tác!", "Thông báo");
                    return;
                }
                int dong = dgvHangHoa.CurrentCell.RowIndex;
                if (dgvHangHoa.Rows[dong].Cells[4].Value == null)
                {
                    MessageBox.Show("Không thể sửa hoặc xóa sản phẩm khuyến mãi", "Thông báo");
                    return;
                }
                else
                {
                    cbbMaHang.Text = dgvHangHoa.Rows[dong].Cells[0].Value.ToString();
                    txtTenHang.Text = dgvHangHoa.Rows[dong].Cells[1].Value.ToString();
                    txtDonGia.Text = dgvHangHoa.Rows[dong].Cells[2].Value.ToString();
                    txtSoLuong.Text = dgvHangHoa.Rows[dong].Cells[3].Value.ToString();
                    cbbKhuyenMai.Text = dgvHangHoa.Rows[dong].Cells[4].Value.ToString();
                    txtThanhTien.Text = dgvHangHoa.Rows[dong].Cells[5].Value.ToString();
                    cbbMaHang.Enabled = false;
                    btnThem.Enabled = false;
                }
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
                        // Kiểm tra nếu sản phẩm này có khuyến mãi tặng kèm
                        var khuyenMai = cbbKhuyenMai.SelectedValue != null
                                        ? km.KM_TimMa(cbbKhuyenMai.SelectedValue.ToString())
                                        : null;

                        if (khuyenMai != null && khuyenMai.MaHH != null)
                        {
                            // Nếu có khuyến mãi tặng sản phẩm, tìm sản phẩm tặng kèm
                            var sanPhamTangKem = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == khuyenMai.MaHH);

                            if (sanPhamTangKem != null)
                            {
                                // Xóa sản phẩm tặng kèm khỏi danh sách
                                danhSachSanPham.Remove(sanPhamTangKem);
                            }
                        }

                        // Xóa sản phẩm chính khỏi danh sách
                        danhSachSanPham.Remove(sanPhamXoa);

                        // Cập nhật lại DataGridView
                        bindingSourceSanPham.ResetBindings(false);

                        // Cập nhật tổng tiền
                        ShowTongTien();

                        // Xóa các ô nhập liệu để cho biết sản phẩm đã bị xóa
                        cbbMaHang.SelectedIndex = 0;
                        txtTenHang.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        cbbKhuyenMai.SelectedIndex = -1;
                        txtThanhTien.Clear();
                        btnThem.Enabled = true;
                        cbbMaHang.Enabled = true;

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
                    if (dgvHangHoa.CurrentRow != null && txtSoLuong.Text != string.Empty && int.Parse(txtSoLuong.Text) != 0)
                    {
                        // Lấy thông tin từ dòng đang chọn trong DataGridView
                        string maHH = cbbMaHang.Text;
                        string tenHH = txtTenHang.Text;
                        int donGia = int.Parse(txtDonGia.Text);
                        int soLuong = int.Parse(txtSoLuong.Text);

                        // Tìm thông tin khuyến mãi
                        ET_KhuyenMai eT_KhuyenMai = new ET_KhuyenMai();
                        if (cbbKhuyenMai.SelectedValue == null)
                        {
                            eT_KhuyenMai.MaGiamGia = 0;
                            eT_KhuyenMai.MaHH = null;
                        }
                        else
                        {
                            eT_KhuyenMai = km.KM_TimMa(cbbKhuyenMai.SelectedValue.ToString());
                        }

                        int giamGia = Convert.ToInt32(eT_KhuyenMai.MaGiamGia); // Giá trị giảm giá (0: tặng sản phẩm)

                        // Tính thành tiền sản phẩm chính
                        double thanhTien = donGia * soLuong;
                        if (giamGia > 0)
                        {
                            thanhTien = donGia * soLuong * (1 - (giamGia / 100.0)); // Áp dụng giảm giá
                        }

                        string khuyenMai = cbbKhuyenMai.Text; // Lấy tên khuyến mãi từ combobox

                        // Tìm sản phẩm chính trong danh sách
                        var sanPhamCanSua = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == maHH);

                        if (sanPhamCanSua != null)
                        {
                            // Cập nhật thông tin sản phẩm chính
                            sanPhamCanSua.SoLuong = soLuong;
                            sanPhamCanSua.ThanhTien = thanhTien;
                            sanPhamCanSua.DonGia = donGia;
                            sanPhamCanSua.KhuyenMai = khuyenMai;

                            // Nếu có khuyến mãi tặng sản phẩm
                            if (eT_KhuyenMai.MaHH != null)
                            {
                                // Tìm sản phẩm tặng kèm
                                var sanPhamTangKem = danhSachSanPham.FirstOrDefault(sp => sp.MaHH == eT_KhuyenMai.MaHH);

                                if (sanPhamTangKem != null)
                                {
                                    // Cập nhật số lượng của sản phẩm tặng kèm
                                    sanPhamTangKem.SoLuong = soLuong; // Số lượng bằng với sản phẩm chính
                                    sanPhamTangKem.ThanhTien = 0; // Thành tiền của sản phẩm tặng kèm luôn là 0
                                }
                                else
                                {
                                    // Nếu sản phẩm tặng kèm chưa tồn tại, thêm mới
                                    ET_HangHoa hhKM = hh.TimHH(eT_KhuyenMai.MaHH);
                                    ET_SanPhamThanhToan sanPhamKM = new ET_SanPhamThanhToan(hhKM.MaHH, hhKM.TenHH, 0, soLuong, null, 0);
                                    danhSachSanPham.Add(sanPhamKM);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm cần sửa trong danh sách!", "Thông báo");
                        }

                        // Cập nhật lại DataGridView
                        bindingSourceSanPham.ResetBindings(false);
                        ShowTongTien();

                        // Xóa thông tin nhập sau khi sửa
                        cbbMaHang.SelectedIndex = 0;
                        txtTenHang.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        cbbKhuyenMai.SelectedIndex = -1;
                        txtThanhTien.Clear();
                        cbbMaHang.Enabled = true;
                        btnThem.Enabled = true;

                        MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn sản phẩm để sửa hoặc nhập số lượng hợp lệ!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi sửa sản phẩm: " + ex.Message, "Thông báo");
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
            txtTongTien.Text = tongTien.ToString(); // Định dạng hiển thị số có 2 chữ số thập phân
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                string maKH = txtMaKH.Text.Trim();
                if (string.IsNullOrEmpty(maKH))
                {
                    maKH = "KH000"; // Sử dụng mã khách hàng mặc định cho khách vãng lai
                }
                ET_HoaDon hoaDon = null;
                try
                {
                    // Bước 1: Tạo đối tượng ET_HoaDon từ thông tin trên form
                    hoaDon = new ET_HoaDon(
                        hd.AutoMa_HoaDon(),                   // Mã hóa đơn duy nhất
                        Program.maNS,
                        maKH,                                 // Lấy mã khách hàng từ textbox
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
                                int donGia = Convert.ToInt32(row.Cells["DonGia"].Value);
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
                                    soLuongMua,                    // Số lượng mua
                                    donGia
                                );

                                // Thêm chi tiết hóa đơn thông qua lớp BUS
                                BUS_CTHoaDon.Instance.themCTHoaDon(ctHoaDon);

                                // Cập nhật số lượng tồn mới trong CSDL
                                int soLuongMoi = soLuongTon - soLuongMua;
                                BUS_HangHoa.Instance.UpdateSoLuongTon(maHH, soLuongMoi);
                            }
                        }
                        
                        // Bước 4: Hiển thị thông báo thành công
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult re = MessageBox.Show("Bạn có muốn in hóa đơn?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (re == DialogResult.Yes)
                        {
                            Menu form = (Menu)this.ParentForm;
                            InHoaDon inHoaDonForm = new InHoaDon(hoaDon.MaHD);
                            form.openChildForm(inHoaDonForm);
                        }
                        dgvHangHoa.DataSource = null;
                        txtTongTien.Clear();
                        danhSachSanPham.Clear();
                        bindingSourceSanPham.Clear();
                        bindingSourceSanPham.DataSource = null; // Xóa liên kết hiện tại
                        bindingSourceSanPham.DataSource = danhSachSanPham; // Gắn lại danh sách trống
                        dgvHangHoa.DataSource = bindingSourceSanPham;

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
                cbbKhuyenMai.SelectedIndex = -1;
                txtThanhTien.Clear();
                dgvHangHoa.DataSource = null;
                txtTongTien.Clear();
                btnThem.Enabled = true;
                cbbMaHang.Enabled = true;
                danhSachSanPham.Clear();
                bindingSourceSanPham.Clear();

                bindingSourceSanPham.DataSource = null; // Xóa liên kết hiện tại
                bindingSourceSanPham.DataSource = danhSachSanPham; // Gắn lại danh sách trống
                dgvHangHoa.DataSource = bindingSourceSanPham;
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
                        ET_KhuyenMai eT_KhuyenMai = new ET_KhuyenMai();

                        // Lấy giá trị từ các TextBox
                        int donGia = int.Parse(txtDonGia.Text);
                        int soLuong = int.Parse(txtSoLuong.Text);

                        eT_KhuyenMai = km.KM_TimMa(cbbKhuyenMai.SelectedValue.ToString());
                        double thanhTien = donGia * soLuong;
                        // Nếu có giảm giá, tính lại thành tiền
                        if (eT_KhuyenMai.MaGiamGia > 0)
                        {
                            thanhTien = donGia * soLuong * (1 - (eT_KhuyenMai.MaGiamGia / 100.0));  // Áp dụng giảm giá theo phần trăm
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
                txtSoLuong.Clear();
                ET_HangHoa et = hh.TimHangHoaTheoMa(cbbMaHang.Text);
                if (et != null)
                {
                    txtTenHang.Text = et.TenHH;
                    txtDonGia.Text = et.GiaHH.ToString();
                    cbbKhuyenMai.DataSource = km.LoadKM_All();
                    cbbKhuyenMai.DataSource = null;
                    if (ctkm.CTKM_Load_Now(DateTime.Now, cbbMaHang.Text).Count() > 0)
                    {
                        List<ET_KhuyenMai> listKM = new List<ET_KhuyenMai>();
                        foreach (string ctkm_km in ctkm.CTKM_Load_Now(DateTime.Now, cbbMaHang.Text))
                        {
                            string ctkm_makm = ctkm_km.ToString();
                            ET_KhuyenMai km_ctkm = km.LoadKM_Now(DateTime.Now, ctkm_makm);
                            listKM.Add(km_ctkm);
                        }

                        cbbKhuyenMai.DataSource = listKM;
                        cbbKhuyenMai.DisplayMember = "TenKM";
                        cbbKhuyenMai.ValueMember = "MaKM";
                    }
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
