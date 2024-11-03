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

        public ET_CTHoaDon(string maHD, string maHH, int soLuong)
        {
            this.MaHD = maHD;
            this.MaHH = maHH;
            this.SoLuong = soLuong;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
