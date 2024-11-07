namespace GUI
{
    partial class ChiTietBangLuong
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
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenQL = new System.Windows.Forms.TextBox();
            this.txtMaQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.cboNS = new System.Windows.Forms.ComboBox();
            this.txtTienLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNgayNghi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayLam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLuongTheoNgay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLSHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLuong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(378, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 611);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Hàng Hóa";
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuong.Location = new System.Drawing.Point(3, 22);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 62;
            this.dgvLuong.Size = new System.Drawing.Size(584, 586);
            this.dgvLuong.TabIndex = 0;
            this.dgvLuong.Click += new System.EventHandler(this.dgvLuong_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(378, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 123);
            this.panel1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(163, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "TÍNH LƯƠNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenQL);
            this.groupBox1.Controls.Add(this.txtMaQL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 115);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Người Tính Lương";
            // 
            // txtTenQL
            // 
            this.txtTenQL.Enabled = false;
            this.txtTenQL.Location = new System.Drawing.Point(163, 75);
            this.txtTenQL.Name = "txtTenQL";
            this.txtTenQL.Size = new System.Drawing.Size(171, 26);
            this.txtTenQL.TabIndex = 7;
            // 
            // txtMaQL
            // 
            this.txtMaQL.Enabled = false;
            this.txtMaQL.Location = new System.Drawing.Point(163, 28);
            this.txtMaQL.Name = "txtMaQL";
            this.txtMaQL.Size = new System.Drawing.Size(171, 26);
            this.txtMaQL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhân sự";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân sự";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaNS);
            this.groupBox2.Controls.Add(this.cboNS);
            this.groupBox2.Controls.Add(this.txtTienLuong);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNgayNghi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNgayLam);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtLuongTheoNgay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 328);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hàng Hóa";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(177, 42);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(144, 26);
            this.txtMaNS.TabIndex = 9;
            // 
            // cboNS
            // 
            this.cboNS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNS.FormattingEnabled = true;
            this.cboNS.Location = new System.Drawing.Point(177, 89);
            this.cboNS.Name = "cboNS";
            this.cboNS.Size = new System.Drawing.Size(144, 28);
            this.cboNS.TabIndex = 8;
            this.cboNS.SelectedIndexChanged += new System.EventHandler(this.cboNS_SelectedIndexChanged);
            // 
            // txtTienLuong
            // 
            this.txtTienLuong.Enabled = false;
            this.txtTienLuong.Location = new System.Drawing.Point(177, 277);
            this.txtTienLuong.Name = "txtTienLuong";
            this.txtTienLuong.Size = new System.Drawing.Size(144, 26);
            this.txtTienLuong.TabIndex = 7;
            this.txtTienLuong.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tiền lương:";
            // 
            // txtNgayNghi
            // 
            this.txtNgayNghi.Location = new System.Drawing.Point(177, 229);
            this.txtNgayNghi.Name = "txtNgayNghi";
            this.txtNgayNghi.Size = new System.Drawing.Size(144, 26);
            this.txtNgayNghi.TabIndex = 5;
            this.txtNgayNghi.Validated += new System.EventHandler(this.txtNgayNghi_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số ngày nghỉ:";
            // 
            // txtNgayLam
            // 
            this.txtNgayLam.Enabled = false;
            this.txtNgayLam.Location = new System.Drawing.Point(177, 180);
            this.txtNgayLam.Name = "txtNgayLam";
            this.txtNgayLam.Size = new System.Drawing.Size(144, 26);
            this.txtNgayLam.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số ngày làm:";
            // 
            // txtLuongTheoNgay
            // 
            this.txtLuongTheoNgay.Location = new System.Drawing.Point(177, 137);
            this.txtLuongTheoNgay.Name = "txtLuongTheoNgay";
            this.txtLuongTheoNgay.Size = new System.Drawing.Size(144, 26);
            this.txtLuongTheoNgay.TabIndex = 4;
            this.txtLuongTheoNgay.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtLuongTheoNgay.Validated += new System.EventHandler(this.txtLuongTheoNgay_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lương theo ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên nhân sự:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhân sự:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLamMoi);
            this.groupBox4.Controls.Add(this.btnLSHoaDon);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 671);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 142);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh Công Cụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(17, 82);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(101, 35);
            this.btnLamMoi.TabIndex = 47;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLSHoaDon
            // 
            this.btnLSHoaDon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLSHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLSHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLSHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLSHoaDon.Location = new System.Drawing.Point(137, 82);
            this.btnLSHoaDon.Name = "btnLSHoaDon";
            this.btnLSHoaDon.Size = new System.Drawing.Size(197, 35);
            this.btnLSHoaDon.TabIndex = 46;
            this.btnLSHoaDon.Text = "Lịch sử tính lương";
            this.btnLSHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(137, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(17, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(258, 28);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 35);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpNgayKT);
            this.groupBox5.Controls.Add(this.dtpNgayBD);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtMaLuong);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(358, 169);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Tính Lương";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(163, 127);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(171, 26);
            this.dtpNgayKT.TabIndex = 4;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(163, 77);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(171, 26);
            this.dtpNgayBD.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày Kết Thúc";
            // 
            // txtMaLuong
            // 
            this.txtMaLuong.Location = new System.Drawing.Point(163, 28);
            this.txtMaLuong.Name = "txtMaLuong";
            this.txtMaLuong.Size = new System.Drawing.Size(171, 26);
            this.txtMaLuong.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Bắt Đầu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Bảng Lương";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(381, 765);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "Lưu bảng lương";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChiTietBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 846);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietBangLuong";
            this.Text = "ChiTietBangLuong";
            this.Load += new System.EventHandler(this.ChiTietBangLuong_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenQL;
        private System.Windows.Forms.TextBox txtMaQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.ComboBox cboNS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLSHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTienLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNgayLam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLuongTheoNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayNghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}