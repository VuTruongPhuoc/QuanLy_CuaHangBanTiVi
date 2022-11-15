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
    public class BUS_ThongKe
    {
        DAO.DataAccess da = new DataAccess();

        public DataTable HienThiDoanhThu(int nam)
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.DoanhThuTheoNam('"+nam+"')";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable DoanhThuTheoThang(int thang, int nam)
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.DoanhThuTheoThang('"+thang+"', '"+nam+"')";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable DoanhThuTheoTungQuy(int nam)
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.DoanhThuTheoTungQuy('"+nam+"')";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable SoLuongMatHangBan(DateTime ngayd, DateTime ngayc)
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.MatHangBanRa('"+ngayd+"', '"+ngayc+ "') order by SoLuongBan desc";
            dt = da.DataReader(sql);
            return dt;
        }
        public DataTable DoanhThuMatHang(DateTime ngayd, DateTime ngayc)
        {
            DataTable dt = new DataTable();
            string sql = "select * from dbo.DoanhThuTungMatHang('"+ngayd+"', '"+ngayc+"')";
            dt = da.DataReader(sql);
            return dt;
        }
    }
}
