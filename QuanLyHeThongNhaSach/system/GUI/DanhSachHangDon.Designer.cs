namespace GUI
{
    partial class DanhSachHangDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLichSuHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.txtMaNPP = new System.Windows.Forms.TextBox();
            this.lblMaNPP = new System.Windows.Forms.Label();
            this.pnlNhapHang = new System.Windows.Forms.Panel();
            this.lblNhapHang = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSHangHoa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuHoaDon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlNhapHang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLichSuHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 312);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lịch Sử Hóa Đơn";
            // 
            // dgvLichSuHoaDon
            // 
            this.dgvLichSuHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuHoaDon.Location = new System.Drawing.Point(3, 20);
            this.dgvLichSuHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLichSuHoaDon.Name = "dgvLichSuHoaDon";
            this.dgvLichSuHoaDon.RowHeadersWidth = 62;
            this.dgvLichSuHoaDon.RowTemplate.Height = 28;
            this.dgvLichSuHoaDon.Size = new System.Drawing.Size(464, 289);
            this.dgvLichSuHoaDon.TabIndex = 0;
            this.dgvLichSuHoaDon.Click += new System.EventHandler(this.dgvLichSuHoaDon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.txtMaHH);
            this.groupBox4.Controls.Add(this.lblMaHH);
            this.groupBox4.Controls.Add(this.txtMaNPP);
            this.groupBox4.Controls.Add(this.lblMaNPP);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(995, 145);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin NhậpHàng Hóa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(760, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 24);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày thanh toán:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(174, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 68);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(482, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(328, 32);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(179, 32);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "In";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Tìm kiếm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtMaHH
            // 
            this.txtMaHH.BackColor = System.Drawing.Color.White;
            this.txtMaHH.Location = new System.Drawing.Point(439, 30);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(177, 24);
            this.txtMaHH.TabIndex = 1;
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Location = new System.Drawing.Point(327, 36);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(102, 18);
            this.lblMaHH.TabIndex = 0;
            this.lblMaHH.Text = "Mã hàng hóa :";
            // 
            // txtMaNPP
            // 
            this.txtMaNPP.BackColor = System.Drawing.Color.White;
            this.txtMaNPP.Enabled = false;
            this.txtMaNPP.Location = new System.Drawing.Point(129, 33);
            this.txtMaNPP.Name = "txtMaNPP";
            this.txtMaNPP.Size = new System.Drawing.Size(177, 24);
            this.txtMaNPP.TabIndex = 1;
            // 
            // lblMaNPP
            // 
            this.lblMaNPP.AutoSize = true;
            this.lblMaNPP.Location = new System.Drawing.Point(15, 36);
            this.lblMaNPP.Name = "lblMaNPP";
            this.lblMaNPP.Size = new System.Drawing.Size(95, 18);
            this.lblMaNPP.TabIndex = 0;
            this.lblMaNPP.Text = "Mã hóa đơn: ";
            // 
            // pnlNhapHang
            // 
            this.pnlNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlNhapHang.Controls.Add(this.lblNhapHang);
            this.pnlNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhapHang.Location = new System.Drawing.Point(0, 0);
            this.pnlNhapHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNhapHang.Name = "pnlNhapHang";
            this.pnlNhapHang.Size = new System.Drawing.Size(1035, 83);
            this.pnlNhapHang.TabIndex = 37;
            // 
            // lblNhapHang
            // 
            this.lblNhapHang.AutoSize = true;
            this.lblNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblNhapHang.Location = new System.Drawing.Point(313, 20);
            this.lblNhapHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapHang.Name = "lblNhapHang";
            this.lblNhapHang.Size = new System.Drawing.Size(390, 46);
            this.lblNhapHang.TabIndex = 7;
            this.lblNhapHang.Text = "LỊCH SỬ HÓA ĐƠN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSHangHoa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(498, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 312);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm Trong Hóa Đơn";
            // 
            // dgvDSHangHoa
            // 
            this.dgvDSHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHangHoa.Location = new System.Drawing.Point(3, 20);
            this.dgvDSHangHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSHangHoa.Name = "dgvDSHangHoa";
            this.dgvDSHangHoa.RowHeadersWidth = 62;
            this.dgvDSHangHoa.RowTemplate.Height = 28;
            this.dgvDSHangHoa.Size = new System.Drawing.Size(516, 289);
            this.dgvDSHangHoa.TabIndex = 0;
            // 
            // DanhSachHangDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlNhapHang);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachHangDon";
            this.Text = "DanhSachHangDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachHangDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuHoaDon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlNhapHang.ResumeLayout(false);
            this.pnlNhapHang.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLichSuHoaDon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.TextBox txtMaNPP;
        private System.Windows.Forms.Label lblMaNPP;
        private System.Windows.Forms.Panel pnlNhapHang;
        private System.Windows.Forms.Label lblNhapHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSHangHoa;
        private System.Windows.Forms.Button button1;
    }
}