using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BangLuong :DAL_Data
    {
        private static DAL_BangLuong instance;
        public static DAL_BangLuong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_BangLuong();
                }
                return instance;
            }
        }

        public IQueryable XemBangLuong()
        {
            IQueryable list = from luong in DbNhaSach.BangTinhLuongs
                              join ns in DbNhaSach.NhanSus on luong.maNS equals ns.maNS
                              select new ET_BangLuong
                              {
                                  MaBangLuong = luong.maBangLuong,
                                  MaQL = luong.maNS,
                                  TenQL = ns.tenNS,
                                  NgayBD = luong.ngayBD,
                                  NgayKT = luong.ngayKT,

                              };
            return list;
        }

        public bool ThemBangLuong(ET_BangLuong ct_BangLuong)
        {
            try
            {
                BangTinhLuong ct = new BangTinhLuong()
                {
                    maBangLuong = ct_BangLuong.MaBangLuong,
                    maNS = ct_BangLuong.MaQL,
                    ngayBD = ct_BangLuong.NgayBD,
                    ngayKT = ct_BangLuong.NgayKT,
                    
                };
                DbNhaSach.BangTinhLuongs.InsertOnSubmit(ct);
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
        public bool XoaBangLuong(string ET_maBangLuong)
        {
            bool flag = false;
            try
            {
                var xoa = from ct in DbNhaSach.BangTinhLuongs
                          where ct.maBangLuong == ET_maBangLuong
                          select ct;
                foreach (var item in xoa)
                {
                    DbNhaSach.BangTinhLuongs.DeleteOnSubmit(item);
                    DbNhaSach.SubmitChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                throw ex;
            }
            return flag;
        }
    }
}
