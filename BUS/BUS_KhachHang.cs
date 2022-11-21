using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAO.DataAccess da = new DAO.DataAccess();

        public DataTable HienThiKhachHang()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tKhachHang";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemKhachHang(string MaKh, string TenKh, string GioiTinh, string sdt, string DiaChi)
        {
            string sql = "insert tKhachHang values(N'" + MaKh + "', N'" + TenKh + "', N'" + GioiTinh + "',N'" + sdt + "', N'" + DiaChi + "')";
            da.DataChange(sql);
        }
        public void SuaKhachHang(string MaKh, string TenKh, string GioiTinh, string sdt, string DiaChi)
        {
            string sql = "update tKhachHang set TenKh = N'" + TenKh + "', GioiTinh = N'" + GioiTinh + "', DienThoai = N'" + sdt + "'" +
                ", DiaChi = N'" + DiaChi + "' where MaKh = N'" + MaKh + "'";
            da.DataChange(sql);
        }
        public void XoaKhachHang(String MaKh)
        {
            string sql = "delete from tKhachHang where MaKh = '" + MaKh + "'";
            da.DataChange(sql);
        }
        public bool KiemTraTrungMaKH(string MaKH)
        {
            string MaBang = "tKhachHang";
            string TenBang = "MaKH";
            if (da.check(MaBang, TenBang, MaKH)) return true;
            return false;
        }

        public DataView TimKiemKhachHang(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();

            dt = HienThiKhachHang();
            dv = dt.DefaultView;
            dv.RowFilter = "MaKh like '%" + tk + "%' or TenKh like '%" + tk + "%' or GioiTinh like '%" + tk + "%' or DienThoai like '%" + tk + "%' or DiaChhi like '%" + tk + "%'";
            return dv;
        }
    }

}
