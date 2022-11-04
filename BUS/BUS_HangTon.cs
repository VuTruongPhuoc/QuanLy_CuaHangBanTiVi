using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_HangTon
    {
        DAO.DataAccess da = new DataAccess();
        public DataTable HienThiHangTon()
        {
            DataTable dt = new DataTable();
            string sql = "select TenSP, SoLuong from tSanPham";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataView TimKiemHangTon(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();
            dt = HienThiHangTon();
            dv = dt.DefaultView;
            dv.RowFilter = "TenSP like '%" + tk + "%'";
            return dv;
        }
    }
}
