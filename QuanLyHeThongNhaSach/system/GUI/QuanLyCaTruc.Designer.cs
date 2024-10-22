namespace GUI
{
    partial class QuanLyCaTruc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCaTruc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblCaTruc = new System.Windows.Forms.Label();
            this.txtTenNS = new System.Windows.Forms.TextBox();
            this.lblTenNS = new System.Windows.Forms.Label();
            this.pnlNhapHang = new System.Windows.Forms.Panel();
            this.lblQLCT = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSHangHoa = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnCT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlNhapHang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 274);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(464, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cboCaTruc);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.lblCaTruc);
            this.groupBox4.Controls.Add(this.txtTenNS);
            this.groupBox4.Controls.Add(this.lblTenNS);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(995, 184);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Ca Trực";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(895, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 24);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "SL nhân viên:";
            // 
            // cboCaTruc
            // 
            this.cboCaTruc.FormattingEnabled = true;
            this.cboCaTruc.Location = new System.Drawing.Point(629, 33);
            this.cboCaTruc.Name = "cboCaTruc";
            this.cboCaTruc.Size = new System.Drawing.Size(148, 26);
            this.cboCaTruc.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCT);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(262, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 102);
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
            this.button1.Location = new System.Drawing.Point(367, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quay về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm ca trực";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // lblCaTruc
            // 
            this.lblCaTruc.AutoSize = true;
            this.lblCaTruc.Location = new System.Drawing.Point(563, 36);
            this.lblCaTruc.Name = "lblCaTruc";
            this.lblCaTruc.Size = new System.Drawing.Size(60, 18);
            this.lblCaTruc.TabIndex = 0;
            this.lblCaTruc.Text = "Ca trực:";
            // 
            // txtTenNS
            // 
            this.txtTenNS.BackColor = System.Drawing.Color.White;
            this.txtTenNS.Enabled = false;
            this.txtTenNS.Location = new System.Drawing.Point(129, 33);
            this.txtTenNS.Name = "txtTenNS";
            this.txtTenNS.Size = new System.Drawing.Size(361, 24);
            this.txtTenNS.TabIndex = 1;
            // 
            // lblTenNS
            // 
            this.lblTenNS.AutoSize = true;
            this.lblTenNS.Location = new System.Drawing.Point(15, 36);
            this.lblTenNS.Name = "lblTenNS";
            this.lblTenNS.Size = new System.Drawing.Size(93, 18);
            this.lblTenNS.TabIndex = 0;
            this.lblTenNS.Text = "Tên nhân sự:";
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
            this.pnlNhapHang.TabIndex = 45;
            // 
            // lblQLCT
            // 
            this.lblQLCT.AutoSize = true;
            this.lblQLCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLCT.ForeColor = System.Drawing.Color.White;
            this.lblQLCT.Location = new System.Drawing.Point(313, 20);
            this.lblQLCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQLCT.Name = "lblQLCT";
            this.lblQLCT.Size = new System.Drawing.Size(399, 46);
            this.lblQLCT.TabIndex = 7;
            this.lblQLCT.Text = "QUẢN LÝ CA TRỰC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSHangHoa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(487, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 274);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Ca Trực";
            this.groupBox3.UseCompatibleTextRendering = true;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvDSHangHoa
            // 
            this.dgvDSHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHangHoa.Location = new System.Drawing.Point(3, 20);
            this.dgvDSHangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSHangHoa.Name = "dgvDSHangHoa";
            this.dgvDSHangHoa.RowHeadersWidth = 62;
            this.dgvDSHangHoa.RowTemplate.Height = 28;
            this.dgvDSHangHoa.Size = new System.Drawing.Size(516, 251);
            this.dgvDSHangHoa.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(20, 70);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa ca trực";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(198, 32);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa ca trực";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(198, 70);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(137, 23);
            this.btnLoc.TabIndex = 8;
            this.btnLoc.Text = "Lọc ca trực";
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // btnCT
            // 
            this.btnCT.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCT.FlatAppearance.BorderSize = 0;
            this.btnCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCT.ForeColor = System.Drawing.Color.White;
            this.btnCT.Location = new System.Drawing.Point(367, 70);
            this.btnCT.Margin = new System.Windows.Forms.Padding(2);
            this.btnCT.Name = "btnCT";
            this.btnCT.Size = new System.Drawing.Size(137, 23);
            this.btnCT.TabIndex = 9;
            this.btnCT.Text = "Ca Trực";
            this.btnCT.UseVisualStyleBackColor = false;
            this.btnCT.Click += new System.EventHandler(this.btnCT_Click);
            // 
            // QuanLyCaTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 572);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlNhapHang);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyCaTruc";
            this.Text = "QuanLyCaTruc";
            this.Load += new System.EventHandler(this.QuanLyCaTruc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblCaTruc;
        private System.Windows.Forms.TextBox txtTenNS;
        private System.Windows.Forms.Label lblTenNS;
        private System.Windows.Forms.Panel pnlNhapHang;
        private System.Windows.Forms.Label lblQLCT;
        private System.Windows.Forms.ComboBox cboCaTruc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSHangHoa;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCT;
    }
}