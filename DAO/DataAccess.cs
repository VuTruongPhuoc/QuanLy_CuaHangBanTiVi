using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataAccess
    {
        string str = "Data Source=DESKTOP-V6QRKTP\\SQL;Initial Catalog=Quanli_CuaHangBanTV;Integrated Security=True";
        SqlConnection conn = null;

        public void Connect()
        {
            conn = new SqlConnection(str);
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Closed()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public DataTable DataReader(string select)
        {
            DataTable dt = new DataTable();
            Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(select, conn);
            adapter.Fill(dt);
            Closed();
            return dt;
        }
        public void DataChange(string sql)
        {
            Connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            Closed();
        }
        public bool check(string Tenbang, string MaBang, string sp)
        {
            DataTable dt = new DataTable();
            string sql = "select * from " + Tenbang + " where " + MaBang + " = '" + sp + "'";
            dt = DataReader(sql);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
    }
}
