using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhapHang
    {
        private string maNH, maNPP;
        private DateTime ngayNH;

        public ET_NhapHang()
        {
        }

        public ET_NhapHang(string maNH, string maNPP, DateTime ngayNH)
        {
            this.MaNH = maNH;
            this.MaNPP = maNPP;
            this.NgayNH = ngayNH;
        }

        public string MaNH { get => maNH; set => maNH = value; }
        public string MaNPP { get => maNPP; set => maNPP = value; }
        public DateTime NgayNH { get => ngayNH; set => ngayNH = value; }
    }
}
