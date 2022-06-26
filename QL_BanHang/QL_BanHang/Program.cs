using System;
using System.Windows.Forms;

namespace QL_BanHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            Application.Run(new TrangChu());
            //Application.Run(new frmHoaDonXuat());
            //Application.Run(new frmHoaDonNhap());
            //Application.Run(new frmBaoCao());
            //Application.Run(new frmTonKho());
            //Application.Run(new FrmTaiKhoan());
            //Application.Run(new frmSanPham());
            //Application.Run(new frmKhachHang());
            //Application.Run(new frmNhaCC());

        }
    }
}
