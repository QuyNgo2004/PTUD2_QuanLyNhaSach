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
        public QuanLyCaTruc()
        {
            InitializeComponent();
        }

        private void QuanLyCaTruc_Load(object sender, EventArgs e)
        {

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
    }
}
