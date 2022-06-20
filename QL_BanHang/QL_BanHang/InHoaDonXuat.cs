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
    public partial class InHoaDonXuat : DevExpress.XtraReports.UI.XtraReport
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        public void dataload()
        {
            var obj = (from p in db.HDXuats
                       join a in db.KHs on p.ID_KH equals a.ID_KH
                       select new clsttXuat
                       {
                           sophieuxuat = p.sophieuxuat,
                           ID_HDXuat = p.ID_HDXuat,
                           tenkh = a.tenkh,
                           makh = a.makh,
                           ngaytao = p.ngaytao,
                           sdt = a.sdt,
                           diachi = a.diachi,
                           masothue = a.masothue
                       }).OrderBy(x => x.ID_HDXuat).FirstOrDefault();
            txt_sophieu.Text = obj.sophieuxuat;
            txt_tenkh.Text = obj.tenkh;
            txt_diachi.Text = obj.diachi;
            txt_makh.Text = obj.makh;
            txt_sdt.Text = obj.sdt;
            txt_ngaytao.Text = obj.ngaytao.ToString("dd/MM/yyyy");
            txt_masothue.Text = Convert.ToString(obj.masothue);
        }

        public InHoaDonXuat()
        {
            InitializeComponent();
            dataload();

        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
