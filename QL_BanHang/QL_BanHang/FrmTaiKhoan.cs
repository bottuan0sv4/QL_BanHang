using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class FrmTaiKhoan : Form
    {
        private Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext(); 
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void dataload()
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.TaiKhoans
                       select p;
            gc_TaiKhoan.DataSource = list;
            gc_TaiKhoan.RefreshDataSource();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void bt_ClickThemMoi(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCapNhatTaiKhoan f = new FrmCapNhatTaiKhoan();
            f.Themmoi = true;
            f.ShowDialog();
            dataload();
        }

        private void bt_ClickChinhSua(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCapNhatTaiKhoan f = new FrmCapNhatTaiKhoan();
            f.Themmoi = false;
            f.Xoa = false;
            f.taiKhoan = (TaiKhoan)gv_TaiKhoan.GetFocusedRow();
            f.ShowDialog();
            dataload();
        }

        private void bt_ClickXoa(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCapNhatTaiKhoan f = new FrmCapNhatTaiKhoan();
            f.Themmoi = false;
            f.Xoa = true;
            f.taiKhoan = (TaiKhoan)gv_TaiKhoan.GetFocusedRow();
            f.ShowDialog();
            dataload();
        }
    }
}
