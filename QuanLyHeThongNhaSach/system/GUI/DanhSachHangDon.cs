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
        BUS_BatLoi batLoi = new BUS_BatLoi();
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
            try
            {
                int dong = dgvLichSuHoaDon.CurrentCell.RowIndex;
                string mahh = dgvLichSuHoaDon.Rows[dong].Cells[0].Value.ToString();
                BUS_CTHoaDon.Instance.xemChiTietHoaDon(dgvDSHangHoa, mahh);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" && txtSDT.Text != "")
            {
                if (CheckThongTin() == true)
                {
                    dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTheoSDT(txtSDT.Text, dateTimePicker1.Value.Date);
                    txtSDT.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    Exception ex = new Exception("Không tìm thấy hóa đơn từ số điện thoại này");
                    MessageBox.Show(ex.Message);
                }
            }
            else if(txtSDT.Text == "" && txtTenNV.Text != "")
            {
                if (CheckThongTin1() == true)
                {
                    dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTheoTenNV(txtTenNV.Text, dateTimePicker1.Value.Date);
                    txtTenNV.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    Exception ex = new Exception("Không tìm thấy hóa đơn từ tên nhân viên này này");
                    MessageBox.Show(ex.Message);
                }
            }
            else if(txtSDT.Text == "" && txtTenNV.Text == "")
            {
                dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTheoNgayThanhToan(dateTimePicker1.Value.Date);
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTongHop(txtSDT.Text, txtTenNV.Text, dateTimePicker1.Value.Date);
                txtSDT.Clear();
                txtTenNV.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }


        }
        private bool CheckThongTin()
        {
            bool flag = false;
            if (batLoi.KT_SoKiTu(txtSDT.Text, 10) == false || batLoi.KT_ChuoiSoDT(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại có 10 số bắt đàu là số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Clear();               
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private bool CheckThongTin1()
        {
            bool flag = false;
            if (batLoi.KT_Null(txtTenNV.Text) || batLoi.KT_SoKiTuCoTheLuu(txtTenNV.Text, 45) == false || batLoi.KT_ChuoiKiTu(txtTenNV.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập tên nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Clear();
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            BUS_HoaDon.Instance.xemDanhSachHoaDon(dgvLichSuHoaDon);
            txtSDT.Clear();
            txtTenNV.Clear();

        }
    }
}
