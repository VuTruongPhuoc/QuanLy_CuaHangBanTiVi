using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAO.DataAccess da = new DAO.DataAccess();

        public DataTable HienThiNV(string user)
        {
            DataTable dt = new DataTable();
            string sql = "select tNhanVien.MaNV, TenNV from tNhanVien,tTaiKhoan where tNhanVien.MaNV = tTaiKhoan.MaNV and Username = '" + user + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable HienThiKH()
        {
            DataTable dt = new DataTable();
            string sql = "select MaKH + ' | ' + TenKH as 'TTKH', MaKH from tKhachHang";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable HienThiGiaSP(string tensp)
        {
            DataTable dt = new DataTable();
            string sql = "select DonGiaBan from tSanPham where TenSP = '"+tensp+"'";
            dt = da.DataReader(sql);
            return dt;
        }
    }
}
