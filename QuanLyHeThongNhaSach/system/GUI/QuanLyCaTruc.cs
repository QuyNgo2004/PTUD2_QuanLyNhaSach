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
    public partial class QuanLyCaTruc : Form
    {
        BUS_ChiNhanh cn = BUS_ChiNhanh.Instance;
        BUS_CaTruc ct =  BUS_CaTruc.Instance;
        BUS_NhanSu ns = BUS_NhanSu.Instance;
        public QuanLyCaTruc()
        {
            InitializeComponent();
        }

        private void QuanLyCaTruc_Load(object sender, EventArgs e)
        {
            cboCN.DataSource = cn.Load_ChiNhanh();
            cboCN.DisplayMember = "TenCN";
            cboCN.ValueMember = "MaCN";
            cboCN_SelectedIndexChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new CaTruc());
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new NhanSu());
            this.Close();
        }

        private void cboCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCaTruc.DataSource = ct.Load_CaTruc(cboCN.SelectedValue.ToString());
            cboCaTruc.DisplayMember = "Tên";
            cboCaTruc.ValueMember = "Mã";
            ns.hienThiNhanSu(dgvNV, cboCN.SelectedValue.ToString());
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNV.CurrentCell.RowIndex;
                txtMaNS.Text = dgvNV.Rows[dong].Cells[0].Value.ToString();
                txtTenNS.Text = dgvNV.Rows[dong].Cells[1].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
