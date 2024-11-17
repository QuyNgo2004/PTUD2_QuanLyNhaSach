using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhuyenMaiReport
    {
        private string maKM, tenHH, ghiChu, tenKM,tenHH_KM;
        private int maGiamGia;
        private DateTime ngayBD, ngayKT;

        public ET_KhuyenMaiReport()
        {
        }

        public ET_KhuyenMaiReport(string maKM, string tenHH, string ghiChu, string tenKM, string tenHH_KM, int maGiamGia, DateTime ngayBD, DateTime ngayKT)
        {
            this.maKM = maKM;
            this.tenHH = tenHH;
            this.ghiChu = ghiChu;
            this.tenKM = tenKM;
            this.tenHH_KM = tenHH_KM;
            this.maGiamGia = maGiamGia;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }

        public string MaKM { get => maKM; set => maKM = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public string TenHH_KM { get => tenHH_KM; set => tenHH_KM = value; }
        public int MaGiamGia { get => maGiamGia; set => maGiamGia = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
    }
}
