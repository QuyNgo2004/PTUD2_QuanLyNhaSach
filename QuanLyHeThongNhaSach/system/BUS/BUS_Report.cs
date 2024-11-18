using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Report
    {
        private static BUS_Report instance;

        public static BUS_Report Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Report();
                }
                return instance;
            }
        }
        public DataTable GetDataInHoaDon(string maHD)
        {
            return DAL_Report.Instance.GetDataInHoaDon(maHD);
        }
    }
}
