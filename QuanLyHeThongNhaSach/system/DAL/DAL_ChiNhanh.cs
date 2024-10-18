using ET;
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

        public bool themChiNhanh(ET_ChiNhanh chiNhanh)
        {
            try
            {
                ChiNhanh cn = new ChiNhanh
                {
                    maCN = chiNhanh.MaCN,
                    tenCN = chiNhanh.TenCN,
                    diaChi = chiNhanh.DiaChi,
                    soDienThoai = chiNhanh.SoDienThoai,
                    email = chiNhanh.Email,
                    ghiChu = chiNhanh.GhiChu,
                };
                db.ChiNhanhs.InsertOnSubmit(cn);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                db.SubmitChanges();
            }
            return true;
        }

        public void xoaChiNhanh(string ma)
        {
            try
            {
                var xoa = from cn in db.ChiNhanhs
                          where cn.maCN == ma
                          select cn;
                foreach (var item in xoa)
                {
                    db.ChiNhanhs.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaChiNhanh(ET_ChiNhanh chiNhanh)
        {
            try
            {
                var capnhat = db.ChiNhanhs.Single(cn => cn.maCN == chiNhanh.MaCN);
                capnhat.maCN = chiNhanh.MaCN;
                capnhat.tenCN = chiNhanh.TenCN;
                capnhat.diaChi = chiNhanh.DiaChi;
                capnhat.soDienThoai = chiNhanh.SoDienThoai;
                capnhat.ghiChu = chiNhanh.GhiChu;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
