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
    public partial class NhaPhanPhoi : Form
    {
        public NhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void NhaPhanPhoi_Load(object sender, EventArgs e)
        {
            BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void them()
        {
            string maNPP = txtMaNPP.Text;
            string tenNPP = txtTenNPP.Text;
            string diachiNPP = txtDiaChi.Text;
            string sdtNPP = txtSDT.Text;
            string emailNPP = txtEmail.Text;
            ET_NhaPhanPhoi nhaPhanPhoi = new ET_NhaPhanPhoi(maNPP, tenNPP, diachiNPP, sdtNPP, emailNPP);
            BUS_NhaPhanPhoi.Instance.themNhaPhanPhoi(nhaPhanPhoi);
            txtMaNPP.Clear();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMaNPP.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        private void xoa()
        {
            BUS_NhaPhanPhoi.Instance.xoaNhaPhanPhoi(txtMaNPP.Text);
            txtMaNPP.Clear();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMaNPP.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        private void sua()
        {
            string maNPP = txtMaNPP.Text;
            string tenNPP = txtTenNPP.Text;
            string diachiNPP = txtDiaChi.Text;
            string sdtNPP = txtSDT.Text;
            string emailNPP = txtEmail.Text;
            ET_NhaPhanPhoi nhaPhanPhoi = new ET_NhaPhanPhoi(maNPP, tenNPP, diachiNPP, sdtNPP, emailNPP);
            BUS_NhaPhanPhoi.Instance.suaNhaPhanPhoi(nhaPhanPhoi);
            txtMaNPP.Clear();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMaNPP.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
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
                    BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                    BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
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
                    BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNPP.Clear();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMaNPP.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
    }
}
