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
    public class BUS_HoaDonBan
    {
        DAO.DataAccess da = new DAO.DataAccess();
        public DataTable HienThiCTHoaDon(string sohd)
        {
            DataTable dt = new DataTable();
            string sql = "select tSanPham.MaSP, TenSP,SLBan, DonGiaBan," +
                "format(SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100,'N','en-US') as TongTien from tChiTietHDB,tSanPham " +
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
            string sql = "select MaKH, MaKH + ' | ' + TenKH as 'TTKH' from tKhachHang";
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
        public void XoaSP(string sohdb, string masp)
        {
            string sql = "delete tChiTietHDB where SoHDB = '" + sohdb+"' and MaSP = '" + masp + "'";
            da.DataChange(sql);
        }
        public DataTable HienThiThanhTien(string sohd)
        {
            DataTable dt = new DataTable();
            string sql = "select format(sum(SLBan*DonGiaBan -Khuyenmai*(SLBan*DonGiaBan)/100),'N','en-US') as ThanhTien " +
                "from tChiTietHDB, tSanPham where tSanPham.MaSP = tChiTietHDB.MaSP and SoHDB  ='" + sohd + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable HienThiThongTinExport(string sohdb)
        {
            DataTable dt = new DataTable();
            string sql = "select SoHDB, TenKH, DiaChi, DienThoai, NgayLap from tHoaDonBan as hdb, tKhachHang as kh " +
                "where hdb.MaKH = kh.MaKH and " +
                "SoHDB = '" + sohdb + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public bool KiemTraTrungMaHDB(string mahdb)
        {
            string Tenbang = "tHoaDonBan";
            string Mabang = "SoHDB";
            if (da.check(Tenbang, Mabang, mahdb)) return true;
            return false;
        }
    }
}
