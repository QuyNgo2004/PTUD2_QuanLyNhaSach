using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon : DAL_Data
    {
        private static DAL_HoaDon instance;
        public static DAL_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_HoaDon();
                }
                return instance;
            }
        }
        public bool ThemHoaDon(ET_HoaDon hoaDon)
        {
            try
            {
                // Tạo đối tượng HoaDon từ lớp ET_HoaDon
                HoaDon hd = new HoaDon
                {
                    maHD = hoaDon.MaHD,
                    maNS = hoaDon.MaNS,
                    maKH = hoaDon.MaKH,
                    tongTien = hoaDon.TongTien,
                    ngayIn = hoaDon.NgayIn,
                    ghiChu = hoaDon.GhiChu,
                };

                // Thêm vào bảng HoaDon
                DbNhaSach.HoaDons.InsertOnSubmit(hd);
                DbNhaSach.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                throw ex; // Ném lại ngoại lệ để xử lý bên ngoài nếu cần
            }
            return true; // Trả về true nếu thành công
        }

        public string AutoMa_HoaDon()
        {
            int demHD = dbNhaSach.HoaDons.Count();
            string newMa;
            do
            {
                demHD++;
                if (demHD < 10)
                {
                    newMa = $"HD0{demHD}";
                }
                else
                {
                    newMa = $"HD{demHD}";
                }
            } while (dbNhaSach.HoaDons.Any(hd => hd.maHD == newMa));
            return newMa;
        }
        public IQueryable xemDanhSachHoaDon()
        {
            IQueryable dsHoaDon = from hd in dbNhaSach.HoaDons
                                  select new
                                  {
                                      MaHD = hd.maHD,
                                      MaNS = hd.maNS,
                                      MaKH = hd.maKH,
                                      TongTien = hd.tongTien,
                                      NgayIn = hd.ngayIn,
                                  };
            return dsHoaDon;
        }

        public IQueryable TimHoaDonTheoSDT(string soDienThoai,DateTime dateTime)
        {
            try
            {
                IQueryable dsHoaDon = from hd in dbNhaSach.HoaDons
                                      join kh in dbNhaSach.KhachHangs on hd.maKH equals kh.maKH
                                      where kh.sdtKH == soDienThoai && hd.ngayIn <= dateTime
                                      select new
                                      {
                                          MaHD = hd.maHD,
                                          MaNS = hd.maNS,
                                          MaKH = hd.maKH,
                                          TongTien = hd.tongTien,
                                          NgayIn = hd.ngayIn,
                                          GhiChu = hd.ghiChu,
                                      };
                return dsHoaDon;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable TimHoaDonTheoTenNV(string tenNV,DateTime dateTime) 
        {
            try
            {
                IQueryable dsHoaDon = from hd in dbNhaSach.HoaDons
                                      join nv in dbNhaSach.NhanSus on hd.maNS equals nv.maNS
                                      where nv.tenNS == tenNV && hd.ngayIn <= dateTime
                                      select new
                                      {
                                          MaHD = hd.maHD,
                                          MaNS = hd.maNS,
                                          MaKH = hd.maKH,
                                          TongTien = hd.tongTien,
                                          NgayIn = hd.ngayIn,
                                          GhiChu = hd.ghiChu,
                                      };
                return dsHoaDon;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable TimHoaDonTheoNgayThanhToan(DateTime dateTime)
        {
            try
            {
                IQueryable dsHoaDon = from hd in dbNhaSach.HoaDons                                      
                                      where hd.ngayIn <= dateTime
                                      select new
                                      {
                                          MaHD = hd.maHD,
                                          MaNS = hd.maNS,
                                          MaKH = hd.maKH,
                                          TongTien = hd.tongTien,
                                          NgayIn = hd.ngayIn,
                                          GhiChu = hd.ghiChu,
                                      };
                return dsHoaDon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IQueryable TimHoaDonTongHop(string soDienThoai,string tenNV,DateTime dateTime)
        {
            try
            {
                IQueryable dsHoaDon = from hd in dbNhaSach.HoaDons
                                      join nv in dbNhaSach.NhanSus on hd.maNS equals nv.maNS
                                      join kh in dbNhaSach.KhachHangs on hd.maKH equals kh.maKH
                                      where hd.ngayIn <= dateTime && nv.tenNS == tenNV && kh.sdtKH == soDienThoai
                                      select new
                                      {
                                          MaHD = hd.maHD,
                                          MaNS = hd.maNS,
                                          MaKH = hd.maKH,
                                          TongTien = hd.tongTien,
                                          NgayIn = hd.ngayIn,
                                          GhiChu = hd.ghiChu,
                                      };
                return dsHoaDon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
