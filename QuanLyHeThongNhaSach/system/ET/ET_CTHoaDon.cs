using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_CTHoaDon
    {
        private string maHD;
        private string maHH;
        private int soLuong;
        private int donGia;
        public ET_CTHoaDon(string maHD, string maHH, int soLuong, int donGia)
        {
            this.MaHD = maHD;
            this.MaHH = maHH;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
    }
}
