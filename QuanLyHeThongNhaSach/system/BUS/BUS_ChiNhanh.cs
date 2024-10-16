using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ChiNhanh
    {
        private static BUS_ChiNhanh instance;

        public static BUS_ChiNhanh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiNhanh();
                }
                return instance;
            }
        }

        public void hienThiChiNhanh(DataGridView dgv)
        {
            dgv.DataSource = DAL_ChiNhanh.Instance.layDSChiNhanh();
        }
    }
}
