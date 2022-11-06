using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        private string sohdn, masp;
        private int sl;
        private double km;

        public string Sohdn { get => sohdn; set => sohdn = value; }
        public string Masp { get => masp; set => masp = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Km { get => km; set => km = value; }
    }
}
