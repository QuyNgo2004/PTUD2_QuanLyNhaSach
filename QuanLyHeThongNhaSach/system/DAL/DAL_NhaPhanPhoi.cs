using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaPhanPhoi
    {
        private static DAL_NhaPhanPhoi instance;

        public static DAL_NhaPhanPhoi Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_NhaPhanPhoi();
                }
                return instance;

            }
        }
        QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSNhaPhanPhoi()
        {
            IQueryable dsNhaCungCap = from ncc in db.NhaPhanPhois
                                      select new 
                                      {
                                          MaNPP = ncc.maNPP,
                                          TenNPP = ncc.tenNPP,
                                          DiaChi = ncc.diachiNPP,
                                          SoDienThoai = ncc.sdtNPP,
                                          Email = ncc.emailNPP,
                                      };
            return dsNhaCungCap;
        }
    }
}
