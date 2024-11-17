using DAL;
using ET;
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

        public IQueryable CTKM_Load_Now(DateTime ngayHT)
        {
            return chiTietKhuyenMai.CTKM_Load_Now(ngayHT);
        }
        public List<ET_KhuyenMaiReport> CTKM_Load_Now_Report(DateTime ngayHT)
        {
            return chiTietKhuyenMai.CTKM_Load_Now_Report(ngayHT);
        }
        public List<string> CTKM_Load_Now(DateTime ngayHT,string ma)
        {
            return chiTietKhuyenMai.CTKM_Load_Now(ngayHT,ma);
        }
        // Them 
        public bool Them_CTKM(string maHH, string maKM)
        {
           bool flag = false;
           IQueryable list = chiTietKhuyenMai.TimTrung_CTKM(maHH, maKM);
            int dem = 0;
            foreach(var l in list)
            {
                dem++;
            }
            if (dem  == 0)
            {
                flag = chiTietKhuyenMai.Them_CTKM(maHH, maKM);
            }
            return flag;
        }

        //Xoa
        public bool xoa_CTKM(int maCTKM)
        {
            return chiTietKhuyenMai.xoa_CTKM(maCTKM);
        }
        //Sua
        public bool sua_CTKM(int CTKM, string maKM)
        {
            return chiTietKhuyenMai.sua_CTKM(CTKM, maKM);
        }
       
    }
}
