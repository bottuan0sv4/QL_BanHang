using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QL_BanHang.Class;

namespace QL_BanHang
{
    public partial class frmHoaDonXuat : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();

        public frmHoaDonXuat()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            db = new Linq_QL_BanHangDataContext();
            var list = (from p in db.HDXuats
                        join c in db.KHs on p.ID_KH equals c.ID_KH
                        select new clsHDXuat
                        {
                            ID_HDXuat = p.ID_HDXuat,
                            sophieuxuat = p.sophieuxuat,
                            ngaytao = p.ngaytao,
                            makh = p.makh,
                            tenkh = c.tenkh,
                            ID_KH = p.ID_KH,
                            masothue = c.masothue
                        }
                        ).OrderBy(x => x.ID_HDXuat);
            gc_HDXuat.DataSource = list;
            gc_HDXuat.RefreshDataSource();
        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void bt_themmoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHDXuat hdx = new frmCapNhatHDXuat();
            hdx.themmoi = true;
            hdx.ShowDialog();
            dataload();
        }

        private void bt_chinhsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHDXuat f = new frmCapNhatHDXuat();
            f.themmoi = false;
            f.hdXuat = gv_HDXuat.GetFocusedRow() as clsHDXuat;
            f.ShowDialog();
            dataload();
        }

        private void bt_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXacNhanXoaDHX f = new frmXacNhanXoaDHX();
            f.hdXuat = gv_HDXuat.GetFocusedRow() as clsHDXuat;
            f.ShowDialog();
            dataload();
        }

        private void gv_HDXuat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            clsHDXuat obj = (clsHDXuat)gv_HDXuat.GetFocusedRow();
            db = new Linq_QL_BanHangDataContext();
            
            var list = (from p in db.CT_HDXuats
                        join c in db.Khos on p.ID_Kho equals c.ID_Kho
                        join d in db.HDXuats on p.ID_HDXuat equals d.ID_HDXuat
                        join s in db.SanPhams on p.ID_SP equals s.ID_SP
                        where p.ID_HDXuat == obj.ID_HDXuat
                        select new clsCTHDXuat
                        {
                            ID_CTHDX = p.ID_CTHDX,
                            ID_HDXuat = p.ID_HDXuat,
                            sophieuxuat = d.sophieuxuat,
                            masp = p.masp,
                            tensp = s.tensp,
                            makho = p.makho,
                            tenkho = c.tenkho,
                            soluong = p.soluong,
                            dongia = s.dongia,
                            chietkhau = p.chietkhau,
                            thanhtien = p.thanhtien,
                        }).OrderBy(x => x.ID_HDXuat);
            gc_CTHDXuat.DataSource = list;
            gc_CTHDXuat.RefreshDataSource();
        }

        private void bt_InHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InHoaDonXuat prt = new InHoaDonXuat();
            var A = gv_HDXuat.GetFocusedRow() as clsHDXuat;
            var listCT_HDNhaps = (from p in db.CT_HDXuats
                                  join c in db.Khos on p.ID_Kho equals c.ID_Kho
                                  join s in db.SanPhams on p.ID_SP equals s.ID_SP
                                  join d in db.HDXuats on p.ID_HDXuat equals d.ID_HDXuat
                                  where p.ID_HDXuat == A.ID_HDXuat
                                  select new clsCTHDXuat
                                  {

                                      ID_CTHDX = p.ID_CTHDX,
                                      ID_HDXuat = p.ID_HDXuat,
                                      sophieuxuat = d.sophieuxuat,
                                      masp = p.masp,
                                      tensp = s.tensp,
                                      makho = p.makho,
                                      tenkho = c.tenkho,
                                      soluong = p.soluong,
                                      dongia = s.dongia,
                                      chietkhau = p.chietkhau,
                                      thanhtien = p.thanhtien,
                                  }).OrderBy(x => x.ID_HDXuat);

            prt.DataSource = listCT_HDNhaps.ToList();
            prt.ShowPreview();
        }

        private void frmHoaDonXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }
    }    
}
