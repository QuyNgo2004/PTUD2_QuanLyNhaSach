namespace GUI
{
    partial class NhaPhanPhoi
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
            this.dgvDSNPP = new System.Windows.Forms.DataGridView();
            this.pnlKhuyenMai = new System.Windows.Forms.Panel();
            this.lblNPP = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtTenNPP = new System.Windows.Forms.TextBox();
            this.lblTenNPP = new System.Windows.Forms.Label();
            this.txtMaNPP = new System.Windows.Forms.TextBox();
            this.lblMaNPP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.mstSDT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNPP)).BeginInit();
            this.pnlKhuyenMai.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSNPP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(428, 146);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1108, 768);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Các Nhà Phân Phối";
            // 
            // dgvDSNPP
            // 
            this.dgvDSNPP.AllowUserToAddRows = false;
            this.dgvDSNPP.AllowUserToDeleteRows = false;
            this.dgvDSNPP.AllowUserToResizeColumns = false;
            this.dgvDSNPP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNPP.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.dgvDSNPP.Location = new System.Drawing.Point(3, 20);
            this.dgvDSNPP.Margin = new System.Windows.Forms.Padding(2);
=======
            this.dgvDSNPP.Location = new System.Drawing.Point(4, 30);
>>>>>>> origin/BuiThuKimNgan
            this.dgvDSNPP.Name = "dgvDSNPP";
            this.dgvDSNPP.RowHeadersWidth = 62;
            this.dgvDSNPP.RowTemplate.Height = 28;
            this.dgvDSNPP.Size = new System.Drawing.Size(1100, 733);
            this.dgvDSNPP.TabIndex = 0;
            this.dgvDSNPP.Click += new System.EventHandler(this.dgvDSNPP_Click);
            // 
            // pnlKhuyenMai
            // 
            this.pnlKhuyenMai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlKhuyenMai.Controls.Add(this.lblNPP);
<<<<<<< HEAD
            this.pnlKhuyenMai.Location = new System.Drawing.Point(285, -1);
            this.pnlKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
=======
            this.pnlKhuyenMai.Location = new System.Drawing.Point(428, -2);
>>>>>>> origin/BuiThuKimNgan
            this.pnlKhuyenMai.Name = "pnlKhuyenMai";
            this.pnlKhuyenMai.Size = new System.Drawing.Size(1108, 128);
            this.pnlKhuyenMai.TabIndex = 38;
            // 
            // lblNPP
            // 
            this.lblNPP.AutoSize = true;
            this.lblNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPP.ForeColor = System.Drawing.Color.White;
            this.lblNPP.Location = new System.Drawing.Point(104, 31);
            this.lblNPP.Name = "lblNPP";
            this.lblNPP.Size = new System.Drawing.Size(891, 69);
            this.lblNPP.TabIndex = 7;
            this.lblNPP.Text = "DANH SÁCH NHÀ PHÂN PHỐI";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.Location = new System.Drawing.Point(32, 265);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(302, 66);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(26, 234);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(91, 26);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // txtTenNPP
            // 
            this.txtTenNPP.BackColor = System.Drawing.Color.White;
            this.txtTenNPP.Location = new System.Drawing.Point(32, 182);
            this.txtTenNPP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNPP.Name = "txtTenNPP";
            this.txtTenNPP.Size = new System.Drawing.Size(302, 32);
            this.txtTenNPP.TabIndex = 3;
            // 
            // lblTenNPP
            // 
            this.lblTenNPP.AutoSize = true;
            this.lblTenNPP.Location = new System.Drawing.Point(26, 151);
            this.lblTenNPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNPP.Name = "lblTenNPP";
            this.lblTenNPP.Size = new System.Drawing.Size(203, 26);
            this.lblTenNPP.TabIndex = 2;
            this.lblTenNPP.Text = "Tên nhà phân phối :";
            // 
            // txtMaNPP
            // 
            this.txtMaNPP.BackColor = System.Drawing.Color.White;
            this.txtMaNPP.Location = new System.Drawing.Point(32, 97);
            this.txtMaNPP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNPP.Name = "txtMaNPP";
            this.txtMaNPP.Size = new System.Drawing.Size(302, 32);
            this.txtMaNPP.TabIndex = 1;
            // 
            // lblMaNPP
            // 
            this.lblMaNPP.AutoSize = true;
            this.lblMaNPP.Location = new System.Drawing.Point(26, 66);
            this.lblMaNPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNPP.Name = "lblMaNPP";
            this.lblMaNPP.Size = new System.Drawing.Size(197, 26);
            this.lblMaNPP.TabIndex = 0;
            this.lblMaNPP.Text = "Mã nhà phân phối :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.groupBox2.Location = new System.Drawing.Point(19, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 218);
