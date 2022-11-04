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
    public class BUS_HoaDon
    {
        DAO.DataAccess da = new DAO.DataAccess();
        public DataTable HienThiCTHoaDon(string sohd)
        {
            DataTable dt = new DataTable();
            string sql = "select tSanPham.MaSP, TenSP,SLBan, DonGiaBan," +
                "SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100 as TongTien from tChiTietHDB,tSanPham " +
                "where tSanPham.MaSP = tChiTietHDB.MaSP and SoHDB = '" + sohd + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable HienThiNV(string user)
        {
            DataTable dt = new DataTable();
            string sql = "select MaNV, TenNV from tNhanVien where Username = '" + user + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable HienThiKH()
        {
            DataTable dt = new DataTable();
            string sql = "select MaKH, MaKH + ' | ' + TenKH as 'TTKH', MaKH from tKhachHang";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable HienThiSP(string tensp )
        {
            DataTable dt = new DataTable();
            string sql = "select MaSP,DonGiaBan from tSanPham where TenSP = '"+tensp+"'";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemCTHD(string sohdb, string masp, int sl, string km)
        {
            string sql = "insert tChiTietHDB values (N'" + sohdb + "', N'" + masp + "','" + sl + "','" + km + "')";
            da.DataChange(sql);
        }
        public void XoaSP(string masp)
        {
            string sql = "delete tChiTietHDB where MaSP = '" + masp + "'";
            da.DataChange(sql);
        }
        public void SuaCTHD(string sohdb, int sl, string km)
        {
            string sql = "update tChiTietHDB set SLBan = '" + sl + "', Khuyenmai = '" + km + "' " +
                "where Sohdb = '" + sohdb + "'";
            da.DataChange(sql);
        }
        public DataTable HienThiThanhTien(string sohd)
        {
            DataTable dt = new DataTable();
            string sql = "select sum(SLBan*DonGiaBan -Khuyenmai*(SLBan*DonGiaBan)/100) as ThanhTien " +
                "from tChiTietHDB, tSanPham where tSanPham.MaSP = tChiTietHDB.MaSP and SoHDB  ='" + sohd + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public void XoaCTHD(string sohdb)
        {
            string sql = "delete tChiTietHDB where SoHDB = '" + sohdb + "'";
            da.DataChange(sql);
        }
        

    }
}
