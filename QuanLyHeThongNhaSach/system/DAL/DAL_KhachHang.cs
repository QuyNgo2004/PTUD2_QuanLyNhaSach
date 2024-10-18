﻿using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        //Khai báo biến tĩnh.
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_KhachHang();
                }
                return instance;
            }
        }

        //Tạo một đối tượng 'db' từ lớp QLNhaSachDataContext.
        private QLNhaSachDataContext db = new QLNhaSachDataContext();

        //Xem danh sách khách hàng.
        public IQueryable XemDSKhachHang()
        {
            IQueryable khachhang = from kh in db.KhachHangs
                              select kh;
            return khachhang;
        }

        /// <summary>
        /// Thêm khách hàng.
        /// </summary>
        /// <param name="etKhachHang"></param>
        /// <returns></returns>
        public bool ThemKhachHang(ET_KhachHang etKhachHang)
        {
            //Kiểm tra xem có trùng mã khách hàng hay không, nếu trùng trả về false.
            if (db.KhachHangs.Any(kh => kh.maKH == etKhachHang.MaKH))
            {
                //Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp.
                return false;
            }
            else
            {
                try
                {
                    //Tạo một đối tượng mới của khách hàng.
                    KhachHang kh = new KhachHang
                    {
                        maKH = etKhachHang.MaKH,
                        hoTenKH = etKhachHang.HotenKH,
                        ngaysinhKH = etKhachHang.NgaysinhKH,
                        gioitinhKH = etKhachHang.GioitinhKH,
                        diachiKH = etKhachHang.DiachiKH,
                        sdtKH = etKhachHang.SdtKH,
                        emailKH = etKhachHang.EmailKH,
                    };
                    //Thêm khách hàng vào cơ sở dữ liệu
                    db.KhachHangs.InsertOnSubmit(kh);
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
        /// Xóa khách hàng.
        /// </summary>
        /// <param name="maKhachHang"></param>
        /// <returns></returns>
        public bool XoaKhachHang(string maKhachHang)
        {
            try
            {
                //Truy vấn lấy tất cả các bản ghi trong KhachHangs có maKH bằng với maKhachHang.
                var xoa = from kh in db.KhachHangs
                          where kh.maKH == maKhachHang
                          select kh;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu.
                foreach (var x in xoa)
                {
                    db.KhachHangs.DeleteOnSubmit(x);
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
        /// Sửa khách hàng.
        /// </summary>
        /// <param name="etKhachHang"></param>
        public void SuaKhachHang(ET_KhachHang etKhachHang)
        {
            // Tìm đối tượng KhachHangs trong cơ sở dữ liệu dựa trên maKH.

            var update = db.KhachHangs.Single(bn => bn.maKH == etKhachHang.MaKH);

            // Cập nhật dựa trên thông tin nhận được.

            update.hoTenKH = etKhachHang.HotenKH;
            update.ngaysinhKH = etKhachHang.NgaysinhKH;
            update.gioitinhKH = etKhachHang.GioitinhKH;
            update.diachiKH = etKhachHang.DiachiKH;
            update.sdtKH = etKhachHang.SdtKH;
            update.emailKH = etKhachHang.EmailKH;

            // Lưu các thay đổi vào cơ sở dữ liệu.
            db.SubmitChanges();
        }

        /// <summary>
        /// Tìm kiếm khách hàng.
        /// </summary>
        /// <returns></returns>
        public IQueryable TimKiemKhachHang(string sdtKH)
        {
            // Truy vấn bệnh nhân dựa trên sdtKH
            IQueryable ds = from dl in db.KhachHangs
                            where (sdtKH == null || dl.sdtKH == sdtKH)
                            select dl;
            //Trả về kết quả truy vấn
            return ds;
        }
    }
}
