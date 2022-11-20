using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_DonNhap
    {
        DataAccess da = new DataAccess();

        public DataTable HienThiDonNhap()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tHoaDonNhap";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemDonNhap(string sohdn, string mancc, string manv, string ngaynhap, double trigia)
        {
            string sql = "insert tHoaDonNhap values(N'" + sohdn + "',null,N'" + manv + "','" + ngaynhap + "', '" + trigia + "')";
            da.DataChange(sql);
        }
        public void SuaDonNhap(string sohdb, string mancc, string manv, double trigia)
        {
            string sql = "update tHoaDonNhap set MaNCC = '" + mancc + "', MaNV = '" + manv + "', ThanhTien = '" + trigia + "'" +
                "where SoHDN = '" + sohdb + "'";
            da.DataChange(sql);
        }
        public DataTable HienThiMaNV(string user)
        {
            DataTable dt = new DataTable();
            string sql = "select MaNV from tNhanVien where username = '" + user + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable TimKiemDonNhap(string tk)
        {
            DataTable dt = new DataTable();

            string sql = "select * from tHoaDonNhap where SoHDN like '%" + tk + "%' or MaNCC like '%" + tk + "%' CONVERT(nvarchar,NgayNhap,101) like '%" + tk + "%'";
            dt = da.DataReader(sql);
            return dt;
        }
    }
}
