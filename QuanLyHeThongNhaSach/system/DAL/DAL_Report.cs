using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Report : DAL_Data
    {
        private static DAL_Report instance;
        public static DAL_Report Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Report();
                }
                return instance;
            }
        }

        public DataTable GetDataInHoaDon(string maHD)
        {
            //using (QLNhaSachDataContext db = new QLNhaSachDataContext())
            //{
                // Gọi stored procedure qua DBML
                var result = dbNhaSach.InHoaDon(maHD);

                // Tạo DataTable để chứa dữ liệu
                DataTable dt = new DataTable();
                dt.Columns.Add("maHD", typeof(string));
                dt.Columns.Add("maNS", typeof(string));
                dt.Columns.Add("tongTien", typeof(decimal));
                dt.Columns.Add("ngayIn", typeof(DateTime));
                dt.Columns.Add("sdtKH", typeof(string));
                dt.Columns.Add("SL", typeof(int));
                dt.Columns.Add("DonGia", typeof(decimal));
                dt.Columns.Add("ThanhTien", typeof(decimal));
                dt.Columns.Add("tenHH", typeof(string));

                // Đổ dữ liệu từ kết quả vào DataTable
                foreach (var item in result)
                {
                    dt.Rows.Add(
                        item.maHD,
                        item.maNS,
                        item.tongTien,
                        item.ngayIn,
                        item.sdtKH,
                        item.SL,
                        item.DonGia,
                        item.ThanhTien,
                        item.tenHH
                    );
                }

                return dt;
            //}
        }

        

    }
}
