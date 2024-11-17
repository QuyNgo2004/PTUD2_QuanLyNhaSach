using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhuyenMai
    {
        private string tenHH,maKM, maHH, ghiChu,tenKM;
        private int maGiamGia;
        private DateTime ngayBD, ngayKT;

        public string MaKM { get => maKM; set => maKM = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public int MaGiamGia { get => maGiamGia; set => maGiamGia = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }

        public ET_KhuyenMai(string maKM, string maHH, string ghiChu, string tenKM, int maGiamGia, DateTime ngayBD, DateTime ngayKT)
        {
            this.MaKM = maKM;
            this.MaHH = maHH;
            this.GhiChu = ghiChu;
            this.TenKM = tenKM;
            this.MaGiamGia = maGiamGia;
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
        }

        public ET_KhuyenMai()
        {
        }
    }
}
