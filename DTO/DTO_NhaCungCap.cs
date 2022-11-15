using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        private string MaNCC;
        private string TenNCC;
        private string dt;
        private string dc;

        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public string TenNCC1 { get => TenNCC; set => TenNCC = value; }
        public string Dt { get => dt; set => dt = value; }
        public string Dc { get => dc; set => dc = value; }
    }
}
