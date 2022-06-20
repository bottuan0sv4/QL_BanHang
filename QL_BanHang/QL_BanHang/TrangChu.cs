using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool isThoat = true;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void bt_TaiKhoan(object sender, ItemClickEventArgs e)
        {

        }

        private void bt_KhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void bt_SanPham_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bt_Acc_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTaiKhoan f = new FrmTaiKhoan();
            f.MdiParent = this;
            f.Show();
        }

        private void bt_SanPham_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void bt_Kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKho kh = new frmKho();
            kh.MdiParent = this;
            kh.Show();

        }

        private void bt_HDNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHoaDonNhap hdn = new frmHoaDonNhap();
            hdn.MdiParent = this;
            hdn.Show();
        }

        private void bt_HDXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHoaDonXuat hdx = new frmHoaDonXuat();
            hdx.MdiParent = this;
            hdx.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void bt_BaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCao tkn = new frmBaoCao();
            tkn.MdiParent = this;
            tkn.Show();
        }

        private void bt_NhaCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaCC ncc = new frmNhaCC();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void bt_HDXuat_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmHoaDonXuat f = new frmHoaDonXuat();
            f.MdiParent = this;
            f.Show();
        }

        private void bt_TonKho_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bt_TrangChu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bt_TrangChu_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmTrangChu f = new frmTrangChu();
            f.MdiParent = this;
            f.Show();
        }

        private void btTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTonKho f = new frmTonKho();
            f.MdiParent = this;
            f.Show();
        }

        private void bt_dangxuat__ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bt_dang_xuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            isThoat = false;
            this.Close();
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void TrangChu_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void bt_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }
    }
}