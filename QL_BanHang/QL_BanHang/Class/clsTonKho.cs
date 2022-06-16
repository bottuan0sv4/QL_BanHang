using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Class
{
    public class clsTonKho
    {
        public int ID_Kho { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int ID_SP { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double dongia { get; set; }
        public int TonDauNam { get; set; }
        public int SoLuongNhap { get; set; }
        public int SoLuongXuat { get; set; }
        public int Ton { get; set; }
        public double giatri { get; set; }
        public int ID_HDNhap { get; set; }
        public int ID_HDXuat { get; set; }
        public List<clsCTHDNhap> cthdnhap { get; set; }
        public List<clsCTHDXuat> cthdxuat { get; set; }

    }

}
