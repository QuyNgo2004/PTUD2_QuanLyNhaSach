﻿using BUS;
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
    public partial class LichSuTinhLuong : Form
    {
        BUS_BangLuong bangLuong = BUS_BangLuong.Instance;
        BUS_ChiTietLuong chiTietLuong = BUS_ChiTietLuong.Instance;
        public LichSuTinhLuong()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                chiTietLuong.XoaBangLuong(txtMaLuong.Text);
                bangLuong.XoaBangLuong(txtMaLuong.Text);
                dgvDSNhanLuong.DataSource = null;
                LichSuTinhLuong_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu" + ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvLSTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LichSuTinhLuong_Load(object sender, EventArgs e)
        {
            txtMaLuong.Text = string.Empty;
            dgvLSTL.DataSource = bangLuong.XemBangLuong();
        }

        private void dgvLSTL_Click(object sender, EventArgs e)
        {

            try
            {
                try
                {
                    int dong = dgvLSTL.CurrentCell.RowIndex;
                    txtMaLuong.Text = dgvLSTL.Rows[dong].Cells[0].Value.ToString();
                    dgvDSNhanLuong.DataSource = chiTietLuong.XemBangLuong(txtMaLuong.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi khi chọn dòng dữ liệu" + ex.Message);
                }
            }
            catch (Exception ex) { }
        }
    }
}
