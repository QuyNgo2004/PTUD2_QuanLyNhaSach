using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_NhapHang
    {
        private static BUS_NhapHang instance;
        public static BUS_NhapHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NhapHang();
                }
                return instance;
            }
        }

        private DAL_NhapHang dalNhapHang = new DAL_NhapHang();

        public void XemDSNH(DataGridView dgvDSHH)
        {
            // Gán DataSource cho DataGridView
            dgvDSHH.DataSource = dalNhapHang.XemDSNhapHang();
        }

        public void ThemNhapHang(ET_NhapHang etNH)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dalNhapHang.ThemNhapHang(etNH) == true)
            {
                //Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Khi thêm không thành công sẽ hiển thị thông báo này
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void XoaNhapHang(DataGridView dgvDSNH)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dalNhapHang.XoaNhapHang(dgvDSNH.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                // Hiện lên thông báo khi xóa thành công
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiện lên thông báo khi xóa không thành công
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string TaoMaHangTuDong()
        {
            return dalNhapHang.TaoMaHangHoaTuDong();
        }
    }
}
