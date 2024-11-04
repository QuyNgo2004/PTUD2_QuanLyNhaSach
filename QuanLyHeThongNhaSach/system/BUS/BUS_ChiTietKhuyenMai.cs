using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietKhuyenMai
    {
        private static BUS_ChiTietKhuyenMai instance;
        DAL_ChiTietKhuyenMai chiTietKhuyenMai = DAL_ChiTietKhuyenMai.Instance;
        public static BUS_ChiTietKhuyenMai Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTietKhuyenMai();
                }
                return instance;
            }
        }
        //Load
        public IQueryable CTKM_Load_All()
        {
            return chiTietKhuyenMai.CTKM_Load_All();
        }
        //Them
        //Xoa
        //Sua
        //Tim Kiem
    }
}
