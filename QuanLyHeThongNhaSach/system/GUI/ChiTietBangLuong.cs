﻿using BUS;
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
                cboNS.DataSource = ns.hienThiNhanSu(ET_ns.MaCN);
                cboNS.DisplayMember = "Họ_Tên";
                cboNS.ValueMember = "Mã";
                dtpNgayBD.Value = dtpNgayBD.Value.AddDays(-30);
                dtpNgayKT.Value = dtpNgayKT.Value.AddDays(-1);
                txtNgayNghi.Text = "0";
                txtNgayNghi_Validated(sender, e);
                cboNS_SelectedIndexChanged(sender, e);


                bindingSourceLuong.DataSource = danhSachLuong;
                dgvLuong.DataSource = bindingSourceLuong;
                dgvLuong.AutoGenerateColumns = true;
                if(danhSachLuong != null)
                {
                    txtMaLuong.Text = string.Empty;
                    dgvLuong.Columns["MaBangLuong"].Visible = false;
                    dtpNgayBD.Enabled = true;
                    dtpNgayKT.Enabled = true;
                }
            }
            catch (Exception ex) { }
        }
        private void TinhLuong()
        {
            if(txtLuongTheoNgay.Text != string.Empty)
            {
                int luong = int.Parse(txtLuongTheoNgay.Text) * ( int.Parse(txtNgayLam.Text) - int.Parse(txtNgayNghi.Text));
                txtTienLuong.Text = luong.ToString();
            }
        }
        private void txtNgayNghi_Validated(object sender, EventArgs e)
        {
            int soNgayNghi = 0;
            if (int.TryParse(txtNgayNghi.Text, out soNgayNghi))
            {
                // Trừ số ngày nghỉ vào số ngày làm việc
                ngayLam = (dtpNgayKT.Value - dtpNgayBD.Value);
                ngayLam = ngayLam.Add(TimeSpan.FromDays(-soNgayNghi));
                txtNgayLam.Text = ngayLam.Days.ToString();
                TinhLuong();
            }
            else
            {
                MessageBox.Show("Tiền lương không hợp lệ!");
            }
            
        }

        private void cboNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaNS.Text = (string)cboNS.SelectedValue;
            }
            catch (Exception ex) { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var NSTonTai = danhSachLuong.FirstOrDefault(sp => sp.MaNS == txtMaNS.Text);

                if (NSTonTai != null)
                {
                    // Nếu sản phẩm đã tồn tại, tăng số lượng và cập nhật thành tiền
                    //NSTonTai.SoLuong += soLuong;
                    //NSTonTai.ThanhTien = sanPhamTonTai.DonGia * sanPhamTonTai.SoLuong;
                }
                else
                {
                    // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới vào danh sách
                    ET_ChiTietLuong LuongMoi = new ET_ChiTietLuong
                    {
                        MaNS = txtMaNS.Text,
                        TenNS = cboNS.Text,
                        LuongTheoNgay = int.Parse(txtLuongTheoNgay.Text),
                        NgayNghi = int.Parse(txtNgayNghi.Text),
                        NgayLam = int.Parse(txtNgayLam.Text),
                        TienLuong = int.Parse(txtTienLuong.Text),
                    };
                    danhSachLuong.Add(LuongMoi);
                    dtpNgayBD.Enabled = false;
                    dtpNgayKT.Enabled = false;
                }
                bindingSourceLuong.ResetBindings(false);
                Load_CTLuong(sender, e);
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
        private void Load_CTLuong(object sender, EventArgs e)
        {
            cboNS.SelectedIndex = 0;
            txtLuongTheoNgay.Clear();
            txtNgayNghi.Text = "0";
            cboNS_SelectedIndexChanged(sender, e);
            txtNgayNghi_Validated(sender, e);
        }
        private void Load_CTLuong()
        {
            cboNS.SelectedIndex = 0;
            txtLuongTheoNgay.Clear();
            txtNgayNghi.Clear();
        }

        private void dgvLuong_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLuong.CurrentCell.RowIndex;
                txtMaNS.Text = dgvLuong.Rows[dong].Cells[1].Value.ToString();
                cboNS.SelectedIndex = cboNS.FindString(dgvLuong.Rows[dong].Cells[2].Value.ToString());
                txtLuongTheoNgay.Text = dgvLuong.Rows[dong].Cells[3].Value.ToString();
                txtNgayNghi.Text = dgvLuong.Rows[dong].Cells[4].Value.ToString();
                txtNgayNghi_Validated(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi chọn dòng dữ liệu" + ex.Message);
            }
        }

        private void txtLuongTheoNgay_Validated(object sender, EventArgs e)
        {
            int luongTheoNgay = 0;
            if (int.TryParse(txtLuongTheoNgay.Text, out luongTheoNgay))
            {
                TinhLuong();
            }
            else
            {
                MessageBox.Show("Số ngày nghỉ không hợp lệ!");
                txtLuongTheoNgay.Text = "0";
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
                        luongSua.LuongTheoNgay = int.Parse(txtLuongTheoNgay.Text);
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
            Load_CTLuong(sender, e);
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
                        for (int i = 0; i < dgvLuong.Rows.Count; i++)
                        {
                            ET_ChiTietLuong LuongMoi = new ET_ChiTietLuong
                            {
                                MaNS = txtMaNS.Text,
                                MaBangLuong = txtMaLuong.Text,
                                LuongTheoNgay = int.Parse(dgvLuong.Rows[i].Cells[3].Value?.ToString() ?? "0"), // Dùng giá trị mặc định nếu null
                                NgayLam = int.Parse(dgvLuong.Rows[i].Cells[5].Value?.ToString() ?? "0"), // Dùng chuỗi rỗng nếu null
                                NgayNghi = int.Parse(dgvLuong.Rows[i].Cells[4].Value?.ToString() ?? "0"), // Dùng chuỗi rỗng nếu null
                                TienLuong = int.Parse(dgvLuong.Rows[i].Cells[6].Value?.ToString() ?? "0") // Dùng giá trị mặc định nếu null
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
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChiTietBangLuong_Load(sender, e);
                        Load_CTLuong(sender, e);
                        
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
    }
}