using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaterDal;
using System.Data.SqlClient;

namespace myDal
{
   public class myDalDemo
    {
        public int Infor(string str_1, string str_2, string str_3)
        {
            //@name意思是这个值是可变的，正常情况上，要指定插入的值，加多@这个符号之后，就可以实现值可变操作了

            string sql = "insert into Person(Name, Age, Sex) values(@name, @age, @sex)";
            SqlParameter[] ps =
            {
               new SqlParameter("@name", str_1),
               new SqlParameter("@age", str_2),
               new SqlParameter("@sex", str_3)

            };   //初始化
            return SqliteHelper.ExecuteNonQuery(sql, ps);  //将sql操作语句发送到数据库中，最后将操作结果返回
        }
    }
}
