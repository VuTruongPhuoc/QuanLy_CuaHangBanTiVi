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
            string sql = "insert tHoaDonNhap values(N'" + sohdn + "', N'" + mancc + "','" + manv + "','" + ngaynhap + "', '" + trigia + "')";
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
        public DataView TimKiemDonNhap(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();          
            dt = HienThiDonNhap();
            dv = dt.DefaultView;
            dv.RowFilter = "SoHDN like '%" + tk + "%', MaNCC like '%" + tk + "%'";
            return dv;
        }
    }
}
