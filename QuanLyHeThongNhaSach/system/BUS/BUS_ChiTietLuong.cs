using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietLuong
    {
        private static BUS_ChiTietLuong instance;
        public static BUS_ChiTietLuong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTietLuong();
                }
                return instance;
            }
        }
        public IQueryable XemBangLuong()
        {
            return DAL_ChiTietLuong.Instance.XemBangLuong();
        }
        public IQueryable XemBangLuong(string ma)
        {
            return DAL_ChiTietLuong.Instance.XemBangLuong(ma);
        }
        public bool ThemBangLuong(ET_ChiTietLuong bl)
        {
            return DAL_ChiTietLuong.Instance.ThemCTBangLuong(bl);
        }
        public bool XoaBangLuong(string maBL)
        {
            return DAL_ChiTietLuong.Instance.XoaCTBangLuong(maBL);
        }
    }
}
