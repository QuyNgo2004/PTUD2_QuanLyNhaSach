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
    public partial class frmChiNhanh : Form
    {
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void them()
        {
            string maCN = txtMa.Text;
            string tenCN = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = mtbSDT.Text;
            string email = txtEmail.Text;
            string ghiChu = txtGhiChu.Text;
            ET_ChiNhanh chiNhanh = new ET_ChiNhanh(maCN, tenCN, diaChi, soDienThoai, email, ghiChu);
            BUS_ChiNhanh.Instance.themChiNhanh(chiNhanh);
            txtMa.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();
            txtMa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void xoa()
        {
            BUS_ChiNhanh.Instance.xoaChiNhanh(txtMa.Text);
            txtMa.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();
            txtMa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void sua()
        {
            string maCN = txtMa.Text;
            string tenCN = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = mtbSDT.Text;
            string email = txtEmail.Text;
            string ghiChu = txtGhiChu.Text;
            ET_ChiNhanh chiNhanh = new ET_ChiNhanh(maCN, tenCN, diaChi, soDienThoai, email, ghiChu);
            BUS_ChiNhanh.Instance.suaChiNhanh(chiNhanh);
            txtMa.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();
            txtMa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dar = MessageBox.Show("Bạn có muốn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dar == DialogResult.Yes)
                {
                    them();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvChiNhanh_Click(object sender, EventArgs e)
        {
            int dong = dgvChiNhanh.CurrentCell.RowIndex;
            txtMa.Text = dgvChiNhanh.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dgvChiNhanh.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvChiNhanh.Rows[dong].Cells[2].Value.ToString();
            mtbSDT.Text = dgvChiNhanh.Rows[dong].Cells[3].Value.ToString();
            txtEmail.Text = dgvChiNhanh.Rows[dong].Cells[4].Value.ToString();
            txtGhiChu.Text = dgvChiNhanh.Rows[dong].Cells[5].Value.ToString();
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dar = MessageBox.Show("Bạn có muốn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dar == DialogResult.Yes)
                {
                    xoa();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dar = MessageBox.Show("Bạn có muốn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dar == DialogResult.Yes)
                {
                    sua();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
