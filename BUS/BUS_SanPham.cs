using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_SanPham
    {
        DAO.DataAccess da = new DAO.DataAccess();

        public DataTable HienThiSanPham()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tSanPham";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemSanPham(string MaSP, string TenSP, string ThuongHieuSX, string KichThuoc, string ManHinh, int SoLuong, double DonGiaNhap, double DonGiaBan, string HinhAnh, string GhiChu)
        {
            string sql = "insert tSanPham values ( N'" + MaSP + "', N'" + TenSP + "', N'" + ThuongHieuSX + "', N'" + KichThuoc + "'" +
                ", N'" + ManHinh + "', '" + SoLuong + "', '" + DonGiaNhap + "', '" + DonGiaBan + "', N'" + HinhAnh + "', N'" + GhiChu + "' )";
            da.DataChange(sql);
        }
        public void SuaSanPham(string MaSP, string TenSP, string ThuongHieuSX, string KichThuoc, string ManHinh, int SoLuong, double DonGiaNhap, double DonGiaBan, string HinhAnh, string GhiChu)
        {
            string sql = "update tSanPham set TenSP = N'" + TenSP + "', MaTH = N'" + ThuongHieuSX + "', KichThuoc = N'" + KichThuoc + "'" +
                ",ManHinh = N'" + ManHinh + "', SoLuong = '" + SoLuong + "', DonGiaNhap = '" + DonGiaNhap + "', DonGiaBan = '" + DonGiaBan + "'" +
                ",HinhAnh = N'" + HinhAnh + "', GhiChu = N'" + GhiChu + "' where MaSP = N'" + MaSP + "'";
            da.DataChange(sql);
        }
        public void XoaSanPham(string MaSP)
        {
            string sql = "Delete tSanPham where MaSP = N'" + MaSP + "'";
            da.DataChange(sql);
        }
        public bool KiemTraTrungMaSP(string MaSP)
        {
            string Tenbang = "tSanPham";
            string Mabang = "MaSP";
            if (da.check(Tenbang, Mabang, MaSP)) return true;
            return false;
        }
        public DataView TimKiemSanPham(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();
            //string sql = "select * from tSanPham where is not null and MaSP like '%" + tk + "%' or TenSP like '%" + tk + "%' or ThuongHieuSX like '%" + tk +"%' " +
            //    "or KichThuoc like '%" + tk + "%' or ManHinh like '%" + tk + "%'";
            dt = HienThiSanPham();
            dv = dt.DefaultView;
            dv.RowFilter = "MaSP like '%" + tk + "%' or TenSP like '%" + tk + "%'or MaTH like '%" + tk + "%' " +
            "or KichThuoc like '%" + tk + "%' or ManHinh like '%" + tk + "%'";
            return dv;
        }
    }
}
