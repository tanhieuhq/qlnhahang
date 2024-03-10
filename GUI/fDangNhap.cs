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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống tài khoản, mật khẩu!");
                return;
            }
            else
            {
                string mahoa = BaoMat.Instance.MaHoaMatKhau(password);
                Account account = AccountBLL.Instance.DangNhap(username, mahoa);
                if (account == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    
                }
                else if(password.Equals("12345@Abc"))
                {
                    MessageBox.Show("Vui lòng đổi mật khẩu cho lần đầu đăng nhập");
                    fDoiMatKhau f = new fDoiMatKhau(account);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fManHinhChinh f = new fManHinhChinh(account);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            
        }
 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
