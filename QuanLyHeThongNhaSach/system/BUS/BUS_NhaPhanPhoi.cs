using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_NhaPhanPhoi
    {
        private static BUS_NhaPhanPhoi instance;

        public static BUS_NhaPhanPhoi Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NhaPhanPhoi();
                }
                return instance;
            }
        }

        public void hienThiChiNhanh(DataGridView dgv)
        {
            dgv.DataSource = DAL_NhaPhanPhoi.Instance.layDSNhaPhanPhoi();
        }
    }
}
