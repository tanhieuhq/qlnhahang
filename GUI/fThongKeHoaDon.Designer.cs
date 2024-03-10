
namespace GUI
{
    partial class fThongKeHoaDon
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
            this.txtNumPage = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dgvBillThongKe = new System.Windows.Forms.DataGridView();
            this.dgvThongKeChiTiet = new System.Windows.Forms.DataGridView();
            this.btnInThongKe = new System.Windows.Forms.Button();
            this.btnTrangDau = new System.Windows.Forms.Button();
            this.btnTrangCuoi = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnKeTiep = new System.Windows.Forms.Button();
            this.lblQuanLyMon = new System.Windows.Forms.Label();
            this.lblDanhSachHD = new System.Windows.Forms.Label();
            this.lblChiTietHoaDon = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPage
            // 
            this.txtNumPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.txtNumPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumPage.ForeColor = System.Drawing.Color.White;
            this.txtNumPage.Location = new System.Drawing.Point(306, 536);
            this.txtNumPage.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumPage.Multiline = true;
            this.txtNumPage.Name = "txtNumPage";
            this.txtNumPage.ReadOnly = true;
            this.txtNumPage.Size = new System.Drawing.Size(60, 30);
            this.txtNumPage.TabIndex = 15;
            this.txtNumPage.Text = "1";
            this.txtNumPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumPage.TextChanged += new System.EventHandler(this.txtNumPage_TextChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(502, 87);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(249, 28);
            this.dtpToDate.TabIndex = 9;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(113, 87);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(249, 28);
            this.dtpFromDate.TabIndex = 8;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblTuNgay.Location = new System.Drawing.Point(13, 92);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(92, 24);
            this.lblTuNgay.TabIndex = 17;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblDenNgay.Location = new System.Drawing.Point(385, 92);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(105, 24);
            this.lblDenNgay.TabIndex = 17;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dgvBillThongKe
            // 
            this.dgvBillThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillThongKe.Location = new System.Drawing.Point(17, 163);
            this.dgvBillThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBillThongKe.Name = "dgvBillThongKe";
            this.dgvBillThongKe.RowHeadersWidth = 51;
            this.dgvBillThongKe.RowTemplate.Height = 24;
            this.dgvBillThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillThongKe.Size = new System.Drawing.Size(734, 357);
            this.dgvBillThongKe.TabIndex = 0;
            this.dgvBillThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillThongKe_CellContentClick);
            // 
            // dgvThongKeChiTiet
            // 
            this.dgvThongKeChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeChiTiet.Location = new System.Drawing.Point(758, 163);
            this.dgvThongKeChiTiet.Name = "dgvThongKeChiTiet";
            this.dgvThongKeChiTiet.RowHeadersWidth = 51;
            this.dgvThongKeChiTiet.RowTemplate.Height = 24;
            this.dgvThongKeChiTiet.Size = new System.Drawing.Size(312, 354);
            this.dgvThongKeChiTiet.TabIndex = 18;
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnInThongKe.FlatAppearance.BorderSize = 0;
            this.btnInThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInThongKe.ForeColor = System.Drawing.Color.White;
            this.btnInThongKe.Image = global::GUI.Properties.Resources._in;
            this.btnInThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInThongKe.Location = new System.Drawing.Point(948, 528);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.Size = new System.Drawing.Size(122, 57);
            this.btnInThongKe.TabIndex = 19;
            this.btnInThongKe.Text = "In Thống kê";
            this.btnInThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInThongKe.UseVisualStyleBackColor = false;
            this.btnInThongKe.Click += new System.EventHandler(this.btnInThongKe_Click);
            // 
            // btnTrangDau
            // 
            this.btnTrangDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnTrangDau.FlatAppearance.BorderSize = 0;
            this.btnTrangDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangDau.ForeColor = System.Drawing.Color.White;
            this.btnTrangDau.Location = new System.Drawing.Point(96, 536);
            this.btnTrangDau.Name = "btnTrangDau";
            this.btnTrangDau.Size = new System.Drawing.Size(60, 30);
            this.btnTrangDau.TabIndex = 19;
            this.btnTrangDau.Text = "|<";
            this.btnTrangDau.UseVisualStyleBackColor = false;
            this.btnTrangDau.Click += new System.EventHandler(this.btnTrangDau_Click);
            // 
            // btnTrangCuoi
            // 
            this.btnTrangCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnTrangCuoi.FlatAppearance.BorderSize = 0;
            this.btnTrangCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangCuoi.ForeColor = System.Drawing.Color.White;
            this.btnTrangCuoi.Location = new System.Drawing.Point(505, 536);
            this.btnTrangCuoi.Name = "btnTrangCuoi";
            this.btnTrangCuoi.Size = new System.Drawing.Size(60, 30);
            this.btnTrangCuoi.TabIndex = 19;
            this.btnTrangCuoi.Text = ">|";
            this.btnTrangCuoi.UseVisualStyleBackColor = false;
            this.btnTrangCuoi.Click += new System.EventHandler(this.btnTrangCuoi_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnTruoc.FlatAppearance.BorderSize = 0;
            this.btnTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruoc.ForeColor = System.Drawing.Color.White;
            this.btnTruoc.Location = new System.Drawing.Point(185, 536);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(60, 30);
            this.btnTruoc.TabIndex = 19;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnKeTiep
            // 
            this.btnKeTiep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnKeTiep.FlatAppearance.BorderSize = 0;
            this.btnKeTiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeTiep.ForeColor = System.Drawing.Color.White;
            this.btnKeTiep.Location = new System.Drawing.Point(421, 536);
            this.btnKeTiep.Name = "btnKeTiep";
            this.btnKeTiep.Size = new System.Drawing.Size(60, 30);
            this.btnKeTiep.TabIndex = 19;
            this.btnKeTiep.Text = ">";
            this.btnKeTiep.UseVisualStyleBackColor = false;
            this.btnKeTiep.Click += new System.EventHandler(this.btnKeTiep_Click);
            // 
            // lblQuanLyMon
            // 
            this.lblQuanLyMon.AutoSize = true;
            this.lblQuanLyMon.Font = new System.Drawing.Font("Cooper Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyMon.ForeColor = System.Drawing.Color.White;
            this.lblQuanLyMon.Location = new System.Drawing.Point(292, 22);
            this.lblQuanLyMon.Name = "lblQuanLyMon";
            this.lblQuanLyMon.Size = new System.Drawing.Size(440, 42);
            this.lblQuanLyMon.TabIndex = 37;
            this.lblQuanLyMon.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // lblDanhSachHD
            // 
            this.lblDanhSachHD.AutoSize = true;
            this.lblDanhSachHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblDanhSachHD.Location = new System.Drawing.Point(13, 135);
            this.lblDanhSachHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachHD.Name = "lblDanhSachHD";
            this.lblDanhSachHD.Size = new System.Drawing.Size(193, 24);
            this.lblDanhSachHD.TabIndex = 17;
            this.lblDanhSachHD.Text = "Danh sách hóa đơn";
            // 
            // lblChiTietHoaDon
            // 
            this.lblChiTietHoaDon.AutoSize = true;
            this.lblChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblChiTietHoaDon.Location = new System.Drawing.Point(755, 136);
            this.lblChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiTietHoaDon.Name = "lblChiTietHoaDon";
            this.lblChiTietHoaDon.Size = new System.Drawing.Size(158, 24);
            this.lblChiTietHoaDon.TabIndex = 17;
            this.lblChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.MinhHoaNhaHang;
            this.picLogo.Location = new System.Drawing.Point(988, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(82, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 38;
            this.picLogo.TabStop = false;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.Image = global::GUI.Properties.Resources._in;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(759, 529);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(122, 57);
            this.btnInHoaDon.TabIndex = 19;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::GUI.Properties.Resources.ThongKe2;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(759, 70);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(122, 57);
            this.btnThongKe.TabIndex = 19;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // fThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1082, 594);
            this.Controls.Add(this.dgvThongKeChiTiet);
            this.Controls.Add(this.dgvBillThongKe);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblQuanLyMon);
            this.Controls.Add(this.btnTrangCuoi);
            this.Controls.Add(this.btnTrangDau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnKeTiep);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnInThongKe);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblChiTietHoaDon);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.lblDanhSachHD);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.txtNumPage);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongKeHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumPage;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DataGridView dgvBillThongKe;
        private System.Windows.Forms.DataGridView dgvThongKeChiTiet;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnInThongKe;
        private System.Windows.Forms.Button btnTrangDau;
        private System.Windows.Forms.Button btnTrangCuoi;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnKeTiep;
        private System.Windows.Forms.Label lblQuanLyMon;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Label lblDanhSachHD;
        private System.Windows.Forms.Label lblChiTietHoaDon;
    }
}