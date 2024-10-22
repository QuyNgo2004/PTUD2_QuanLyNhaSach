using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_CaTruc
    {
        private string maCN, tenCT, ghiChu;
        private int sL,maCT;

        public ET_CaTruc()
        {
        }

        public ET_CaTruc(string maCN, string tenCT, string ghiChu, int sL, int maCT)
        {
            this.MaCN = maCN;
            this.TenCT = tenCT;
            this.GhiChu = ghiChu;
            this.SL = sL;
            this.maCT = maCT;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int SL { get => sL; set => sL = value; }
        public int MaCT { get => maCT; set => maCT = value; }
    }
}
