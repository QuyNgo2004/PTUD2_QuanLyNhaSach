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
            try
            {
                NhapHang nh = new NhapHang
                {
                    maNH = etNH.MaNH,
                    maNPP = etNH.MaNPP,
                    ngayNH = etNH.NgayNH,

                };

                // Thêm vào bảng HoaDon
                DbNhaSach.NhapHangs.InsertOnSubmit(nh);
                DbNhaSach.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                throw ex; // Ném lại ngoại lệ để xử lý bên ngoài nếu cần
            }
            return true; // Trả về true nếu thành công
        }



        public string TaoMaHangHoaTuDong()
        {
            //Lấy ngày hiện tại với định dạng yymmdd.
            string dinhdangngay = DateTime.Now.ToString("ddMMyy");
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
