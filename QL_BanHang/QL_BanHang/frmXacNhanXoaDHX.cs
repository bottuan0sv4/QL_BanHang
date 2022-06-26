using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QL_BanHang.Class;

namespace QL_BanHang
{
    public partial class frmXacNhanXoaDHX : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        HDXuat hdx = new HDXuat();
        CT_HDXuat ct_hdx = new CT_HDXuat();
        public clsHDXuat hdXuat { get; set; }
        public clsCTHDXuat cthdXuat { get; set; }

        List<clsCTHDXuat> lstchitiet = new List<clsCTHDXuat>();
        public frmXacNhanXoaDHX()
        {
            InitializeComponent();
        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_Xacnhan_Click(object sender, EventArgs e)
        {
            txt_SoPhieuXuat.Text = hdXuat.sophieuxuat;
            date_NgayTao.DateTime = hdXuat.ngaytao;
            cbMaKH.Text = hdXuat.makh;
            hdXuat.ID_KH = (from p in db.KHs
                          where cbMaKH.Text == p.makh
                          select p.ID_KH).FirstOrDefault();

            HDXuat hdxoa = (from c in db.HDXuats
                            where txt_SoPhieuXuat.Text == c.sophieuxuat
                            select c).FirstOrDefault();


            db.CT_HDXuats.DeleteAllOnSubmit(hdxoa.CT_HDXuats);

            db.HDXuats.DeleteOnSubmit(hdxoa);
            db.SubmitChanges();
            frmHoaDonXuat_Load(sender, e);
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmXacNhanXoaDHX_Load(object sender, EventArgs e)
        {
            
                db = new Linq_QL_BanHangDataContext();
                var list = from p in db.KHs select p;

                foreach (var kh in list)
                {
                    cbMaKH.Items.Add(kh.makh);
                }
                txt_SoPhieuXuat.Text = hdXuat.sophieuxuat;
                date_NgayTao.DateTime = hdXuat.ngaytao;
                cbMaKH.Text = hdXuat.makh;
            

        }

        private void cbMaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.KHs where p.makh == cbMaKH.Text select p;
            foreach (var kh in list)
            {
                txt_TenKH.Text = kh.tenkh;
            }
        }

        private void frmXacNhanXoaDHX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }
    }
}
