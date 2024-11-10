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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietKhuyenMai : Form
    {
        BUS_KhuyenMai km = BUS_KhuyenMai.Instance;
        BUS_HangHoa hh =  BUS_HangHoa.Instance;
        BUS_ChiTietKhuyenMai ctKhuyenMai = BUS_ChiTietKhuyenMai.Instance;
        BUS_BatLoi error = new BUS_BatLoi();
        private DateTime ngayHT = DateTime.Now;
        private int maCTHD;
        public ChiTietKhuyenMai()
        {
            InitializeComponent();
        }
        // Load form
        private void Load_Frm()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            dgvDSKhuyenMai.DataSource = ctKhuyenMai.CTKM_Load_All();
            cboKhuyenMai.DataSource = km.LoadKM_Now(ngayHT);
            cboKhuyenMai.ValueMember = "Mã";
            cboKhuyenMai.DisplayMember = "TenKM";
            maCTHD = 0;
            // Ẩn cột "MaHH"
            dgvDSKhuyenMai.Columns["MaHH"].Visible = false;
            dgvDSKhuyenMai.Columns["MaCT"].Visible = false;
            dgvDSKhuyenMai.Columns["MaKM"].Visible = false;
            //cboKhuyenMai.SelectedIndex = 0;
            //if(km.LoadKM_Now(ngayHT).Count() <= 0)
            //{
            //    Menu formMenu = (Menu)this.ParentForm;
            //    formMenu.openChildForm(new KhuyenMai());
            //}
        }
        private void lblCaTruc_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa khuyến mãi cho sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (KT_DieuKien() == true)
                    {
                        if (ctKhuyenMai.sua_CTKM(maCTHD, cboKhuyenMai.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Sửa khuyến mãi cho sản phẩm này thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa khuyến mãi cho sản phẩm này không thành công!\n "+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new KhuyenMai());
            this.Close();
        }

        private void cboCaTruc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ET_KhuyenMai khuyenMai = km.KM_TimMa(cboKhuyenMai.SelectedValue.ToString());
            if(khuyenMai != null)
            {
                txtGhiChu.Text = khuyenMai.GhiChu;
            }

        }

        private void ChiTietKhuyenMai_Load(object sender, EventArgs e)
        {
            Load_Frm();
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thêm khuyến mãi cho sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (KT_DieuKien() == true)
                    {
                        if (ctKhuyenMai.Them_CTKM(txtMaHH.Text, cboKhuyenMai.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Thêm khuyến mãi cho sản phẩm này thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm khuyến mãi cho sản phẩm này không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm khuyến mãi cho sản phẩm này không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaHH_Validated(object sender, EventArgs e)
        {
            ET_HangHoa hangHoa = hh.TimHangHoaTheoMa(txtMaHH.Text);
            if (hangHoa != null)
            {
                txtTenHH.Text = hangHoa.TenHH;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm này!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KT_DieuKien()
        {
            bool flag = true;
            ET_HangHoa hangHoa = hh.TimHangHoaTheoMa(txtMaHH.Text);
            if (km.LoadKM_Now(ngayHT).Count() <= 0)
            {
                flag = false;
                MessageBox.Show("Không tìm thấy khuyến mãi để thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(hangHoa == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm để thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        private void dgvDSKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvDSKhuyenMai.CurrentCell.RowIndex;
                maCTHD = int.Parse(dgvDSKhuyenMai.Rows[dong].Cells[0].Value.ToString());
                txtMaHH.Text = dgvDSKhuyenMai.Rows[dong].Cells[1].Value.ToString();
                txtTenHH.Text = dgvDSKhuyenMai.Rows[dong].Cells[2].Value.ToString();
                cboKhuyenMai.SelectedIndex = cboKhuyenMai.FindString(dgvDSKhuyenMai.Rows[dong].Cells[4].Value.ToString());
                cboCaTruc_SelectedIndexChanged(sender, e);
                txtMaHH.Enabled = false;
            }
            catch (Exception ex) { }
        }

        private void cbXemKM_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của checkbox
            if (cbXemKM.Checked)
            {
                // Nếu checkbox được chọn, tải tất cả khuyến mại
                dgvDSKhuyenMai.DataSource = ctKhuyenMai.CTKM_Load_All();
            }
            else
            {
                // Nếu không được chọn, tải khuyến mại hiện tại
                dgvDSKhuyenMai.Refresh(); // Làm mới DataGridView nếu cần
                dgvDSKhuyenMai.DataSource = ctKhuyenMai.CTKM_Load_Now(ngayHT);
            }

            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHH.Enabled = true;
            Load_Frm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khuyến mãi cho sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (KT_DieuKien() == true)
                    {
                        if (ctKhuyenMai.xoa_CTKM(maCTHD))
                        {
                            MessageBox.Show("Xóa khuyến mãi cho sản phẩm này thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa khuyến mãi cho sản phẩm này không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
