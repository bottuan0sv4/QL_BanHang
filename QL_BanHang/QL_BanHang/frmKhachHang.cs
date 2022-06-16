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
    public partial class frmKhachHang : Form
    {
        private Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void dataload()
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.KHs
                       select p;
            gc_KhachHang.DataSource = list;
            gc_KhachHang.RefreshDataSource();
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void bt_ClickThemMoi(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatKhachHang kh = new frmCapNhatKhachHang();
            kh.them = true;
            kh.ShowDialog();
            dataload();
        }

        private void bt_ClickChinhSua(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatKhachHang kh = new frmCapNhatKhachHang();
            kh.them = false;
            kh.xoa = false;
            kh.khachHang = (KH)gv_KhachHang.GetFocusedRow();
            kh.ShowDialog();
            dataload();
        }


        private void bt_ClickXoa(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatKhachHang kh = new frmCapNhatKhachHang();
            kh.xoa = true;
            kh.khachHang = (KH)gv_KhachHang.GetFocusedRow();
            kh.ShowDialog();
            dataload();
        }




    }
}
