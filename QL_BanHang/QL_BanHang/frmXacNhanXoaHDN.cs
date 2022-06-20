using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QL_BanHang.Class;

namespace QL_BanHang
{
    public partial class frmXacNhanXoaHDN : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        HDNhap hdn = new HDNhap();
        CT_HDNhap ct_hdn = new CT_HDNhap();
        public clsHDNhap hdNhap { get; set; }
        public clsCTHDNhap cthdNhap { get; set; }

        List<clsCTHDNhap> lstchitiet = new List<clsCTHDNhap>();

        public frmXacNhanXoaHDN()
        {
            InitializeComponent();
        }
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {

        }

        private void bt_Xacnhan_Click(object sender, EventArgs e)
        {
            txt_SoPhieuNhap.Text = hdNhap.sophieunhap;
            date_NgayTao.DateTime = hdNhap.ngaytao;
            cbMaNCC.Text = hdNhap.mancc;
            hdn.ID_NCC = (from p in db.NCCs
                        where cbMaNCC.Text == p.mancc
                        select p.ID_NCC).FirstOrDefault();
            
            HDNhap hdxoa = (from c in db.HDNhaps
                            where txt_SoPhieuNhap.Text == c.sophieunhap
                            select c).FirstOrDefault();


            db.CT_HDNhaps.DeleteAllOnSubmit(hdxoa.CT_HDNhaps);

            db.HDNhaps.DeleteOnSubmit(hdxoa);
            db.SubmitChanges();
            frmHoaDonNhap_Load(sender, e);
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmXacNhanXoaHDN_Load(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.NCCs select p;

            foreach (var ncc in list)
            {
                cbMaNCC.Items.Add(ncc.mancc);
            }
                txt_SoPhieuNhap.Text = hdNhap.sophieunhap;
                date_NgayTao.DateTime = hdNhap.ngaytao;
                cbMaNCC.Text = hdNhap.mancc;
        }

        private void cbMaNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.NCCs where p.mancc == cbMaNCC.Text select p;
            foreach (var ncc in list)
            {
                txt_TenNCC.Text = ncc.tenncc;
            }
        }
    }
}
