using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAO;
using System.Net.NetworkInformation;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAO.DataAccess da = new DAO.DataAccess();

        public DataTable HienThiNhanVien()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tNhanVien";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemNhanVien(string manv, String tennv, string ngaysinh, string dienthoai, string diachi,string tk, string mk, int LoaiTaiKhoan)
        {
            string sql = "insert tNhanVien values(N'" + manv + "', N'" + tennv + "', N'" + ngaysinh + "', N'" + dienthoai + "', N'" + diachi + "',N'" + tk + "',N'" + mk + "', '" + LoaiTaiKhoan + "')";
            da.DataChange(sql);
        }
        public void SuaNhanVien(string manv, String tennv, string ngaysinh, string dienthoai, string diachi, string tk, string mk, int LoaiTaiKhoan)
        {
            string sql = "update tNhanVien set TenNV = N'" + tennv + "',NgaySinh = N'" + ngaysinh + "', DienThoai = N'" + dienthoai + "'" +
                ", DiaChi = N'" + diachi + "',Username = N'" + tk + "',Password = N'" + mk + "' '" + LoaiTaiKhoan + "' where MaNV = N'" + manv + "'";
            da.DataChange(sql);
        }
        public void XoaNhanVien(string manv)
        {
            string sql = "delete tNhanVien where MaNV = N'" + manv + "'";
            da.DataChange(sql);
        }
        public bool KiemTraTrungMaNV(string manv)
        {
            string TenBang = "tNhanVien";
            string MaBang = "MaNV";
            if (da.check(TenBang, MaBang, manv)) return true;
            return false;
        }
        public DataView TimKiemNhanVien(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();

            dt = HienThiNhanVien();
            dv = dt.DefaultView;
            dv.RowFilter = "MaNV like '%" + tk + "%' or TenNV like '%" + tk + "%' or DienThoai like '%" + tk + "%' or " +
                "DiaChi like '%" + tk + "%'";
            return dv;
        }
    }
}
