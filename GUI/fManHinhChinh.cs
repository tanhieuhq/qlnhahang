using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DTO;
using BLL;
using GUI.Reports;
namespace GUI
{
    public partial class fManHinhChinh : Form
    {
        float thanhTien;
        CultureInfo culture = new CultureInfo("vi-VN");
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set 
            { 
                loginAccount = value;
                if (loginAccount.Type != 1)
                {
                    mnsQuanLyBaoTri.Visible=false;
                }
            }
        }

        public fManHinhChinh(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            lblXinChao.Text = "Xin chào\n" + this.loginAccount.DisplayName;
            HienThiDanhSachBan();
            HienThiDSLoaiMon();
        }

        #region HienThiBan
        private void HienThiDanhSachBan()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableBLL.Instance.LayDanhSachBan();
            cboSwitchTable.DataSource = tableList;
            cboSwitchTable.DisplayMember = "Name";
            foreach (Table table in tableList)
            {
                ButtonTron btn = new ButtonTron()
                {
                    Width = 90,
                    Height = 90
                };
                //btn.TabStop = false;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.OnHoverBorderColor = Color.Silver;
                btn.OnHoverButtonColor = Color.FromArgb(246, 173, 60);
                btn.OnHoverTextColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.MouseDownBackColor = Color.SlateGray;
                btn.FlatAppearance.MouseOverBackColor = Color.SlateGray;
                btn.Text = table.Name + "\n" + table.Status;

                switch (table.Status)
                {
                    case "Có khách":
                        btn.BorderColor = Color.IndianRed;
                        btn.ButtonColor = Color.FromArgb(246, 173, 60);
                        btn.OnHoverBorderColor = Color.IndianRed;
                        break;
                    default:
                        btn.BorderColor = Color.Silver;
                        btn.ButtonColor = Color.SlateGray;
                        break;
                }
                btn.Tag = table;
                btn.Click += Btn_Click;
                flpTable.Controls.Add(btn);
            }
        }
        #endregion

        #region HienthiThongtinLenListView

        private void Btn_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table;
            picLogo.Tag = (sender as Button).Tag;
            HienThiHoaDonTrenListView(table.ID);
            CapNhatIDBanSoHD();
        }

        void HienThiHoaDonTrenListView(int idBan)
        {
            List<ThongTinTrenListView> dsCTHD = ThongTinTrenListViewBLL.Instance.LayHoaDonTheoBan(idBan);
            float totalPrice = 0;
            lvwBill.Items.Clear();
            foreach (ThongTinTrenListView item in dsCTHD)
            {
                ListViewItem lvi = new ListViewItem(item.FoodName.ToString());
                lvi.SubItems.Add(item.Count.ToString());
                lvi.SubItems.Add(item.Price.ToString());
                lvi.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvwBill.Items.Add(lvi);
                lvi.Tag = item;
            }
            thanhTien = totalPrice;
            txtTotalPrice.Text = thanhTien.ToString("c", culture);
            CapNhatIDBanSoHD();
        }
        #endregion

        #region HienThiCombobox LoaiMon va Mon
        void HienThiDSLoaiMon()
        {
            List<CategoryFood> list = CategoryFoodBLL.Instance.LayDSLoaiMon();
            cboCategoryFood.DataSource = list;
            cboCategoryFood.DisplayMember = "name";
        }
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            CategoryFood category = cb.SelectedItem as CategoryFood;
            int idCategoryFood = category.ID;
            HienThiDSMon(idCategoryFood);
        }

        void HienThiDSMon(int idLoaiMon)
        {
            List<Food> list = FoodBLL.Instance.DSMonTheoIDLoaiMon(idLoaiMon);
            cboFood.DataSource = list;
            cboFood.DisplayMember = "name";
        }



        #endregion

        #region Them mon

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = picLogo.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món");
                return;
            }

            int idTaiKhoan = loginAccount.Id;
            int idHoaDon = BillBLL.Instance.LayIDHoaDonTheoIDBan(table.ID);
            if (cboFood.SelectedItem == null)
            {
                MessageBox.Show("Món không tồn tại");
                return;
            }    
            Food food = cboFood.SelectedItem as Food;
            int SoLuong = (int)nudFoodCount.Value;

            if (idHoaDon == -1)
            {
                BillBLL.Instance.ThemHoaDon(table.ID, idTaiKhoan);
                if (MessageBox.Show("Thêm món " + food.Name + ", số lượng " + SoLuong.ToString() + ", " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int idHD = BillBLL.Instance.IdHoaDonLonNhat();
                    BillInfoBLL.Instance.ThemChiTietHoaDon(idHD, food.ID, SoLuong);
                }

            }
            else if (MessageBox.Show("Thêm món " + food.Name + ", số lượng " + SoLuong.ToString() + ", " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillInfoBLL.Instance.ThemChiTietHoaDon(idHoaDon, food.ID, SoLuong);
            }
            HienThiHoaDonTrenListView(table.ID);
            HienThiDanhSachBan();
        }
        #endregion

        #region Xoa mon
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (lvwBill.SelectedItems.Count > 0)
            {
                int idTable = (picLogo.Tag as Table).ID;
                ListViewItem lvi = lvwBill.SelectedItems[0];
                int idCTHoa = (lvi.Tag as ThongTinTrenListView).ID; //(lvwBill.Tag as ThongTinTrenListView).ID;//Convert.ToInt32(lvwBill.SelectedItems[0].SubItems[4].Text);
                int soLuong = (int)nudFoodCount.Value;
                if (MessageBox.Show(string.Format("Cập nhật {0}, số lượng {1}", (lvi.Tag as ThongTinTrenListView).FoodName, soLuong), "Thông báo,", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillInfoBLL.Instance.CapNhatPhieuGoiMon(idCTHoa, soLuong);
                    HienThiHoaDonTrenListView(idTable);
                    HienThiDanhSachBan();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món trước khi cập nhật số lượng");
            }
        }
        #endregion

        #region Thanh toan

        private void btnCapNhatKhuyenMai_Click(object sender, EventArgs e)
        {
            int KhuyenMai = (int)nudDisCount.Value;
            float finalTotalPrice = thanhTien - (thanhTien / 100) * KhuyenMai;
            txtTotalPrice.Text = finalTotalPrice.ToString("c", culture);
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = picLogo.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần thanh toán");
                return;
            }
            int idHoaDon = BillBLL.Instance.LayIDHoaDonTheoIDBan(table.ID);
            if (idHoaDon == -1)
            {
                MessageBox.Show("Bàn chưa có hóa đơn");
                return;
            }     
            int KhuyenMai = (int)nudDisCount.Value;
            float finalTotalPrice = thanhTien - (thanhTien / 100) * KhuyenMai;
            if (idHoaDon != -1)
            {
                DialogResult ret = MessageBox.Show(string.Format("Bạn có muốn thanh toán cho {0}\nTổng tiền: {1} VNĐ\nKhuyến mãi: {2}%\nSố tiền cần thanh toán: {3} VNĐ", table.Name, thanhTien.ToString("#,##0"), KhuyenMai, finalTotalPrice.ToString("#,##0")),
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question);
                if (ret==DialogResult.OK)
                {
                    BillBLL.Instance.ThanhToan(idHoaDon, KhuyenMai, finalTotalPrice);
                    HienThiHoaDonTrenListView(table.ID);
                    HienThiDanhSachBan();
                    DialogResult ret2= MessageBox.Show("Thanh toán thành công, bạn có muốn in hóa đơn không",
                                    "Thông báo",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (ret2 == DialogResult.Yes)
                    {
                        fInHoaDon f = new fInHoaDon();
                        f.idHD = idHoaDon;
                        f.ShowDialog();
                    }
                }
            }
            
        }

        
        #endregion

        #region Chuyen ban
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (picLogo.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển");
                return;
            }
            int idBan1 = (picLogo.Tag as Table).ID;
            int idBan2 = (cboSwitchTable.SelectedItem as Table).ID;
            if (idBan1 == idBan2)
            {
                MessageBox.Show("Vui lòng chọn 2 bàn khác nhau");
                return;
            }
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển {0} sang {1} không", (picLogo.Tag as Table).Name, (cboSwitchTable.SelectedItem as Table).Name), "Thông báo,", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableBLL.Instance.ChuyenBan(idBan1, idBan2);
                HienThiDanhSachBan();
                HienThiHoaDonTrenListView(idBan1);
            }
        }
        #endregion

        #region Gop ban
        private void btnGopBan_Click(object sender, EventArgs e)
        {
            int idBan1 = (picLogo.Tag as Table).ID;
            int idBan2 = (cboSwitchTable.SelectedItem as Table).ID;

            int idBill1 = BillBLL.Instance.LayIDHoaDonTheoIDBan(idBan1);
            int idBill2 = BillBLL.Instance.LayIDHoaDonTheoIDBan(idBan2);
            if (idBill1 == -1)
            {
                MessageBox.Show((picLogo.Tag as Table).Name + " chưa có hóa đơn");
                return;
            }
            if (idBill2 == -1)
            {
                MessageBox.Show((cboSwitchTable.SelectedItem as Table).Name + " chưa có hóa đơn");
                return;
            }

            if (MessageBox.Show(string.Format("Bạn có muốn gộp {0} sang {1} không", (picLogo.Tag as Table).Name, (cboSwitchTable.SelectedItem as Table).Name), "Thông báo,", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableBLL.Instance.GopBan(idBan1, idBan2);
                HienThiDanhSachBan();
                HienThiHoaDonTrenListView(idBan1);
            }

        }
        #endregion

        #region Xoa phieu goi mon
        private void cmsXoa_Click(object sender, EventArgs e)
        {
            int idBan = (picLogo.Tag as Table).ID;

            foreach (ListViewItem item in lvwBill.SelectedItems)
            {
                int idCTHD = (item.Tag as ThongTinTrenListView).ID;
                BillInfoBLL.Instance.XoaPhieuGoiMon(idCTHD);
                HienThiHoaDonTrenListView(idBan);
            }
            HienThiDanhSachBan();
        }

        #endregion

        #region Su kien nhan tren listview
        private void lvwBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwBill.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvwBill.SelectedItems[0];
                ThongTinTrenListView t = lvi.Tag as ThongTinTrenListView;
                cboCategoryFood.Text = t.TenLoaiMon;
                cboFood.Text = t.FoodName;
                nudFoodCount.Value = t.Count;
            }
        }
        #endregion

        #region Menustrip chuc nang
        private void mnsThemMon_Click(object sender, EventArgs e)
        {
            btnThemMon.PerformClick();
        }

        private void mnsCapNhatSoLuong_Click(object sender, EventArgs e)
        {
            btnCapNhatSoLuong.PerformClick();
        }

        private void mnsChuyenBan_Click(object sender, EventArgs e)
        {
            btnChuyenBan.PerformClick();
        }

        private void mnsGopBan_Click(object sender, EventArgs e)
        {
            btnGopBan.PerformClick();
        }

        private void mnsThanhToan_Click(object sender, EventArgs e)
        {
            btnThanhToan.PerformClick();
        }

        private void mnsThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menustrip Tai khoan
        private void mnsThongKe_Click(object sender, EventArgs e)
        {
            fThongKeHoaDon t = new fThongKeHoaDon(loginAccount);
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void mnsTKThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            fThongTinTaiKhoan f = new fThongTinTaiKhoan(loginAccount);
            //f.testAcc = new fThongTinTaiKhoan.test(doiten);
            f.UpdateAcc += F_UpdateAcc;
            f.ShowDialog();
        }

        private void F_UpdateAcc(object sender, AccountUpdate e)
        {
            lblXinChao.Text = "Xin chào\n" + e.Acc.DisplayName;
        }

        private void mnsLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(loginAccount);
            f.ShowDialog();
        }
        #endregion

        #region Menustrip Quan ly bao tri
        private void mnsQuanLyBaoTri_Click(object sender, EventArgs e)
        {
            int hoaDon = BillBLL.Instance.HoaDonChuaThanhToan();
            if (hoaDon != 0)
            {
                MessageBox.Show("Để sử dụng chức năng này tất cả các bàn đều phải trống");
            }
            else
            {
                fQuanLyBaoTri f = new fQuanLyBaoTri();
                f.delegateLMon = new fQuanLyBaoTri.delegateLoaiMon(HienThiDSLoaiMon);
                f.dDSBan = new fQuanLyBaoTri.delegateDSBan(HienThiDanhSachBan);
                f.loginAccount = loginAccount;
                f.DoiHoTen += F_DoiHoTen;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void F_DoiHoTen(object sender, CDoiHoTen e)
        {
            lblXinChao.Text = "Xin chào\n" + e.EventAccount.DisplayName;
        }
        #endregion

        #region Phuong thuc chung
        void CapNhatIDBanSoHD()
        {
            Table table = picLogo.Tag as Table;
            lblTenBan.Text = "Tên bàn: " + table.Name;
            int idHoaDon = BillBLL.Instance.LayIDHoaDonTheoIDBan(table.ID);
            if (idHoaDon == -1)
                lblSoHoaDon.Text = "Số hóa đơn: Chưa có";
            else
                lblSoHoaDon.Text = "Số hóa đơn: " + idHoaDon;
        }







        #endregion

        
    }
}
