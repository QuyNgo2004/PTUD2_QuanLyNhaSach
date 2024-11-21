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
    public partial class RpNhapHang : Form
    {
        public RpNhapHang()
        {
            InitializeComponent();
        }

        private void RpNhapHang_Load(object sender, EventArgs e)
        {

            this.reportNhapHang.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
