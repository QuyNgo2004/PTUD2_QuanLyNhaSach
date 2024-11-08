using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietNhapHang
    {
        public string maNH, maHH, ghiChu, tenHangHoa;
        public int maCTNCC, soLuong;

        public ET_ChiTietNhapHang()
        {
        }

        public ET_ChiTietNhapHang(string maNH, string maHH, string ghiChu, string tenHangHoa, int maCTNCC, int soLuong)
        {
            this.maNH = maNH;
            this.maHH = maHH;
            this.ghiChu = ghiChu;
            this.TenHangHoa = tenHangHoa;
            this.maCTNCC = maCTNCC;
            this.soLuong = soLuong;
        }

        public string MaNH { get => maNH; set => maNH = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public string TenHangHoa { get => tenHangHoa; set => tenHangHoa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaCTNCC { get => maCTNCC; set => maCTNCC = value; }
    }
}
