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
    public partial class frmCapNhatSanPham : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        SanPham sp = new SanPham();

        public bool themmoi { get; set; }

        public bool xoa { get; set; }
        public SanPham sanPham { get; set; }
        public frmCapNhatSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

        }
        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (themmoi)
                {
                    sp.masp = txt_MaSP.Text;
                    sp.tensp = txt_TenSP.Text;
                    sp.donvi = txt_DonVi.Text;
                    sp.dongia = Convert.ToDouble(txt_DonGia.EditValue);
                    sp.ngaytao = date_NgayTao.DateTime;

                    db.SanPhams.InsertOnSubmit(sp);
                    db.SubmitChanges();
                    frmSanPham_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    if (xoa)
                    {
                        sp = db.SanPhams.Where(s => s.masp == txt_MaSP.Text).FirstOrDefault();
                        sp.tensp = txt_TenSP.Text;
                        sp.donvi = txt_DonVi.Text;
                        sp.dongia = Convert.ToDouble(txt_DonGia.EditValue);
                        sp.ngaytao = date_NgayTao.DateTime;

                        db.SanPhams.DeleteOnSubmit(sp);
                        db.SubmitChanges();
                        frmSanPham_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        sp = db.SanPhams.Where(s => s.masp == txt_MaSP.Text).FirstOrDefault();
                        sp.tensp = txt_TenSP.Text;
                        sp.donvi = txt_DonVi.Text;
                        sp.dongia = Convert.ToDouble(txt_DonGia.EditValue);
                        sp.ngaytao = date_NgayTao.DateTime;

                        db.SubmitChanges();
                        frmSanPham_Load(sender, e);
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xin hãy nhập dữ liệu!", "Error");
            }
            
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void frmCapNhatSanPham_Load(object sender, EventArgs e)
        {
            if (themmoi)
            {

            }
            else
            {
                txt_MaSP.Text = sanPham.masp;
                txt_TenSP.Text = sanPham.tensp;
                txt_DonVi.Text = sanPham.donvi;
                txt_DonGia.EditValue = sanPham.dongia;
                date_NgayTao.DateTime = (DateTime)sanPham.ngaytao;
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(txt_DonGia.Text, out n))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Successful!";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Error! Vui lòng nhập số";
            }
        }
    }
}
