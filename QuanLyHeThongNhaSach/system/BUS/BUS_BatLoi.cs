using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BatLoi
    {
        public BUS_BatLoi() { }
        public bool KT_Null( string  chuoi)
        {
            bool flag = false;
            if (chuoi == string.Empty)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_ChuoiSo(string chuoi)
        {
            bool flag = false;
            Regex regex = new Regex(@"^[0-9]*?[0-9]+$");
            if (regex.IsMatch(chuoi) == true)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_ChuoiSoDT(string chuoi)
        {
            bool flag = false;
            Regex regex = new Regex(@"^0+[0-9]+$");
            if (regex.IsMatch(chuoi) == true)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_ChuoiKiTu(string chuoi)
        {
            bool flag = false;
            Regex regex = new Regex(@"^(([A-Z]{1}([a-z]?)+)\s{1})+([A-Z]{1}([a-z]?)+)$");
            if (regex.IsMatch(chuoi) == true)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_SoKiTu<T>( T chuoi , int SoTD /* Số tối đa */ )
        {
            bool flag = false;
            int lenght = chuoi.ToString().Length;
            if (lenght == SoTD) { 
                flag = true;
            }
            return flag;
        }
        public bool KT_SoKiTuCoTheLuu<T>(T chuoi, int SoTD /* Số tối đa */ )
        {
            bool flag = false;
            int lenght = chuoi.ToString().Length;
            if (lenght <= SoTD)
            {
                flag = true;
            }
            return flag;
        }
        public bool KT_Email ( string chuoi)
        {
            bool flag = false;
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            if (regex.IsMatch(chuoi) == true)
            {
                flag = true;
            }
            return flag;
        }
    }
}
