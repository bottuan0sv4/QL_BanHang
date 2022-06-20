using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class frmLogin : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();

        public frmLogin()
        {
            InitializeComponent();
        }

        bool kTraDangNhap(string username, string password)
        {
            var login = from p in db.TaiKhoans
                        select p;
            foreach(var tk in login)
            {
                if (txt_Username.Text == tk.username && txt_Password.Text == tk.password)
                {
                    return true;
                }
            }
            return false;
        }

        private void bt_Dangnhap_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            if(kTraDangNhap(txt_Username.Text, txt_Password.Text))
            {
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai Tên đăng nhập hoặc Mật khẩu", "Error");
                txt_Username.Focus();
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            
        }
    }
}
