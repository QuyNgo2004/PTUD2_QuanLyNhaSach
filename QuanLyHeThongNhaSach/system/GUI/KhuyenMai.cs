using BUS;
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
            rbtGiamGia_Click(sender, e);
        }
        public void TaoMaKhuyenMai()
        {
            txtMaKM.Text = "KM_"+txtMaGiamGia.Text+"_"+dtpNgayBD.Text+"_"+dtpNgayKT.Text;
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
                txtMaGiamGia.Text = string.Empty;
                txtMaGiamGia.Enabled = false;
                txtMaSP.Enabled = true;
                txtTenSP.Enabled = true;
                txtMaSP.BackColor = Color.White;
                txtTenSP.BackColor = Color.White;
                txtMaGiamGia.BackColor = Color.LightGray;
            }
        }

        private void txtMaGiamGia_TextChanged(object sender, EventArgs e)
        {
            if(rbtGiamGia.Checked == true)
            {
                if (error.KT_Null(txtMaGiamGia.Text) == true) {
                    MessageBox.Show("Vui lòng nhập mã giảm giá!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            TaoMaKhuyenMai();
        }
    }
}
