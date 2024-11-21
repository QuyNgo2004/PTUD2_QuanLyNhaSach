using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietLuong
    {
        private string maBangLuong, maNS,tenNS;
        private int luongTheoNgay, ngayNghi, ngayLam, tienLuong,maCTLuong;

        public ET_ChiTietLuong()
        {
        }

        public ET_ChiTietLuong(string maBangLuong, string maNS, string tenNS, int luongTheoNgay, int ngayNghi, int ngayLam, int tienLuong, int maCTLuong)
        {
            this.MaBangLuong = maBangLuong;
            this.MaNS = maNS;
            this.TenNS = tenNS;
            this.LuongTheoNgay = luongTheoNgay;
            this.NgayNghi = ngayNghi;
            this.NgayLam = ngayLam;
            this.TienLuong = tienLuong;
            this.MaCTLuong = maCTLuong;
        }

        public string MaBangLuong { get => maBangLuong; set => maBangLuong = value; }
        public string MaNS { get => maNS; set => maNS = value; }
        public string TenNS { get => tenNS; set => tenNS = value; }
        public int LuongTheoNgay { get => luongTheoNgay; set => luongTheoNgay = value; }
        public int NgayNghi { get => ngayNghi; set => ngayNghi = value; }
        public int NgayLam { get => ngayLam; set => ngayLam = value; }
        public int TienLuong { get => tienLuong; set => tienLuong = value; }
        public int MaCTLuong { get => maCTLuong; set => maCTLuong = value; }
    }
}
