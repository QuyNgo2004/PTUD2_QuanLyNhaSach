using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Data
    {
        DAL_Data data = new DAL_Data();
        public bool Load_Data()
        {
            return data.Load_Data();
        }
        public BUS_Data() { }
        public bool LoadData(string path)
        {
            //return data.LoadData(path);
            return false;
        }
        public void SaveData(string ser)
        {
            data.ThemDataBase(ser);
        }
    }
}
