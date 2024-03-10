using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Reports;

namespace GUI
{
    public partial class fThongKeHoaDon : Form
    {
        int idHD=0;
        int lastPage;
        public Account loginAccount;
        public fThongKeHoaDon(Account account)
        {
            InitializeComponent();
            loginAccount = account;
            if (loginAccount.Type == 0)
                btnInThongKe.Visible = false;
            DatNgayThang();
            TrangCuoi();
            ThongKeHD(dtpFromDate.Value, dtpToDate.Value);
            DinhDangCot();
        }

        void DinhDangCot()
        {
            dgvBillThongKe.Columns[0].Width = 88;
            dgvBillThongKe.Columns[1].Width = 118;
            dgvBillThongKe.Columns[2].Width = 70;
            dgvBillThongKe.Columns[3].Width = 90;
            dgvBillThongKe.Columns[4].Width = 120;
            dgvBillThongKe.Columns[5].Width = 90;
            dgvBillThongKe.Columns[6].Width = 105;


            
        }
        #region DatNgayThang
        void DatNgayThang()
        {
            DateTime d = DateTime.Now;
            dtpFromDate.Value = new DateTime(d.Year, d.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        #endregion

        #region ThongKeHoaDon
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            TrangCuoi();
            txtNumPage.Text = "1";
            if (loginAccount.Type == 1)
            {
                dgvBillThongKe.DataSource = BillBLL.Instance.HoaDonTheoNgayVaTrang(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txtNumPage.Text));
            }
            else
            {
                dgvBillThongKe.DataSource = BillBLL.Instance.HoaDonTheoNgayVaTrangTK(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txtNumPage.Text), loginAccount.Id);
            }
        }
        void ThongKeHD(DateTime ngayTao, DateTime ngayThanhToan)
        {
            if (loginAccount.Type == 1)
            {
                dgvBillThongKe.DataSource = BillBLL.Instance.HoaDonTheoNgayVaTrang(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txtNumPage.Text));
            }
            else
            {
                dgvBillThongKe.DataSource = BillBLL.Instance.HoaDonTheoNgayVaTrangTK(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txtNumPage.Text),loginAccount.Id);
            }
            
        }
        private void dgvBillThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBillThongKe.CurrentRow;
            idHD = (int)row.Cells["SoHoaDon"].Value;
            dgvThongKeChiTiet.DataSource = BillBLL.Instance.CTHDTheoHD(idHD);

            dgvThongKeChiTiet.Columns[0].Width = 120;
            dgvThongKeChiTiet.Columns[1].Width = 70;
            dgvThongKeChiTiet.Columns[2].Width = 70;
        }
        #endregion

        #region Phan Trang

        void TrangCuoi()
        {
            int sumPage = BillBLL.Instance.SoLuongHoaDonTheoNgay(dtpFromDate.Value, dtpToDate.Value);
            lastPage = sumPage / 14;
            if (sumPage % 14 != 0)
                lastPage++;
        }
        private void btnTrangDau_Click(object sender, EventArgs e)
        {
            txtNumPage.Text = "1";
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int numPage = Convert.ToInt32(txtNumPage.Text);
            if (numPage > 1)
                numPage--;
            txtNumPage.Text = numPage.ToString();
        }

        private void txtNumPage_TextChanged(object sender, EventArgs e)
        {
            if (loginAccount.Type == 1)
            {
                dgvBillThongKe.DataSource = BillBLL.Instance.HoaDonTheoNgayVaTrang(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txtNumPage.Text));
            }
            else
            {
                dgvBillThongKe.DataSource = BillBLL.Instance.HoaDonTheoNgayVaTrangTK(dtpFromDate.Value, dtpToDate.Value, Convert.ToInt32(txtNumPage.Text), loginAccount.Id);
            }
        }

        private void btnKeTiep_Click(object sender, EventArgs e)
        {
            int numPage = Convert.ToInt32(txtNumPage.Text);
            if (numPage < lastPage)
                numPage++;
            txtNumPage.Text = numPage.ToString();
        }

        private void btnTrangCuoi_Click(object sender, EventArgs e)
        {
            txtNumPage.Text = lastPage.ToString();
        }

        #endregion


        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            FInThongkeHoaDon f = new FInThongkeHoaDon();
            f.tuNgay = dtpFromDate.Value;
            f.denNgay = dtpToDate.Value;
            f.Show();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (idHD == 0)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn");
            }
            else
            {
                fInHoaDon f = new fInHoaDon();
                f.idHD = idHD;
                f.ShowDialog();
            }
        }
    }
}
