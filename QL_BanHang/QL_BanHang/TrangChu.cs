using DevExpress.XtraBars;
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
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
    }
}