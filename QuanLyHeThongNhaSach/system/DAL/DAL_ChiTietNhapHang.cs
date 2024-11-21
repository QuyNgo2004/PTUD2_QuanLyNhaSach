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
            IQueryable chitiet = from nh in dbNhaSach.NhapHangs
                                 join chithh in dbNhaSach.ChTietNhapHangs
                                 on nh.maNH equals chithh.maNH
                                 join hh in dbNhaSach.HangHoas on chithh.maHH equals hh.maHH
                                 where nh.maNH == maNH
                                 select new
                                 {
                                     MaChiTietNhapHang = chithh.maCTNCC,
                                     MaNhapHang = chithh.maNH,
                                     MaHangHoa = hh.maHH,
                                     SoLuong = chithh.soLuong,
                                     GhiChu = chithh.ghiChu,
                                 };
            return chitiet;
        }
        public List<ET_ChiTietNhapHang> XemDSChiTietNhapHangTheoMa_Report(string maNH)
        {
            IEnumerable<ET_ChiTietNhapHang> chitiet = from nh in dbNhaSach.NhapHangs
                                 join chithh in dbNhaSach.ChTietNhapHangs
                                 on nh.maNH equals chithh.maNH
                                 join hh in dbNhaSach.HangHoas on chithh.maHH equals hh.maHH
                                 where nh.maNH == maNH
                                 select new ET_ChiTietNhapHang
                                 {
                                     maCTNCC = chithh.maCTNCC,
                                     maNH = chithh.maNH,
                                     maHH = hh.maHH,
                                     tenHangHoa = hh.tenHH,
                                     soLuong = int.Parse(chithh.soLuong.ToString()),
                                     GhiChu = chithh.ghiChu,
                                 };
             List<ET_ChiTietNhapHang> CTNhapHang = new List<ET_ChiTietNhapHang>();
            return CTNhapHang = chitiet.ToList();
        }

        public ET_ChiTietNhapHang TimChiTietNhapHangTheoMaHH(string maHH, string maCTNH)
        {
            IQueryable<ET_ChiTietNhapHang> chitiet = from ct in dbNhaSach.ChTietNhapHangs
                                                     where ct.maHH == maHH && ct.maCTNCC.ToString() == maCTNH
                                                     select new ET_ChiTietNhapHang
                                                     {
                                                         MaHH = ct.maHH,
                                                         MaCTNCC = ct.maCTNCC
                                                     };
            return chitiet.FirstOrDefault();
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
