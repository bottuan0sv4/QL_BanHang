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

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            if (themmoi)
            {
                ncc.mancc = txt_MaNCC.Text;
                ncc.tenncc = txt_TenNCC.Text;
                ncc.diachi = txt_DiaChi.Text;
                ncc.sdt = txt_SDT.Text;
                db.NCCs.InsertOnSubmit(ncc);
                db.SubmitChanges();
                frmNhaCC_Load(sender, e);
                this.DialogResult = DialogResult.Cancel;
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

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
