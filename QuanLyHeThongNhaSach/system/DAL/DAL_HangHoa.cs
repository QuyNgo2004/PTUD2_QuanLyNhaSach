using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HangHoa : DAL_Data
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

        //Tạo một đối tượng 'dbNhaSach' từ lớp QLNhaSachDataContext.
        //private QLNhaSachDataContext dbNhaSach = new QLNhaSachDataContext();

        //Xem danh sách loại hàng.
        public IQueryable XemDSHangHoa()
        {
            IQueryable hanghoa = from hh in dbNhaSach.HangHoas
                                 join hanghoa1 in dbNhaSach.LoaiHangHoas on hh.maLHH equals hanghoa1.maLHH
                                 join hanghoa2 in dbNhaSach.NhaPhanPhois on hh.maNPP equals hanghoa2.maNPP
                                 select new
                                 {
                                     Ma = hh.maHH,
                                     Ten = hh.tenHH,
                                     Loai = hanghoa1.tenLHH,
                                     Gia = hh.giaHH,
                                     DonViTinh = hh.donViTinh,
                                     SoLuongTon = hh.soLuongTon,
                                     NhaPhanPhoi = hanghoa2.tenNPP,
                                     TacGia = hh.tacGia,
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
            if (dbNhaSach.HangHoas.Any(hh => hh.maHH == etHH.MaHH))
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
                        tacGia = etHH.TacGia,
                        moTa = etHH.MoTa,
                        ghiChu = etHH.GhiChu,
                        tinhTrang = etHH.TinhTrang,

                    };
                    //Thêm loại hàng vào cơ sở dữ liệu
                    dbNhaSach.HangHoas.InsertOnSubmit(hh);
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

        /// <summary>
        /// Xóa hàng hoa
        /// </summary>
        /// <returns></returns>
        public bool XoaHangHoa(string maHH)
        {
            try
            {
                //Truy vấn lấy tất cả các bản ghi trong HangHoa có maLHH bằng với maHangHoa.
                var xoa = from hh in dbNhaSach.HangHoas
                          where hh.maHH == maHH
                          select hh;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu.
                foreach (var x in xoa)
                {
                    dbNhaSach.HangHoas.DeleteOnSubmit(x);
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

        /// <summary>
        /// Sửa hàng hóa.
        /// </summary>
        public void SuaHangHoa(ET_HangHoa etHH)
        {
            // Tìm đối tượng LoaiHangHoas trong cơ sở dữ liệu dựa trên maKH.

            var update = dbNhaSach.HangHoas.Single(hh => hh.maHH == etHH.MaHH);

            // Cập nhật dựa trên thông tin nhận được.

            update.tenHH = etHH.TenHH;
            update.maLHH = etHH.LoaiHH;
            update.giaHH = etHH.GiaHH;
            update.donViTinh = etHH.DonviTinh;
            update.soLuongTon = etHH.SlTon;
            update.maNPP = etHH.NhaPP;
            update.tacGia = etHH.TacGia;
            update.moTa = etHH.MoTa;
            update.ghiChu = etHH.GhiChu;
            update.tinhTrang = etHH.TinhTrang;

            // Lưu các thay đổi vào cơ sở dữ liệu.
            dbNhaSach.SubmitChanges();
        }

        //Tạo mã hàng hóa tự động.
        public string TaoMaHangHoaTuDong()
        {
            //Lấy ngày hiện tại với định dạng yymmdd.
            string dinhdangngay = DateTime.Now.ToString("yyMMdd");
            //Đếm số lượng loại hàng.
            int countMaHH = dbNhaSach.HangHoas.Count() + 1;

            //Tạo mã mới.
            string NewMaHH;
            do
            {
                if (countMaHH < 1000)
                {
                    NewMaHH = $"801{dinhdangngay}0{countMaHH}";
                }
                else
                {
                    NewMaHH = $"801{dinhdangngay}{countMaHH}";
                }
                countMaHH++;
            } while (dbNhaSach.HangHoas.Any(kh => kh.maHH == NewMaHH));
            return NewMaHH;
        }

        public ET_HangHoa TimHangHoaTheoMa(string ma)
        {
            try
            {
                // Sử dụng DbNhaSach để gọi stored procedure
                var result = DbNhaSach.TimHangHoaTheoMa(ma).FirstOrDefault();

                if (result != null)
                {
                    return new ET_HangHoa(
                        result.maHH,
                        result.tenHH,
                        result.tenLHH,
                        result.giaHH,
                        result.donViTinh,
                        result.soLuongTon,
                        result.tenNPP,
                        result.moTa,
                        result.ghiChu,
                        result.tinhTrang
                    );
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm hàng hóa theo mã: " + ex.Message);
            }
        }

        public IQueryable XemDSHangHoaAutoCompleted()
        {
            IQueryable hanghoa = (from hh in dbNhaSach.HangHoas
                                 join hanghoa1 in dbNhaSach.LoaiHangHoas on hh.maLHH equals hanghoa1.maLHH
                                 join hanghoa2 in dbNhaSach.NhaPhanPhois on hh.maNPP equals hanghoa2.maNPP
                                 select new
                                 {                                     
                                     Ten = hh.tenHH,
                                 });

            return hanghoa;
        }

        public int GetSoLuongTon(string maHH)
        {
            int soLuong = (from hh in dbNhaSach.HangHoas
                          where hh.maHH == maHH
                          select hh.soLuongTon).FirstOrDefault();
            return soLuong;
        }

        public bool UpdateSoLuongTon(string maHH,int soLuongMoi)
        {
            try
            {
                // Tìm sản phẩm với mã hàng hóa tương ứng
                var hangHoa = dbNhaSach.HangHoas.SingleOrDefault(hh => hh.maHH == maHH);

                // Kiểm tra xem sản phẩm có tồn tại không
                if (hangHoa != null)
                {
                    // Cập nhật số lượng tồn mới
                    hangHoa.soLuongTon = soLuongMoi;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbNhaSach.SubmitChanges();
                    return true; // Cập nhật thành công
                }
                else
                {
                    return false; // Không tìm thấy sản phẩm
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật số lượng tồn: " + ex.Message);
            }
        //Tìm hàng hóa.

        public ET_HangHoa TimHangHoa(string maHangHoa)
        {
            IQueryable<ET_HangHoa> hanghoa = from hh in dbNhaSach.HangHoas
                                 //join hanghoa1 in dbNhaSach.LoaiHangHoas on hh.maLHH equals hanghoa1.maLHH
                                 //join hanghoa2 in dbNhaSach.NhaPhanPhois on hh.maNPP equals hanghoa2.maNPP
                                 where hh.maHH == maHangHoa 
                                 select new ET_HangHoa
                                 {
                                     MaHH = hh.maHH,
                                     TenHH = hh.tenHH,
                                     LoaiHH = hh.maLHH,
                                     GiaHH = hh.giaHH,
                                     DonviTinh = hh.donViTinh,
                                     SlTon = hh.soLuongTon,
                                     NhaPP = hh.maNPP,
                                     TacGia = hh.tacGia,
                                     MoTa = hh.moTa,
                                     GhiChu = hh.ghiChu,
                                     TinhTrang = hh.tinhTrang
                                 };
            ET_HangHoa hhoa = hanghoa.FirstOrDefault();
            return hhoa;
        }

        public ET_HangHoa TimNPP(string maNPP, string maHH)
        {
            IQueryable<ET_HangHoa> hanghoa = from hh in dbNhaSach.HangHoas
                                                   //join hanghoa1 in dbNhaSach.LoaiHangHoas on hh.maLHH equals hanghoa1.maLHH
                                                   //join hanghoa2 in dbNhaSach.NhaPhanPhois on hh.maNPP equals hanghoa2.maNPP
                                             where hh.maNPP == maNPP && hh.maHH == maHH
                                             select new ET_HangHoa
                                             {
                                                 MaHH = hh.maHH,
                                                 TenHH = hh.tenHH,
                                                 LoaiHH = hh.maLHH,
                                                 GiaHH = hh.giaHH,
                                                 DonviTinh = hh.donViTinh,
                                                 SlTon = hh.soLuongTon,
                                                 NhaPP = hh.maNPP,
                                                 TacGia = hh.tacGia,
                                                 MoTa = hh.moTa,
                                                 GhiChu = hh.ghiChu,
                                                 TinhTrang = hh.tinhTrang
                                             };
            ET_HangHoa hhoa = hanghoa.FirstOrDefault();
            return hhoa;
        }
    }
}
