using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QL_BanHang.Class;
using Syncfusion.XlsIO;

namespace QL_BanHang
{
    public partial class frmHoaDonNhap : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();

        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            db = new Linq_QL_BanHangDataContext();
            var list = (from p in db.HDNhaps
                        join c in db.NCCs on p.ID_NCC equals c.ID_NCC
                        select new clsHDNhap
                        {
                            ID_HDNhap = p.ID_HDNhap,
                            sophieunhap = p.sophieunhap,
                            ngaytao = p.ngaytao,
                            mancc = p.mancc,
                            tenncc = c.tenncc,
                            ID_NCC = p.ID_NCC
                        }
                        ).OrderBy(x => x.ID_HDNhap);
            gc_HDNhap.DataSource = list;
            gc_HDNhap.RefreshDataSource();
        }
        private void loaddataCTHDN()
        {
        }


        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void bt_ThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHDNhap hdn = new frmCapNhatHDNhap();
            hdn.themmoi = true;
            hdn.ShowDialog();
            dataload();
        }

        private void bt_ChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHDNhap f = new frmCapNhatHDNhap();
            f.themmoi = false;
            f.hdNhap = gv_HDNhap.GetFocusedRow() as clsHDNhap;
            f.ShowDialog();
            dataload();
        }

        private void bt_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXacNhanXoaHDN f = new frmXacNhanXoaHDN();
            f.hdNhap = gv_HDNhap.GetFocusedRow() as clsHDNhap;
            f.ShowDialog();
            dataload();
        }

        private void bt_ChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gv_HDNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            clsHDNhap obj = (clsHDNhap)gv_HDNhap.GetFocusedRow();
            db = new Linq_QL_BanHangDataContext();
            var list = (from p in db.CT_HDNhaps
                        join c in db.Khos on p.ID_Kho equals c.ID_Kho
                        join s in db.SanPhams on p.ID_SP equals s.ID_SP
                        join d in db.HDNhaps on p.ID_HDNhap equals d.ID_HDNhap
                        where p.ID_HDNhap == obj.ID_HDNhap
                        select new clsCTHDNhap
                        {
                            ID_CTHDN = p.ID_CTHDN,
                            ID_HDNhap = d.ID_HDNhap,
                            sophieunhap = d.sophieunhap,
                            masp = p.masp,
                            tensp = s.tensp,
                            makho = p.makho,
                            tenkho = c.tenkho,
                            soluong = p.soluong,
                            dongia = s.dongia,
                            chietkhau = p.chietkhau,
                            thanhtien = p.thanhtien,
                        }).OrderBy(x => x.ID_HDNhap);
                gc_CTHDNhap.DataSource = list;
                gc_CTHDNhap.RefreshDataSource();

           
            
        }



        private void btsua_click(object sender, EventArgs e)
        {
            frmCapNhatHDNhap f = new frmCapNhatHDNhap();
            f.themmoi = false;
            f.suact = true;
            f.cthdNhap = (clsCTHDNhap)gv_CTHDNhap.GetFocusedRow();
            f.ShowDialog();
            dataload();
        }

        private void gv_CTHDNhap_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            clsCTHDNhap obj = (clsCTHDNhap)gv_CTHDNhap.GetFocusedRow();
            db = new Linq_QL_BanHangDataContext();
            var list = (from p in db.HDNhaps
                        join c in db.NCCs on p.ID_NCC equals c.ID_NCC
                        where p.ID_HDNhap == obj.ID_HDNhap
                        select new clsHDNhap
                        {
                            ID_HDNhap = p.ID_HDNhap,
                            sophieunhap = p.sophieunhap,
                            ngaytao = p.ngaytao,
                            ID_NCC = c.ID_NCC,
                            mancc = c.mancc,
                            tenncc = c.tenncc
                        }).OrderBy(x => x.ID_HDNhap);
        }

        private void bt_InHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InHoaDonNhap prt = new InHoaDonNhap();
            var A = gv_HDNhap.GetFocusedRow() as clsHDNhap;
            var listCT_HDNhaps = (from p in db.CT_HDNhaps
                                  join c in db.Khos on p.ID_Kho equals c.ID_Kho
                                  join s in db.SanPhams on p.ID_SP equals s.ID_SP
                                  join d in db.HDNhaps on p.ID_HDNhap equals d.ID_HDNhap
                                  where p.ID_HDNhap == A.ID_HDNhap
                                  select new clsCTHDNhap
                                  {
                                      ID_CTHDN = p.ID_CTHDN,
                                      ID_HDNhap = p.ID_HDNhap,
                                      sophieunhap = d.sophieunhap,
                                      masp = p.masp,
                                      tensp = s.tensp,
                                      makho = p.makho,
                                      tenkho = c.tenkho,
                                      soluong = p.soluong,
                                      dongia = s.dongia,
                                      chietkhau = p.chietkhau,
                                      thanhtien = p.thanhtien,
                                  }).OrderBy(x => x.ID_HDNhap);

            prt.DataSource = listCT_HDNhaps.ToList();
            prt.ShowPreview();
           
        }
    }
}
