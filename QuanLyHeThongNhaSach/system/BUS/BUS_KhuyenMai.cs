using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        private static BUS_KhuyenMai instance;
        private DAL_KhuyenMai DAL_km = new DAL_KhuyenMai();
        public static BUS_KhuyenMai Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_KhuyenMai();
                }
                return instance;
            }
        }
        // Load khuyen mai 
        public void LoadKM_All(DataGridView dgv)
        {
            dgv.DataSource = DAL_km.LoadKM_All();
        }
        public IQueryable LoadKM_All()
        {
            return DAL_km.LoadKM_All();
        }
        public void LoadKM_Now(DateTime ngayHT,DataGridView dgv)
        {
            dgv.DataSource = DAL_km.LoadKM_Now(ngayHT);
        }
        public IQueryable LoadKM_Now(DateTime ngayHT)
        {
            return DAL_km.LoadKM_Now(ngayHT);
        }
        // Them 
        public bool KM_Them(ET_KhuyenMai km)
        {
            return DAL_km.ThemKM(km);
        }
        // Xoa
        public bool KM_Xoa(string ma)
        {
            return DAL_km.xoa_KM(ma);
        }
        //Sua
        // Xoa
        public bool KM_Sua(ET_KhuyenMai km)
        {
            return DAL_km.sua_KM(km);
        }
        // Tim kiếm
        public ET_KhuyenMai KM_TimMa(string ma)
        {
            return DAL_km.KM_TimMa(ma);
        }
    }
}
