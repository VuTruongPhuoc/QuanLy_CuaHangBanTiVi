using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        private string UserName;
        private string PassWord;
        private string DisplayName;
        private string Type;

        public string UserName1 { get => UserName; set => UserName = value; }
        public string PassWord1 { get => PassWord; set => PassWord = value; }
        public string DisplayName1 { get => DisplayName; set => DisplayName = value; }
        public string Type1 { get => Type; set => Type = value; }
    }
}
