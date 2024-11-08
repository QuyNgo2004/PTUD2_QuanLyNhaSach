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
    public partial class DanhSachHangDon : Form
    {
        public DanhSachHangDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DanhSachHangDon_Load(object sender, EventArgs e)
        {
            BUS_HoaDon.Instance.xemDanhSachHoaDon(dgvLichSuHoaDon);
        }

        private void dgvLichSuHoaDon_Click(object sender, EventArgs e)
        {
            int dong = dgvLichSuHoaDon.CurrentCell.RowIndex;
            string mahh = dgvLichSuHoaDon.Rows[dong].Cells[0].Value.ToString();            
            BUS_CTHoaDon.Instance.xemChiTietHoaDon(dgvDSHangHoa, mahh);
        }
    }
}
