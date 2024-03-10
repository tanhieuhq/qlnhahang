using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class fQuanLyBaoTri : Form
    {

        public delegate void delegateDSBan();
        public delegateDSBan dDSBan;
        public Account loginAccount;

        BindingSource bindingSourceMon = new BindingSource();
        BindingSource bingdingTaiKhoan = new BindingSource();
        BindingSource bindingBAN = new BindingSource();
        BindingSource bindingLoaiMon = new BindingSource();
        public fQuanLyBaoTri()
        {
            InitializeComponent();
            LoadTabFood();
            LoadTabTaiKhoan();
            LoadBan();
            LoadTabLoaiMon();
            dgvTaiKhoan.Columns[0].Width = 50;
            dgvTaiKhoan.Columns[2].Width = 125;
        }

        #region Tab Mon
        void LoadTabFood()
        {
            DanhSachMon();
            DSLoaiMon();
            BindingsFood();
        }
        void DSLoaiMon()
        {
            cboCategoryFood.DataSource = CategoryFoodBLL.Instance.LayDSLoaiMon();
            cboCategoryFood.DisplayMember = "Name";
        }
        void DanhSachMon()
        {
            bindingSourceMon.DataSource = FoodBLL.Instance.DanhSachMon();
            dgvFood.DataSource = bindingSourceMon;
        }
        void BindingsFood()
        {
            txtIDFood.DataBindings.Add(new Binding("text", dgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtFoodName.DataBindings.Add(new Binding("text", dgvFood.DataSource, "TenMon", true, DataSourceUpdateMode.Never));
            txtPriceFood.DataBindings.Add(new Binding("text", dgvFood.DataSource, "Gia", true, DataSourceUpdateMode.Never));
            cboCategoryFood.DataBindings.Add(new Binding("text", dgvFood.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DanhSachMon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "" || txtPriceFood.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tên món, giá món");
            }
            else
            {
                string tenMon = txtFoodName.Text;
                float gia = (float)Convert.ToDouble(txtPriceFood.Text);
                int idLoaiMon = (cboCategoryFood.SelectedItem as CategoryFood).ID;
                bool result = FoodBLL.Instance.ThemMon(tenMon, gia, idLoaiMon);
                if (result)
                {
                    MessageBox.Show("Thêm món thành công");
                    DanhSachMon();
                }
                else
                {
                    MessageBox.Show("Thêm món thất bại");
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "" || txtPriceFood.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tên món, giá món");
            }
            else
            {
                int idMon = Convert.ToInt32(txtIDFood.Text);
                string tenMon = txtFoodName.Text;
                float gia = (float)Convert.ToDouble(txtPriceFood.Text);
                int idLoaiMon = (cboCategoryFood.SelectedItem as CategoryFood).ID;
                bool result = FoodBLL.Instance.SuaMon(tenMon, gia, idLoaiMon, idMon);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    DanhSachMon();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idMon = Convert.ToInt32(txtIDFood.Text);
            bool result = FoodBLL.Instance.XoaMon(idMon);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                DanhSachMon();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnTimMon_Click(object sender, EventArgs e)
        {
            DataTable data = FoodBLL.Instance.TimKiemMon(txtTimKiemMon.Text);
            if (data.Rows.Count < 1)
                MessageBox.Show("Không có món cần tìm");
            else
                bindingSourceMon.DataSource = data;
        }

        private void txtTimKiemMon_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemMon.Text == "Tên món")
            {
                txtTimKiemMon.Text = "";
                txtTimKiemMon.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemMon_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemMon.Text == "")
            {
                txtTimKiemMon.Text = "Tên món";
                txtTimKiemMon.ForeColor = Color.Silver;
            }
        }
        #endregion

        #region Loai Mon
        public delegate void delegateLoaiMon();
        public delegateLoaiMon delegateLMon;
        void LoadTabLoaiMon()
        {
            DanhSachLoaiMon();
            BindingLoaiMon();
        }

        void BindingLoaiMon()
        {
            txtIDLoaiMon.DataBindings.Add(new Binding("text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenLoaiMon.DataBindings.Add(new Binding("text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void DanhSachLoaiMon()
        {
            bindingLoaiMon.DataSource = CategoryFoodBLL.Instance.LayDSLoaiMon();
            dgvCategory.DataSource = bindingLoaiMon;
        }

        private void btnXemLoaiMon_Click(object sender, EventArgs e)
        {
            bindingLoaiMon.DataSource = CategoryFoodBLL.Instance.LayDSLoaiMon();
            dgvCategory.DataSource = bindingLoaiMon;
        }

        private void btnThemLoaiMon_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiMon.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tên loại món");
            }
            else
            {
                bool kq = CategoryFoodBLL.Instance.TonTaiTenLoaiMon(txtTenLoaiMon.Text);
                if (kq)
                {
                    MessageBox.Show("Tên loại món đã tồn tại");
                }
                else
                {
                    bool result = CategoryFoodBLL.Instance.ThemLoaiMon(txtTenLoaiMon.Text);
                    if (result)
                    {
                        MessageBox.Show("Thêm loại món thành công");
                        DanhSachLoaiMon();
                        delegateLMon();
                    }
                    else
                        MessageBox.Show("Thêm loại món thất bại");
                }
            }
        }

        private void btnSuaLoaiMon_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiMon.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tên loại món");
            }
            else
            {
                bool kq = CategoryFoodBLL.Instance.TonTaiTenLoaiMon(txtTenLoaiMon.Text);
                if (kq)
                {
                    MessageBox.Show("Tên loại món đã tồn tại");
                }
                else
                {
                    int idLoaiMon = Convert.ToInt32(txtIDLoaiMon.Text);
                    bool result = CategoryFoodBLL.Instance.SuaLoaiMon(idLoaiMon, txtTenLoaiMon.Text);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật loại món thành công");
                        DanhSachLoaiMon();
                        delegateLMon();
                    }
                    else
                        MessageBox.Show("Cập nhật loại món thất bại");
                }

            }
        }

        private void btnXoaLoaiMon_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận xóa loại món", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                int idLoaiMon = Convert.ToInt32(txtIDLoaiMon.Text);
                bool result = CategoryFoodBLL.Instance.XoaLoaiMon(idLoaiMon);
                if (result)
                {
                    DanhSachLoaiMon();
                    delegateLMon();
                }
                    
                else
                    MessageBox.Show("Xóa loại món thất bại");
            }
        }

        private void btnTKLoaiMon_Click(object sender, EventArgs e)
        {
            List<CategoryFood> data = CategoryFoodBLL.Instance.TimKiemLoaiMon(txtTimLoaiMon.Text);
            if (data.Count < 1)
                MessageBox.Show("Không có loại món cần tìm");
            else
                bindingLoaiMon.DataSource = data;
        }

        private void txtTimLoaiMon_Enter(object sender, EventArgs e)
        {
            if (txtTimLoaiMon.Text == "Tên loại")
            {
                txtTimLoaiMon.Text = "";
                txtTimLoaiMon.ForeColor = Color.Black;
            }
        }

        private void txtTimLoaiMon_Leave(object sender, EventArgs e)
        {
            if (txtTimLoaiMon.Text == "")
            {
                txtTimLoaiMon.Text = "Tên loại";
                txtTimLoaiMon.ForeColor = Color.Silver;
            }
        }

        #endregion

        #region Tab Tai Khoan
        void LoadTabTaiKhoan()
        {
            DSTaiKhoan();
            DSLoaiTaiKhoan();
            BindingsTaiKhoan();
        }

        void DSTaiKhoan()
        {
            bingdingTaiKhoan.DataSource = AccountBLL.Instance.DSTaiKhoan();
            dgvTaiKhoan.DataSource = bingdingTaiKhoan;
            dgvTaiKhoan.Columns[5].Visible = false;
        }

        void DSLoaiTaiKhoan()
        {
            cboLoaiTaiKhoan.DataSource = AccountCategoryBLL.Instance.DSLoaiTaiKhoan();
            cboLoaiTaiKhoan.DisplayMember = "TenLoaiTK";
        }

        void BindingsTaiKhoan()
        {
            txtMaTaiKhoan.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTaiKhoan.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "TenTaiKhoan", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            cboLoaiTaiKhoan.DataBindings.Add(new Binding("text", dgvTaiKhoan.DataSource, "TenLoaiTK", true, DataSourceUpdateMode.Never));
        }


        private void btnXemTK_Click(object sender, EventArgs e)
        {
            bingdingTaiKhoan.DataSource = AccountBLL.Instance.DSTaiKhoan();
            dgvTaiKhoan.DataSource = bingdingTaiKhoan;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtTenHienThi.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tài khoản, họ tên");
            }
            else
            {
                bool result = AccountBLL.Instance.LayTenTaiKhoan(txtTaiKhoan.Text);
                if (result)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                }
                else
                {
                    string tenTK = txtTaiKhoan.Text;
                    string tenHienThi = txtTenHienThi.Text;
                    string diaChi = txtDiaChi.Text;
                    string SDT = txtSDT.Text;
                    int loaiTK = 0;
                    if ((cboLoaiTaiKhoan.Text).Equals("Quản lý"))
                        loaiTK = 1;
                    bool kq = AccountBLL.Instance.ThemTaiKhoan(tenTK, tenHienThi, diaChi, SDT, loaiTK);
                    if (kq)
                    {
                        MessageBox.Show("Thêm tài khoản thành công");
                        DSTaiKhoan();
                    }
                    else
                        MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tài khoản");
            }
            else
            {
                    int maTK = Convert.ToInt32(txtMaTaiKhoan.Text);
                    string tenTK = txtTaiKhoan.Text;
                    int loaiTK = 0;
                    if ((cboLoaiTaiKhoan.Text).Equals("Quản lý"))
                        loaiTK = 1;
                    bool kq = AccountBLL.Instance.SuaTaiKhoan(tenTK, loaiTK, maTK);
                    if (kq)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công");
                        DSTaiKhoan();
                        
                    }
                    else
                        MessageBox.Show("Cập nhật tài khoản thất bại");
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            int idTK = Convert.ToInt32(txtMaTaiKhoan.Text);
            if (this.loginAccount.Id==idTK)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa tài khoản") == System.Windows.Forms.DialogResult.OK)
            {
                int maTK = Convert.ToInt32(txtMaTaiKhoan.Text);
                bool result = AccountBLL.Instance.XoaTaiKhoan(maTK);
                if (result)
                    DSTaiKhoan();
                else
                    MessageBox.Show("Xóa tài khoản thất bại");

            }
        }

        private void btnCapNhatThongTinCaNhan_Click(object sender, EventArgs e)
        {
            int maTK = Convert.ToInt32(txtMaTaiKhoan.Text);
            string hoten = txtTenHienThi.Text;
            string diaChi = txtDiaChi.Text;
            string SDT = txtSDT.Text;
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống họ tên");
            }
            else
            {
                bool result = AccountBLL.Instance.SuaTTCaNhan(maTK, hoten, diaChi, SDT);
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    DSTaiKhoan();
                    if (loginAccount.Id == maTK)
                    {
                        if (doiHoTen != null)
                            doiHoTen(this, new CDoiHoTen(AccountBLL.Instance.LayTaiKhoanTheoID(maTK)));
                    }
                }
                else
                    MessageBox.Show("Cập nhật thông tin thất bại");
            }
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            int maTK = Convert.ToInt32(txtMaTaiKhoan.Text);
            bool result = AccountBLL.Instance.DatLaiMatKhau(maTK);
            if (result)
                MessageBox.Show("Đặt lại mật khẩu thành công");
            else
                MessageBox.Show("Đặt lại tài khoản thất bại");
        }

        private void btnTimTK_Click(object sender, EventArgs e)
        {
            DataTable data = AccountBLL.Instance.TimKiemTaiKhoan(txtTimKiemTK.Text);
            if (data.Rows.Count < 1)
                MessageBox.Show("Không có tài khoản cần tìm");
            else
                bingdingTaiKhoan.DataSource = data;
        }

        private void txtTimKiemTK_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemTK.Text == "")
            {
                txtTimKiemTK.Text = "Họ tên";
                txtTimKiemTK.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiemTK_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemTK.Text == "Họ tên")
            {
                txtTimKiemTK.Text = "";
                txtTimKiemTK.ForeColor = Color.Black;
            }
        }

        #endregion

        #region Tab Ban
        void LoadBan()
        {
            DanhSachBan();
            BingdingsBan();
        }

        void BingdingsBan()
        {
            txtIDTable.DataBindings.Add(new Binding("text", dgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTableName.DataBindings.Add(new Binding("text", dgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            cboTinhTrangBan.DataBindings.Add(new Binding("text", dgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        void DanhSachBan()
        {
            bindingBAN.DataSource = TableBLL.Instance.LayDanhSachBan();
            dgvTable.DataSource = bindingBAN;
        }
        private void btnXemBan_Click(object sender, EventArgs e)
        {
            List<Table> list = TableBLL.Instance.LayDanhSachBan();
            dgvTable.DataSource = bindingBAN;
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tên bàn");
            }
            else
            {
                bool result = TableBLL.Instance.ThemBan(txtTableName.Text);
                if (result)
                {
                    MessageBox.Show("Thêm bàn thành công");
                    DanhSachBan();
                    dDSBan();
                }
                else
                    MessageBox.Show("Thêm bàn thất bại");
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tên bàn");
            }
            else
            {
                int idBan = Convert.ToInt32(txtIDTable.Text);
                bool result = TableBLL.Instance.SuaBan(txtTableName.Text,cboTinhTrangBan.Text,idBan);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    DanhSachBan();
                    dDSBan();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Xác nhận xóa",
                                             "Thông báo",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                int idBan = Convert.ToInt32(txtIDTable.Text);
                bool result = TableBLL.Instance.XoaBan(idBan);
                if (result)
                {
                    MessageBox.Show("Xóa bàn thành công");
                    DanhSachBan();
                    dDSBan();
                }
                else
                    MessageBox.Show("Xóa bàn thất bại");
            }
        }

        private void btnTimBan_Click(object sender, EventArgs e)
        {
            List<Table> data = TableBLL.Instance.TimKiemBan(txtTimBan.Text);
            if (data.Count<1)
                MessageBox.Show("Không có bàn cần tìm");
            else
                bindingBAN.DataSource = data;
        }

        private void txtTimBan_Enter(object sender, EventArgs e)
        {
            if(txtTimBan.Text=="Tên bàn")
            {
                txtTimBan.Text = "";
                txtTimBan.ForeColor = Color.Black;
            }
        }

        private void txtTimBan_Leave(object sender, EventArgs e)
        {
            if (txtTimBan.Text == "")
            {
                txtTimBan.Text = "Tên bàn";
                txtTimBan.ForeColor = Color.Silver;
            }
        }

        #endregion

        #region Event doi ho ten
        private event EventHandler<CDoiHoTen> doiHoTen;
        public event EventHandler<CDoiHoTen> DoiHoTen
        {
            add { doiHoTen += value; }
            remove{ doiHoTen -= value; }
        }
        #endregion

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số");
                e.Handled = true;
            }
        }
    }

    public class CDoiHoTen:EventArgs
    {
        public Account EventAccount { get; set; }
        public CDoiHoTen(Account acc)
        {
            EventAccount = acc;
        }
    }
}
