using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class frmNhaCC : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        private void dataload()
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.NCCs
                       select p;
            gc_Nhacc.DataSource = list;
            gc_Nhacc.RefreshDataSource();
        }
        public frmNhaCC()
        {
            InitializeComponent();
        }

        private void bt_ThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmCapNhatNCC ncc = new frmCapNhatNCC();
            ncc.themmoi = true;
            ncc.ShowDialog();
            dataload();
        }

        private void bt_ChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatNCC ncc = new frmCapNhatNCC();
            ncc.themmoi = false;
            ncc.xoa = false;
            ncc.nhacc = (NCC)gv_Nhacc.GetFocusedRow();
            ncc.ShowDialog();
            dataload();
        }

        private void bt_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatNCC ncc = new frmCapNhatNCC();
            ncc.xoa = true;
            ncc.nhacc = (NCC)gv_Nhacc.GetFocusedRow();
            ncc.ShowDialog();
            dataload();
        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            dataload();
        }
    }
}
