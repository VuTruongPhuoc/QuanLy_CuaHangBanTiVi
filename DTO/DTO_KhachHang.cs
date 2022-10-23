using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string Makh;
        private string Tenkh;
        private string GioiTinh;
        private string sdt;
        private string Diachi;

        public string Makh1 { get => Makh; set => Makh = value; }
        public string Tenkh1 { get => Tenkh; set => Tenkh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
    }
}
