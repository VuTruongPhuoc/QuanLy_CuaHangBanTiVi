using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DonHang
    {
        DAO.DataAccess da = new DAO.DataAccess();
        public DataTable HienThiDonHang()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tHoaDonBan";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemDonHang(string sohdb, string manv, string makh, string ngayban, double trigia)
        {
            string sql = "insert tHoaDonBan values(N'" + sohdb + "', N'" + manv + "','" + makh + "','" + ngayban + "', '" + trigia + "')";
            da.DataChange(sql);
        }
        public void SuaDonHang(string sohdb, string manv, string makh,double trigia)
        {
            string sql = "update tHoaDonBan set MaNV = '" + manv + "', MaKH = '" + makh + "', ThanhTien = '" + trigia + "'" +
                "where SoHDB = '"+sohdb+"'";
            da.DataChange(sql);
        }
        public DataTable HienThiMaNV(string user)
        {
            DataTable dt = new DataTable();
            string sql = "select MaNV from tNhanVien where username = '" + user + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataView TimKiemDonHang(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();

            dt = HienThiDonHang();
            dv = dt.DefaultView;
            dv.RowFilter = "SoHDB like '%" + tk + "%' or MaKH like '%" + tk + "%'";
            
            return dv;
        }
    }
}
