using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class frmKho : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        public frmKho()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.Khos
                       select p;
            gc_Kho.DataSource = list;
            gc_Kho.RefreshDataSource();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void bt_ThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatKho k = new frmCapNhatKho();
            k.Themmoi = true;
            k.ShowDialog();
            dataload();
        }

        private void bt_ChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatKho k = new frmCapNhatKho();
            k.Themmoi = false;
            k.Xoa = false;
            k.kho = (Kho)gv_Kho.GetFocusedRow();
            k.ShowDialog();
            dataload();
        }

        private void bt_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatKho k = new frmCapNhatKho();
            k.Xoa = true;
            k.kho = (Kho)gv_Kho.GetFocusedRow();
            k.ShowDialog();
            dataload();
        }
    }
}
