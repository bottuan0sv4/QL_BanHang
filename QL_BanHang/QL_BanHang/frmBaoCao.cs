using DevExpress.DataProcessing;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QL_BanHang.Class;

namespace QL_BanHang
{
    public partial class frmBaoCao : Form
    {
        private Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        List<clsBaoCao> lstBaoCao = new List<clsBaoCao>();
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            var lst = (from p in db.CT_HDNhaps
                       join a in db.Khos on p.ID_Kho equals a.ID_Kho
                       join b in db.SanPhams on p.ID_SP equals b.ID_SP
                       join c in db.HDNhaps on p.ID_HDNhap equals c.ID_HDNhap
                       select new clsBaoCao
                       {
                           ID_HDNhap = c.ID_HDNhap,
                           ID_Kho = a.ID_Kho,
                           MaKho = a.makho,
                           TenKho = a.tenkho,
                           ID_SP = b.ID_SP,
                           MaSP = b.masp,
                           TenSP = b.tensp,
                           SoLuongNhap = p.soluong,
                           ThoiGianNhap = c.ngaytao,
                           
                       }).OrderBy(x => x.ID_HDNhap).ToList();

            var lst2 = (from p in db.CT_HDXuats
                        join a in db.Khos on p.ID_Kho equals a.ID_Kho
                        join b in db.SanPhams on p.ID_SP equals b.ID_SP
                        join c in db.HDXuats on p.ID_HDXuat equals c.ID_HDXuat
                        select new clsBaoCao
                        {
                            ID_HDXuat = c.ID_HDXuat,
                            ID_Kho = a.ID_Kho,
                            MaKho = a.makho,
                            TenKho = a.tenkho,
                            ID_SP = b.ID_SP,
                            MaSP = b.masp,
                            TenSP = b.tensp,
                            SoLuongXuat = p.soluong,
                            ThoiGianXuat = c.ngaytao,
                        }).OrderBy(x => x.ID_HDXuat).ToList();

            lstBaoCao.AddRange(lst);
            lstBaoCao.AddRange(lst2);


        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void bt_MaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lst3 = lstBaoCao.GroupBy(x => x.ID_Kho).Select(ds => new clsBaoCao
            {
                ID_Kho = ds.First().ID_Kho,
                MaKho = ds.First().MaKho,
                TenKho = ds.First().TenKho,
                ID_SP = ds.First().ID_SP,
                MaSP = ds.First().MaSP,
                TenSP = ds.First().TenSP,
                SoLuongNhap = ds.Sum(i => i.SoLuongNhap),
                SoLuongXuat = ds.Sum(i => i.SoLuongXuat),
                ThoiGianNhap = ds.First().ThoiGianNhap,
                ThoiGianXuat = ds.First().ThoiGianXuat

            }).ToList();

            gc_BaoCao.DataSource = lst3;
            gc_BaoCao.RefreshDataSource();
        }

        private void bt_NgayNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lst3 = lstBaoCao.GroupBy(x => x.ThoiGianNhap).Select(ds => new clsBaoCao
            {
                ID_Kho = ds.First().ID_Kho,
                MaKho = ds.First().MaKho,
                TenKho = ds.First().TenKho,
                ID_SP = ds.First().ID_SP,
                MaSP = ds.First().MaSP,
                TenSP = ds.First().TenSP,
                SoLuongNhap = ds.Sum(i => i.SoLuongNhap),
                SoLuongXuat = ds.Sum(i => i.SoLuongXuat),
                ThoiGianNhap = ds.First().ThoiGianNhap,
                ThoiGianXuat = ds.First().ThoiGianXuat

            }).ToList();

            gc_BaoCao.DataSource = lst3;
            gc_BaoCao.RefreshDataSource();
        }

        private void bt_NgayXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lst3 = lstBaoCao.GroupBy(x => x.ThoiGianXuat ).Select(ds => new clsBaoCao
            {
                ID_Kho = ds.First().ID_Kho,
                MaKho = ds.First().MaKho,
                TenKho = ds.First().TenKho,
                ID_SP = ds.First().ID_SP,
                MaSP = ds.First().MaSP,
                TenSP = ds.First().TenSP,
                SoLuongNhap = ds.Sum(i => i.SoLuongNhap),
                SoLuongXuat = ds.Sum(i => i.SoLuongXuat),
                ThoiGianNhap = ds.First().ThoiGianNhap,
                ThoiGianXuat = ds.First().ThoiGianXuat

            }).ToList();

            gc_BaoCao.DataSource = lst3;
            gc_BaoCao.RefreshDataSource();
        }

        private void btMaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lst3 = lstBaoCao.GroupBy(x => x.ID_Kho).Select(ds => new clsBaoCao
            {
                ID_Kho = ds.First().ID_Kho,
                MaKho = ds.First().MaKho,
                TenKho = ds.First().TenKho,
                ID_SP = ds.First().ID_SP,
                MaSP = ds.First().MaSP,
                TenSP = ds.First().TenSP,
                SoLuongNhap = ds.Sum(i => i.SoLuongNhap),
                SoLuongXuat = ds.Sum(i => i.SoLuongXuat),
                ThoiGianNhap = ds.First().ThoiGianNhap,
                ThoiGianXuat = ds.First().ThoiGianXuat

            }).ToList();

            gc_BaoCao.DataSource = lst3;
            gc_BaoCao.RefreshDataSource();
        }

        private void btBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc_BaoCao.DataSource = lstBaoCao;
            gc_BaoCao.RefreshDataSource();
        }
    }
}
