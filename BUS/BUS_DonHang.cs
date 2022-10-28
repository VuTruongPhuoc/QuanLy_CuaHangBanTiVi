using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public DataView TimKiemDonHang(string tk)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();

            dt = HienThiDonHang();
            dv = dt.DefaultView;
            dv.RowFilter = "SoHDB like '%" + tk + "%' or MaKH like '%" + tk + "%' or NgayLap = '" + tk + "'";
            
            return dv;
        }
    }
}
