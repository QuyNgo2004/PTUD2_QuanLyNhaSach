using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiNhanh
    {
        private static DAL_ChiNhanh instance;

        public static DAL_ChiNhanh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiNhanh();
                }
                return instance;
            }
        }
        QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSChiNhanh()
        {
            IQueryable dsChiNhanh = from cn in db.ChiNhanhs
                                    select new 
                                    { 
                                        MaCN = cn.maCN,
                                        TenCN = cn.tenCN,
                                        DiaChi = cn.diaChi,
                                        SoDienThoai = cn.soDienThoai,
                                        Email = cn.email,
                                        GhiChu = cn.ghiChu,
                                    };                                   
            return dsChiNhanh;
        }
    }
}
