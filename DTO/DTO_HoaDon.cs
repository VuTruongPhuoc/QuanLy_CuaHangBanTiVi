using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string sohdb, masp, km;
        int slban;

        public string Sohdb { get => sohdb; set => sohdb = value; }
        public string Masp { get => masp; set => masp = value; }
        public int Slban { get => slban; set => slban = value; }
        public string Km { get => km; set => km = value; }
    }
}
