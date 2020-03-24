using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AdminSystem
{
   public class MyVar
    {

        string path = @"Data Source=LAPTOP-5IHIBBCL\SQLSERVER2014;Initial Catalog=demo;Persist Security Info=True;User ID=sa;Password=281164czq";
        public int Show(string sql)
        {
            using(SqlConnection sqlcon = new SqlConnection(path))
            {
                using(SqlCommand sqlcmd = new SqlCommand(sql, sqlcon))
                {
                    sqlcon.Open();
                    return sqlcmd.ExecuteNonQuery(); //根据sql语句的信息进行相关操作 找到对应内容操作后完返回1
                }
            }
        }
    }
}
