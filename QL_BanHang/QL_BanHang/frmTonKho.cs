using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QL_BanHang.Class;

namespace QL_BanHang
{

    public partial class frmTonKho : Form
    {
        private Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        public clsTonKho tonKho { get; set; }
        List<clsTonKho> lsttonKho = new List<clsTonKho>();



        public frmTonKho()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            var lstTonDau = (from p in db.TonKhos
                             join a in db.Khos on p.ID_Kho equals a.ID_Kho
                            join b in db.SanPhams on p.ID_SP equals b.ID_SP
                            select new clsTonKho
                            {
                                ID_Kho = a.ID_Kho,
                                MaKho = a.makho,
                                TenKho = a.tenkho,
                                ID_SP = b.ID_SP,
                                MaSP = b.masp,
                                TenSP = b.tensp,
                                dongia = b.dongia,
                                TonDauNam = p.soluong,
                            }).OrderBy(x => x.ID_SP).ToList();

            var lst = (from p in db.CT_HDNhaps
                        join a in db.Khos on p.ID_Kho equals a.ID_Kho
                        join b in db.SanPhams on p.ID_SP equals b.ID_SP
                        join c in db.HDNhaps on p.ID_HDNhap equals c.ID_HDNhap
                        where DateTime.Now >= c.ngaytao
                        select new clsTonKho
                        {
                            ID_HDNhap = c.ID_HDNhap,
                            ID_Kho = a.ID_Kho,
                            MaKho = a.makho,
                            TenKho = a.tenkho,
                            dongia = b.dongia,
                            ID_SP = b.ID_SP,
                            MaSP = b.masp,
                            TenSP = b.tensp,
                            SoLuongNhap = p.soluong,
                        }).OrderBy(x => x.ID_HDNhap).ToList();

            var lst2 = (from p in db.CT_HDXuats
                        join a in db.Khos on p.ID_Kho equals a.ID_Kho
                        join b in db.SanPhams on p.ID_SP equals b.ID_SP
                        join c in db.HDXuats on p.ID_HDXuat equals c.ID_HDXuat
                        where DateTime.Now >= c.ngaytao 
                        select new clsTonKho
                        {
                            ID_HDXuat = c.ID_HDXuat,
                            ID_Kho = a.ID_Kho,
                            MaKho = a.makho,
                            TenKho = a.tenkho,
                            ID_SP = b.ID_SP,
                            MaSP = b.masp,
                            TenSP = b.tensp,
                            dongia = b.dongia,
                            SoLuongXuat = p.soluong,
                        }).OrderBy(x => x.ID_HDXuat).ToList();

            lsttonKho.AddRange(lstTonDau);
            lsttonKho.AddRange(lst);
            lsttonKho.AddRange(lst2);
            var lst3 = lsttonKho.GroupBy(x => x.ID_SP).Select(ds => new clsTonKho
            {
                ID_Kho = ds.First().ID_Kho,
                MaKho = ds.First().MaKho,
                TenKho = ds.First().TenKho,
                ID_SP = ds.First().ID_SP,
                MaSP = ds.First().MaSP,
                TenSP = ds.First().TenSP,
                dongia = ds.First().dongia,
                SoLuongNhap = ds.Sum(i => i.SoLuongNhap),
                SoLuongXuat = ds.Sum(i => i.SoLuongXuat),
                TonDauNam = ds.First().TonDauNam,
                Ton = ds.First().TonDauNam + ds.Sum(i => i.SoLuongNhap) - ds.Sum(i => i.SoLuongXuat),
                giatri = ds.First().dongia *(ds.First().TonDauNam + ds.Sum(i => i.SoLuongNhap) - ds.Sum(i => i.SoLuongXuat)),
            }).ToList();

            gc_TonKho.DataSource = lst3;
            gc_TonKho.RefreshDataSource();
        }
        
        private void frmTonKho_Load(object sender, EventArgs e)
        {
            dataload();
        }
    }
}
