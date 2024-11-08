namespace GUI
{
    partial class NhapHang
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
            this.btnThemHHMoi = new System.Windows.Forms.Button();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.lblSLNhap = new System.Windows.Forms.Label();
            this.lblTenHH = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.btnLSNhapHang = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtpNgayNH = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNH = new System.Windows.Forms.Label();
            this.lblTenNPP = new System.Windows.Forms.Label();
            this.txtMaNPP = new System.Windows.Forms.TextBox();
            this.lblMaNPP = new System.Windows.Forms.Label();
            this.lblNhapHang = new System.Windows.Forms.Label();
            this.pnlNhapHang = new System.Windows.Forms.Panel();
            this.dgvDSNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenNPP = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMaNH = new System.Windows.Forms.Label();
            this.txtMaNH = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhapHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemHHMoi
            // 
            this.btnThemHHMoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemHHMoi.FlatAppearance.BorderSize = 0;
            this.btnThemHHMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHHMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHHMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemHHMoi.Location = new System.Drawing.Point(314, 1138);
            this.btnThemHHMoi.Name = "btnThemHHMoi";
            this.btnThemHHMoi.Size = new System.Drawing.Size(256, 35);
            this.btnThemHHMoi.TabIndex = 32;
            this.btnThemHHMoi.Text = "Thêm hàng hóa mới";
            this.btnThemHHMoi.UseVisualStyleBackColor = false;
            this.btnThemHHMoi.Click += new System.EventHandler(this.btnThemHHMoi_Click);
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.BackColor = System.Drawing.Color.White;
            this.txtSLNhap.Location = new System.Drawing.Point(198, 143);
            this.txtSLNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(264, 32);
            this.txtSLNhap.TabIndex = 9;
            this.txtSLNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLNhap_KeyPress);
            this.txtSLNhap.Validated += new System.EventHandler(this.txtSLNhap_Validated);
            // 
            // lblSLNhap
            // 
            this.lblSLNhap.AutoSize = true;
            this.lblSLNhap.Location = new System.Drawing.Point(30, 146);
            this.lblSLNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSLNhap.Name = "lblSLNhap";
            this.lblSLNhap.Size = new System.Drawing.Size(164, 26);
            this.lblSLNhap.TabIndex = 4;
            this.lblSLNhap.Text = "Số lượng nhập :";
            // 
            // lblTenHH
            // 
            this.lblTenHH.AutoSize = true;
            this.lblTenHH.Location = new System.Drawing.Point(26, 92);
            this.lblTenHH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHH.Name = "lblTenHH";
            this.lblTenHH.Size = new System.Drawing.Size(156, 26);
            this.lblTenHH.TabIndex = 2;
            this.lblTenHH.Text = "Tên hàng hóa :";
            // 
            // txtMaHH
            // 
            this.txtMaHH.BackColor = System.Drawing.Color.White;
            this.txtMaHH.Location = new System.Drawing.Point(198, 37);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(264, 32);
            this.txtMaHH.TabIndex = 1;
            this.txtMaHH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHH_KeyPress);
            this.txtMaHH.Validated += new System.EventHandler(this.txtMaHH_Validated);
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Location = new System.Drawing.Point(26, 40);
            this.lblMaHH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(150, 26);
            this.lblMaHH.TabIndex = 0;
            this.lblMaHH.Text = "Mã hàng hóa :";
            // 
            // btnLSNhapHang
            // 
            this.btnLSNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLSNhapHang.FlatAppearance.BorderSize = 0;
            this.btnLSNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLSNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnLSNhapHang.Location = new System.Drawing.Point(25, 1138);
            this.btnLSNhapHang.Name = "btnLSNhapHang";
            this.btnLSNhapHang.Size = new System.Drawing.Size(259, 35);
            this.btnLSNhapHang.TabIndex = 31;
            this.btnLSNhapHang.Text = "Lịch sử nhập hàng";
            this.btnLSNhapHang.UseVisualStyleBackColor = false;
            this.btnLSNhapHang.Click += new System.EventHandler(this.btnLSNhapHang_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTenHangHoa);
            this.groupBox4.Controls.Add(this.txtGhiChu);
            this.groupBox4.Controls.Add(this.lblGhiChu);
            this.groupBox4.Controls.Add(this.txtSLNhap);
            this.groupBox4.Controls.Add(this.lblSLNhap);
            this.groupBox4.Controls.Add(this.lblTenHH);
            this.groupBox4.Controls.Add(this.txtMaHH);
            this.groupBox4.Controls.Add(this.lblMaHH);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 293);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(472, 308);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Hàng Hóa";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.BackColor = System.Drawing.Color.White;
            this.txtTenHangHoa.Enabled = false;
            this.txtTenHangHoa.Location = new System.Drawing.Point(198, 89);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(264, 32);
            this.txtTenHangHoa.TabIndex = 17;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.Location = new System.Drawing.Point(198, 196);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(264, 81);
            this.txtGhiChu.TabIndex = 16;
            this.txtGhiChu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGhiChu_KeyPress);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(30, 199);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(99, 26);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi chú :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNhapHang);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 892);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(516, 221);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(289, 161);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(207, 35);
            this.btnNhapHang.TabIndex = 10;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(289, 105);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(207, 35);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(30, 161);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(207, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(289, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(207, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(30, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(207, 35);
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
            this.btnSua.Location = new System.Drawing.Point(30, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(207, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // dtpNgayNH
            // 
            this.dtpNgayNH.Enabled = false;
            this.dtpNgayNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNH.Location = new System.Drawing.Point(281, 187);
            this.dtpNgayNH.Name = "dtpNgayNH";
            this.dtpNgayNH.Size = new System.Drawing.Size(251, 30);
            this.dtpNgayNH.TabIndex = 18;
            // 
            // lblNgayNH
            // 
            this.lblNgayNH.AutoSize = true;
            this.lblNgayNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNH.Location = new System.Drawing.Point(43, 187);
            this.lblNgayNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNH.Name = "lblNgayNH";
            this.lblNgayNH.Size = new System.Drawing.Size(183, 26);
            this.lblNgayNH.TabIndex = 17;
            this.lblNgayNH.Text = "Ngày nhập hàng :";
            // 
            // lblTenNPP
            // 
            this.lblTenNPP.AutoSize = true;
            this.lblTenNPP.Location = new System.Drawing.Point(16, 125);
            this.lblTenNPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNPP.Name = "lblTenNPP";
            this.lblTenNPP.Size = new System.Drawing.Size(112, 26);
            this.lblTenNPP.TabIndex = 2;
            this.lblTenNPP.Text = "Tên NPP :";
            // 
            // txtMaNPP
            // 
            this.txtMaNPP.BackColor = System.Drawing.Color.White;
            this.txtMaNPP.Enabled = false;
            this.txtMaNPP.Location = new System.Drawing.Point(21, 70);
            this.txtMaNPP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNPP.Name = "txtMaNPP";
            this.txtMaNPP.Size = new System.Drawing.Size(429, 32);
            this.txtMaNPP.TabIndex = 1;
            // 
            // lblMaNPP
            // 
            this.lblMaNPP.AutoSize = true;
            this.lblMaNPP.Location = new System.Drawing.Point(16, 39);
            this.lblMaNPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNPP.Name = "lblMaNPP";
            this.lblMaNPP.Size = new System.Drawing.Size(106, 26);
            this.lblMaNPP.TabIndex = 0;
            this.lblMaNPP.Text = "Mã NPP :";
            // 
            // lblNhapHang
            // 
            this.lblNhapHang.AutoSize = true;
            this.lblNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblNhapHang.Location = new System.Drawing.Point(296, 29);
            this.lblNhapHang.Name = "lblNhapHang";
            this.lblNhapHang.Size = new System.Drawing.Size(394, 69);
            this.lblNhapHang.TabIndex = 7;
            this.lblNhapHang.Text = "NHẬP HÀNG";
            // 
            // pnlNhapHang
            // 
            this.pnlNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlNhapHang.Controls.Add(this.lblNhapHang);
            this.pnlNhapHang.Location = new System.Drawing.Point(577, 0);
            this.pnlNhapHang.Name = "pnlNhapHang";
            this.pnlNhapHang.Size = new System.Drawing.Size(953, 128);
            this.pnlNhapHang.TabIndex = 28;
            // 
            // dgvDSNhapHang
            // 
            this.dgvDSNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhapHang.Location = new System.Drawing.Point(4, 30);
            this.dgvDSNhapHang.Name = "dgvDSNhapHang";
            this.dgvDSNhapHang.RowHeadersWidth = 62;
            this.dgvDSNhapHang.RowTemplate.Height = 28;
            this.dgvDSNhapHang.Size = new System.Drawing.Size(945, 1031);
            this.dgvDSNhapHang.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenNPP);
            this.groupBox1.Controls.Add(this.lblTenNPP);
            this.groupBox1.Controls.Add(this.txtMaNPP);
            this.groupBox1.Controls.Add(this.lblMaNPP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(472, 221);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhà Phân Phối";
            // 
            // cboTenNPP
            // 
            this.cboTenNPP.FormattingEnabled = true;
            this.cboTenNPP.Location = new System.Drawing.Point(21, 164);
            this.cboTenNPP.Name = "cboTenNPP";
            this.cboTenNPP.Size = new System.Drawing.Size(429, 34);
            this.cboTenNPP.TabIndex = 8;
            this.cboTenNPP.SelectedIndexChanged += new System.EventHandler(this.cboTenNPP_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSNhapHang);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(577, 146);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(953, 1066);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Nhập Hàng";
            // 
            // lblMaNH
            // 
            this.lblMaNH.AutoSize = true;
            this.lblMaNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNH.Location = new System.Drawing.Point(43, 75);
            this.lblMaNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNH.Name = "lblMaNH";
            this.lblMaNH.Size = new System.Drawing.Size(162, 26);
            this.lblMaNH.TabIndex = 34;
            this.lblMaNH.Text = "Mã nhập hàng :";
            // 
            // txtMaNH
            // 
            this.txtMaNH.BackColor = System.Drawing.Color.White;
            this.txtMaNH.Enabled = false;
            this.txtMaNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNH.Location = new System.Drawing.Point(281, 72);
            this.txtMaNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.Size = new System.Drawing.Size(251, 32);
            this.txtMaNH.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(281, 131);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 32);
            this.textBox1.TabIndex = 35;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.AutoSize = true;
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(43, 134);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(230, 26);
            this.txtNhanVien.TabIndex = 36;
            this.txtNhanVien.Text = "Nhân viên nhập hàng :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(26, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(516, 629);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Nhập Hàng";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1558, 1106);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.btnThemHHMoi);
            this.Controls.Add(this.txtMaNH);
            this.Controls.Add(this.btnLSNhapHang);
            this.Controls.Add(this.dtpNgayNH);
            this.Controls.Add(this.lblMaNH);
            this.Controls.Add(this.lblNgayNH);
            this.Controls.Add(this.pnlNhapHang);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapHang";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlNhapHang.ResumeLayout(false);
            this.pnlNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhapHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemHHMoi;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label lblSLNhap;
        private System.Windows.Forms.Label lblTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.Button btnLSNhapHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTenNPP;
        private System.Windows.Forms.TextBox txtMaNPP;
        private System.Windows.Forms.Label lblMaNPP;
        private System.Windows.Forms.Label lblNhapHang;
        private System.Windows.Forms.Panel pnlNhapHang;
        private System.Windows.Forms.DataGridView dgvDSNhapHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMaNH;
        private System.Windows.Forms.TextBox txtMaNH;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayNH;
        private System.Windows.Forms.Label lblNgayNH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtNhanVien;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.ComboBox cboTenNPP;
        private System.Windows.Forms.Button btnNhapHang;
    }
}