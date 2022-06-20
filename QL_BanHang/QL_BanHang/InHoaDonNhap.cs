using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using QL_BanHang.Class;

namespace QL_BanHang
{
    public partial class InHoaDonNhap : DevExpress.XtraReports.UI.XtraReport
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        public void dataload()
        {
            var obj = (from p in db.HDNhaps
                       join a in db.NCCs on p.ID_NCC equals a.ID_NCC
                       select new clsTTHDNhap
                       {
                           sophieunhap = p.sophieunhap,
                           ID_HDNhap = p.ID_HDNhap,
                           tenncc = a.tenncc,
                           mancc = a.mancc,
                           ngaytao = p.ngaytao,
                           sdt = a.sdt,
                           diachi = a.diachi
                       }).OrderBy(x => x.ID_HDNhap).FirstOrDefault();
            txt_sophieu.Text = obj.sophieunhap;
            txt_tenncc.Text = obj.tenncc;
            txt_diachi.Text = obj.diachi;
            txt_mancc.Text = obj.mancc;
            txt_sdt.Text = obj.sdt;
            txt_ngaytao.Text = obj.ngaytao.ToString("dd/MM/yyyy");

        }
        public InHoaDonNhap()
        {
            InitializeComponent();
            dataload();
        }

    }
}
