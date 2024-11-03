using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CTHoaDon
    {
        private static BUS_CTHoaDon instance;

        public static BUS_CTHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_CTHoaDon();
                }
                return instance;
            }
        }

        public bool themCTHoaDon(ET_CTHoaDon hoadon)
        {
            try
            {
                return DAL_CTHoaDon.Instance.ThemCTHoaDon(hoadon);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
