using DevExpress.DataProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using QL_BanHang.Class;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace QL_BanHang
{
    public partial class frmCapNhatHDNhap : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        HDNhap hdn = new HDNhap();
        CT_HDNhap ct_hdn = new CT_HDNhap();
        SanPham sp = new SanPham();

        public bool themmoi { get; set; }
        public bool suact { get; set; }

        public clsHDNhap hdNhap { get; set; }
        public clsCTHDNhap cthdNhap { get; set; }

        List<clsCTHDNhap> lstchitiet = new List<clsCTHDNhap>();
        List<clsCTHDNhap> lstSource = new List<clsCTHDNhap>();


        public frmCapNhatHDNhap()
        {
            InitializeComponent();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmCapNhatHDNhap_Load(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.NCCs select p;
            var list2 = from c in db.Khos select c;
            var list3 = from d in db.SanPhams select d;

            foreach (var ncc in list)
            {
                cbMaNCC.Items.Add(ncc.mancc);
            }
            foreach (var kho in list2)
            {
                cbMaKho.Items.Add(kho.makho);
            }
            foreach (var sp in list3)
            {
                cbMaSP.Items.Add(sp.masp);
            }
            if (themmoi)
            {

            }
            else
            {
                txt_SoPhieuNhap.Text = hdNhap.sophieunhap;
                date_NgayTao.DateTime = hdNhap.ngaytao;
                cbMaNCC.Text = hdNhap.mancc;

                lstSource = (from p in db.CT_HDNhaps
                          join c in db.Khos on p.ID_Kho equals c.ID_Kho
                          join s in db.SanPhams on p.ID_SP equals s.ID_SP
                          join d in db.HDNhaps on p.ID_HDNhap equals d.ID_HDNhap
                          where p.ID_HDNhap == hdNhap.ID_HDNhap
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
                          }).OrderBy(x => x.ID_HDNhap).ToList();
                gc_ctHDNhap.DataSource = lstSource;
                gc_ctHDNhap.RefreshDataSource();


            }


        }



        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void cbMaNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.NCCs where p.mancc == cbMaNCC.Text select p;
            foreach (var ncc in list)
            {
                txt_TenNCC.Text = ncc.tenncc;
            }
        }

        private void bt_Huy_HD(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void sidePanel2_Click(object sender, EventArgs e)
        {

        }





        private void bt_Luu_HD_Click(object sender, EventArgs e)
        {
            if (themmoi)
            {
                hdn.sophieunhap = txt_SoPhieuNhap.Text;
                hdn.mancc = cbMaNCC.Text;
                hdn.ngaytao = (DateTime)date_NgayTao.DateTime;
                var list = (from p in db.NCCs
                            where cbMaNCC.Text == p.mancc
                            select p.ID_NCC).SingleOrDefault();
                hdn.ID_NCC = list;


                foreach (var item in lstchitiet)
                {
                    CT_HDNhap ct = new CT_HDNhap();
                    ct.makho = item.makho;
                    ct.masp = item.masp;
                    ct.soluong = item.soluong;
                    ct.chietkhau = item.chietkhau;
                    ct.thanhtien = item.thanhtien;

                    ct.ID_Kho = item.ID_Kho;

                    ct.ID_SP = item.ID_SP;

                    ct.ID_HDNhap = item.ID_HDNhap;


                    hdn.CT_HDNhaps.Add(ct);
                }


                db.HDNhaps.InsertOnSubmit(hdn);
                db.SubmitChanges();
                frmHoaDonNhap_Load(sender, e);
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                HDNhap hdns = (from ds in db.HDNhaps where ds.ID_HDNhap == hdNhap.ID_HDNhap select ds).FirstOrDefault();

                hdns.sophieunhap = txt_SoPhieuNhap.Text;
                hdns.mancc = cbMaNCC.Text;
                hdns.ngaytao = (DateTime)date_NgayTao.DateTime;
                var list = (from p in db.NCCs
                            where cbMaNCC.Text == p.mancc
                            select p.ID_NCC).SingleOrDefault();
                hdns.ID_NCC = list;

                foreach (var item in from ds in db.CT_HDNhaps where ds.ID_HDNhap == hdns.ID_HDNhap select ds)
                {
                    db.CT_HDNhaps.DeleteOnSubmit(item);
                }
                foreach (var item in lstchitiet)
                {
                    CT_HDNhap ct = new CT_HDNhap();
                    ct.makho = item.makho;
                    ct.masp = item.masp;
                    ct.soluong = item.soluong;
                    ct.chietkhau = item.chietkhau;
                    ct.thanhtien = item.thanhtien;

                    ct.ID_Kho = (from p in db.Khos
                                 where item.makho == p.makho
                                 select p.ID_Kho).SingleOrDefault();

                    ct.ID_SP = (from p in db.SanPhams
                                where item.masp == p.masp
                                select p.ID_SP).SingleOrDefault();

                    ct.ID_HDNhap = (from p in db.HDNhaps
                                    where txt_SoPhieuNhap.Text == p.sophieunhap
                                    select p.ID_HDNhap).SingleOrDefault();
                    ct.ID_CTHDN = item.ID_CTHDN;

                    hdns.CT_HDNhaps.Add(ct);
                }
                    db.SubmitChanges();
                frmHoaDonNhap_Load(sender, e);
                this.DialogResult = DialogResult.Cancel;

            }



        }



        private void bt_Luu_Click_1(object sender, EventArgs e)
        {
            if (themmoi)
            {

                lstchitiet.Add(new clsCTHDNhap()
                {
                    ID_Kho = (from p in db.Khos
                              where cbMaKho.Text == p.makho
                              select p.ID_Kho).FirstOrDefault(),
                    makho = cbMaKho.Text,
                    tenkho = txt_TenKho.Text,
                    ID_SP = (from p in db.SanPhams
                             where cbMaSP.Text == p.masp
                             select p.ID_SP).FirstOrDefault(),
                    masp = cbMaSP.Text,
                    tensp = txt_TenSP.Text,
                    soluong = Convert.ToInt32(txt_SoLuong.EditValue),
                    dongia = Convert.ToDouble(txt_DonGia.EditValue),
                    chietkhau = Convert.ToDouble(txt_ChietKhau.EditValue),
                    thanhtien = ((Convert.ToDouble(txt_ChietKhau.EditValue) * Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) - (Convert.ToDouble(txt_ChietKhau.EditValue) * Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) / 100)
                });

            }
            else
            {
                lstchitiet.AddRange(lstSource);
            }
            cbMaNCC.Items.Clear();
            cbMaSP.Items.Clear();
            cbMaKho.Items.Clear();
            frmCapNhatHDNhap_Load(sender, e);
            gc_ctHDNhap.DataSource = lstchitiet;
            gc_ctHDNhap.RefreshDataSource();
        }

        private void cbMaKho_SelectedValueChanged_1(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.Khos where p.makho == cbMaKho.Text select p;
            foreach (var kho in list)
            {
                txt_TenKho.Text = kho.tenkho;
            }
        }

        private void cbMaSP_SelectedValueChanged_1(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.SanPhams where p.masp == cbMaSP.Text select p;
            foreach (var sp in list)
            {
                txt_TenSP.Text = sp.tensp;
                txt_DonGia.EditValue = sp.dongia;
            }
        }

        private void gv_ctHDNhap_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {

            /*var sua = gv_ctHDNhap.GetFocusedRow() as clsCTHDNhap;
            if(sua != null)
            {
                cbMaKho.Text = sua.makho;
                cbMaSP.Text = sua.masp;
                txt_SoLuong.EditValue = sua.soluong;
                txt_ChietKhau.EditValue = sua.chietkhau;
            }
           
            gc_ctHDNhap.RefreshDataSource();*/
        }


        private void gv_ctHDNhap_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var obj = gv_ctHDNhap.GetRowCellValue(e.RowHandle, maSP);
            if (obj != null)
            {

                var b = (from ds in lstSource where ds.masp == obj.ToString() select ds).FirstOrDefault();
                if (b.soluong != null && b.dongia != null && b.chietkhau != null)
                {
                    if (b != null)
                    {
                        b.thanhtien = (int.Parse(b.soluong.ToString()) * int.Parse(b.dongia.ToString()) * int.Parse(b.chietkhau.ToString())) - (int.Parse(b.soluong.ToString()) * int.Parse(b.dongia.ToString()) * int.Parse(b.chietkhau.ToString()) * 0.01);
                        gc_ctHDNhap.DataSource = lstSource;
                    }

                }
            }
        }
    }
}
