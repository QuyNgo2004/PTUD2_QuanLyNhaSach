using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDon
    {
        private static BUS_HoaDon instance;

        public static BUS_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_HoaDon();
                }
                return instance;
            }
        }
        public bool themHoaDon(ET_HoaDon hoadon)
        {
            try
            {
                return DAL_HoaDon.Instance.ThemHoaDon(hoadon);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string AutoMa_HoaDon()
        {
            return DAL_HoaDon.Instance.AutoMa_HoaDon();
        }

        public void xemDanhSachHoaDon(DataGridView dgv)
        {
            dgv.DataSource = DAL_HoaDon.Instance.xemDanhSachHoaDon();
        }

        public IQueryable TimHoaDonTheoSDT(string soDienThoai, DateTime dateTime)
        {
            try
            {
                return DAL_HoaDon.Instance.TimHoaDonTheoSDT(soDienThoai,dateTime);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IQueryable TimHoaDonTheoTenNV(string tenNV, DateTime dateTime)
        {
            try
            {
                return DAL_HoaDon.Instance.TimHoaDonTheoTenNV(tenNV,dateTime);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable TimHoaDonTheoNgayThanhToan(DateTime dateTime)
        {
            try
            {
                return DAL_HoaDon.Instance.TimHoaDonTheoNgayThanhToan(dateTime);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable TimHoaDonTongHop(string soDienThoai, string tenNV, DateTime dateTime)
        {
            try
            {
                return DAL_HoaDon.Instance.TimHoaDonTongHop(soDienThoai, tenNV, dateTime);
            }
            catch (Exception ex)
            {
                return null;
        //        throw ex;
            }
        }
    }
}
