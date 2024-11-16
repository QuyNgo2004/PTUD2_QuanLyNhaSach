using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanSu
    {
        private string maNS, tenNS, gioiTinh, cCCD, email, diaChi, maCN, matKhau, sDT;
        private int chucVu,luongCanBan;


        public ET_NhanSu(string maNS, string tenNS, string gioiTinh, string cCCD, string email, string diaChi, string maCN, int chucVu, string matKhau, string sDT)
        {
            this.MaNS = maNS;
            this.TenNS = tenNS;
            this.GioiTinh = gioiTinh;
            this.CCCD = cCCD;
            this.Email = email;
            this.DiaChi = diaChi;
            this.MaCN = maCN;
            this.ChucVu = chucVu;
            this.MatKhau = matKhau;
            this.SDT = sDT;
        }

        public ET_NhanSu()
        {
        }

        public ET_NhanSu(string maNS, string tenNS, string gioiTinh, string cCCD, string email, string diaChi, string maCN, string matKhau, string sDT, int chucVu, int luongCanBan)
        {
            this.maNS = maNS;
            this.tenNS = tenNS;
            this.gioiTinh = gioiTinh;
            this.cCCD = cCCD;
            this.email = email;
            this.diaChi = diaChi;
            this.maCN = maCN;
            this.matKhau = matKhau;
            this.sDT = sDT;
            this.chucVu = chucVu;
            this.luongCanBan = luongCanBan;
        }

        public string MaNS { get => maNS; set => maNS = value; }
        public string TenNS { get => tenNS; set => tenNS = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaCN { get => maCN; set => maCN = value; }
        public int ChucVu { get => chucVu; set => chucVu = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public int LuongCanBan { get => luongCanBan; set => luongCanBan = value; }
    }
}
