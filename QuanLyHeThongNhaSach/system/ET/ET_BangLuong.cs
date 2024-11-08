using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BangLuong
    {
        private string maBangLuong, maQL, tenQL;
        private DateTime ngayBD, ngayKT;

        public string MaBangLuong { get => maBangLuong; set => maBangLuong = value; }
        public string MaQL { get => maQL; set => maQL = value; }
        public string TenQL { get => tenQL; set => tenQL = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }

        public ET_BangLuong(string maBangLuong, string maQL, string tenQL, DateTime ngayBD, DateTime ngayKT)
        {
            this.MaBangLuong = maBangLuong;
            this.MaQL = maQL;
            this.TenQL = tenQL;
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
        }

        public ET_BangLuong()
        {
        }
    }
}
