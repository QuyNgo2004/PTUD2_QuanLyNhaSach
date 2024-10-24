using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CaTruc : DAL_Data
    {
        private static DAL_CaTruc instance;
        public static DAL_CaTruc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_CaTruc();
                }
                return instance;
            }
        }
        //QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSCaTruc()
        {
            IQueryable dsCaTruc = from ct in DbNhaSach.CaTrucs
                                  join cn in DbNhaSach.ChiNhanhs on ct.maCN equals cn.maCN
                                  select new
                                  {
                                      Mã = ct.maCT,
                                      Tên = ct.tenCaTruc,
                                      Chi_Nhánh = cn.tenCN,
                                      Số_Lượng = ct.SL,
                                      Ghi_Chú = ct.ghiChu,
                                  };
            return dsCaTruc;
        }

        public bool themCaTruc(ET_CaTruc CaTruc)
        {
            try
            {
                CaTruc ct = new CaTruc()
                {
                    tenCaTruc = CaTruc.TenCT,
                    maCN = CaTruc.MaCN,
                    SL = CaTruc.SL,
                    ghiChu= CaTruc.GhiChu,
                };
                DbNhaSach.CaTrucs.InsertOnSubmit(ct);
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

        public void xoaCaTruc(int ma)
        {
            try
            {
                var xoa = from ct in DbNhaSach.CaTrucs
                          where ct.maCT == ma
                          select ct;
                foreach (var item in xoa)
                {
                    DbNhaSach.CaTrucs.DeleteOnSubmit(item);
                    DbNhaSach.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaCaTruc(ET_CaTruc CaTruc)
        {
            try
            {
                var capnhat = DbNhaSach.CaTrucs.Single(ct => ct.maCT == CaTruc.MaCT);
                capnhat.tenCaTruc = CaTruc.TenCT;
                capnhat.maCN = CaTruc.MaCN;
                capnhat.SL = CaTruc.SL;
                capnhat.ghiChu = CaTruc.GhiChu;
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
