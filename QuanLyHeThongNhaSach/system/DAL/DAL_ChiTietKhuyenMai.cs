using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietKhuyenMai :DAL_Data
    {
        private static DAL_ChiTietKhuyenMai instance;
        public static DAL_ChiTietKhuyenMai Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiTietKhuyenMai();
                }
                return instance;
            }
        }

        // Load
        public IQueryable CTKM_Load_All()
        {
            IQueryable list = from ctkm in dbNhaSach.CTKhuyenMais
                              join hh in dbNhaSach.HangHoas on ctkm.maHH equals hh.maHH
                              join km in dbNhaSach.KhuyenMais on ctkm.maKM equals km.maKM
                              select new
                              {
                                  MaCT = ctkm.maCTKM,
                                  MaHH = ctkm.maHH,
                                  TenHH = hh.tenHH,
                                  MaKM = ctkm.maKM,
                                  TenKM = km.tenKM,
                              };
            return list;
        }
        //Them
        //Xoa
        //Sua
        //Tim Kiem
    }
}
