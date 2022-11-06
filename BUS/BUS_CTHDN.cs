using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_CTHDN
    {
        DAO.DataAccess da = new DAO.DataAccess();
        public DataTable HienThiTT(string sohdb)
        {
            DataTable dt = new DataTable();
            string sql = "select tNhanVien.MaNV + ' | ' + TenNV as TTNV,tNhaCungCap.MaNCC + ' | ' + TenNCC as TTNCC, NgayNhap,Khuyenmai " +
                "from tHoaDonNhap,tChiTietHDN,tNhanVien,tNhaCungCap " +
                "where tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN and " +
                "tHoaDonNhap.MaNV = tNhanVien.MaNV and " +
                "tHoaDonNhap.MaNCC = tNhaCungCap.MaNCC and " +
                "tHoaDonNhap.SoHDN = '" + sohdb + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public void XoaHDN(string sohdn)
        {
            string sql = "delete tChiTietHDN where SoHDN = '" + sohdn + "'";
            da.DataChange(sql);
            string sql1 = "delete tHoaDonNhap where SoHDN = '" + sohdn + "'";
            da.DataChange(sql1);
        }
    }
}
