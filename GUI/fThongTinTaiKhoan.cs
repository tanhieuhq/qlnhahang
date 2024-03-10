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

namespace GUI
{
    public partial class fThongTinTaiKhoan : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fThongTinTaiKhoan(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            HienThi();
        }


        void HienThi()
        {
            txtTenTaiKhoan.Text = loginAccount.UserName;
            txtHoTen.Text = loginAccount.DisplayName;
            txtDiaChi.Text = loginAccount.Address;
            txtSDT.Text = loginAccount.PhoneNumber;
        }

        private void btnCapNhatTTTK_Click(object sender, EventArgs e)
        {
            int id = loginAccount.Id;
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string sDT = txtSDT.Text;
            string password = txtMatKhauCNTT.Text;
            bool result = AccountBLL.Instance.CapNhatThongTinTK(id, hoTen, diaChi, sDT, password);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công");
                updateAcc(this, new AccountUpdate(AccountBLL.Instance.LayTaiKhoanTheoID(id)));
                //testAcc(AccountBLL.Instance.LayTaiKhoanTheoID(id));
            }
            else
                MessageBox.Show("Cập nhật thất bại\nThử kiểm tra lại mật khẩu");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số");
                e.Handled = true;
            }
        }


        //public delegate void test(Account account);
        //public test testAcc;

        private event EventHandler<AccountUpdate> updateAcc;
        public event EventHandler<AccountUpdate> UpdateAcc
        {
            add { updateAcc += value; }
            remove { updateAcc -= value; } 
        }
    }

    public class AccountUpdate : EventArgs
    {
        public Account Acc { get; set; }
        public AccountUpdate(Account account)
        {
            Acc = account;
        }
    }
}
