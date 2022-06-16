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
    public partial class frmCapNhatKho : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        Kho k = new Kho();
        public bool Themmoi { get; set; }

        public bool Xoa { get; set; }
        public Kho kho { get; set; }
        public frmCapNhatKho()
        {
            InitializeComponent();
        }

        private void frmCapNhatKho_Load(object sender, EventArgs e)
        {
            if (Themmoi)
            {

            }
            else
            {
                txt_MaKho.Text = kho.makho;
                txt_TenKho.Text = kho.tenkho;
            }
        }

        private void frmKho_Load(object sender, EventArgs e)
        {

        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            if (Themmoi)
            {
                k.makho = txt_MaKho.Text;
                k.tenkho = txt_TenKho.Text;

                db.Khos.InsertOnSubmit(k);
                db.SubmitChanges();
                frmKho_Load(sender, e);

                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                if (Xoa)
                {
                    k = db.Khos.Where(s => s.makho == txt_MaKho.Text).FirstOrDefault();
                    k.tenkho = txt_TenKho.Text;
                    db.Khos.DeleteOnSubmit(k);
                    db.SubmitChanges();
                    frmKho_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    k = db.Khos.Where(s => s.makho == txt_MaKho.Text).FirstOrDefault();
                    k.tenkho = txt_TenKho.Text;
                    db.SubmitChanges();
                    frmKho_Load(sender, e);
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
