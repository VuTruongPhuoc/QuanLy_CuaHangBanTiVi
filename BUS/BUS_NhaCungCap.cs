using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAO;

namespace BUS
{

    public class BUS_NhaCungCap
    {
        DAO.DataAccess da = new DataAccess();

        public DataTable HienThiNCC()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tNhaCungCap";
            dt = da.DataReader(sql);
            return dt;
        }
        public void ThemNCC(string MaNCC, string TenNCC)
        {
            string sql = "insert tNhaCungCap values(N'" + MaNCC + "', N'" + TenNCC + "')";
            da.DataChange(sql);
        }
        public void SuaNCC(string MaNCC, string TenNCC)
        {
            string sql = "update tNhaCungCap set TenNCC = N'" + TenNCC + "' where MaNCC = N'" + MaNCC + "'";
            da.DataChange(sql);
        }
        public void XoaNCC(string MaNCC)
        {
            string sql = "delete tNhaCungCap where MaNCC = N'" + MaNCC + "'";
            da.DataChange(sql);
        }
        public bool KiemTraTrungMaNCC(string MaNCC)
        {
            string TenBang = "tNhaCungCap";
            string MaBang = "MaNCC";
            if (da.check(TenBang, MaBang, MaNCC)) return true;
            return false;
        }
        public DataView TimKiemNCC(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();

            dt = HienThiNCC();
            dv = dt.DefaultView;
            dv.RowFilter = "MaNCC like '%" + tk + "%' or TenNCC like '%" + tk + "%'";
            return dv;
        }

    }
}
