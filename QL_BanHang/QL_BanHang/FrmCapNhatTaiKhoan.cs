using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class FrmCapNhatTaiKhoan : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        TaiKhoan tk = new TaiKhoan();

        public bool Themmoi { get; set; }
        public bool Xoa { get; set; }
        public TaiKhoan taiKhoan { get; set; }



        public FrmCapNhatTaiKhoan()
        {
            InitializeComponent();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Themmoi)
                {
                    tk.username = txt_Username.Text;
                    tk.password = txt_Pass.Text;
                    tk.hoten = txt_HoTen.Text;
                    tk.ngaysinh = date_NgaySinh.DateTime;
                    tk.diachi = txtDiaChi.Text;
                    tk.sdt = txtSDT.Text;
                    tk.gioitinh = txt_GioiTinh.Text;

                    db.TaiKhoans.InsertOnSubmit(tk);
                    db.SubmitChanges();
                    FrmTaiKhoan_Load(sender, e);

                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    if (Xoa)
                    {
                        tk = db.TaiKhoans.Where(s => s.username == txt_Username.Text).FirstOrDefault();
                        tk.password = txt_Pass.Text;
                        tk.hoten = txt_HoTen.Text;
                        tk.ngaysinh = date_NgaySinh.DateTime;
                        tk.diachi = txtDiaChi.Text;
                        tk.sdt = txtSDT.Text;
                        tk.gioitinh = txt_GioiTinh.Text;
                        db.TaiKhoans.DeleteOnSubmit(tk);
                        db.SubmitChanges();
                        FrmTaiKhoan_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        tk = db.TaiKhoans.Where(s => s.username == txt_Username.Text).FirstOrDefault();
                        tk.password = txt_Pass.Text;
                        tk.hoten = txt_HoTen.Text;
                        tk.ngaysinh = date_NgaySinh.DateTime;
                        tk.diachi = txtDiaChi.Text;
                        tk.sdt = txtSDT.Text;
                        tk.gioitinh = txt_GioiTinh.Text;
                        db.SubmitChanges();
                        FrmTaiKhoan_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xin hãy nhập dữ liệu!", "Error");
            }
            
            
        }

        private void FrmCapNhatTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Themmoi)
            {

            }else
            {
                txt_Username.Text = taiKhoan.username;
                txt_Pass.Text = taiKhoan.password;
                txt_HoTen.Text = taiKhoan.hoten;
                txtDiaChi.Text = taiKhoan.diachi;
                txtSDT.Text = taiKhoan.sdt;
                date_NgaySinh.DateTime = (DateTime)taiKhoan.ngaysinh;
                txt_GioiTinh.Text = taiKhoan.gioitinh;

            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(txtSDT.Text, out n))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Successful!";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Error! Vui lòng nhập số!";
            }
        }
    }
}
