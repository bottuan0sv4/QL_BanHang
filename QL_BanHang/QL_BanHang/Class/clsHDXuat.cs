using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Class
{

    public class clsHDXuat
    {
        public int ID_HDXuat { get; set; }
        public string sophieuxuat { get; set; }
        public DateTime ngaytao { get; set; }
        public string makh { get; set; }
        public string tenkh { get; set; }
        public int ID_KH { get; set; }
        public double masothue { get; set; }
        public List<clsCTHDXuat> ChiTietHoaDon { get; set; }

    }
        public class clsCTHDXuat
        {
            public int ID_CTHDX { get; set; }
            public int ID_HDXuat { get; set; }
            public int ID_Kho { get; set; }
            public int ID_SP { get; set; }
            public string sophieuxuat { get; set; }
            public string masp { get; set; }
            public string tensp { get; set; }
            public string makho { get; set; }
            public string tenkho { get; set; }
            public int soluong { get; set; }
            public double dongia { get; set; }
            public double chietkhau { get; set; }
            public double masothue { get; set; }
            public double thanhtien { get; set; }
        }

        public class clsttXuat
        {
            public int ID_HDXuat { get; set; }
            public int ID_CTHDX { get; set; }
            public string sophieuxuat { get; set; }
            public DateTime ngaytao { get; set; }
            public string makh { get; set; }
            public string tenkh { get; set; }
            public int ID_KH { get; set; }
            public string sdt { get; set; }
            public string diachi { get; set; }
            public double masothue { get; set; }

        }

}
