using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string manv;
        private string tennv;
        private string ngaysinh;
        private string sdt;
        private string diachi;
        private string tentk;
        private string mk;
        private string chucvu;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Mk { get => mk; set => mk = value; }
    }
}
