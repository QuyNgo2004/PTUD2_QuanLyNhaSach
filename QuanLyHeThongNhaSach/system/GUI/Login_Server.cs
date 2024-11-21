using BUS;
using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login_Server : Form
    {
        BUS_Data data = new BUS_Data();
        public Login_Server()
        {
            InitializeComponent();
        }

        private void Login_Server_Load(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Application.StartupPath);
            MessageBox.Show(path);
            if (data.Load_Data() == true)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //string path = System.IO.Path.Combine(Application.StartupPath);
                data.SaveData(txtSerName.Text);
                if (data.Load_Data() == false)
                {
                    data.SaveData(txtSerName.Text);
                    //FormServe_Load(sender, e);
                    MessageBox.Show("Lỗi đăng nhập serve!");
                }
                else
                {
                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
