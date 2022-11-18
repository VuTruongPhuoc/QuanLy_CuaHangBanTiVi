using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_BaoCaoDoanhThu
    {
        DAO.DataAccess da = new DAO.DataAccess();
        public DataTable BaoCaoDoanhThuThang(int thang, int nam)
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.BaoCaoDoanhThuThang('"+thang+"','"+nam+"')";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable BaoCaoDoanhThuNam(int nam)
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.BaoCaoDoanhThuNam('"+nam+"')";
            dt = da.DataReader(sql);
            return dt;
        }
    }
}
