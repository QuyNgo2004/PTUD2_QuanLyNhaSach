using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTCaTruc :DAL_Data
    {
        private static DAL_CTCaTruc instance;
        public static DAL_CTCaTruc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_CTCaTruc();
                }
                return instance;
            }
        }
        //QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSCTCaTruc()
        {
            IQueryable dsCaTruc = from ctct in DbNhaSach.ChiTietCaTrucs
                                  join ct in DbNhaSach.CaTrucs on ctct.maCT equals ct.maCT
                                  join ns in DbNhaSach.NhanSus on ctct.maNS equals ns.maNS
                                  select new
                                  {
                                      Mã = ctct.maCTCT,
                                      Tên_Nhân_Sự = ns.tenNS,
                                      Tên_Ca_Trực = ct.tenCaTruc,
                                      Giờ_Bắt_Đầu = ct.gioBD,
                                      Giờ_Kết_Thúc = ct.gioKT,
                                  };
            return dsCaTruc;
        }
        public IQueryable layDSCTCaTruc(int maCT)
        {
            IQueryable dsCaTruc = from ctct in DbNhaSach.ChiTietCaTrucs
                                  join ct in DbNhaSach.CaTrucs on ctct.maCT equals ct.maCT
                                  join ns in DbNhaSach.NhanSus on ctct.maNS equals ns.maNS
                                  where ctct.maCT == maCT
                                  select new
                                  {
                                      Mã = ctct.maCTCT,
                                      Tên_Nhân_Sự = ns.tenNS,
                                      Tên_Ca_Trực = ct.tenCaTruc,
                                      Giờ_Bắt_Đầu = ct.gioBD,
                                      Giờ_Kết_Thúc = ct.gioKT,
                                  };
            return dsCaTruc;
        }
        public bool themCTCaTruc(int maCT,string maNS)
        {
            try
            {
                ChiTietCaTruc ct = new ChiTietCaTruc
                {
                    maCT = maCT,
                    maNS = maNS,
                };
                DbNhaSach.ChiTietCaTrucs.InsertOnSubmit(ct);
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

        public void xoaCTCaTruc(int ma)
        {
            try
            {
                var xoa = from ct in DbNhaSach.ChiTietCaTrucs
                          where ct.maCTCT == ma
                          select ct;
                foreach (var item in xoa)
                {
                    DbNhaSach.ChiTietCaTrucs.DeleteOnSubmit(item);
                    DbNhaSach.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaCTCaTruc(int maCTCT, int maCT, string maNS)
        {
            try
            {
                var capnhat = DbNhaSach.ChiTietCaTrucs.Single(ct => ct.maCTCT == maCTCT);
                capnhat.maCT = maCT;
                capnhat.maNS = maNS;
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
