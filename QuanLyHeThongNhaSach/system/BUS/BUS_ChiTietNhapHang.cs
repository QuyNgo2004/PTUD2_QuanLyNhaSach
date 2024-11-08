﻿using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ChiTietNhapHang
    {
        private static BUS_ChiTietNhapHang instance;
        private static DAL_ChiTietNhapHang insatnce;
        public static BUS_ChiTietNhapHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTietNhapHang();
                }
                return instance;
            }
        }


        public void XemDSCTNH(DataGridView dgvDSCTNH)
        {
            // Gán DataSource cho DataGridView
            dgvDSCTNH.DataSource = DAL_ChiTietNhapHang.Instance.XemDSChiTietNhapHang();
        }

        public void XemDSCTNHTM(DataGridView dgvDSCTNH, string maNH)
        {
            // Gán DataSource cho DataGridView
            dgvDSCTNH.DataSource = DAL_ChiTietNhapHang.Instance.XemDSChiTietNhapHangTheoMa(maNH);
        }

        public void ThemChiTiet(ET_ChiTietNhapHang etCT)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (DAL_ChiTietNhapHang.Instance.ThemChiTiet(etCT) == true)
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

        public void XoaChiTiet(DataGridView dgvDSCT)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (DAL_ChiTietNhapHang.Instance.XoaChiTiet(dgvDSCT.CurrentRow.Cells[0].Value.ToString()) == true)
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
    }
}