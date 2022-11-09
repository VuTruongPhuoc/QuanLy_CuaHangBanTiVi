using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonNhap
    {
        private string sohdn, mancc, manv;
        private double thanhtien;

        public string Sohdn { get => sohdn; set => sohdn = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string Manv { get => manv; set => manv = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
