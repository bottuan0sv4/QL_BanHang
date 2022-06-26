using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class frmCapNhatNCC : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        NCC ncc = new NCC();

        public bool themmoi { get; set; }
        public bool xoa { get; set; }
        public NCC nhacc { get; set; }

        public frmCapNhatNCC()
        {
            InitializeComponent();
        }

        private void frmCapNhatNCC_Load(object sender, EventArgs e)
        {
            if (themmoi)
            {

            }
            else
            {
                txt_MaNCC.Text = nhacc.mancc;
                txt_TenNCC.Text = nhacc.tenncc;
                txt_DiaChi.Text = nhacc.diachi;
                txt_SDT.Text = nhacc.sdt;
            }
        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {

        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {

                if (themmoi)
                {
                    ncc.mancc = txt_MaNCC.Text;
                    ncc.tenncc = txt_TenNCC.Text;
                    ncc.diachi = txt_DiaChi.Text;
                    ncc.sdt = txt_SDT.Text;
                if (string.IsNullOrEmpty(ncc.mancc)) {
                    MessageBox.Show("Hãy nhập dữ liệu!","Error");
                }
                else
                {
                    db.NCCs.InsertOnSubmit(ncc);
                    db.SubmitChanges();
                    frmNhaCC_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;
                }
                }
                else
                {
                    if (xoa)
                    {
                        ncc = db.NCCs.Where(s => s.mancc == txt_MaNCC.Text).FirstOrDefault();
                        ncc.tenncc = txt_TenNCC.Text;
                        ncc.diachi = txt_DiaChi.Text;
                        ncc.sdt = txt_SDT.Text;
                        db.NCCs.DeleteOnSubmit(ncc);
                        db.SubmitChanges();
                        frmNhaCC_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        ncc = db.NCCs.Where(s => s.mancc == txt_MaNCC.Text).FirstOrDefault();
                        ncc.tenncc = txt_TenNCC.Text;
                        ncc.diachi = txt_DiaChi.Text;
                        ncc.sdt = txt_SDT.Text;
                        db.SubmitChanges();
                        frmNhaCC_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
               
        }

        private void frmCapNhatNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }
    }
}
