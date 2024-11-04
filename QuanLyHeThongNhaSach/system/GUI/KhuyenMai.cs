using BUS;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Utils.Extensions;
using ET;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class KhuyenMai : Form
    {
        BUS_BatLoi error = new BUS_BatLoi();
        BUS_KhuyenMai bus_km = new BUS_KhuyenMai();
        private DateTime ngayHT = DateTime.Now;
        public KhuyenMai()
        {
            InitializeComponent();
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            
            rbtGiamGia.Checked = true;
            dtpNgayKT.Value = DateTime.Now.AddDays(1);
            Load_XemKM();
            rbtGiamGia_Click(sender, e);
        }
        private void Load_XemKM()
        {
            TaoMaKhuyenMai();
            txtTen.Text = string.Empty;
            cbXemKM.Checked = true;
            dgvDSCTKM.Refresh(); // Làm mới DataGridView nếu cần
            bus_km.LoadKM_Now(ngayHT, dgvDSCTKM);
            dgvDSCTKM.Columns["MaHH"].Visible = false;
        }
        public void TaoMaKhuyenMai()
        {
            DateTime ngayBD = DateTime.Parse(dtpNgayBD.Text);
            DateTime ngayKT = DateTime.Parse(dtpNgayKT.Text);
            txtMaKM.Text = "KM"+"_"+ngayBD.ToString("dd/MM/yy")+"_"+ ngayKT.ToString("dd/MM/yy")+ "_"+(bus_km.LoadKM_All().Count()+1);
        }
       

        private void rbtGiamGia_Click(object sender, EventArgs e)
        {
            
            if (rbtGiamGia.Checked)
            {
                txtMaSP.Text = string.Empty;
                txtTenSP.Text = string.Empty;
                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                txtMaGiamGia.Enabled = true;
                txtMaSP.BackColor = Color.LightGray;
                txtTenSP.BackColor = Color.LightGray;
                txtMaGiamGia.BackColor = Color.White;
            }
            else if (rbtSP.Checked)
            {
                txtMaGiamGia.Text = "0";
                txtMaGiamGia.Enabled = false;
                txtMaSP.Enabled = true;
                txtTenSP.Enabled = true;
                txtMaSP.BackColor = Color.White;
                txtTenSP.BackColor = Color.White;
                txtMaGiamGia.BackColor = Color.LightGray;
                
                
            }
        }

        

        private void txtMaGiamGia_Validated(object sender, EventArgs e)
        {
            if (rbtGiamGia.Checked == true)
            {
                if (error.KT_Null(txtMaGiamGia.Text) == true)
                {
                    MessageBox.Show("Vui lòng nhập mã giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (txtMaGiamGia.Text == "0" || int.Parse(txtMaGiamGia.Text) >= 100 )
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGiamGia.Text = "1";
            }
            else if (error.KT_ChuoiSo(txtMaGiamGia.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá bằng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGiamGia.Text = "1";
            }
            //TaoMaKhuyenMai();
        }

        private void dtpNgayBD_Validated(object sender, EventArgs e)
        {
            if(error.KT_Ngay(dtpNgayBD.Value,dtpNgayKT.Value,ngayHT) == false)
            {
                MessageBox.Show("Vui lòng chọn ngày BD lớn hơn ngay KT và lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaSP_Validated(object sender, EventArgs e)
        {

        }

        

        private void cbXemKM_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của checkbox
            if (cbXemKM.Checked)
            {
                // Nếu checkbox được chọn, tải tất cả khuyến mại
                bus_km.LoadKM_All(dgvDSCTKM);
            }
            else
            {
                // Nếu không được chọn, tải khuyến mại hiện tại
                dgvDSCTKM.Refresh(); // Làm mới DataGridView nếu cần
                bus_km.LoadKM_Now(ngayHT, dgvDSCTKM);
            }

            // Ẩn cột "MaHH"
            dgvDSCTKM.Columns["MaHH"].Visible = false;
        }
        private ET_KhuyenMai KhuyenMai_Value(object sender, EventArgs e)
        {
            ET_KhuyenMai khuyenMai = new ET_KhuyenMai() ;
            try {
                if (txtMaKM.Text == string.Empty || txtTen.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (error.KT_SoKiTuCoTheLuu(txtMaKM.Text,25))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin nhỏ hơn 20 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (error.KT_SoKiTuCoTheLuu(txtTen.Text, 50))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin nhỏ hơn 50 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtMaGiamGia_Validated(sender, e);
                rbtGiamGia_Click(sender, e);

                ET_KhuyenMai km = new ET_KhuyenMai
                {
                    MaKM = txtMaKM.Text,
                    TenKM = txtTen.Text,
                    MaGiamGia = int.Parse(txtMaGiamGia.Text) ,
                    MaHH = txtMaSP.Text != string.Empty ? txtMaSP.Text : null,
                    NgayBD = dtpNgayBD.Value,
                    NgayKT = dtpNgayKT.Value,
                    GhiChu = txtGhiChu.Text,
                };
                khuyenMai = km;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return khuyenMai;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_KhuyenMai km = KhuyenMai_Value(sender, e);
            if (BUS_KhuyenMai.Instance.KM_Them(km) == true)
            {
                MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_XemKM();
            }
            else
            {
                MessageBox.Show("Thêm khuyến mãi không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa khuyến mãi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS_KhuyenMai.Instance.KM_Xoa(txtMaKM.Text))
                {
                    MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_XemKM();
                }
                else
                {
                    MessageBox.Show("Xóa khuyến mãi không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDSCTKM_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvDSCTKM.CurrentCell.RowIndex;
                txtMaKM.Text = dgvDSCTKM.Rows[dong].Cells[1].Value.ToString();
                if (dgvDSCTKM.Rows[dong].Cells[3].Value.ToString() == "0") {
                    rbtSP.Checked = true;
                    rbtGiamGia_Click(sender,e);
                    txtMaSP.Text = dgvDSCTKM.Rows[dong].Cells[0].Value.ToString() != null ? dgvDSCTKM.Rows[dong].Cells[0].Value.ToString() : null;
                    txtTenSP.Text = dgvDSCTKM.Rows[dong].Cells[3].Value.ToString() != null ? dgvDSCTKM.Rows[dong].Cells[0].Value.ToString() : null;
                }
                else
                {
                    rbtGiamGia.Checked = true;
                    rbtGiamGia_Click(sender, e);
                    txtMaGiamGia.Text = dgvDSCTKM.Rows[dong].Cells[4].Value.ToString();
                }

                txtTen.Text = dgvDSCTKM.Rows[dong].Cells[2].Value.ToString();
                dtpNgayBD.Value = DateTime.Parse(dgvDSCTKM.Rows[dong].Cells[5].Value.ToString());
                dtpNgayKT.Value = DateTime.Parse(dgvDSCTKM.Rows[dong].Cells[6].Value.ToString());
                txtGhiChu.Text = dgvDSCTKM.Rows[dong].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_KhuyenMai km = KhuyenMai_Value(sender, e);
            if (BUS_KhuyenMai.Instance.KM_Sua(km) == true)
            {
                MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_XemKM();

            }
            else
            {
                MessageBox.Show("Sửa khuyến mãi không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
