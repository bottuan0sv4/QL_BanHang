using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class frmSanPham : Form
    {
        private Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.SanPhams
                       select p;
            gc_SanPham.DataSource = list;
            gc_SanPham.RefreshDataSource();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void bt_ThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatSanPham sp = new frmCapNhatSanPham();
            sp.themmoi = true;
            sp.ShowDialog();
            dataload();
        }

        private void bt_ChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatSanPham sp = new frmCapNhatSanPham();
            sp.themmoi = false;
            sp.xoa = false;
            sp.sanPham = (SanPham)gv_SanPham.GetFocusedRow();
            sp.ShowDialog();
            dataload();
        }

        private void bt_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatSanPham sp = new frmCapNhatSanPham();
            sp.xoa = true;
            sp.sanPham = (SanPham)gv_SanPham.GetFocusedRow();
            sp.ShowDialog();
            dataload();
        }
    }
}
