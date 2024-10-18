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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private Menu mainForm;

        public KhachHang(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
        }

        private void dgvDSKH_Click(object sender, EventArgs e)
        {
            int a = dgvDSKH.CurrentCell.RowIndex;

            txtMaKH.Text = dgvDSKH.Rows[a].Cells[0].Value?.ToString() ?? "";

            txtTenKH.Text = dgvDSKH.Rows[a].Cells[1].Value?.ToString() ?? "";

            if (DateTime.TryParse(dgvDSKH.Rows[a].Cells[2].Value?.ToString(), out DateTime birthDate))
            {
                if (birthDate < dtpNgaySinh.MinDate || birthDate > dtpNgaySinh.MaxDate)
                {
                    dtpNgaySinh.Value = DateTime.Today; // Set to current date or any valid date
                }
                else
                {
                    dtpNgaySinh.Value = birthDate; // Only set this if within valid range
                }
            }
            else
            {
                dtpNgaySinh.Value = DateTime.Today; // or any default value if parsing fails
            }

            string gender = dgvDSKH.Rows[a].Cells[3].Value?.ToString();
            radNam.Checked = (gender == radNam.Text);
            radNu.Checked = (gender == radNu.Text);

            txtDiaChi.Text = dgvDSKH.Rows[a].Cells[4].Value?.ToString() ?? "";
            mtbSDT.Text = dgvDSKH.Rows[a].Cells[5].Value?.ToString() ?? "";
            txtEmail.Text = dgvDSKH.Rows[a].Cells[6].Value?.ToString() ?? "";
        }

        public bool KTraMa(string maBN)
        {
            if (maBN.Equals(dgvDSKH.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaKH.Text.Length == 0 || txtTenKH.Text.Length == 0 || txtDiaChi.Text.Length == 0 || mtbSDT.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        public string layGioiTinh()
        {
            string gtinh = string.Empty;
            if (radNam.Checked == true)
            {
                gtinh = radNam.Text;
            }
            else
            {
                gtinh = radNu.Text;
            }
            return gtinh;
        }

        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Thêm khách hàng.
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_KhachHang.Instance.ThemKhachHang(new ET_KhachHang(txtMaKH.Text, txtTenKH.Text, dtpNgaySinh.Value, layGioiTinh(), txtDiaChi.Text, mtbSDT.Text, txtEmail.Text));
                    BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Xóa khách hàng.

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_KhachHang.Instance.XoaKhachHang(dgvDSKH);
                    BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sửa khách hàng.

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaKH.Text) == true)
                        {
                            BUS_KhachHang.Instance.SuaKhachHang(new ET_KhachHang(txtMaKH.Text, txtTenKH.Text, dtpNgaySinh.Value, layGioiTinh(), txtDiaChi.Text, mtbSDT.Text, txtEmail.Text));
                            BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã khách hàng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaKH.Text = dgvDSKH.CurrentRow.Cells[0].Value.ToString();
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


        //Thoát khỏi màn hình khách hàng.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
