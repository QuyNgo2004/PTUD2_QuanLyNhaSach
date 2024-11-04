using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoaDon
    {
        private string maHD;
        private string maNS;
        private string maKH;
        private double tongTien;
        private DateTime ngayIn;
        private string ghiChu;

        public ET_HoaDon(string maHD, string maNS, string maKH, double tongTien, DateTime ngayIn, string ghiChu)
        {
            this.MaHD = maHD;
            this.MaNS = maNS;
            this.MaKH = maKH;
            this.TongTien = tongTien;
            this.NgayIn = ngayIn;
            this.GhiChu = ghiChu;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNS { get => maNS; set => maNS = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayIn { get => ngayIn; set => ngayIn = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
