using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        private string MaSP;
        private string TenSP;
        private string ThuongHieuSX;
        private string KichThuoc;
        private string ManHinh;
        private int SoLuong;
        private double DonGiaNhap;
        private double DonGiaBan;
        private string HinhAnh;
        private string GhiChu;

        public string MaSP1 { get => MaSP; set => MaSP = value; }
        public string TenSP1 { get => TenSP; set => TenSP = value; }
        public string KichThuoc1 { get => KichThuoc; set => KichThuoc = value; }
        public string ManHinh1 { get => ManHinh; set => ManHinh = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public double DonGiaNhap1 { get => DonGiaNhap; set => DonGiaNhap = value; }
        public double DonGiaBan1 { get => DonGiaBan; set => DonGiaBan = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
        public string HinhAnh1 { get => HinhAnh; set => HinhAnh = value; }
        public string ThuongHieuSX1 { get => ThuongHieuSX; set => ThuongHieuSX = value; }
    }
}
