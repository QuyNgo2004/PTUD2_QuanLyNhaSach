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
        private string maHD_Selected = "";
        public DanhSachHangDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                string maHD = dgvLichSuHoaDon.Rows[dong].Cells["MaHD"].Value.ToString();
                maHD_Selected = maHD;
                BUS_CTHoaDon.Instance.xemChiTietHoaDon(dgvDSHangHoa, maHD);                
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
                try
                {
                    if (CheckThongTin() == true)
                    {
                        dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTheoSDT(txtSDT.Text, dateTimePicker1.Value.Date);
                        if (dgvLichSuHoaDon.Rows.Count  == 0)
                        {
                            Exception ex = new Exception("Không tìm thấy hóa đơn từ số điện thoại này");
                            MessageBox.Show(ex.Message);
                        }
                        txtSDT.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                    }
                    else
                    {                        
                        return;                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi tìm kiếm theo số điện thoại" + ex.Message);
                }
            }
            else if(txtSDT.Text == "" && txtTenNV.Text != "")
            {
                try
                {
                    if (CheckThongTin1() == true)
                    {
                        dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTheoTenNV(txtTenNV.Text, dateTimePicker1.Value.Date);
                        if (dgvLichSuHoaDon.Rows.Count == 0)
                        {
                            Exception ex = new Exception("Không tìm thấy hóa đơn từ tên nhân viên này");
                            MessageBox.Show(ex.Message);
                        }
                        txtTenNV.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Có lỗi khi tìm kiếm theo tên nhân viên" + ex.Message);
                }
            }
            else if(txtSDT.Text == "" && txtTenNV.Text == "")
            {
                try
                {
                    dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTheoNgayThanhToan(dateTimePicker1.Value.Date);
                    dateTimePicker1.Value = DateTime.Now;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Có lỗi khi tìm kiếm theo ngày in"+ ex.Message);
                }
            }
            else
            {
                try
                {
                    if (CheckThongTin() == true && CheckThongTin1() == true)
                    {
                        dgvLichSuHoaDon.DataSource = BUS_HoaDon.Instance.TimHoaDonTongHop(txtSDT.Text, txtTenNV.Text, dateTimePicker1.Value.Date);
                        if (dgvLichSuHoaDon.Rows.Count == 0)
                        {
                            Exception ex = new Exception("Không tìm thấy hóa đơn từ tên nhân viên và số điện thoại này");
                            MessageBox.Show(ex.Message);
                        }
                        txtSDT.Clear();
                        txtTenNV.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Có lỗi khi tìm kiếm tổng hợp" + ex.Message);
                }
            }


        }
        private bool CheckThongTin()
        {
            bool flag = false;
            if (batLoi.KT_SoKiTu(txtSDT.Text, 10) == false || batLoi.KT_ChuoiSoDT(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại có 10 số bắt đàu là số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Clear();
                return flag;
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
            DialogResult dar = MessageBox.Show("Bạn có muốn làm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                BUS_HoaDon.Instance.xemDanhSachHoaDon(dgvLichSuHoaDon);
                txtSDT.Clear();
                txtTenNV.Clear();
                dgvDSHangHoa = null;
            }

        }

        

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            if (maHD_Selected != "")
            {
                Menu form = (Menu)this.ParentForm;
                InHoaDon inHoaDonForm = new InHoaDon(maHD_Selected);
                form.openChildForm(inHoaDonForm);
            }
            else
            {
                Exception ex = new Exception("Vui lòng chọn 1 dòng trong Danh sách lịch sử hóa đơn");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
