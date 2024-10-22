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
    public partial class CaTruc : Form
    {
        private BUS_ChiNhanh cn = BUS_ChiNhanh.Instance;
        private BUS_CaTruc ct = BUS_CaTruc.Instance;
        public CaTruc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnQLCT_Click(object sender, EventArgs e)
        {
            
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new QuanLyCaTruc());
            this.Close();
        }

        private void CaTruc_Load(object sender, EventArgs e)
        {
            cboChiNhanh.DataSource = cn.Load_ChiNhanh();
            cboChiNhanh.DisplayMember = "TenCN";
            cboChiNhanh.ValueMember = "MaCN";
            Load_CT();
        }
        private void Load_CT()
        {
            ct.hienThiCaTruc(dgvCaTruc);
            dgvCaTruc.Columns["Mã"].Visible = false;
            btnThem.Focus();
            txtTenCT.Text = null;
            txtSL.Text = null;
            txtGhiChu.Text = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
