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
    public class BUS_DoanhThu
    {
        DAO.DataAccess da = new DataAccess();

        public DataTable HienThiDoanhThu()
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.DoanhThuTheoNam()";
            dt = da.DataReader(sql);
            return dt;
        }
    }
}
