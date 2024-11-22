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
    public partial class ChiTietBangLuong : Form
    {
        private BUS_NhanSu ns = BUS_NhanSu.Instance;
        private BUS_BatLoi error = new BUS_BatLoi();
        private BUS_BangLuong bl =BUS_BangLuong.Instance;
        private ET_NhanSu ET_ns = null;
        private TimeSpan ngayLam = new TimeSpan();
        private List<ET_ChiTietLuong> danhSachLuong = new List<ET_ChiTietLuong>();
        private BindingSource bindingSourceLuong = new BindingSource();
        
        public ChiTietBangLuong(ET_NhanSu ET_ns)
        {
            InitializeComponent();
            txtMaQL.Text = ET_ns.MaNS;
            txtTenQL.Text = ET_ns.TenNS;
            this.ET_ns = ET_ns;
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            //TinhLuong();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChiTietBangLuong_Load(object sender, EventArgs e)
        {
            try
            {
                
                //cboNS.DisplayMember = "Họ_Tên";
                //cboNS.ValueMember = "Mã";
                dtpNgayBD.Value = dtpNgayBD.Value.AddDays(-30);
                dtpNgayKT.Value = dtpNgayKT.Value.AddDays(-1);
                txtNgayNghi.Text = "0";
                txtNgayNghi_Validated(sender, e);
                cboNS_SelectedIndexChanged(sender, e);
                txtMaLuong.Text = dtpNgayBD.Text + "_" + dtpNgayKT.Text + "_" + bl.XemBangLuong().Count();



                // Xet ngay
                dtpLuong_ValueChanged(sender, e);
                danhSachLuong = ns.hienThiNhanSu_Luong(ET_ns.MaCN);
                bindingSourceLuong.DataSource = danhSachLuong;
                dgvLuong.DataSource = bindingSourceLuong;
                //dgvLuong.AutoGenerateColumns = true;
                //if(danhSachLuong != null)
                //{

                //    dgvLuong.Columns["MaBangLuong"].Visible = false;
                //    dtpNgayBD.Enabled = true;
                //    dtpNgayKT.Enabled = true;
                //}
            }
            catch (Exception ex) { }
        }
        private void TinhLuong()
        {
            
                int luong = int.Parse(txtLuongCB.Text) /  int.Parse(txtNgayLam.Text) * ( int.Parse(txtNgayLam.Text) - int.Parse(txtNgayNghi.Text)) + (int.Parse(txtLuongCB.Text) / int.Parse(txtNgayLam.Text) * int.Parse(cboLuongTC.Text) *2 ) ;
                txtTienLuong.Text = luong.ToString();
            
        }
        private void txtNgayNghi_Validated(object sender, EventArgs e)
        {
            //int soNgayNghi = 0;
            //if (int.TryParse(txtNgayNghi.Text, out soNgayNghi))
            //{

            //    try
            //    {
            //        // Trừ số ngày nghỉ vào số ngày làm việc
            //        ngayLam = (dtpNgayKT.Value - dtpNgayBD.Value);
            //        ngayLam = ngayLam.Add(TimeSpan.FromDays(-soNgayNghi));
            //        txtNgayLam.Text = ngayLam.Days.ToString();
            //        if (int.Parse(txtNgayLam.Text) >= 0)
            //        {
            //            TinhLuong();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Có lỗi xảy ra: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
                   
            //    }catch (Exception ex) {
            //        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Tiền lương không hợp lệ!");
            //}
            
        }

        private void cboNS_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    try
        //    {
        //        txtMaNS.Text = (string)cboNS.SelectedValue;
        //    }
        //    catch (Exception ex) { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var NSTonTai = danhSachLuong.FirstOrDefault(sp => sp.MaNS == txtMaNS.Text);

            //    if (NSTonTai != null)
            //    {
            //        // Nếu sản phẩm đã tồn tại, tăng số lượng và cập nhật thành tiền
            //        //NSTonTai.SoLuong += soLuong;
            //        //NSTonTai.ThanhTien = sanPhamTonTai.DonGia * sanPhamTonTai.SoLuong;
            //    }
            //    else
            //    {
            //        // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới vào danh sách
            //        ET_ChiTietLuong LuongMoi = new ET_ChiTietLuong
            //        {
            //            MaNS = txtMaNS.Text,
            //            //TenNS = cboNS.Text,
            //            LuongTheoNgay = int.Parse(cboLuongTC.Text),
            //            NgayNghi = int.Parse(txtNgayNghi.Text),
            //            NgayLam = int.Parse(txtNgayLam.Text),
            //            TienLuong = int.Parse(txtTienLuong.Text),
            //        };
            //        danhSachLuong.Add(LuongMoi);
            //        dtpNgayBD.Enabled = false;
            //        dtpNgayKT.Enabled = false;
            //    }
            //    bindingSourceLuong.ResetBindings(false);
            //    Load_CTLuong(sender, e);
            //}catch(Exception ex)
            //{
            //    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
           
        }
        private void Load_CTLuong(object sender, EventArgs e)
        {
            //cboNS.SelectedIndex = 0;
            txtNgayNghi.Text = "0";
            cboNS_SelectedIndexChanged(sender, e);
            txtNgayNghi_Validated(sender, e);
        }
        private void Load_CTLuong()
        {
            //cboNS.SelectedIndex = 0;
            //txtLuongTheoNgay.Clear();
            txtNgayNghi.Clear();
        }

        private void dgvLuong_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLuong.CurrentCell.RowIndex;
                txtMaNS.Text = dgvLuong.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dgvLuong.Rows[dong].Cells[1].Value.ToString();
                txtLuongCB.Text = dgvLuong.Rows[dong].Cells[3].Value.ToString();
                cboLuongTC.SelectedIndex = cboLuongTC.FindString(dgvLuong.Rows[dong].Cells[6].Value.ToString());
                txtNgayLam.Text = dgvLuong.Rows[dong].Cells[4].Value.ToString();
                txtNgayNghi.Text = dgvLuong.Rows[dong].Cells[5].Value.ToString();
                txtTienLuong.Text = dgvLuong.Rows[dong].Cells[7].Value.ToString();
                //txtNgayNghi_Validated(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi chọn dòng dữ liệu" + ex.Message);
            }
        }

        private void txtLuongTheoNgay_Validated(object sender, EventArgs e)
        {
            int luongTheoNgay = 0;
            if (int.TryParse(txtNgayNghi.Text, out luongTheoNgay) && int.Parse(txtNgayNghi.Text) < 26)
            {
                TinhLuong();
            }
            else 
            {
                MessageBox.Show("Số ngày nghỉ không hợp lệ!");
                txtNgayNghi.Text = "0";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn sửa tiền lương nhân sự đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                try
                {
                    // Lấy mã hàng hóa của sản phẩm cần sửa
                    string maNS = txtMaNS.Text;

                    // Tìm sản phẩm trong danh sách dựa trên mã hàng hóa
                    var luongSua = danhSachLuong.FirstOrDefault(sp => sp.MaNS == maNS);

                    if (luongSua != null)
                    {
                        // Cập nhật thông tin sản phẩm dựa trên dữ liệu từ các TextBox
                        luongSua.NgayTC = int.Parse(cboLuongTC.Text);
                        luongSua.NgayNghi = int.Parse(txtNgayNghi.Text);
                        
                        luongSua.TienLuong = int.Parse(txtTienLuong.Text);

                        // Cập nhật lại DataGridView
                        bindingSourceLuong.ResetBindings(false);

                        Load_CTLuong(sender, e);

                        MessageBox.Show("Cập nhật tiền lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân sự để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật tiền lương nhân sự: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn xóa tiền lương nhân sự đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                try
                {
                    string maNS = txtMaNS.Text;

                    // Tìm sản phẩm trong danh sách dựa trên mã hàng hóa
                    var luongXoa = danhSachLuong.FirstOrDefault(sp => sp.MaNS == maNS);

                    if (luongXoa != null)
                    {
                        // Xóa sản phẩm khỏi danh sách
                        danhSachLuong.Remove(luongXoa);

                        // Cập nhật lại DataGridView
                        bindingSourceLuong.ResetBindings(false);

                        Load_CTLuong(sender, e);

                        MessageBox.Show("Đã xóa tiền lương nhân sự thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(danhSachLuong.Count == 0)
                        {
                            dtpNgayBD.Enabled =true;
                            dtpNgayKT.Enabled =true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tiền lương nhân sự để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLuong.Text = dtpNgayBD.Text +"_"+ dtpNgayKT.Text + "_" +bl.XemBangLuong().Count();
            Load_CTLuong(sender, e);
        }
        public void TaoMaTuDong()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dar = MessageBox.Show("Bạn có muốn lưu bảng lương không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                ET_BangLuong bangLuong = null;
                try
                {
                    // Bước 1: Tạo đối tượng ET_HoaDon từ thông tin trên form
                    bangLuong = new ET_BangLuong {
                        MaBangLuong = txtMaLuong.Text,
                        MaQL = txtMaQL.Text,
                        NgayBD = DateTime.Parse(dtpNgayBD.Value.ToString()),
                        NgayKT = DateTime.Parse(dtpNgayKT.Value.ToString()),
                    };
                        

                    //MessageBox.Show(hoaDon.MaHD);
                    // Bước 2: Thêm hóa đơn thông qua lớp BUS
                    bool bangLuongAdd = BUS_BangLuong.Instance.ThemBangLuong(bangLuong);

                    if (bangLuongAdd)
                    {
                        // Bước 3: Nếu hóa đơn được thêm thành công, thêm các chi tiết hóa đơn
                        for (int i = 0; i < dgvLuong.Rows.Count - 1; i++)
                        {
                            ET_ChiTietLuong LuongMoi = new ET_ChiTietLuong
                            {

                                MaBangLuong = txtMaLuong.Text,
                                //NgayLam = int.Parse(dgvLuong.Rows[i].Cells[4].Value?.ToString() ?? "0"), // Dùng chuỗi rỗng nếu null
                                //NgayNghi = int.Parse(dgvLuong.Rows[i].Cells[5].Value?.ToString() ?? "0"), // Dùng chuỗi rỗng nếu null
                                //TienLuong = int.Parse(dgvLuong.Rows[i].Cells[7].Value?.ToString() ?? "0") // Dùng giá trị mặc định nếu null

                                MaNS = dgvLuong.Rows[i].Cells[0].Value.ToString(),
                                TenNS = dgvLuong.Rows[i].Cells[1].Value.ToString(),
                                LuongCB = int.Parse(dgvLuong.Rows[i].Cells[3].Value.ToString()),
                                NgayTC = int.Parse(dgvLuong.Rows[i].Cells[6].Value.ToString() ?? "0"),
                                NgayLam = int.Parse(dgvLuong.Rows[i].Cells[4].Value.ToString() ?? "0"),
                                NgayNghi = int.Parse(dgvLuong.Rows[i].Cells[5].Value.ToString() ?? "0"),
                                TienLuong = int.Parse(dgvLuong.Rows[i].Cells[7].Value.ToString() ?? "0") 
                            };
                        
                            if (BUS_ChiTietLuong.Instance.ThemBangLuong(LuongMoi) == true) { }
                            else
                            {
                                MessageBox.Show("Lỗi khi thêm lương nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        dgvLuong.DataSource = null;
                        danhSachLuong = null;
                        // Bước 4: Hiển thị thông báo thành công
                        MessageBox.Show("Lưu bảng lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChiTietBangLuong_Load(sender, e);
                        btnLamMoi_Click(sender, e);
                        
                    }

                    else
                    {
                        MessageBox.Show("Lỗi khi lưu bảng lương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnLSHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new LichSuTinhLuong(ET_ns));
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Không thể mở lịch sử nhập hàng");
            }
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            if (error.KT_Ngay(dtpNgayBD.Value, dtpNgayKT.Value) == false)
            {
                MessageBox.Show("Ngày bắt đầu nhỏ hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayBD.Value = DateTime.Now.AddDays(-30);
                dtpNgayKT.Value = DateTime.Now.AddDays(-1);
            }
            else if (error.KT_Ngay(dtpNgayKT.Value, DateTime.Now) == false)
            {
                MessageBox.Show("Ngày chưa diễn ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayKT.Value = DateTime.Now.AddDays(-1);
            }
            txtMaLuong.Text = dtpNgayBD.Text + "_" + dtpNgayKT.Text + "_" + bl.XemBangLuong().Count();
            //txtNgayNghi_Validated(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpLuong_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayBD.Value = new DateTime(dtpLuong.Value.Year, dtpLuong.Value.Month, 1);
            
            if (dtpLuong.Value.Month == 12 )
            {
                dtpNgayKT.Value = new DateTime(dtpLuong.Value.Year, 12,31);
            }
            else
            {
                dtpNgayKT.Value = new DateTime(dtpLuong.Value.Year, dtpLuong.Value.Month + 1, 1).AddDays(-1);
            }
        }
    }
}
