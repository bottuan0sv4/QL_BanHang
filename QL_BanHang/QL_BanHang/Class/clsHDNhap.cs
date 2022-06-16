using System;
using System.Collections.Generic;


namespace QL_BanHang.Class
{
  public class clsHDNhap
    {
        public int ID_HDNhap { get; set; }
        public string sophieunhap { get; set; }
        public DateTime ngaytao { get; set; }
        public string mancc { get; set; }
        public string tenncc { get; set; }
        public int ID_NCC { get; set; }
        public List<clsCTHDNhap> ChiTietHoaDon { get; set; }
    }
   public class clsCTHDNhap
    {
        public int ID_CTHDN { get; set; }
        public int ID_HDNhap { get; set; }
        public int ID_Kho { get; set; }
        public int ID_SP { get; set; }
        public string sophieunhap { get; set; }
        public string masp { get; set; }
        public string tensp { get; set; }
        public string makho { get; set; }
        public string tenkho { get; set; }
        public int soluong { get; set; }
        public double dongia { get; set; }
        public double chietkhau { get; set; }
        public double thanhtien { get; set; }

    }

    public class clsTTHDNhap
    {
        public int ID_HDNhap { get; set; }
        public int ID_CTHDN { get; set; }
        public string sophieunhap { get; set; }
        public DateTime ngaytao { get; set; }
        public string mancc { get; set; }
        public string tenncc { get; set; }
        public int ID_NCC { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
    }
}
