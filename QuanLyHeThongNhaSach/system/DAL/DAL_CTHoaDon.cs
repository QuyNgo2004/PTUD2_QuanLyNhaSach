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

    }
}
