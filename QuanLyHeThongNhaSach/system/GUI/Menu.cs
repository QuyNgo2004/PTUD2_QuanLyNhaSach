﻿using BUS;
using ET;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        private string maNS = string.Empty;
        private ET_NhanSu ns_ET = null;
        public Menu(ET_NhanSu ns)
        {
            InitializeComponent();
            lbltTenNS.Text = ns.TenNS;
            maNS = ns.MaNS;
            this.ns_ET = ns;
        }

        /// <summary>
        /// bỏ màn hình con vào panel.
        /// </summary>
        /// <param name="childForm"></param>

        public void openChildForm(Form childForm)
        {

            try
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlMenuShow.Controls.Add(childForm);
                pnlMenuShow.Tag = childForm;
                // Code để thêm và hiển thị form con
                this.pnlMenuShow.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                // Ghi lại hoặc hiển thị lỗi
                Console.WriteLine("Không thể hiển thị màn hình đang chọn: " + ex.Message);
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        /// <summary>
        /// button thoát.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi chương trình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// button logout.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn đăng xuất khỏi tài khoảng hay không ?", "ĐĂNG XUẤT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// button nhập hàng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private NhapHang nhaphang;
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if(ns_ET.ChucVu == 1)
            {
                if (nhaphang == null || nhaphang.IsDisposed)
                {
                    openChildForm(new NhapHang());
                }
                else
                {
                    nhaphang.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// button danh sách nhân sự.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private NhanSu nhansu;
        private void btnDanhSachNhanSu_Click(object sender, EventArgs e)
        {
            if (ns_ET.ChucVu == 1)
            {
                if (nhansu == null || nhansu.IsDisposed)
                {
                    openChildForm(new NhanSu(ns_ET));
                }
                else
                {
                    nhansu.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// button chương trình khuyến mãi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private ChiTietKhuyenMai khuyenmai;
        private void btnCTKhuyenMai_Click(object sender, EventArgs e)
        {
            if (ns_ET.ChucVu == 1)
            {
                if (khuyenmai == null || khuyenmai.IsDisposed)
                {
                    openChildForm(new ChiTietKhuyenMai(ns_ET));
                }
                else
                {
                    khuyenmai.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// button nhà phân phối.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private NhaPhanPhoi npp;
        private void btnDanhSachNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            if (ns_ET.ChucVu == 1)
            {
                if (npp == null || npp.IsDisposed)
                {
                    openChildForm(new NhaPhanPhoi());
                }
                else
                {
                    npp.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        /// <summary>
        /// button Khách Hàng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private KhachHang kh;
        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            if (kh == null || kh.IsDisposed)
            {
                openChildForm(new KhachHang());
            }
            else
            {
                kh.BringToFront();
            }
        }
        private frmChiNhanh chiNhanh;
        private void btnDanhSachChiNhanh_Click(object sender, EventArgs e)
        {
            if (ns_ET.ChucVu == 1)
            {
                if (chiNhanh == null || chiNhanh.IsDisposed)
                {
                    openChildForm(new frmChiNhanh());
                }
                else
                {
                    kh.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            //pnlMenuShow.Controls.Clear();
            //UCChiNhanh chiNhanh = new UCChiNhanh();
            //pnlMenuShow.Tag = chiNhanh;
            //chiNhanh.Dock = DockStyle.Fill;
            //this.pnlMenuShow.Controls.Add(chiNhanh);
        }
        private formThanhToan thanhToan;
        private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
        {
            if (thanhToan == null || thanhToan.IsDisposed)
            {
                openChildForm(new formThanhToan(maNS));
            }
            else
            {
                kh.BringToFront();
            }
            //pnlMenuShow.Controls.Clear();
            //ThanhToan thanhToan = new ThanhToan();
            //pnlMenuShow.Tag = thanhToan;
            //thanhToan.Dock = DockStyle.Fill;
            //pnlMenuShow.Controls.Add(thanhToan);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
