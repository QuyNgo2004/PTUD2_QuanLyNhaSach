using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BangLuong
    {
        private static BUS_BangLuong instance;
        public static BUS_BangLuong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_BangLuong();
                }
                return instance;
            }
        }
        public IQueryable XemBangLuong()
        {
            return DAL_BangLuong.Instance.XemBangLuong();
        }
        public bool ThemBangLuong(ET_BangLuong bl)
        {
            return DAL_BangLuong.Instance.ThemBangLuong(bl);
        }
        public bool XoaBangLuong(string maBL)
        {
            return DAL_BangLuong.Instance.XoaBangLuong(maBL);
        }
    }
}
