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
            gc_BaoCao.DataSource = lstBaoCao;
            gc_BaoCao.RefreshDataSource();

        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dataload();
        }

       
    }
}
