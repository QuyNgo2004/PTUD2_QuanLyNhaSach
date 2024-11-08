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
    public partial class HangHoa : Form
    {
        private BUS_LoaiHangHoa lhh = BUS_LoaiHangHoa.Instance;
        private BUS_NhaPhanPhoi npp = BUS_NhaPhanPhoi.Instance;
        public HangHoa()
        {
            InitializeComponent();
        }

        private Menu mainForm;

        public HangHoa(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
            txtMaHH.Text = BUS_HangHoa.Instance.TaoMaHangTuDong();

            try
            {

                cboLoaiHH.DataSource = lhh.LoadDSloaiHH();
                cboNhaPP.DataSource = npp.loadnpp();
                cboLoaiHH.DisplayMember = "tenLHH";
                cboLoaiHH.ValueMember = "maLHH";
                cboNhaPP.ValueMember = "maNPP";
                cboNhaPP.DisplayMember = "tenNPP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dgvDSHangHoa_Click(object sender, EventArgs e)
        {
            int a = dgvDSHangHoa.CurrentCell.RowIndex;

            txtMaHH.Text = dgvDSHangHoa.Rows[a].Cells[0].Value?.ToString() ?? "";
            txtTenHH.Text = dgvDSHangHoa.Rows[a].Cells[1].Value?.ToString() ?? "";
            cboLoaiHH.Text = dgvDSHangHoa.Rows[a].Cells[2].Value?.ToString() ?? "";
            txtGiaHH.Text = dgvDSHangHoa.Rows[a].Cells[3].Value?.ToString() ?? "";
            txtDonViTinh.Text = dgvDSHangHoa.Rows[a].Cells[4].Value?.ToString() ?? "";
            txtSoLuongTon.Text = dgvDSHangHoa.Rows[a].Cells[5].Value?.ToString() ?? "";
            cboNhaPP.Text = dgvDSHangHoa.Rows[a].Cells[6].Value?.ToString() ?? "";
            txtTacGia.Text = dgvDSHangHoa.Rows[a].Cells[7].Value?.ToString() ?? "";
            txtMoTa.Text = dgvDSHangHoa.Rows[a].Cells[8].Value?.ToString() ?? "";
            txtGhiChu.Text = dgvDSHangHoa.Rows[a].Cells[9].Value?.ToString() ?? "";
            cboTinhTrang.Text = dgvDSHangHoa.Rows[a].Cells[10].Value?.ToString() ?? "";
        }

        public bool KTraMa(string maLHH)
        {
            if (maLHH.Equals(dgvDSHangHoa.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaHH.Text.Length == 0 || txtTenHH.Text.Length == 0 || txtGiaHH.Text.Length == 0 || txtDonViTinh.Text.Length == 0 || txtSoLuongTon.Text.Length == 0 || txtGhiChu.Text.Length == 0 || txtMoTa.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnThemLHH_Click(object sender, EventArgs e)
        {
            //Menu formMenu = (Menu)this.ParentForm;
            //formMenu.openChildForm(new LoaiHangHoa());

            LoaiHangHoa lhh = new LoaiHangHoa();
            lhh.Show();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHH.Text = BUS_HangHoa.Instance.TaoMaHangTuDong();
            txtTenHH.Clear();
            if (cboLoaiHH.Items.Count > 0) // Kiểm tra nếu có item trong ComboBox
            {
                cboLoaiHH.SelectedIndex = 0; // Thiết lập item đầu tiên làm item được chọn
            }
            txtGiaHH.Clear();
            txtDonViTinh.Clear();
            txtSoLuongTon.Clear();
            if (cboNhaPP.Items.Count > 0)
            {
                cboNhaPP.SelectedIndex = 0;
            }
            txtGhiChu.Clear();
            txtMoTa.Clear();
            if (cboTinhTrang.Items.Count > 0)
            {
                cboTinhTrang.SelectedIndex = 0;
            }
        }

        private void btnTroLaiNhapHang_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_HangHoa.Instance.ThemHangHoa(new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboLoaiHH.SelectedValue.ToString(), int.Parse(txtGiaHH.Text), txtDonViTinh.Text, int.Parse(txtSoLuongTon.Text), cboNhaPP.SelectedValue.ToString(), txtTacGia.Text, txtGhiChu.Text, txtMoTa.Text, cboTinhTrang.Text));
                    BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHangHoa.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_HangHoa.Instance.XoaHangHoa(dgvDSHangHoa);
                    BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSHangHoa.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaHH.Text) == true)
                        {
                            BUS_HangHoa.Instance.SuaHangHoa(new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboLoaiHH.SelectedValue.ToString(), int.Parse(txtGiaHH.Text), txtDonViTinh.Text, int.Parse(txtSoLuongTon.Text), cboNhaPP.SelectedValue.ToString(), txtTacGia.Text, txtGhiChu.Text, txtMoTa.Text, cboTinhTrang.Text));
                            BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã loại hàng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaHH.Text = dgvDSHangHoa.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtTenHH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar != '\b' && txtTenHH.Text.Trim().Length == 0 && !char.IsLetter(e.KeyChar))
            {
                // Nếu chưa có ký tự chữ nào
                e.Handled = true;
                MessageBox.Show("Tên khách hàng phải chứa ít nhất một ký tự chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenHH.Text.Length > 44 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên khách hàng quá 45 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtGiaHH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDonViTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenHH.Text.Length > 16 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập đơn vị tính quá 15 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenHH.Text.Trim().Length == 0 && e.KeyChar == ' ')
            {
                // Ngăn không cho nhập khoảng trắng đầu tiên
                e.Handled = true;
                MessageBox.Show("Tên hàng hóa không được chỉ là khoảng trắng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGiaHH_Validated(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox và chuyển đổi sang số
            if (decimal.TryParse(txtGiaHH.Text, out decimal gia))
            {
                // Kiểm tra giá trị trong khoảng 1000 đến 1.000.000
                if (gia < 1000 || gia > 10000000)
                {
                    MessageBox.Show("Giá hàng hóa phải lớn hơn 1.000 VND và nhỏ hơn 1000000 VND.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiaHH.Focus(); // Đặt lại tiêu điểm vào TextBox
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị hợp lệ.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaHH.Focus(); // Đặt lại tiêu điểm vào TextBox
            }
        }

        private void txtSoLuongTon_Validated(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSoLuongTon.Text, out decimal soLuong))
            {
                if (soLuong == 0)
                {
                    // Đặt ComboBox mặc định là "Hết hàng"
                    cboTinhTrang.SelectedItem = "Hết hàng";
                    MessageBox.Show("Vì số lượng hàng bạn nhập là 0, trạng thái hàng hóa đã được tự động mặc định thành 'Hết hàng'.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (soLuong < 1 || soLuong > 50)
                {
                    MessageBox.Show("Số lượng hàng hóa phải lớn hơn 1 và nhỏ hơn 59.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuongTon.Focus();
                }
                else
                {
                    // Nếu số lượng hợp lệ, đặt trạng thái về "Còn hàng"
                    cboTinhTrang.SelectedItem = "Còn hàng"; // Hoặc cboTinhTrang.SelectedIndex = 1; nếu "Còn hàng" là mục thứ hai
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị hợp lệ.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongTon.Focus();
            }
        }

        private void txtMoTa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMoTa.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 150 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar != '\b' && txtGhiChu.Text.Trim().Length == 0 && !char.IsLetterOrDigit(e.KeyChar))
            {
                // Nếu chưa có ký tự chữ nào
                e.Handled = true;
                MessageBox.Show("Địa chỉ phải chứa ít nhất một ký tự chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGhiChu.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 150 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenHH_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                MessageBox.Show("Tên hàng hóa không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHH.Focus();
            }
        }

        private void txtDonViTinh_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonViTinh.Text))
            {
                MessageBox.Show("Tên hàng hóa không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonViTinh.Focus();
            }
        }

        private void txtTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra ký tự nhập vào
            if (char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTacGia.Text.Length >= 44 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tác giả quá 45 ký tự!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTacGia.Text.Trim().Length == 0 && e.KeyChar == ' ')
            {
                // Ngăn không cho nhập khoảng trắng đầu tiên
                e.Handled = true;
                MessageBox.Show("Tác giả không được chỉ là khoảng trắng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTacGia_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                MessageBox.Show("Tác giả không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHH.Focus();
            }
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinhTrang.SelectedItem != null && cboTinhTrang.SelectedItem.ToString() == "Hết hàng")
            {
                txtSoLuongTon.Text = "0";
                MessageBox.Show("Vì trạng thái hàng hóa của bạn là hết hàng, số lượng tồn được tự động mặc định trở về 0.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
