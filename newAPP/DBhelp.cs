using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DBhelp
    {
        SqlConnection conn;
        SqlCommand cmd;
        public void connect(string severIp, string dbName)
        {
            //---连接字符串
            string connstring = "Data Source=" + severIp + ";Initial Catalog=" + dbName + ";Integrated Security=True";
            //创建连接对象
            conn = new SqlConnection(connstring);
            //打开数据连接
            conn.Open();
            //设置命令对象
            cmd = conn.CreateCommand();
        }
        public int executeNonQuery(string sqlStr)
        {
            cmd.CommandText = sqlStr;
            int tmp;
            try
            {
                tmp = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                tmp = -1;
            }
            return tmp;
        }
        public SqlDataReader queryData(string sqlStr)
        {
            cmd.CommandText = sqlStr;
            SqlDataReader tmp = cmd.ExecuteReader();
            return tmp;
        }
        public void close()
        {
            conn.Close();
        }
    }

}
