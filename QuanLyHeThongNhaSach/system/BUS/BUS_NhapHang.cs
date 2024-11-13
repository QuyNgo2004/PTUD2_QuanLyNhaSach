﻿using DAL;
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

        public bool ThemNhapHang(ET_NhapHang etNH)
        {
            try
            {
                return DAL_NhapHang.Instance.ThemNhapHang(etNH);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void XoaNhapHang(string maNH, string maHH, DataGridView dgvDSNH)
        {
            //// Gọi phương thức XoaNhapHang trong DAL
            //bool success = dalNhapHang.XoaNhapHang(maNH, maHH);

            //if (success)
            //{
            //    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Không thể xóa dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public string TaoMaHangTuDong()
        {
            return dalNhapHang.TaoMaHangHoaTuDong();
        }

    }
}
