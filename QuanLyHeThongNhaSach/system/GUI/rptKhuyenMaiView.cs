using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class rptKhuyenMaiView : Form
    {
        public rptKhuyenMaiView()
        {
            InitializeComponent();
        }

        private void rptKhuyenMaiView_Load(object sender, EventArgs e)
        {

            this.rptBCKhuyenMai.RefreshReport();
        }
    }
}
