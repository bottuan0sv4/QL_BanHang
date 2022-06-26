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
            txt_NgayLap.Text = obj.ngaytao.ToString("dd");
            txt_ThangLap.Text = obj.ngaytao.ToString("MM");
            txt_NamLap.Text = obj.ngaytao.ToString("yyyy");
        }
        public InHoaDonNhap()
        {
            InitializeComponent();
            dataload();
        }

    }
}
