using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietLuong :DAL_Data
    {
        private static DAL_ChiTietLuong instance;
        public static DAL_ChiTietLuong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiTietLuong();
                }
                return instance;
            }
        }

        public IQueryable XemBangLuong()
        {
            IQueryable list = from luong in DbNhaSach.ChiTietLuongs
                              join ns in DbNhaSach.NhanSus on luong.maNS equals ns.maNS
                              select new ET_ChiTietLuong { 
                                  MaCTLuong = luong.maCTLuong,
                                  MaBangLuong = luong.maBangLuong,
                                  MaNS = luong.maNS,
                                  TenNS = ns.tenNS,
                                  NgayTC = (int)luong.ngayTC,
                                  NgayLam = luong.soNgayLam,
                                  NgayNghi = (int)luong.ngayNghi,
                                  TienLuong = luong.tienLuong,

                              };
            return list;
        }
        public IQueryable XemBangLuong(string ma)
        {
            IQueryable list = from luong in DbNhaSach.ChiTietLuongs
                              join ns in DbNhaSach.NhanSus on luong.maNS equals ns.maNS
                              join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                              where luong.maBangLuong == ma
                              select new ET_ChiTietLuong
                              {
                                  MaCTLuong = luong.maCTLuong,
                                  MaBangLuong = luong.maBangLuong,
                                  LuongCB = int.Parse(luong.luongCB),
                                  ChucVu = cv.tenChucVu,
                                  MaNS = luong.maNS,
                                  TenNS = ns.tenNS,
                                  NgayTC = (int)luong.ngayTC,
                                  NgayLam = luong.soNgayLam,
                                  NgayNghi = (int)luong.ngayNghi,
                                  TienLuong = luong.tienLuong,

                              };
            return list;
        }
        public List<ET_ChiTietLuong> XemBangLuong_Report(string ma)
        {
            IEnumerable<ET_ChiTietLuong> list = from luong in DbNhaSach.ChiTietLuongs
                              join ns in DbNhaSach.NhanSus on luong.maNS equals ns.maNS
                              join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                              where luong.maBangLuong == ma
                              select new ET_ChiTietLuong
                              {
                                  MaCTLuong = luong.maCTLuong,
                                  MaBangLuong = luong.maBangLuong,
                                  ChucVu = cv.tenChucVu,
                                  LuongCB = int.Parse(luong.luongCB),
                                  MaNS = luong.maNS,
                                  TenNS = ns.tenNS,
                                  NgayTC = (int)luong.ngayTC,
                                  NgayLam = luong.soNgayLam,
                                  NgayNghi = (int)luong.ngayNghi,
                                  TienLuong = luong.tienLuong,

                              };
            return list.ToList();
        }
        public bool ThemCTBangLuong(ET_ChiTietLuong ct_Luong)
        {
            try
            {
                ChiTietLuong ct = new ChiTietLuong()
                {
                    maBangLuong = ct_Luong.MaBangLuong,
                    maNS = ct_Luong.MaNS,
                    luongCB = ct_Luong.LuongCB.ToString(),
                    ngayTC = (int)ct_Luong.NgayTC,
                    soNgayLam = ct_Luong.NgayLam,
                    ngayNghi = ct_Luong.NgayNghi,
                    tienLuong = ct_Luong.TienLuong,
                };
                DbNhaSach.ChiTietLuongs.InsertOnSubmit(ct);
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
        public bool XoaCTBangLuong(string ET_maBangLuong)
        {
            bool flag = false;
            try
            {
                var xoa = from ct in DbNhaSach.ChiTietLuongs
                          where ct.maBangLuong == ET_maBangLuong
                          select ct;
                foreach (var item in xoa)
                {
                    DbNhaSach.ChiTietLuongs.DeleteOnSubmit(item);
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