=======
            this.groupBox2.Location = new System.Drawing.Point(28, 625);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(366, 288);
>>>>>>> origin/BuiThuKimNgan
            this.groupBox2.TabIndex = 40;
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
            this.btnLamMoi.Location = new System.Drawing.Point(22, 143);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(202, 23);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm Mới";
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
<<<<<<< HEAD
            this.btnXoa.Location = new System.Drawing.Point(21, 66);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnXoa.Location = new System.Drawing.Point(32, 102);
>>>>>>> origin/BuiThuKimNgan
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(303, 35);
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
<<<<<<< HEAD
            this.btnThoat.Location = new System.Drawing.Point(21, 181);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnThoat.Location = new System.Drawing.Point(32, 220);
>>>>>>> origin/BuiThuKimNgan
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(303, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnThem.Location = new System.Drawing.Point(21, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnThem.Location = new System.Drawing.Point(32, 42);
>>>>>>> origin/BuiThuKimNgan
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(303, 35);
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
<<<<<<< HEAD
            this.btnSua.Location = new System.Drawing.Point(21, 104);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnSua.Location = new System.Drawing.Point(32, 160);
>>>>>>> origin/BuiThuKimNgan
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(303, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mstSDT);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNPP);
            this.groupBox1.Controls.Add(this.lblTenNPP);
            this.groupBox1.Controls.Add(this.txtMaNPP);
            this.groupBox1.Controls.Add(this.lblMaNPP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
=======
            this.groupBox1.Location = new System.Drawing.Point(28, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> origin/BuiThuKimNgan
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(366, 520);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhà Phân Phối";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(32, 465);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 32);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 434);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 26);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email :";
            // 
<<<<<<< HEAD
=======
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.Location = new System.Drawing.Point(32, 382);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(302, 32);
            this.txtSDT.TabIndex = 9;
            // 
>>>>>>> origin/BuiThuKimNgan
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(26, 351);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(151, 26);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại :";
            // 
            // mstSDT
            // 
            this.mstSDT.Location = new System.Drawing.Point(22, 250);
            this.mstSDT.Mask = "0000000000";
            this.mstSDT.Name = "mstSDT";
            this.mstSDT.Size = new System.Drawing.Size(201, 24);
            this.mstSDT.TabIndex = 12;
            // 
            // NhaPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1561, 915);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pnlKhuyenMai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2);
=======
>>>>>>> origin/BuiThuKimNgan
            this.Name = "NhaPhanPhoi";
            this.Text = "NhaPhanPhoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhaPhanPhoi_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNPP)).EndInit();
            this.pnlKhuyenMai.ResumeLayout(false);
            this.pnlKhuyenMai.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSNPP;
        private System.Windows.Forms.Panel pnlKhuyenMai;
        private System.Windows.Forms.Label lblNPP;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtTenNPP;
        private System.Windows.Forms.Label lblTenNPP;
        private System.Windows.Forms.TextBox txtMaNPP;
        private System.Windows.Forms.Label lblMaNPP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.MaskedTextBox mstSDT;
    }
}