using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonHang
    {
        private string Sohdb, manv, makh, ngaylap;
        private double thanhtien;

        public string Sohdb1 { get => Sohdb; set => Sohdb = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
