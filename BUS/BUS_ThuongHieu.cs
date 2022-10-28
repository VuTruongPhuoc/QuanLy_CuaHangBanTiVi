using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThuongHieu
    {
        DAO.DataAccess da = new DataAccess();

        public DataTable HienThiTH()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tThuongHieu";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemTH(string MaTH, string TenTH)
        {
            string sql = "insert tThuongHieu values(N'" + MaTH + "', N'" + TenTH + "')";
            da.DataChange(sql);
        }
        public void SuaTH(string MaTH, string TenTH)
        {
            string sql = "update tThuongHieu set TenTH = N'" + TenTH + "' where MaTH = N'" + MaTH + "'";
            da.DataChange(sql);
        }
        public void XoaTH(string MaTH)
        {
            string sql = "delete tThuongHieu where MaTH = N'" + MaTH + "'";
            da.DataChange(sql);
        }
        public bool KiemTraTrungMaTH(string MaTH)
        {
            string TenBang = "tThuongHieu";
            string MaBang = "MaTH";
            if (da.check(TenBang, MaBang, MaTH)) return true;
            return false;
        }
        public DataView TimKiemTH(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();

            dt = HienThiTH();
            dv = dt.DefaultView;
            dv.RowFilter = "MaTH like '%" + tk + "%' or TenTH like '%" + tk + "%'";
            return dv;
        }
    }
}
