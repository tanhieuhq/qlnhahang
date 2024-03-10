
namespace GUI
{
    partial class fManHinhChinh
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
            this.components = new System.ComponentModel.Container();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.nudDisCount = new System.Windows.Forms.NumericUpDown();
            this.nudFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cboSwitchTable = new System.Windows.Forms.ComboBox();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.cboCategoryFood = new System.Windows.Forms.ComboBox();
            this.lvwBill = new System.Windows.Forms.ListView();
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsXoaHD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGiamgia = new System.Windows.Forms.Label();
            this.lblChonBan = new System.Windows.Forms.Label();
            this.btnGopBan = new System.Windows.Forms.Button();
            this.grpPhieuGoiMon = new System.Windows.Forms.GroupBox();
            this.grpDanhSachBan = new System.Windows.Forms.GroupBox();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.btnCapNhatKhuyenMai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblLoaiMon = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.grpCapNhatGoiMon = new System.Windows.Forms.GroupBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnCapNhatSoLuong = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.grpCapNhatBan = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThemMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCapNhatSoLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsChuyenBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsGopBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTKThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyBaoTri = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).BeginInit();
            this.cmsXoaHD.SuspendLayout();
            this.grpPhieuGoiMon.SuspendLayout();
            this.grpDanhSachBan.SuspendLayout();
            this.grpThanhToan.SuspendLayout();
            this.grpCapNhatGoiMon.SuspendLayout();
            this.grpCapNhatBan.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(332, 58);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(140, 28);
            this.txtTotalPrice.TabIndex = 21;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(200, 61);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(105, 24);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "Tổng tiền:";
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(3, 24);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(404, 488);
            this.flpTable.TabIndex = 19;
            // 
            // nudDisCount
            // 
            this.nudDisCount.BackColor = System.Drawing.Color.White;
            this.nudDisCount.Location = new System.Drawing.Point(332, 28);
            this.nudDisCount.Name = "nudDisCount";
            this.nudDisCount.Size = new System.Drawing.Size(140, 28);
            this.nudDisCount.TabIndex = 17;
            this.nudDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudFoodCount
            // 
            this.nudFoodCount.BackColor = System.Drawing.Color.White;
            this.nudFoodCount.Location = new System.Drawing.Point(113, 141);
            this.nudFoodCount.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudFoodCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFoodCount.Name = "nudFoodCount";
            this.nudFoodCount.Size = new System.Drawing.Size(157, 28);
            this.nudFoodCount.TabIndex = 18;
            this.nudFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnChuyenBan.FlatAppearance.BorderSize = 0;
            this.btnChuyenBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenBan.Location = new System.Drawing.Point(148, 75);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(126, 57);
            this.btnChuyenBan.TabIndex = 13;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // cboSwitchTable
            // 
            this.cboSwitchTable.BackColor = System.Drawing.Color.White;
            this.cboSwitchTable.FormattingEnabled = true;
            this.cboSwitchTable.Location = new System.Drawing.Point(117, 27);
            this.cboSwitchTable.Name = "cboSwitchTable";
            this.cboSwitchTable.Size = new System.Drawing.Size(157, 30);
            this.cboSwitchTable.TabIndex = 10;
            // 
            // cboFood
            // 
            this.cboFood.BackColor = System.Drawing.Color.White;
            this.cboFood.ForeColor = System.Drawing.Color.Black;
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(113, 87);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(157, 30);
            this.cboFood.TabIndex = 11;
            // 
            // cboCategoryFood
            // 
            this.cboCategoryFood.BackColor = System.Drawing.Color.White;
            this.cboCategoryFood.FormattingEnabled = true;
            this.cboCategoryFood.Location = new System.Drawing.Point(113, 33);
            this.cboCategoryFood.Name = "cboCategoryFood";
            this.cboCategoryFood.Size = new System.Drawing.Size(157, 30);
            this.cboCategoryFood.TabIndex = 12;
            this.cboCategoryFood.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lvwBill
            // 
            this.lvwBill.BackColor = System.Drawing.Color.White;
            this.lvwBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenMon,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.lvwBill.ContextMenuStrip = this.cmsXoaHD;
            this.lvwBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBill.FullRowSelect = true;
            this.lvwBill.GridLines = true;
            this.lvwBill.HideSelection = false;
            this.lvwBill.Location = new System.Drawing.Point(3, 24);
            this.lvwBill.Name = "lvwBill";
            this.lvwBill.Size = new System.Drawing.Size(466, 382);
            this.lvwBill.TabIndex = 0;
            this.lvwBill.UseCompatibleStateImageBehavior = false;
            this.lvwBill.View = System.Windows.Forms.View.Details;
            this.lvwBill.SelectedIndexChanged += new System.EventHandler(this.lvwBill_SelectedIndexChanged);
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 170;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.Width = 80;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 100;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.Width = 110;
            // 
            // cmsXoaHD
            // 
            this.cmsXoaHD.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsXoaHD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsXoa});
            this.cmsXoaHD.Name = "cmsXoaHD";
            this.cmsXoaHD.Size = new System.Drawing.Size(105, 28);
            // 
            // cmsXoa
            // 
            this.cmsXoa.Name = "cmsXoa";
            this.cmsXoa.Size = new System.Drawing.Size(104, 24);
            this.cmsXoa.Text = "Xóa";
            this.cmsXoa.Click += new System.EventHandler(this.cmsXoa_Click);
            // 
            // lblGiamgia
            // 
            this.lblGiamgia.AutoSize = true;
            this.lblGiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblGiamgia.Location = new System.Drawing.Point(200, 30);
            this.lblGiamgia.Name = "lblGiamgia";
            this.lblGiamgia.Size = new System.Drawing.Size(126, 24);
            this.lblGiamgia.TabIndex = 23;
            this.lblGiamgia.Text = "Khuyến mãi:";
            // 
            // lblChonBan
            // 
            this.lblChonBan.AutoSize = true;
            this.lblChonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblChonBan.Location = new System.Drawing.Point(10, 33);
            this.lblChonBan.Name = "lblChonBan";
            this.lblChonBan.Size = new System.Drawing.Size(107, 24);
            this.lblChonBan.TabIndex = 24;
            this.lblChonBan.Text = "Chọn bàn:";
            // 
            // btnGopBan
            // 
            this.btnGopBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnGopBan.FlatAppearance.BorderSize = 0;
            this.btnGopBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGopBan.Location = new System.Drawing.Point(14, 75);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(122, 57);
            this.btnGopBan.TabIndex = 13;
            this.btnGopBan.Text = "Gộp bàn";
            this.btnGopBan.UseVisualStyleBackColor = false;
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // grpPhieuGoiMon
            // 
            this.grpPhieuGoiMon.Controls.Add(this.lvwBill);
            this.grpPhieuGoiMon.ForeColor = System.Drawing.Color.White;
            this.grpPhieuGoiMon.Location = new System.Drawing.Point(12, 124);
            this.grpPhieuGoiMon.Name = "grpPhieuGoiMon";
            this.grpPhieuGoiMon.Size = new System.Drawing.Size(472, 409);
            this.grpPhieuGoiMon.TabIndex = 25;
            this.grpPhieuGoiMon.TabStop = false;
            this.grpPhieuGoiMon.Text = "Phiếu gọi món";
            // 
            // grpDanhSachBan
            // 
            this.grpDanhSachBan.Controls.Add(this.flpTable);
            this.grpDanhSachBan.ForeColor = System.Drawing.Color.White;
            this.grpDanhSachBan.Location = new System.Drawing.Point(776, 124);
            this.grpDanhSachBan.Name = "grpDanhSachBan";
            this.grpDanhSachBan.Size = new System.Drawing.Size(410, 515);
            this.grpDanhSachBan.TabIndex = 26;
            this.grpDanhSachBan.TabStop = false;
            this.grpDanhSachBan.Text = "Danh sách bàn";
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.Location = new System.Drawing.Point(8, 46);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(92, 22);
            this.lblXinChao.TabIndex = 28;
            this.lblXinChao.Text = "Xin chào! ";
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.lblGiamgia);
            this.grpThanhToan.Controls.Add(this.lblTenBan);
            this.grpThanhToan.Controls.Add(this.nudDisCount);
            this.grpThanhToan.Controls.Add(this.txtTotalPrice);
            this.grpThanhToan.Controls.Add(this.lblSoHoaDon);
            this.grpThanhToan.Controls.Add(this.lblTotalPrice);
            this.grpThanhToan.Controls.Add(this.btnCapNhatKhuyenMai);
            this.grpThanhToan.Controls.Add(this.btnThanhToan);
            this.grpThanhToan.ForeColor = System.Drawing.Color.White;
            this.grpThanhToan.Location = new System.Drawing.Point(12, 539);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(758, 100);
            this.grpThanhToan.TabIndex = 29;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thanh toán";
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblTenBan.Location = new System.Drawing.Point(6, 62);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(100, 24);
            this.lblTenBan.TabIndex = 25;
            this.lblTenBan.Text = "Tên bàn: ";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblSoHoaDon.Location = new System.Drawing.Point(6, 30);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(125, 24);
            this.lblSoHoaDon.TabIndex = 24;
            this.lblSoHoaDon.Text = "Số hóa đơn:";
            // 
            // btnCapNhatKhuyenMai
            // 
            this.btnCapNhatKhuyenMai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnCapNhatKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnCapNhatKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatKhuyenMai.Location = new System.Drawing.Point(492, 30);
            this.btnCapNhatKhuyenMai.Name = "btnCapNhatKhuyenMai";
            this.btnCapNhatKhuyenMai.Size = new System.Drawing.Size(122, 57);
            this.btnCapNhatKhuyenMai.TabIndex = 15;
            this.btnCapNhatKhuyenMai.Text = "Cập nhật khuyến mãi";
            this.btnCapNhatKhuyenMai.UseVisualStyleBackColor = false;
            this.btnCapNhatKhuyenMai.Click += new System.EventHandler(this.btnCapNhatKhuyenMai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Image = global::GUI.Properties.Resources.Dollar245;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(626, 29);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(122, 57);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblLoaiMon
            // 
            this.lblLoaiMon.AutoSize = true;
            this.lblLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblLoaiMon.Location = new System.Drawing.Point(6, 39);
            this.lblLoaiMon.Name = "lblLoaiMon";
            this.lblLoaiMon.Size = new System.Drawing.Size(102, 24);
            this.lblLoaiMon.TabIndex = 30;
            this.lblLoaiMon.Text = "Loại Món:";
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblMon.Location = new System.Drawing.Point(6, 86);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(57, 24);
            this.lblMon.TabIndex = 31;
            this.lblMon.Text = "Món:";
            // 
            // grpCapNhatGoiMon
            // 
            this.grpCapNhatGoiMon.Controls.Add(this.lblSoLuong);
            this.grpCapNhatGoiMon.Controls.Add(this.lblLoaiMon);
            this.grpCapNhatGoiMon.Controls.Add(this.lblMon);
            this.grpCapNhatGoiMon.Controls.Add(this.cboCategoryFood);
            this.grpCapNhatGoiMon.Controls.Add(this.cboFood);
            this.grpCapNhatGoiMon.Controls.Add(this.btnCapNhatSoLuong);
            this.grpCapNhatGoiMon.Controls.Add(this.btnThemMon);
            this.grpCapNhatGoiMon.Controls.Add(this.nudFoodCount);
            this.grpCapNhatGoiMon.ForeColor = System.Drawing.Color.White;
            this.grpCapNhatGoiMon.Location = new System.Drawing.Point(490, 124);
            this.grpCapNhatGoiMon.Name = "grpCapNhatGoiMon";
            this.grpCapNhatGoiMon.Size = new System.Drawing.Size(280, 253);
            this.grpCapNhatGoiMon.TabIndex = 32;
            this.grpCapNhatGoiMon.TabStop = false;
            this.grpCapNhatGoiMon.Text = "Cập nhật gọi món";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblSoLuong.Location = new System.Drawing.Point(6, 141);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(100, 24);
            this.lblSoLuong.TabIndex = 32;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // btnCapNhatSoLuong
            // 
            this.btnCapNhatSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnCapNhatSoLuong.FlatAppearance.BorderSize = 0;
            this.btnCapNhatSoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatSoLuong.Location = new System.Drawing.Point(14, 190);
            this.btnCapNhatSoLuong.Name = "btnCapNhatSoLuong";
            this.btnCapNhatSoLuong.Size = new System.Drawing.Size(122, 57);
            this.btnCapNhatSoLuong.TabIndex = 16;
            this.btnCapNhatSoLuong.Text = "Cập nhật số lượng";
            this.btnCapNhatSoLuong.UseVisualStyleBackColor = false;
            this.btnCapNhatSoLuong.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnThemMon.FlatAppearance.BorderSize = 0;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Image = global::GUI.Properties.Resources.add242;
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.Location = new System.Drawing.Point(148, 190);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(122, 57);
            this.btnThemMon.TabIndex = 16;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // grpCapNhatBan
            // 
            this.grpCapNhatBan.Controls.Add(this.lblChonBan);
            this.grpCapNhatBan.Controls.Add(this.cboSwitchTable);
            this.grpCapNhatBan.Controls.Add(this.btnChuyenBan);
            this.grpCapNhatBan.Controls.Add(this.btnGopBan);
            this.grpCapNhatBan.ForeColor = System.Drawing.Color.White;
            this.grpCapNhatBan.Location = new System.Drawing.Point(490, 383);
            this.grpCapNhatBan.Name = "grpCapNhatBan";
            this.grpCapNhatBan.Size = new System.Drawing.Size(280, 150);
            this.grpCapNhatBan.TabIndex = 33;
            this.grpCapNhatBan.TabStop = false;
            this.grpCapNhatBan.Text = "Cập nhật bàn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsHeThong,
            this.mnsTaiKhoan,
            this.mnsThongKe,
            this.mnsQuanLyBaoTri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 30);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsHeThong
            // 
            this.mnsHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsThemMon,
            this.mnsCapNhatSoLuong,
            this.mnsChuyenBan,
            this.mnsGopBan,
            this.mnsThanhToan,
            this.mnsThoat});
            this.mnsHeThong.ForeColor = System.Drawing.Color.Black;
            this.mnsHeThong.Name = "mnsHeThong";
            this.mnsHeThong.Size = new System.Drawing.Size(85, 26);
            this.mnsHeThong.Text = "Hệ thống";
            // 
            // mnsThemMon
            // 
            this.mnsThemMon.Name = "mnsThemMon";
            this.mnsThemMon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.mnsThemMon.Size = new System.Drawing.Size(261, 26);
            this.mnsThemMon.Text = "Thêm món";
            this.mnsThemMon.Click += new System.EventHandler(this.mnsThemMon_Click);
            // 
            // mnsCapNhatSoLuong
            // 
            this.mnsCapNhatSoLuong.Name = "mnsCapNhatSoLuong";
            this.mnsCapNhatSoLuong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.mnsCapNhatSoLuong.Size = new System.Drawing.Size(261, 26);
            this.mnsCapNhatSoLuong.Text = "Cập nhật số lượng";
            this.mnsCapNhatSoLuong.Click += new System.EventHandler(this.mnsCapNhatSoLuong_Click);
            // 
            // mnsChuyenBan
            // 
            this.mnsChuyenBan.Name = "mnsChuyenBan";
            this.mnsChuyenBan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnsChuyenBan.Size = new System.Drawing.Size(261, 26);
            this.mnsChuyenBan.Text = "Chuyển bàn";
            this.mnsChuyenBan.Click += new System.EventHandler(this.mnsChuyenBan_Click);
            // 
            // mnsGopBan
            // 
            this.mnsGopBan.Name = "mnsGopBan";
            this.mnsGopBan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.mnsGopBan.Size = new System.Drawing.Size(261, 26);
            this.mnsGopBan.Text = "Gộp bàn";
            this.mnsGopBan.Click += new System.EventHandler(this.mnsGopBan_Click);
            // 
            // mnsThanhToan
            // 
            this.mnsThanhToan.Name = "mnsThanhToan";
            this.mnsThanhToan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnsThanhToan.Size = new System.Drawing.Size(261, 26);
            this.mnsThanhToan.Text = "Thanh toán";
            this.mnsThanhToan.Click += new System.EventHandler(this.mnsThanhToan_Click);
            // 
            // mnsThoat
            // 
            this.mnsThoat.Name = "mnsThoat";
            this.mnsThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnsThoat.Size = new System.Drawing.Size(261, 26);
            this.mnsThoat.Text = "Thoát";
            this.mnsThoat.Click += new System.EventHandler(this.mnsThoat_Click);
            // 
            // mnsTaiKhoan
            // 
            this.mnsTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsTKThongTinTaiKhoan,
            this.mnsDoiMatKhau,
            this.mnsLogOut});
            this.mnsTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.mnsTaiKhoan.Name = "mnsTaiKhoan";
            this.mnsTaiKhoan.Size = new System.Drawing.Size(85, 26);
            this.mnsTaiKhoan.Text = "Tài khoản";
            // 
            // mnsTKThongTinTaiKhoan
            // 
            this.mnsTKThongTinTaiKhoan.Name = "mnsTKThongTinTaiKhoan";
            this.mnsTKThongTinTaiKhoan.Size = new System.Drawing.Size(220, 26);
            this.mnsTKThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.mnsTKThongTinTaiKhoan.Click += new System.EventHandler(this.mnsTKThongTinTaiKhoan_Click);
            // 
            // mnsDoiMatKhau
            // 
            this.mnsDoiMatKhau.Name = "mnsDoiMatKhau";
            this.mnsDoiMatKhau.Size = new System.Drawing.Size(220, 26);
            this.mnsDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnsDoiMatKhau.Click += new System.EventHandler(this.mnsDoiMatKhau_Click);
            // 
            // mnsLogOut
            // 
            this.mnsLogOut.Name = "mnsLogOut";
            this.mnsLogOut.Size = new System.Drawing.Size(220, 26);
            this.mnsLogOut.Text = "Đăng xuất";
            this.mnsLogOut.Click += new System.EventHandler(this.mnsLogOut_Click);
            // 
            // mnsThongKe
            // 
            this.mnsThongKe.ForeColor = System.Drawing.Color.Black;
            this.mnsThongKe.Name = "mnsThongKe";
            this.mnsThongKe.Size = new System.Drawing.Size(84, 26);
            this.mnsThongKe.Text = "Thống kê";
            this.mnsThongKe.Click += new System.EventHandler(this.mnsThongKe_Click);
            // 
            // mnsQuanLyBaoTri
            // 
            this.mnsQuanLyBaoTri.ForeColor = System.Drawing.Color.Black;
            this.mnsQuanLyBaoTri.Name = "mnsQuanLyBaoTri";
            this.mnsQuanLyBaoTri.Size = new System.Drawing.Size(121, 26);
            this.mnsQuanLyBaoTri.Text = "Quản lý bảo trì";
            this.mnsQuanLyBaoTri.Click += new System.EventHandler(this.mnsQuanLyBaoTri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 46);
            this.label1.TabIndex = 35;
            this.label1.Text = "RESTAURENT  MANAGEMENT";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.MinhHoaNhaHang;
            this.picLogo.Location = new System.Drawing.Point(1098, 46);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(82, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 27;
            this.picLogo.TabStop = false;
            // 
            // fManHinhChinh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1198, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpCapNhatGoiMon);
            this.Controls.Add(this.grpCapNhatBan);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpDanhSachBan);
            this.Controls.Add(this.grpPhieuGoiMon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "fManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.nudDisCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).EndInit();
            this.cmsXoaHD.ResumeLayout(false);
            this.grpPhieuGoiMon.ResumeLayout(false);
            this.grpDanhSachBan.ResumeLayout(false);
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.grpCapNhatGoiMon.ResumeLayout(false);
            this.grpCapNhatGoiMon.PerformLayout();
            this.grpCapNhatBan.ResumeLayout(false);
            this.grpCapNhatBan.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.NumericUpDown nudDisCount;
        private System.Windows.Forms.NumericUpDown nudFoodCount;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cboSwitchTable;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.ComboBox cboCategoryFood;
        private System.Windows.Forms.ListView lvwBill;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.Label lblGiamgia;
        private System.Windows.Forms.Label lblChonBan;
        private System.Windows.Forms.Button btnGopBan;
        private System.Windows.Forms.GroupBox grpPhieuGoiMon;
        private System.Windows.Forms.GroupBox grpDanhSachBan;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblLoaiMon;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.GroupBox grpCapNhatGoiMon;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.GroupBox grpCapNhatBan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnsTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsTKThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnsThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Button btnCapNhatKhuyenMai;
        private System.Windows.Forms.Button btnCapNhatSoLuong;
        private System.Windows.Forms.ContextMenuStrip cmsXoaHD;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyBaoTri;
        private System.Windows.Forms.ToolStripMenuItem mnsDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnsThemMon;
        private System.Windows.Forms.ToolStripMenuItem mnsCapNhatSoLuong;
        private System.Windows.Forms.ToolStripMenuItem mnsChuyenBan;
        private System.Windows.Forms.ToolStripMenuItem mnsGopBan;
        private System.Windows.Forms.ToolStripMenuItem mnsThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnsThoat;
    }
}