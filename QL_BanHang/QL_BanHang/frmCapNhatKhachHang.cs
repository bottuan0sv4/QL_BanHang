using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class frmCapNhatKhachHang : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        KH kh = new KH();

        public bool them { get; set; }
        public bool xoa { get; set; }
        public KH khachHang { get; set; }
        public frmCapNhatKhachHang()
        {
            InitializeComponent();
        }

        public void frmKhachHang_Load(object sender, EventArgs e)
        {

        }



        private void frmCapNhatKhachHang_Load(object sender, EventArgs e)
        {

            if (them)
            {

            }
            else
            {
                txt_MaKH.Text = khachHang.makh;
                txt_TenKH.Text = khachHang.tenkh;
                txt_DiaChi.Text = khachHang.diachi;
                txt_GioiTinh.Text = khachHang.gioitinh;
                txt_MSThue.EditValue = khachHang.masothue;
                txt_SDT.Text = khachHang.sdt;
            }


        }
        private void bt_ClickHuy(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txt_MSThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '+' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_MSThue_TextChanged(object sender, EventArgs e)
        {
            /*double n;
            if (double.TryParse(txt_MSThue.Text,out n))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Successful!";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Error! Vui lòng nhập số!";
            }*/
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            /*long n;
            if (long.TryParse(txt_SDT.Text, out n))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Successful!";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Error! Vui lòng nhập số!";
            }*/
        }

        private void bt_ClickXacNhan(object sender, EventArgs e)
        {
 
                if (them)
                {
                    kh.makh = txt_MaKH.Text;
                    kh.tenkh = txt_TenKH.Text;
                    kh.diachi = txt_DiaChi.Text;
                    kh.sdt = txt_SDT.Text;
                    kh.gioitinh = txt_GioiTinh.Text;
                    kh.masothue = Convert.ToDouble(txt_MSThue.EditValue);
                if (string.IsNullOrEmpty(kh.makh))
                {
                    MessageBox.Show("Hãy nhập dữ liệu!", "Error");
                }
                else
                {
                    db.KHs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    frmKhachHang_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;
                }
                    
                }


                else
                {
                    if (xoa)
                    {
                        kh = db.KHs.Where(s => s.makh == txt_MaKH.Text).FirstOrDefault();
                        kh.tenkh = txt_TenKH.Text;
                        kh.diachi = txt_DiaChi.Text;
                        kh.sdt = txt_SDT.Text;
                        kh.gioitinh = txt_GioiTinh.Text;
                        kh.masothue = Convert.ToDouble(txt_MSThue.EditValue);
                        db.KHs.DeleteOnSubmit(kh);
                        db.SubmitChanges();
                        frmKhachHang_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        kh = db.KHs.Where(s => s.makh == txt_MaKH.Text).FirstOrDefault();
                        kh.tenkh = txt_TenKH.Text;
                        kh.diachi = txt_DiaChi.Text;
                        kh.sdt = txt_SDT.Text;
                        kh.gioitinh = txt_GioiTinh.Text;
                        kh.masothue = Convert.ToDouble(txt_MSThue.EditValue);
                        db.SubmitChanges();
                        frmKhachHang_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                
                
        }

        private void frmCapNhatKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }
    }
}
