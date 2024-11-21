using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HangHoa
    {
        private string maHH, tenHH, loaiHH, donviTinh, nhaPP, tacGia, moTa, ghiChu, tinhTrang;
        private int giaHH, slTon;



        public ET_HangHoa()
        {
        }

        public ET_HangHoa(string maHH, string loaiHH, string tenHH, int giaHH, string donviTinh, int slTon, string nhaPP, string tacGia, string moTa, string ghiChu, string tinhTrang)
        {
            this.MaHH = maHH;
            this.LoaiHH = loaiHH;
            this.TenHH = tenHH;
            this.GiaHH = giaHH;
            this.DonviTinh = donviTinh;
            this.SlTon = slTon;
            this.NhaPP = nhaPP;
            this.TacGia = tacGia;
            this.MoTa = moTa;
            this.GhiChu = ghiChu;
            this.TinhTrang = tinhTrang;
        }

        public string MaHH { get => maHH; set => maHH = value; }
        public string LoaiHH { get => loaiHH; set => loaiHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public int GiaHH { get => giaHH; set => giaHH = value; }
        public string DonviTinh { get => donviTinh; set => donviTinh = value; }
        public int SlTon { get => slTon; set => slTon = value; }
        public string NhaPP { get => nhaPP; set => nhaPP = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
