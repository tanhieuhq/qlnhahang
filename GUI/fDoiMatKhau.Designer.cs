
namespace GUI
{
    partial class fDoiMatKhau
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhauHienTai = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblCapNhatThongTinTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(335, 391);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 57);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(189, 391);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(122, 57);
            this.btnDoiMatKhau.TabIndex = 9;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(184, 168);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMatKhau.MaxLength = 15;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(268, 28);
            this.txtMatKhau.TabIndex = 4;
            // 
            // lblMatKhauHienTai
            // 
            this.lblMatKhauHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblMatKhauHienTai.Location = new System.Drawing.Point(16, 158);
            this.lblMatKhauHienTai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            this.lblMatKhauHienTai.Size = new System.Drawing.Size(108, 49);
            this.lblMatKhauHienTai.TabIndex = 3;
            this.lblMatKhauHienTai.Text = "Mật khẩu hiện tại:";
            this.lblMatKhauHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(184, 316);
            this.txtNhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNhapLaiMatKhauMoi.MaxLength = 15;
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.PasswordChar = '*';
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(268, 28);
            this.txtNhapLaiMatKhauMoi.TabIndex = 8;
            // 
            // lblNhapLaiMatKhauMoi
            // 
            this.lblNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLaiMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblNhapLaiMatKhauMoi.Location = new System.Drawing.Point(14, 303);
            this.lblNhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNhapLaiMatKhauMoi.Name = "lblNhapLaiMatKhauMoi";
            this.lblNhapLaiMatKhauMoi.Size = new System.Drawing.Size(110, 55);
            this.lblNhapLaiMatKhauMoi.TabIndex = 7;
            this.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu:";
            this.lblNhapLaiMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(184, 243);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMatKhauMoi.MaxLength = 15;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(268, 28);
            this.txtMatKhauMoi.TabIndex = 6;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(14, 245);
            this.lblMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(140, 24);
            this.lblMatKhauMoi.TabIndex = 5;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            this.lblMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(184, 86);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(268, 28);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(14, 88);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(160, 24);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            this.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCapNhatThongTinTaiKhoan
            // 
            this.lblCapNhatThongTinTaiKhoan.AutoSize = true;
            this.lblCapNhatThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatThongTinTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(173)))), ((int)(((byte)(60)))));
            this.lblCapNhatThongTinTaiKhoan.Location = new System.Drawing.Point(163, 19);
            this.lblCapNhatThongTinTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapNhatThongTinTaiKhoan.Name = "lblCapNhatThongTinTaiKhoan";
            this.lblCapNhatThongTinTaiKhoan.Size = new System.Drawing.Size(227, 32);
            this.lblCapNhatThongTinTaiKhoan.TabIndex = 0;
            this.lblCapNhatThongTinTaiKhoan.Text = "ĐỔI MẬT KHẨU";
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(487, 490);
            this.Controls.Add(this.lblCapNhatThongTinTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhauHienTai);
            this.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.Controls.Add(this.lblNhapLaiMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhauHienTai;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Label lblNhapLaiMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblCapNhatThongTinTaiKhoan;
    }
}