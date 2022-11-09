using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDonNhap
    {
        DAO.DataAccess da = new DAO.DataAccess();
        public DataTable HienThiCTHDN(string sohd)
        {
            DataTable dt = new DataTable();
            string sql = "select tSanPham.MaSP as MaSP, TenSP,SLNhap, DonGiaNhap," +
                "format(SLNhap*DonGiaNhap - Khuyenmai*(SLNhap*DonGiaNhap)/100,'N','en-US') as TongTien from tChiTietHDN,tSanPham " +
                "where tSanPham.MaSP = tChiTietHDN.MaSP and SoHDN = '" + sohd + "'";
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
        public DataTable HienThiNCC()
        {
            DataTable dt = new DataTable();
            string sql = "select MaNCC, MaNCC + ' | ' + TenNCC as 'TTNCC' from tNhaCungCap";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable HienThiSP(string tensp)
        {
            DataTable dt = new DataTable();
            string sql = "select MaSP,DonGiaNhap from tSanPham where TenSP = '" + tensp + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemCTHDN(string sohdb, string mancc, int sl, string km)
        {
            string sql = "insert tChiTietHDN values (N'" + sohdb + "', N'" + mancc + "','" + sl + "','" + km + "')";
            da.DataChange(sql);
        }
        public void XoaSP(string sohdn, string masp)
        {
            string sql = "delete tChiTietHDN where SoHDN = '" + sohdn + "' and MaSP = '" + masp + "'";
            da.DataChange(sql);
        }
        public DataTable HienThiThanhTien(string sohd)
        {
            DataTable dt = new DataTable();
            string sql = "select format(sum(SLNhap*DonGiaNhap -Khuyenmai*(SLNhap*DonGiaNhap)/100),'N','en-US') as ThanhTien " +
                "from tChiTietHDN, tSanPham where tSanPham.MaSP = tChiTietHDN.MaSP and SoHDN  ='" + sohd + "'";
            dt = da.DataReader(sql);
            return dt;
        }
        public bool KiemTraTrungMaHDN(string mahdn)
        {
            string Tenbang = "tHoaDonNhap";
            string Mabang = "SoHDN";
            if (da.check(Tenbang, Mabang, mahdn)) return true;
            return false;
        }
        public DataTable HienThiThongTinExport(string sohdn)
        {
            DataTable dt = new DataTable();
            string sql = "select SoHDN, TenNCC, DiaChi, DienThoai, NgayNhap from tHoaDonNhap as hdn, tNhaCungCap as ncc " +
                "where hdn.MaNCC = ncc.MaNCC and " +
                "SoHDN = '" + sohdn + "'";
            dt = da.DataReader(sql);
            return dt;
        }
    }
}
