using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAO.DataAccess da = new DAO.DataAccess();

        string TenBang = "tAccount";
        string MaBang = "Username";
        public bool KiemTraUser(string tk)
        {
            if (da.check(TenBang, MaBang, tk)) return true;
            return false;
        }
        public void DoiMatKhau(string username, string password)
        {
            string sql = "update tAccount set password = '" + password + "' where username = '" + username + "'";
            da.DataChange(sql);
        }
    }
}
