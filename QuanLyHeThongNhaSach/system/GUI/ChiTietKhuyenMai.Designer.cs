namespace GUI
{
    partial class ChiTietKhuyenMai
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboKhuyenMai = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKM = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCaTruc = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.lblTenNS = new System.Windows.Forms.Label();
            this.pnlNhapHang = new System.Windows.Forms.Panel();
            this.lblQLCT = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbXemKM = new System.Windows.Forms.CheckBox();
            this.dgvDSKhuyenMai = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlNhapHang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboKhuyenMai);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblCaTruc);
            this.groupBox4.Controls.Add(this.txtMaHH);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtGhiChu);
            this.groupBox4.Controls.Add(this.txtTenHH);
            this.groupBox4.Controls.Add(this.lblTenNS);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 488);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Ca Trực";
            // 
            // cboKhuyenMai
            // 
            this.cboKhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuyenMai.FormattingEnabled = true;
            this.cboKhuyenMai.Location = new System.Drawing.Point(144, 137);
            this.cboKhuyenMai.Name = "cboKhuyenMai";
            this.cboKhuyenMai.Size = new System.Drawing.Size(231, 26);
            this.cboKhuyenMai.TabIndex = 16;
            this.cboKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cboCaTruc_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnKM);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 182);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnKM
            // 
            this.btnKM.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKM.FlatAppearance.BorderSize = 0;
            this.btnKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKM.ForeColor = System.Drawing.Color.White;
            this.btnKM.Location = new System.Drawing.Point(188, 85);
            this.btnKM.Margin = new System.Windows.Forms.Padding(2);
            this.btnKM.Name = "btnKM";
            this.btnKM.Size = new System.Drawing.Size(137, 23);
            this.btnKM.TabIndex = 9;
            this.btnKM.Text = "Khuyến mãi";
            this.btnKM.UseVisualStyleBackColor = false;
            this.btnKM.Click += new System.EventHandler(this.btnCT_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(27, 85);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 23);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quay về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(188, 36);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 23);
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
            this.btnThem.Location = new System.Drawing.Point(27, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ghi Chú Khuyến Mãi:";
            this.label2.Click += new System.EventHandler(this.lblCaTruc_Click);
            // 
            // lblCaTruc
            // 
            this.lblCaTruc.AutoSize = true;
            this.lblCaTruc.Location = new System.Drawing.Point(33, 143);
            this.lblCaTruc.Name = "lblCaTruc";
            this.lblCaTruc.Size = new System.Drawing.Size(89, 18);
            this.lblCaTruc.TabIndex = 0;
            this.lblCaTruc.Text = "Khuyến Mãi:";
            this.lblCaTruc.Click += new System.EventHandler(this.lblCaTruc_Click);
            // 
            // txtMaHH
            // 
            this.txtMaHH.BackColor = System.Drawing.Color.White;
            this.txtMaHH.Location = new System.Drawing.Point(144, 38);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(231, 24);
            this.txtMaHH.TabIndex = 1;
            this.txtMaHH.Validated += new System.EventHandler(this.txtMaHH_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Location = new System.Drawing.Point(36, 211);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(339, 70);
            this.txtGhiChu.TabIndex = 1;
            // 
            // txtTenHH
            // 
            this.txtTenHH.BackColor = System.Drawing.Color.White;
            this.txtTenHH.Enabled = false;
            this.txtTenHH.Location = new System.Drawing.Point(144, 88);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(231, 24);
            this.txtTenHH.TabIndex = 1;
            // 
            // lblTenNS
            // 
            this.lblTenNS.AutoSize = true;
            this.lblTenNS.Location = new System.Drawing.Point(32, 93);
            this.lblTenNS.Name = "lblTenNS";
            this.lblTenNS.Size = new System.Drawing.Size(106, 18);
            this.lblTenNS.TabIndex = 0;
            this.lblTenNS.Text = "Tên sản phẩm:";
            // 
            // pnlNhapHang
            // 
            this.pnlNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlNhapHang.Controls.Add(this.lblQLCT);
            this.pnlNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhapHang.Location = new System.Drawing.Point(0, 0);
            this.pnlNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNhapHang.Name = "pnlNhapHang";
            this.pnlNhapHang.Size = new System.Drawing.Size(1027, 83);
            this.pnlNhapHang.TabIndex = 48;
            // 
            // lblQLCT
            // 
            this.lblQLCT.AutoSize = true;
            this.lblQLCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLCT.ForeColor = System.Drawing.Color.White;
            this.lblQLCT.Location = new System.Drawing.Point(313, 20);
            this.lblQLCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQLCT.Name = "lblQLCT";
            this.lblQLCT.Size = new System.Drawing.Size(461, 46);
            this.lblQLCT.TabIndex = 7;
            this.lblQLCT.Text = "CHI TIẾT KHUYẾN MÃI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbXemKM);
            this.groupBox3.Controls.Add(this.dgvDSKhuyenMai);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(462, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 491);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm Khuyến Mãi";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // cbXemKM
            // 
            this.cbXemKM.AutoSize = true;
            this.cbXemKM.Location = new System.Drawing.Point(33, 32);
            this.cbXemKM.Name = "cbXemKM";
            this.cbXemKM.Size = new System.Drawing.Size(177, 22);
            this.cbXemKM.TabIndex = 2;
            this.cbXemKM.Text = "Xem tất cả khuyến mãi";
            this.cbXemKM.UseVisualStyleBackColor = true;
            this.cbXemKM.Click += new System.EventHandler(this.cbXemKM_Click);
            // 
            // dgvDSKhuyenMai
            // 
            this.dgvDSKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhuyenMai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSKhuyenMai.Location = new System.Drawing.Point(3, 59);
            this.dgvDSKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSKhuyenMai.Name = "dgvDSKhuyenMai";
            this.dgvDSKhuyenMai.RowHeadersWidth = 62;
            this.dgvDSKhuyenMai.RowTemplate.Height = 28;
            this.dgvDSKhuyenMai.Size = new System.Drawing.Size(527, 429);
            this.dgvDSKhuyenMai.TabIndex = 0;
            this.dgvDSKhuyenMai.Click += new System.EventHandler(this.dgvDSKhuyenMai_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(188, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "In khuyến mãi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChiTietKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 616);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlNhapHang);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietKhuyenMai";
            this.Text = "ChiTietKhuyenMai";
            this.Load += new System.EventHandler(this.ChiTietKhuyenMai_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlNhapHang.ResumeLayout(false);
            this.pnlNhapHang.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhuyenMai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboKhuyenMai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblCaTruc;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label lblTenNS;
        private System.Windows.Forms.Panel pnlNhapHang;
        private System.Windows.Forms.Label lblQLCT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSKhuyenMai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.CheckBox cbXemKM;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button button2;
    }
}