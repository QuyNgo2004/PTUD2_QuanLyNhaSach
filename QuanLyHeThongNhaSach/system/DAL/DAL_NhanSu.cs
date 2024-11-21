using ET;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanSu : DAL_Data
    {
        private static DAL_NhanSu instance;
        public static DAL_NhanSu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_NhanSu();
                }
                return instance;
            }
        }
        //QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSNhanSu()
        {
            IQueryable dsNhanSu = from ns in DbNhaSach.NhanSus
                                  join cn in DbNhaSach.ChiNhanhs on ns.maCN equals cn.maCN
                                  join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                                  select new
                                  {
                                      Mã = ns.maNS,
                                      Họ_Tên = ns.tenNS,
                                      Giới_Tính = ns.gioiTinh,
                                      CCCD = ns.cccdNS,
                                      SoDienThoai = ns.sdtNV,
                                      Email = ns.emailNV,
                                      Địa_Chỉ_Nhà  = ns.diaChiNha,
                                      Chi_Nhánh = cn.tenCN,
                                      Chức_vụ = cv.tenChucVu,
                                      Lương_Căn_Bản = ns.luongcanban,
                                    };
            return dsNhanSu;
        }
        public IQueryable<NhanSu> layDSNhanSu_MK()
        {
            IQueryable<NhanSu> dsNhanSu = from ns in DbNhaSach.NhanSus
                                  join cn in DbNhaSach.ChiNhanhs on ns.maCN equals cn.maCN
                                  join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                                  select new NhanSu
                                  {
                                      maNS = ns.maNS,
                                      tenNS = ns.tenNS,
                                      gioiTinh = ns.gioiTinh,
                                      cccdNS = ns.cccdNS,
                                      sdtNV = ns.sdtNV,
                                      emailNV = ns.emailNV,
                                      diaChiNha = ns.diaChiNha,
                                      maCN = ns.maCN,
                                      chucVu = ns.chucVu,
                                      matkhau = ns.maNS,
                                      luongcanban = ns.luongcanban,
                                  };
            return dsNhanSu;
        }
        public ET_NhanSu TimNhanSu(string tenDN,string matKhau)
        {
            var listNS = from ns in dbNhaSach.NhanSus
                                join cn in DbNhaSach.ChiNhanhs on ns.maCN equals cn.maCN
                                join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                                where ns.maNS == tenDN && ns.matkhau == matKhau
                                select new 
                                {
                                    MaNS = ns.maNS,
                                    TenNS = ns.tenNS,
                                    GioiTinh = ns.gioiTinh,
                                    CccdNS = ns.cccdNS,
                                    SdtNV = ns.sdtNV,
                                    EmailNV = ns.emailNV,
                                    DiaChiNha = ns.diaChiNha,
                                    MaCN = ns.maCN,
                                    ChucVu = ns.chucVu,
                                    Matkhau = ns.matkhau,
                                    LuongCanBan = ns.luongcanban
                                };
            if (listNS.Count() > 0) {
                var r = listNS.FirstOrDefault();
                ET_NhanSu nhanSu = new ET_NhanSu
                {
                    MaNS = r.MaNS,
                    TenNS = r.TenNS,
                    GioiTinh = r.GioiTinh,
                    CCCD = r.CccdNS,
                    SDT = r.SdtNV,
                    Email = r.EmailNV,
                    DiaChi = r.DiaChiNha,
                    MaCN = r.MaCN,
                    ChucVu = int.Parse(r.ChucVu.ToString()),
                    MatKhau = r.Matkhau,
                    LuongCanBan = int.Parse(r.LuongCanBan.ToString()) ,
                };
                return nhanSu;
            }
            return null;
           
        }
        // Loc nhan su theo chi nhanh
        public IQueryable layDSNhanSu(string macn)
        {
            IQueryable dsNhanSu = from ns in DbNhaSach.NhanSus
                                  join cn in DbNhaSach.ChiNhanhs on ns.maCN equals cn.maCN
                                  join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                                  where ns.maCN == macn
                                  select new
                                  {
                                      Mã = ns.maNS,
                                      Họ_Tên = ns.tenNS,
                                      Giới_Tính = ns.gioiTinh,
                                      CCCD = ns.cccdNS,
                                      SoDienThoai = ns.sdtNV,
                                      Email = ns.emailNV,
                                      Địa_Chỉ_Nhà = ns.diaChiNha,
                                      Chi_Nhánh = cn.tenCN,
                                      Chức_vụ = cv.tenChucVu,
                                      Lương_Căn_Bản = ns.luongcanban,
                                  };
            return dsNhanSu;
        }
        public IQueryable<ET_ChiTietLuong> layDSNhanSu_luong(string macn)
        {
            IQueryable<ET_ChiTietLuong> dsNhanSu = from ns in DbNhaSach.NhanSus
                                  join cn in DbNhaSach.ChiNhanhs on ns.maCN equals cn.maCN
                                  join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                                  where ns.maCN == macn
                                  select new ET_ChiTietLuong
                                  {
                                      MaNS = ns.maNS,
                                      TenNS = ns.tenNS,
                                      ChucVu = cv.tenChucVu,
                                      LuongCB = int.Parse(ns.luongcanban),
                                      TienLuong = int.Parse(ns.luongcanban),
                                      NgayLam = 26,
                                      NgayNghi= 0,
                                      NgayTC = 0,
                                  };
            return dsNhanSu;
        }
        //Tạo mã tự động
        public string AutoMa_NhanSu()
        {
            int demNS = dbNhaSach.NhanSus.Count();
            string newMa;
            do
            {
                demNS++;
                if(demNS < 10)
                {
                    newMa = $"NS0{demNS}";
                }
                else
                {
                    newMa = $"NS{demNS}";
                }
            } while (dbNhaSach.NhanSus.Any(ns => ns.maNS == newMa));
            return newMa;
        }
        public bool themNhanSu(ET_NhanSu NhanSu)
        {
            try
            {
                NhanSu ns = new NhanSu()
                {
                    maNS = NhanSu.MaNS,
                    tenNS = NhanSu.TenNS,
                    gioiTinh = NhanSu.GioiTinh,
                    cccdNS = NhanSu.CCCD,
                    sdtNV = NhanSu.SDT,
                    emailNV = NhanSu.Email,
                    diaChiNha = NhanSu.DiaChi,
                    maCN = NhanSu.MaCN,
                    chucVu = NhanSu.ChucVu,
                    luongcanban = NhanSu.LuongCanBan.ToString(),
                    matkhau = "0",
                };
                DbNhaSach.NhanSus.InsertOnSubmit(ns);
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
        public bool KT_TTNS(string ma)
        {
            bool flag = false;
            try
            {
                var xoa = from ns in DbNhaSach.NhanSus
                          where ns.maNS == ma
                          select ns;
                if(xoa.Count() == 0)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return flag;
        }
        public void xoaNhanSu(string ma)
        {
            try
            {
                var xoa = from ns in DbNhaSach.NhanSus
                          where ns.maNS == ma
                          select ns;
                foreach (var item in xoa)
                {
                    DbNhaSach.NhanSus.DeleteOnSubmit(item);
                    DbNhaSach.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaNhanSu(ET_NhanSu NhanSu)
        {
            try
            {
                var capnhat = DbNhaSach.NhanSus.Single(ns => ns.maNS == NhanSu.MaNS);
                capnhat.tenNS = NhanSu.TenNS;
                capnhat.gioiTinh = NhanSu.GioiTinh;
                capnhat.cccdNS = NhanSu.CCCD;
                capnhat.sdtNV = NhanSu.SDT;
                capnhat.emailNV = NhanSu.Email;
                capnhat.diaChiNha = NhanSu.DiaChi;
                capnhat.maCN = NhanSu.MaCN;
                capnhat.luongcanban = NhanSu.LuongCanBan.ToString();
                capnhat.chucVu = NhanSu.ChucVu;
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Tim nhan su

        public ET_NhanSu TimNhanSu(string maNS)
        {
            IEnumerable<ET_NhanSu> listNS = from ns in dbNhaSach.NhanSus
                         join cn in DbNhaSach.ChiNhanhs on ns.maCN equals cn.maCN
                         join cv in DbNhaSach.ChucVus on ns.chucVu equals cv.maChucVu
                         where ns.maNS == maNS 
                         select new ET_NhanSu
                         {
                             MaNS = ns.maNS,
                             TenNS = ns.tenNS,
                             GioiTinh = ns.gioiTinh,
                             CCCD = ns.cccdNS,
                             SDT = ns.sdtNV,
                             Email = ns.emailNV,
                             DiaChi = ns.diaChiNha,
                             MaCN = ns.maCN,
                             ChucVu = int.Parse(ns.chucVu.ToString()),
                             MatKhau = ns.matkhau,
                             LuongCanBan = int.Parse(ns.luongcanban.ToString()),
                         };
            return listNS.FirstOrDefault();

        }
        // Cập nhật mật khẩu

    }
}
