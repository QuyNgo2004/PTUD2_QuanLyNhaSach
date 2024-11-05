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
    public partial class ChiTietKhuyenMai : Form
    {
        BUS_KhuyenMai km = BUS_KhuyenMai.Instance;
        BUS_ChiTietKhuyenMai ctKhuyenMai = BUS_ChiTietKhuyenMai.Instance;
        private DateTime ngayHT = DateTime.Now;
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
            //cboKhuyenMai.SelectedIndex = 0;
        }
        private void lblCaTruc_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
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
            Load_Frm();
        }
    }
}
