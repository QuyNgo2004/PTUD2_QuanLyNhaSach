using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HangHoa
    {
        //Khai báo biến tĩnh.
        private static DAL_HangHoa instance;

        public static DAL_HangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_HangHoa();
                }
                return instance;
            }
        }

        //Tạo một đối tượng 'db' từ lớp QLNhaSachDataContext.
        private QLNhaSachDataContext db = new QLNhaSachDataContext();

        //Xem danh sách loại hàng.
        public IQueryable XemDSHangHoa()
        {
            IQueryable hanghoa = from hh in db.HangHoas
                                 join hanghoa1 in db.LoaiHangHoas on hh.maLHH equals hanghoa1.maLHH
                                 join hanghoa2 in db.NhaPhanPhois on hh.maNPP equals hanghoa2.maNPP
                                 select new
                                 {
                                     Ma = hh.maHH,
                                     Ten = hh.tenHH,
                                     Loai = hanghoa1.tenLHH,
                                     Gia = hh.giaHH,
                                     DonViTinh = hh.donViTinh,
                                     SoLuongTon = hh.soLuongTon,
                                     NhaPhanPhoi = hanghoa2.tenNPP,
                                     MoTa = hh.moTa,
                                     GhiChu = hh.ghiChu,
                                     TinhTrang = hh.tinhTrang
                                     
                                     

                                 };
            return hanghoa;
        }

        /// <summary>
        /// Thêm hàng hóa.
        /// </summary>
        /// <param name="etKhachHang"></param>
        /// <returns></returns>
        public bool ThemHangHoa(ET_HangHoa etHH)
        {
            //Kiểm tra xem có trùng mã loại hàng hay không, nếu trùng trả về false.
            if (db.HangHoas.Any(hh => hh.maHH == etHH.MaHH))
            {
                //Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp.
                return false;
            }
            else
            {
                try
                {
                    //Tạo một đối tượng mới của loại hàng hóa.
                    HangHoa hh = new HangHoa
                    {
                        maHH = etHH.MaHH,
                        tenHH = etHH.TenHH,
                        maLHH = etHH.LoaiHH,
                        giaHH = etHH.GiaHH,
                        donViTinh = etHH.DonviTinh,
                        soLuongTon = etHH.SlTon,
                        maNPP = etHH.NhaPP,
                        moTa = etHH.MoTa,
                        ghiChu = etHH.GhiChu,
                        tinhTrang = etHH.TinhTrang,

                    };
                    //Thêm loại hàng vào cơ sở dữ liệu
                    db.HangHoas.InsertOnSubmit(hh);
                }
                finally
                {
                    // Lưu các thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();
                }
                // Trả về true để báo hiệu việc thêm mới thành công
                return true;
            }
        }

        /// <summary>
        /// Xóa hàng hoa
        /// </summary>
        /// <returns></returns>
        public bool XoaHangHoa(string maHH)
        {
            try
            {
                //Truy vấn lấy tất cả các bản ghi trong HangHoa có maLHH bằng với maHangHoa.
                var xoa = from hh in db.HangHoas
                          where hh.maLHH == maHH
                          select hh;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu.
                foreach (var x in xoa)
                {
                    db.HangHoas.DeleteOnSubmit(x);
                    db.SubmitChanges();
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

        /// <summary>
        /// Sửa hàng hóa.
        /// </summary>
        public void SuaHangHoa(ET_HangHoa etHH)
        {
            // Tìm đối tượng LoaiHangHoas trong cơ sở dữ liệu dựa trên maKH.

            var update = db.HangHoas.Single(hh => hh.maLHH == etHH.MaHH);

            // Cập nhật dựa trên thông tin nhận được.

            update.maHH = etHH.MaHH;
            update.tenHH = etHH.TenHH;
            update.maLHH = etHH.LoaiHH;
            update.giaHH = etHH.GiaHH;
            update.donViTinh = etHH.DonviTinh;
            update.soLuongTon = etHH.SlTon;
            update.maNPP = etHH.NhaPP;
            update.moTa = etHH.MoTa;
            update.ghiChu = etHH.GhiChu;
            update.tinhTrang = etHH.TinhTrang;

            // Lưu các thay đổi vào cơ sở dữ liệu.
            db.SubmitChanges();
        }

        //Tạo mã hàng hóa tự động.
        public string TaoMaHangHoaTuDong()
        {
            //Đếm số lượng loại hàng.
            int countMaHH = db.HangHoas.Count() + 1;

            //Tạo mã mới.
            string NewMaHH;
            do
            {
                NewMaHH = $"KH{countMaHH}";
                countMaHH++;
            } while (db.HangHoas.Any(kh => kh.maHH == NewMaHH));
            return NewMaHH;
        }
    }
}
