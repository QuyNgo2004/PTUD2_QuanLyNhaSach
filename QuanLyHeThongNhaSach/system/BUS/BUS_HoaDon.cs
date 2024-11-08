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

        //public IQueryable<HoaDon> TimHoaDonTheoSoDienThoai(string soDienThoai)
        //{
        //    try
        //    {
        //        return DAL_HoaDon.Instance.TimHoaDonTheoSoDienThoai(soDienThoai);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
