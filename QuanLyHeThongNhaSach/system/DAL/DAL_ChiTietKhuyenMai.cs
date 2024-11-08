using ET;
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
        public IQueryable CTKM_Load_Now(DateTime ngayHT)
        {
            IQueryable list = from ctkm in dbNhaSach.CTKhuyenMais
                              join hh in dbNhaSach.HangHoas on ctkm.maHH equals hh.maHH
                              join km in dbNhaSach.KhuyenMais on ctkm.maKM equals km.maKM
                              where  km.ngayKT >= ngayHT
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
        // Them 
        public bool Them_CTKM(string maHH, string maKM)
        {
            bool flag = true;
            try
            {
                CTKhuyenMai km = new CTKhuyenMai
                {
                    maKM = maKM,
                    maHH = maHH,
                };
                
                    dbNhaSach.CTKhuyenMais.InsertOnSubmit(km);
                    dbNhaSach.SubmitChanges();
                
              
                
            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }

        //Xoa
        public bool xoa_CTKM(int CTKM)
        {
            bool flag = true;
            try
            {
                var xoa = from km in DbNhaSach.CTKhuyenMais
                          where km.maCTKM == CTKM 
                          select km;
                DbNhaSach.CTKhuyenMais.DeleteOnSubmit(xoa.FirstOrDefault());
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
        public bool sua_CTKM(int CTKM,string maKM)
        {
            bool flag = true;
            try
            {
                var capnhat = DbNhaSach.CTKhuyenMais.Single(km => km.maCTKM ==  CTKM);
                capnhat.maKM = maKM;
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {
                flag = false;
                throw ex;
            }
            return flag;
        }
        //Tim Kiem
        public IQueryable TimTrung_CTKM(string maHH, string maKM)
        {
            IQueryable list = null;
            try
            {
                 list = from km in DbNhaSach.CTKhuyenMais
                          where km.maHH == maHH && km.maKM == maKM
                          select km;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
