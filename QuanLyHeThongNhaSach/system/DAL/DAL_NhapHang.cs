using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhapHang : DAL_Data
    {
        //Khai báo biến tĩnh.
        private static DAL_NhapHang instance;

        public static DAL_NhapHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_NhapHang();
                }
                return instance;
            }
        }

        public IQueryable XemDSNhapHang()
        {
            IQueryable nhaphang = from nh in dbNhaSach.NhapHangs
                                  join npp in dbNhaSach.NhaPhanPhois on nh.maNPP equals npp.maNPP
                                  select new
                                 {
                                     MaNhapHang = nh.maNH,
                                     MaNPP = npp.maNPP,
                                     TenNPP = npp.tenNPP,
                                     DiaChi = npp.diachiNPP,
                                     NgayNhap = nh.ngayNH,
                                 };
            return nhaphang;
        }

        public bool ThemNhapHang(ET_NhapHang etNH)
        {
            //Kiểm tra xem có trùng mã hay không, nếu trùng trả về false.
            if (dbNhaSach.NhapHangs.Any(nh => nh.maNH == etNH.MaNH))
            {
                //Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp.
                return false;
            }
            else
            {
                try
                {
                    //Tạo một đối tượng mới.
                    NhapHang nh = new NhapHang
                    {
                        maNH = etNH.MaNH,
                        ngayNH = etNH.NgayNH,
                        maNPP = etNH.MaNPP,
                    };
                    //Thêm loại hàng vào cơ sở dữ liệu
                    dbNhaSach.NhapHangs.InsertOnSubmit(nh);
                }
                finally
                {
                    // Lưu các thay đổi vào cơ sở dữ liệu
                    dbNhaSach.SubmitChanges();
                }
                // Trả về true để báo hiệu việc thêm mới thành công
                return true;
            }
        }

        public bool XoaNhapHang(string maNH)
        {
            try
            {
                //Truy vấn lấy tất cả các bản ghi trong HangHoa có maLHH bằng với maHangHoa.
                var xoa = from nh in dbNhaSach.NhapHangs
                          where nh.maNH == maNH
                          select nh;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu.
                foreach (var x in xoa)
                {
                    dbNhaSach.NhapHangs.DeleteOnSubmit(x);
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

        public string TaoMaHangHoaTuDong()
        {
            //Lấy ngày hiện tại với định dạng yymmdd.
            string dinhdangngay = DateTime.Now.ToString("yyMMdd");
            //Đếm số lượng loại hàng.
            int countMaNH = dbNhaSach.NhapHangs.Count() + 1;

            //Tạo mã mới.
            string NewMaNH;
            do
            {
                if (countMaNH < 10)
                {
                    NewMaNH = $"{dinhdangngay}0000{countMaNH}";
                }
                else if (countMaNH < 100)
                {
                    NewMaNH = $"{dinhdangngay}000{countMaNH}";
                }
                else if (countMaNH < 1000)
                {
                    NewMaNH = $"{dinhdangngay}00{countMaNH}";
                }
                else if (countMaNH < 10000)
                {
                    NewMaNH = $"{dinhdangngay}0{countMaNH}";
                }
                else
                {
                    NewMaNH = $"{dinhdangngay}{countMaNH}";
                }
                countMaNH++;
            } while (dbNhaSach.NhapHangs.Any(nh => nh.maNH == NewMaNH));
            return NewMaNH;
        }
    }
}
