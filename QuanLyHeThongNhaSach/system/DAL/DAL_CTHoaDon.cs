using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTHoaDon : DAL_Data
    {
        private static DAL_CTHoaDon instance;
        public static DAL_CTHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_CTHoaDon();
                }
                return instance;
            }
        }

        public bool ThemCTHoaDon(ET_CTHoaDon ctHoaDon)
        {
            try
            {
                // Tạo đối tượng CTHoaDon từ lớp ET_CTHoaDon
                CTHoaDon ctHd = new CTHoaDon
                {
                    maHD = ctHoaDon.MaHD,
                    maHH = ctHoaDon.MaHH,
                    SL = ctHoaDon.SoLuong
                };

                // Thêm vào bảng CTHoaDon
                DbNhaSach.CTHoaDons.InsertOnSubmit(ctHd);
                DbNhaSach.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                throw ex; // Ném lại ngoại lệ để xử lý bên ngoài nếu cần
            }
            return true; // Trả về true nếu thành công
        }

        public IQueryable xemChiTietHoaDon(string mahd)
        {
            IQueryable hangHoa = from cthd in dbNhaSach.CTHoaDons
                                 join hh in dbNhaSach.HangHoas on cthd.maHH equals hh.maHH
                                 join hd in dbNhaSach.HoaDons on cthd.maHD equals hd.maHD
                                 where cthd.maHD == mahd
                                 select new
                                 {
                                     MaHH = cthd.maHH,
                                     TenHH = hh.tenHH,
                                     TongTien = hd.tongTien,
                                     SoLuong = cthd.SL,

                                 };
            return hangHoa;
                                 
        }
    }
}
