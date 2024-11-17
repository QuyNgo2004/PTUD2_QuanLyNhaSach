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
        private static DAL_KhuyenMai km = DAL_KhuyenMai.Instance;
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
        public List<ET_KhuyenMaiReport> CTKM_Load_Now_Report(DateTime ngayHT)
        {
            IEnumerable<ET_KhuyenMaiReport> list = from ctkm in dbNhaSach.CTKhuyenMais
                              join hh in dbNhaSach.HangHoas on ctkm.maHH equals hh.maHH
                              join km in dbNhaSach.KhuyenMais on ctkm.maKM equals km.maKM
                              where km.ngayKT >= ngayHT
                              select new ET_KhuyenMaiReport 
                              {
                                  MaKM = ctkm.maKM,
                                  TenKM = km.tenKM,
                                  TenHH = hh.tenHH,
                                  NgayBD = km.ngayBD,
                                  NgayKT = km.ngayKT,
                              };
            List<ET_KhuyenMaiReport> list_report = new List<ET_KhuyenMaiReport>();
            foreach (ET_KhuyenMaiReport r in list)
            {
                ET_KhuyenMai km_r = km.KM_TimMa(r.MaKM);
                r.TenHH = km_r.TenHH;
                r.MaGiamGia = km_r.MaGiamGia;
                list_report.Add(r);
            }
            return list_report;
        }
        public List<string> CTKM_Load_Now(DateTime ngayHT,string ma)
        {
            IQueryable<string> list = from ctkm in dbNhaSach.CTKhuyenMais
                                join hh in dbNhaSach.HangHoas on ctkm.maHH equals hh.maHH
                                join km in dbNhaSach.KhuyenMais on ctkm.maKM equals km.maKM
                                where km.ngayKT >= ngayHT && ctkm.maHH == ma
                                select ctkm.maKM;
            List<string> listMaKM = list.ToList();
            return listMaKM;
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
