using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietLuong
    {
        private string maBangLuong, maNS,tenNS, chucVu;
        private int ngayTC , ngayNghi, ngayLam, tienLuong,maCTLuong,luongCB;

        public ET_ChiTietLuong()
        {
        }

        public ET_ChiTietLuong( string maNS, string tenNS, int luongCB,  int ngayLam,  int ngayNghi, int ngayTC, int tienLuong, int maCTLuong, string maBangLuong)
        {
            this.maBangLuong = maBangLuong;
            this.maNS = maNS;
            this.tenNS = tenNS;
            this.ngayTC = ngayTC;
            this.ngayNghi = ngayNghi;
            this.ngayLam = ngayLam;
            this.tienLuong = tienLuong;
            this.maCTLuong = maCTLuong;
            this.luongCB = luongCB;
        }

       
        public string MaNS { get => maNS; set => maNS = value; }
        public string TenNS { get => tenNS; set => tenNS = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int LuongCB { get => luongCB; set => luongCB = value; }
       
        public int NgayLam { get => ngayLam; set => ngayLam = value; }
       
        public int NgayNghi { get => ngayNghi; set => ngayNghi = value; }
        public int NgayTC { get => ngayTC; set => ngayTC = value; }
        public int TienLuong { get => tienLuong; set => tienLuong = value; }
        public int MaCTLuong { get => maCTLuong; set => maCTLuong = value; }
        public string MaBangLuong { get => maBangLuong; set => maBangLuong = value; }
       
    }
}
