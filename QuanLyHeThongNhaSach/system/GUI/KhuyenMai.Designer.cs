﻿namespace GUI
{
    partial class KhuyenMai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbXemKM = new System.Windows.Forms.CheckBox();
            this.dgvDSCTKM = new System.Windows.Forms.DataGridView();
            this.pnlKhuyenMai = new System.Windows.Forms.Panel();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.lblMaKM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.rbtGiamGia = new System.Windows.Forms.RadioButton();
            this.rbtSP = new System.Windows.Forms.RadioButton();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTKM)).BeginInit();
            this.pnlKhuyenMai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbXemKM);
            this.groupBox3.Controls.Add(this.dgvDSCTKM);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(317, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 541);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Các Chương Trình Khuyến Mãi";
            // 
            // cbXemKM
            // 
            this.cbXemKM.AutoSize = true;
            this.cbXemKM.Location = new System.Drawing.Point(45, 33);
            this.cbXemKM.Name = "cbXemKM";
            this.cbXemKM.Size = new System.Drawing.Size(177, 22);
            this.cbXemKM.TabIndex = 1;
            this.cbXemKM.Text = "Xem tất cả khuyến mãi";
            this.cbXemKM.UseVisualStyleBackColor = true;
            this.cbXemKM.Click += new System.EventHandler(this.cbXemKM_Click);
            // 
            // dgvDSCTKM
            // 
            this.dgvDSCTKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTKM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSCTKM.Location = new System.Drawing.Point(3, 68);
            this.dgvDSCTKM.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSCTKM.Name = "dgvDSCTKM";
            this.dgvDSCTKM.RowHeadersWidth = 62;
            this.dgvDSCTKM.RowTemplate.Height = 28;
            this.dgvDSCTKM.Size = new System.Drawing.Size(681, 470);
            this.dgvDSCTKM.TabIndex = 0;
            this.dgvDSCTKM.Click += new System.EventHandler(this.dgvDSCTKM_Click);
            // 
            // pnlKhuyenMai
            // 
            this.pnlKhuyenMai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlKhuyenMai.Controls.Add(this.lblKhuyenMai);
            this.pnlKhuyenMai.Location = new System.Drawing.Point(317, -1);
            this.pnlKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKhuyenMai.Name = "pnlKhuyenMai";
            this.pnlKhuyenMai.Size = new System.Drawing.Size(687, 83);
            this.pnlKhuyenMai.TabIndex = 34;
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.lblKhuyenMai.Location = new System.Drawing.Point(37, 20);
            this.lblKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(611, 46);
            this.lblKhuyenMai.TabIndex = 7;
            this.lblKhuyenMai.Text = "CHƯƠNG TRÌNH KHUYẾN MÃI";
            // 
            // txtMaKM
            // 
            this.txtMaKM.BackColor = System.Drawing.Color.White;
            this.txtMaKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKM.Enabled = false;
            this.txtMaKM.Location = new System.Drawing.Point(29, 55);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(209, 24);
            this.txtMaKM.TabIndex = 1;
            // 
            // lblMaKM
            // 
            this.lblMaKM.AutoSize = true;
            this.lblMaKM.Location = new System.Drawing.Point(26, 36);
            this.lblMaKM.Name = "lblMaKM";
            this.lblMaKM.Size = new System.Drawing.Size(116, 18);
            this.lblMaKM.TabIndex = 0;
            this.lblMaKM.Text = "Mã khuyến mãi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayKT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayBD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaKM);
            this.groupBox1.Controls.Add(this.lblMaKM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaGiamGia);
            this.groupBox1.Controls.Add(this.rbtGiamGia);
            this.groupBox1.Controls.Add(this.rbtSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 447);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khuyến Mãi";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(128, 180);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(110, 24);
            this.dtpNgayKT.TabIndex = 21;
            this.dtpNgayKT.Validated += new System.EventHandler(this.dtpNgayBD_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày kết thúc :";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(128, 138);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(110, 24);
            this.dtpNgayBD.TabIndex = 21;
            this.dtpNgayBD.Validated += new System.EventHandler(this.dtpNgayBD_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày bắt đầu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên :";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Location = new System.Drawing.Point(29, 385);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGhiChu.Size = new System.Drawing.Size(209, 56);
            this.txtGhiChu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ghi chú:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Location = new System.Drawing.Point(68, 333);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(169, 22);
            this.txtTenSP.TabIndex = 19;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.White;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Location = new System.Drawing.Point(28, 109);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(209, 24);
            this.txtTen.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khuyến mãi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã :";
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaGiamGia.Location = new System.Drawing.Point(29, 250);
            this.txtMaGiamGia.Multiline = true;
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(209, 22);
            this.txtMaGiamGia.TabIndex = 14;
            this.txtMaGiamGia.Text = "1";
            this.txtMaGiamGia.Validated += new System.EventHandler(this.txtMaGiamGia_Validated);
            // 
            // rbtGiamGia
            // 
            this.rbtGiamGia.AutoSize = true;
            this.rbtGiamGia.Location = new System.Drawing.Point(29, 222);
            this.rbtGiamGia.Name = "rbtGiamGia";
            this.rbtGiamGia.Size = new System.Drawing.Size(116, 22);
            this.rbtGiamGia.TabIndex = 15;
            this.rbtGiamGia.TabStop = true;
            this.rbtGiamGia.Text = "Giảm giá (%):";
            this.rbtGiamGia.UseVisualStyleBackColor = true;
            this.rbtGiamGia.Click += new System.EventHandler(this.rbtGiamGia_Click);
            // 
            // rbtSP
            // 
            this.rbtSP.AutoSize = true;
            this.rbtSP.Location = new System.Drawing.Point(29, 282);
            this.rbtSP.Name = "rbtSP";
            this.rbtSP.Size = new System.Drawing.Size(176, 22);
            this.rbtSP.TabIndex = 17;
            this.rbtSP.TabStop = true;
            this.rbtSP.Text = "Sản phẩm khuyến mãi:";
            this.rbtSP.UseVisualStyleBackColor = true;
            this.rbtSP.Click += new System.EventHandler(this.rbtGiamGia_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.LightGray;
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Location = new System.Drawing.Point(69, 305);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(169, 22);
            this.txtMaSP.TabIndex = 16;
            this.txtMaSP.Validated += new System.EventHandler(this.txtMaSP_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 143);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(139, 67);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 23);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(20, 67);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(20, 107);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Visible = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 29);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(139, 29);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pnlKhuyenMai);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KhuyenMai";
            this.Text = "KhoHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KhuyenMai_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTKM)).EndInit();
            this.pnlKhuyenMai.ResumeLayout(false);
            this.pnlKhuyenMai.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSCTKM;
        private System.Windows.Forms.Panel pnlKhuyenMai;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.Label lblMaKM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.RadioButton rbtGiamGia;
        private System.Windows.Forms.RadioButton rbtSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbXemKM;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamMoi;
    }
}