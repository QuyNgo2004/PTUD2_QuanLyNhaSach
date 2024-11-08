using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuyenMai :DAL_Data
    {
        private static DAL_KhuyenMai instance;
        public static DAL_KhuyenMai Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_KhuyenMai();
                }
                return instance;
            }
        }
        //Load
        public IQueryable LoadKM_All()
        {
            IQueryable list = from km in dbNhaSach.KhuyenMais 
                              join hh in dbNhaSach.HangHoas on km.maHH equals hh.maHH into joined
                              from hh in joined.DefaultIfEmpty() // Sử dụng DefaultIfEmpty để cho phép giá trị null
                              select new
                              {
                                  MaHH = km.maHH,
                                  Mã = km.maKM,
                                  TenKM = km.tenKM,
                                  HH_TặngKèm = hh  != null ? hh.tenHH : "null",
                                  GiảmGiá = km.giamGia,
                                  NgayBD = km.ngayBD,
                                  NgayKT = km.ngayKT,
                                  GhiChú = km.ghiChu,
                              };
            return list;
        }

        public IQueryable LoadKM_Now(DateTime ngayHT)
        {
            IQueryable list = from km in dbNhaSach.KhuyenMais
                              join hh in dbNhaSach.HangHoas on km.maHH equals hh.maHH into joined
                              from hh in joined.DefaultIfEmpty() // Sử dụng DefaultIfEmpty để cho phép giá trị null
                              where  km.ngayKT >= ngayHT
                              select new
                              {
                                  MaHH = km.maHH,
                                  Mã = km.maKM,
                                  TenKM = km.tenKM,
                                  HH_TặngKèm = hh != null ? hh.tenHH : "null",
                                  GiảmGiá = km.giamGia,
                                  NgayBD = km.ngayBD,
                                  NgayKT = km.ngayKT,
                                  GhiChú = km.ghiChu,
                              };
            return list;
        }
        // Them
        public bool ThemKM(ET_KhuyenMai khuyenMai) {
            bool flag = true;
            try
            {
                KhuyenMai km = new KhuyenMai
                {
                    maKM = khuyenMai.MaKM,
                    tenKM = khuyenMai.TenKM,
                    maHH = khuyenMai.MaHH,
                    giamGia = khuyenMai.MaGiamGia,
                    ngayBD = khuyenMai.NgayBD,
                    ngayKT = khuyenMai.NgayKT,
                    ghiChu = khuyenMai.GhiChu
                };
                dbNhaSach.KhuyenMais.InsertOnSubmit(km);
                dbNhaSach.SubmitChanges();
            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }

        //Xoa
        public bool xoa_KM(string ma)
        {
            bool flag = true;
            try
            {
                var xoa = from km in DbNhaSach.KhuyenMais
                          where km.maKM == ma
                          select km;
                KhuyenMai item = xoa.FirstOrDefault();
                DbNhaSach.KhuyenMais.DeleteOnSubmit(item);
                DbNhaSach.SubmitChanges();
              
            }
            catch (Exception ex)
            {
                flag = false;
                throw ex;
            }
            return flag;
        }
        //Sua
        public bool sua_KM(ET_KhuyenMai kmai)
        {
            bool flag = true;
            try
            {
                var capnhat = DbNhaSach.KhuyenMais.Single(km => km.maKM == kmai.MaKM);
                capnhat.tenKM = kmai.TenKM;
                capnhat.maHH = kmai.MaHH;
                capnhat.giamGia = kmai.MaGiamGia;
                capnhat.ngayBD = kmai.NgayBD;
                capnhat.ngayKT = kmai.NgayKT;
                capnhat.ghiChu = kmai.GhiChu;
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {
                flag=false; 
                throw ex;
            }
            return flag;
        }
        //Tim kiem
        public ET_KhuyenMai KM_TimMa(string ma)
        {
            IQueryable<ET_KhuyenMai> khuyenMai = from km in dbNhaSach.KhuyenMais
                                     where km.maKM.Equals(ma)
                                     select new ET_KhuyenMai
                                     {
                                         MaKM = km.maKM,
                                         TenKM = km.tenKM,
                                         MaGiamGia = int.Parse(km.giamGia.ToString()),
                                         MaHH = km.maHH,
                                         NgayBD = km.ngayBD,
                                         NgayKT = km.ngayKT,
                                         GhiChu = km.ghiChu,
                                     };
            ET_KhuyenMai kmai =  khuyenMai.FirstOrDefault();
            return kmai;
        }

    }
}
