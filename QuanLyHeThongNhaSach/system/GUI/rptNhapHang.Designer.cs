namespace GUI
{
    partial class rptNhapHang
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rptBCNhapHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pnlNhapHang = new System.Windows.Forms.Panel();
            this.lblQLCT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.pnlNhapHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rptBCNhapHang);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 136);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1074, 302);
            this.panelControl2.TabIndex = 57;
            // 
            // rptBCNhapHang
            // 
            this.rptBCNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBCNhapHang.Location = new System.Drawing.Point(2, 2);
            this.rptBCNhapHang.Name = "rptBCNhapHang";
            this.rptBCNhapHang.ServerReport.BearerToken = null;
            this.rptBCNhapHang.Size = new System.Drawing.Size(1070, 298);
            this.rptBCNhapHang.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 83);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1074, 53);
            this.panelControl1.TabIndex = 56;
            // 
            // pnlNhapHang
            // 
            this.pnlNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlNhapHang.Controls.Add(this.lblQLCT);
            this.pnlNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhapHang.Location = new System.Drawing.Point(0, 0);
            this.pnlNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNhapHang.Name = "pnlNhapHang";
            this.pnlNhapHang.Size = new System.Drawing.Size(1074, 83);
            this.pnlNhapHang.TabIndex = 55;
            // 
            // lblQLCT
            // 
            this.lblQLCT.AutoSize = true;
            this.lblQLCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLCT.ForeColor = System.Drawing.Color.White;
            this.lblQLCT.Location = new System.Drawing.Point(313, 20);
            this.lblQLCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQLCT.Name = "lblQLCT";
            this.lblQLCT.Size = new System.Drawing.Size(470, 46);
            this.lblQLCT.TabIndex = 7;
            this.lblQLCT.Text = "BÁO CÁO NHẬP HÀNG";
            // 
            // rptNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 438);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlNhapHang);
            this.Name = "rptNhapHang";
            this.Text = "rptNhapHang";
            this.Load += new System.EventHandler(this.rptNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.pnlNhapHang.ResumeLayout(false);
            this.pnlNhapHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Microsoft.Reporting.WinForms.ReportViewer rptBCNhapHang;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel pnlNhapHang;
        private System.Windows.Forms.Label lblQLCT;
    }
}