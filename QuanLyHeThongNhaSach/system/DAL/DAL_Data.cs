using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class DAL_Data
    {
        string serveName = "";
        string conection = "";
        protected  QLNhaSachDataContext dbNhaSach;
        public DAL_Data()
        {
            Load_Data();
        }

        public void ThemDataBase(string serve)
        {
            string r = AppDomain.CurrentDomain.BaseDirectory;
            XDocument xDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Root", new XElement("ServeName", serve))
                );
            xDocument.Save(r + @"\Conection.xml");
        }
        // Load connection string
        public QLNhaSachDataContext Connetion_String(string connect)
        {
              return  new QLNhaSachDataContext(connect);
        }
        public bool Load_Data()
        {
            
            bool flag = true;
            //try
            //{
            //    //conection = @"Data Source=" + "DESKTOP-4HPV2E5\\LISM" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";

            //     Conection = @"Data Source=" + "MSI\\SQLEXPRESS" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
            //    //string conection = @"Data Source=" + "B202A-PC35\\SQLEXPRESS" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";

            //    //string conection = @"Data Source=" + "MSI\\SQLEXPRESS" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
            //    //string conection = @"Data Source=" + "B202A-PC35\\SQLEXPRESS" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";

            //    //string conection = @"Data Source=" + "." + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
            //    SqlConnection sqlConnection = new SqlConnection(conection);
            //    sqlConnection.Open();
            //    DbNhaSach = Connetion_String(conection);
            //}
            //catch (Exception ex)
            //{
            //    flag = false;
            //}
            XElement ConectionXML;
            IEnumerable<XElement> nullable;
            try
            {
                string r = AppDomain.CurrentDomain.BaseDirectory;
                ConectionXML = XElement.Load(r + @"\Conection.xml");
                nullable = from el in ConectionXML.Elements("ServeName")
                           select el;
                foreach (XElement e in nullable)
                {
                    ServeName = e.Value;
                }

                Conection = @"Data Source=" + ServeName + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
                //Conection = @"Data Source=" + "MSI\\SQLEXPRESS" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection sqlConnection = new SqlConnection(conection);
                sqlConnection.Open();
                DbNhaSach = Connetion_String(Conection);
            }
            catch (Exception ex)
            {

                return false;
            }
            return flag;
        }


        //public QLNhaSachDataContext DbNhaSach { get => dbNhaSach; set => dbNhaSach = value; }
        public bool LoadData(string path)
        {
        //    XElement ConectionXML;
        //    IEnumerable<XElement> nullable;
        //    try
        //    {
        //        string r = AppDomain.CurrentDomain.BaseDirectory;
        //        ConectionXML = XElement.Load(r + @"\Conection.xml");
        //        nullable = from el in ConectionXML.Elements("ServeName")
        //                   select el;
        //        foreach (XElement e in nullable)
        //        {
        //            ServeName = e.Value;
        //        }

        //        Conection = @"Data Source=" + ServeName + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
        //        //Conection = @"Data Source=" + "MSI\\SQLEXPRESS" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
        //        SqlConnection sqlConnection = new SqlConnection(conection);
        //        sqlConnection.Open();
        //        DbNhaSach = Connetion_String(Conection);
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }


           return true;

        }


        public QLNhaSachDataContext DbNhaSach { get => dbNhaSach; set => dbNhaSach = value; }
        public string ServeName { get => serveName; set => serveName = value; }
        public string Conection { get => conection; set => conection = value; }
    }
}

