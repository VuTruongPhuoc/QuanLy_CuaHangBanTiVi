using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_CTHD
    {
        DAO.DataAccess da = new DAO.DataAccess();
        public DataTable HienThiTT(string sohdb)
        {
            DataTable dt = new DataTable();
            string sql = "select tNhanVien.MaNV + ' | ' + TenNV as TTNV,tKhachHang.MaKH + ' | ' + TenKH as TTKH, NgayLap,Khuyenmai " +
                "from tHoaDonBan,tChiTietHDB,tNhanVien,tKhachHang " +
                "where tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and " +
                "tHoaDonBan.MaNV = tNhanVien.MaNV and " +
                "tHoaDonBan.MaKH = tKhachHang.MaKH and " +
                "tHoaDonBan.SoHDB = '" + sohdb + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public void XoaHD(string sohdb)
        {
            string sql = "delete tChiTietHDB where SoHDB = '" + sohdb + "'";
            da.DataChange(sql);
            string sql1 = "delete tHoaDonBan where SoHDB = '" + sohdb + "'";
            da.DataChange(sql1);
        }
    }
}
