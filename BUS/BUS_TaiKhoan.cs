using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public DataTable HienThiTaiKhoan(string tendn)
        {
            DataTable dt = new DataTable();
            string sql = "select * from tTaiKhoan,tNhanVien where tTaiKhoan.MaNV = tNhanVien.MaNV and Username = '"+ tendn +"'";
            dt = da.DataReader(sql); 
            return dt;
        }
        public void SuaTaiKhoan(string manv, string tennv, string sdt, string diachi)
        {
            string sql = "update tNhanVien set TenNV = '" + tennv + "', DienThoai = '" + sdt + "', DiaChi = '" + diachi + "'" +
                "where MaNV = '" + manv + "'";
            da.DataChange(sql);
        }
        public void SuaTenDN(string manv, string username)
        {
            string sql = "update tTaiKhoan set Username = '" + username + "' where MaNV = '" + manv + "'";
            da.DataChange(sql);
        } 
        public void DoiMatKhau(string username, string password)
        {
            string sql = "update tTaiKhoan set Password = '" + password + "' where Username = '" + username + "'";
            da.DataChange(sql);
        }
    }
}
