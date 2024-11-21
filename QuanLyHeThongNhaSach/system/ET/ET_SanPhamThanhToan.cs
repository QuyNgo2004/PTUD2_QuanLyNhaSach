using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_SanPhamThanhToan
    {
        private string maHH;
        private string tenHH;
        private int donGia;
        private int soLuong;
        private string khuyenMai;
        private double thanhTien;

        public ET_SanPhamThanhToan(string maHH, string tenHH, int donGia, int soLuong, string khuyenMai, double thanhTien)
        {
            this.MaHH = maHH;
            this.TenHH = tenHH;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.KhuyenMai = khuyenMai;
            this.ThanhTien = thanhTien;
        }

        public string MaHH { get => maHH; set => maHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
