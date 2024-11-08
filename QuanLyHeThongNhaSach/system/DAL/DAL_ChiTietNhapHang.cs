using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietNhapHang : DAL_Data
    {
        //Khai báo biến tĩnh.
        private static DAL_ChiTietNhapHang instance;

        public static DAL_ChiTietNhapHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiTietNhapHang();
                }
                return instance;
            }
        }

        public IQueryable XemDSChiTietNhapHang()
        {
            IQueryable chitiet = from ctnh in dbNhaSach.ChTietNhapHangs
                                  join hh in dbNhaSach.HangHoas on ctnh.maHH equals hh.maHH
                                  select new
                                  {
                                      MaChiTietNhapHang = ctnh.maCTNCC,
                                      MaNhapHang = ctnh.maNH,
                                      MaHangHoa = ctnh.maHH,
                                      SoLuong = ctnh.soLuong,
                                      GhiChu = ctnh.ghiChu,
                                  };
            return chitiet;
        }

        public IQueryable XemDSChiTietNhapHangTheoMa(string maNH)
        {
            IQueryable chitiet = from ctnh in dbNhaSach.ChTietNhapHangs
                                 join hh in dbNhaSach.HangHoas on ctnh.maHH equals hh.maHH
                                 select new
                                 {
                                     MaChiTietNhapHang = ctnh.maCTNCC,
                                     MaNhapHang = ctnh.maNH,
                                     MaHangHoa = ctnh.maHH,
                                     SoLuong = ctnh.soLuong,
                                     GhiChu = ctnh.ghiChu,
                                 };
            return chitiet;
        }

        public bool ThemChiTiet(ET_ChiTietNhapHang etCT)
        {
            try
            {
                //Tạo một đối tượng mới.
                ChTietNhapHang ct = new ChTietNhapHang
                {
                    maNH = etCT.MaNH,
                    maHH = etCT.MaHH,
                    soLuong = etCT.soLuong,
                    ghiChu = etCT.GhiChu,
                };
                //Thêm loại hàng vào cơ sở dữ liệu
                dbNhaSach.ChTietNhapHangs.InsertOnSubmit(ct);
            }
            finally
            {
                // Lưu các thay đổi vào cơ sở dữ liệu
                dbNhaSach.SubmitChanges();
            }
            // Trả về true để báo hiệu việc thêm mới thành công
            return true;
        }

        public bool XoaChiTiet(string maCT)
        {
            try
            {
                //Truy vấn lấy tất cả các bản ghi trong HangHoa có maLHH bằng với maHangHoa.
                var xoa = from ct in dbNhaSach.ChTietNhapHangs
                          where ct.maHH == maCT
                          select ct;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu.
                foreach (var x in xoa)
                {
                    dbNhaSach.ChTietNhapHangs.DeleteOnSubmit(x);
                    dbNhaSach.SubmitChanges();
                }
                // Nếu xóa thành công, trả về true.
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // Xử lý các trường hợp ngoại lệ cụ thể, chẳng hạn liên quan đến ràng buộc khóa ngoại
                if (ex.Number == 547)
                {
                    // Trả về false nếu có lỗi do ràng buộc khóa ngoại
                    return false;
                }
                return false;
            }
        }
    }
}
