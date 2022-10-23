using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class BUS_DangNhap
    {
        DataAccess da = new DataAccess();

        public bool Check_Login(string UserName, string PassWord)
        {
            string sql = "select * from tTaiKhoan where Username = N'" + UserName + "' and Password = N'" + PassWord + "'";
            DataTable dt = new DataTable();
            dt = da.DataReader(sql);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
        public bool IsAdmin(string UserName, string PassWord)
        {
            string sql = "select * from tNhanVien,tTaiKhoan where tNhanVien.MaNV = tTaiKhoan.MaNV and Username = N'" + UserName + "' and Password = N'" + PassWord + "' and LoaiTaiKhoan = 1";
            DataTable dt = new DataTable();
            dt = da.DataReader(sql);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
    }
}
