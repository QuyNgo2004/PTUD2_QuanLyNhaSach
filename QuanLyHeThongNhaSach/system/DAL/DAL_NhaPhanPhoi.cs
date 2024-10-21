using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaPhanPhoi : DAL_Data
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
        //QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSNhaPhanPhoi()
        {
            IQueryable dsNhaPhanPhoi = from ncc in DbNhaSach.NhaPhanPhois
                                      select new 
                                      {
                                          MaNPP = ncc.maNPP,
                                          TenNPP = ncc.tenNPP,
                                          DiaChi = ncc.diachiNPP,
                                          SoDienThoai = ncc.sdtNPP,
                                          Email = ncc.emailNPP,
                                      };
            return dsNhaPhanPhoi;
        }
        public bool themNhaPhanPhoi(ET_NhaPhanPhoi nhaPhanPhoi)
        {
            if (DbNhaSach.NhaPhanPhois.Any(a => a.maNPP == nhaPhanPhoi.MaNPP))
            {
                throw new Exception("Đã tồn tại Mã này trong Cơ Sở Dữ Liệu vui lòng nhập mã khác");
            }
            try
            {
                NhaPhanPhoi npp = new NhaPhanPhoi
                {
                    maNPP = nhaPhanPhoi.MaNPP,
                    tenNPP = nhaPhanPhoi.TenNPP,
                    diachiNPP = nhaPhanPhoi.DiaChiNPP,
                    sdtNPP = nhaPhanPhoi.SdtNPP,
                    emailNPP = nhaPhanPhoi.EmailNPP,
                };
                DbNhaSach.NhaPhanPhois.InsertOnSubmit(npp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DbNhaSach.SubmitChanges();
            }
            return true;
        }

        public void xoaNhaPhanPhoi(string ma)
        {
            try
            {
                var xoa = from cn in DbNhaSach.ChiNhanhs
                          where cn.maCN == ma
                          select cn;
                foreach (var item in xoa)
                {
                    DbNhaSach.ChiNhanhs.DeleteOnSubmit(item);
                    DbNhaSach.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaNhaPhanPhoi(ET_NhaPhanPhoi nhaPhanPhoi)
        {
            try
            {
                var capnhat = DbNhaSach.NhaPhanPhois.Single(npp => npp.maNPP == nhaPhanPhoi.MaNPP);
                capnhat.maNPP = nhaPhanPhoi.MaNPP;
                capnhat.tenNPP = nhaPhanPhoi.TenNPP;
                capnhat.diachiNPP = nhaPhanPhoi.DiaChiNPP;
                capnhat.sdtNPP = nhaPhanPhoi.SdtNPP;
                capnhat.emailNPP = nhaPhanPhoi.EmailNPP;
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
