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
    public partial class fDoiMatKhau : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fDoiMatKhau(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            txtTenDangNhap.Text = loginAccount.UserName;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            int id = loginAccount.Id;
            string matKhau = txtMatKhau.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string matKhauNhapLai = txtNhapLaiMatKhauMoi.Text;
            if (matKhau.Equals("") || matKhauMoi.Equals("")||matKhauNhapLai.Equals(""))
            {
                MessageBox.Show("Vui lòng không để trống mật khẩu");
                return;
            }
            if (!matKhauMoi.Equals(matKhauNhapLai))
            {
                MessageBox.Show("Mật khẩu mới không giống nhau");
                return;
            }

            if (BaoMat.Instance.KiemTraMatKhau(matKhauMoi)==false)
            {
                MessageBox.Show("Mật khẩu phải có đội dài tối thiểu 8 ký tự, có ít nhất 1 chữ số, chữ thường, in hoa,ký tự đặc biệt.");
            }
            else
            {
                string maHoaMK = BaoMat.Instance.MaHoaMatKhau(matKhau);
                string maHoaMKMoi = BaoMat.Instance.MaHoaMatKhau(matKhauMoi);
                bool result = AccountBLL.Instance.DoiMatKhauTK(id, maHoaMK, maHoaMKMoi);
                if (result)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                    MessageBox.Show("Đổi mật khẩu thất bại\nHãy chắc chắn mật khẩu cũ đúng");
            }    
        }
    }
}
