namespace GUI
{
    partial class LichSuNhapHang
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
            this.cboMaNPP = new System.Windows.Forms.ComboBox();
            this.dtpNgayNH = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.lblMaNPP = new System.Windows.Forms.Label();
            this.pnlNhapHang = new System.Windows.Forms.Panel();
            this.lblNhapHang = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSHangHoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLSNH = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlNhapHang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSNH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboMaNPP);
            this.groupBox4.Controls.Add(this.dtpNgayNH);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.txtMaHH);
            this.groupBox4.Controls.Add(this.lblMaHH);
            this.groupBox4.Controls.Add(this.lblMaNPP);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(30, 135);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1492, 223);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin NhậpHàng Hóa";
            // 
            // cboMaNPP
            // 
            this.cboMaNPP.FormattingEnabled = true;
            this.cboMaNPP.Location = new System.Drawing.Point(192, 48);
            this.cboMaNPP.Name = "cboMaNPP";
            this.cboMaNPP.Size = new System.Drawing.Size(235, 34);
            this.cboMaNPP.TabIndex = 16;
            this.cboMaNPP.SelectedIndexChanged += new System.EventHandler(this.cboMaNPP_SelectedIndexChanged);
            // 
            // dtpNgayNH
            // 
            this.dtpNgayNH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNH.Location = new System.Drawing.Point(1198, 46);
            this.dtpNgayNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayNH.Name = "dtpNgayNH";
            this.dtpNgayNH.Size = new System.Drawing.Size(223, 32);
            this.dtpNgayNH.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày nhập hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(389, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(734, 105);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(492, 49);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(206, 35);
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
            this.btnXoa.Location = new System.Drawing.Point(268, 49);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(206, 35);
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
            this.btnThem.Location = new System.Drawing.Point(22, 49);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(206, 35);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Tìm kiếm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtMaHH
            // 
            this.txtMaHH.BackColor = System.Drawing.Color.White;
            this.txtMaHH.Location = new System.Drawing.Point(705, 46);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(264, 32);
            this.txtMaHH.TabIndex = 1;
            this.txtMaHH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHH_KeyPress);
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Location = new System.Drawing.Point(526, 51);
            this.lblMaHH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(150, 26);
            this.lblMaHH.TabIndex = 0;
            this.lblMaHH.Text = "Mã hàng hóa :";
            // 
            // lblMaNPP
            // 
            this.lblMaNPP.AutoSize = true;
            this.lblMaNPP.Location = new System.Drawing.Point(65, 51);
            this.lblMaNPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNPP.Name = "lblMaNPP";
            this.lblMaNPP.Size = new System.Drawing.Size(106, 26);
            this.lblMaNPP.TabIndex = 0;
            this.lblMaNPP.Text = "Mã NPP :";
            // 
            // pnlNhapHang
            // 
            this.pnlNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlNhapHang.Controls.Add(this.lblNhapHang);
            this.pnlNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhapHang.Location = new System.Drawing.Point(0, 0);
            this.pnlNhapHang.Name = "pnlNhapHang";
            this.pnlNhapHang.Size = new System.Drawing.Size(1557, 128);
            this.pnlNhapHang.TabIndex = 32;
            // 
            // lblNhapHang
            // 
            this.lblNhapHang.AutoSize = true;
            this.lblNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblNhapHang.Location = new System.Drawing.Point(491, 34);
            this.lblNhapHang.Name = "lblNhapHang";
            this.lblNhapHang.Size = new System.Drawing.Size(653, 69);
            this.lblNhapHang.TabIndex = 7;
            this.lblNhapHang.Text = "LỊCH SỬ NHẬP HÀNG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSHangHoa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 657);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1497, 273);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm Được Nhập:";
            // 
            // dgvDSHangHoa
            // 
            this.dgvDSHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHangHoa.Location = new System.Drawing.Point(4, 30);
            this.dgvDSHangHoa.Name = "dgvDSHangHoa";
            this.dgvDSHangHoa.RowHeadersWidth = 62;
            this.dgvDSHangHoa.RowTemplate.Height = 28;
            this.dgvDSHangHoa.Size = new System.Drawing.Size(1489, 238);
            this.dgvDSHangHoa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLSNH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 368);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1497, 279);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lịch Sử Nhập Hàng:";
            // 
            // dgvLSNH
            // 
            this.dgvLSNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLSNH.Location = new System.Drawing.Point(4, 30);
            this.dgvLSNH.Name = "dgvLSNH";
            this.dgvLSNH.RowHeadersWidth = 62;
            this.dgvLSNH.RowTemplate.Height = 28;
            this.dgvLSNH.Size = new System.Drawing.Size(1489, 244);
            this.dgvLSNH.TabIndex = 0;
            this.dgvLSNH.Click += new System.EventHandler(this.dgvLSNH_Click);
            // 
            // LichSuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1557, 934);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlNhapHang);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LichSuNhapHang";
            this.Text = "LichSuNhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LichSuNhapHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlNhapHang.ResumeLayout(false);
            this.pnlNhapHang.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.Panel pnlNhapHang;
        private System.Windows.Forms.Label lblNhapHang;
        private System.Windows.Forms.Label lblMaNPP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayNH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLSNH;
        private System.Windows.Forms.ComboBox cboMaNPP;
    }
}