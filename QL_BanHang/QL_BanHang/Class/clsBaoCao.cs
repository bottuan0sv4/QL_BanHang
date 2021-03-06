using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Class
{
    class clsBaoCao
    {
        public int ID_Kho { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int ID_SP { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuongNhap { get; set; }
        public DateTime ThoiGianNhap { get; set; }
        public int SoLuongXuat { get; set; }
        public DateTime ThoiGianXuat { get; set; }
        public int ID_HDNhap { get; set; }
        public int ID_HDXuat { get; set; }
        public List<clsCTHDNhap> cthdnhap { get; set; }
        public List<clsCTHDXuat> cthdxuat { get; set; }
    }
}
