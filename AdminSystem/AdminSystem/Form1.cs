using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //sqlServer数据使用声明

namespace AdminSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection mycon = new SqlConnection(); //创建sqlServer数据库连接类
            SqlCommand mycmd = new SqlCommand();  //创建数据库命令执行类

            string path = @"Data Source=LAPTOP-5IHIBBCL\SQLSERVER2014;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=281164czq"; //数据库路径  Data Source :数据源  

            //3.设置数据库连接路径 Data Sou:数据源
            //定义数据库连接路径
            mycon.ConnectionString = path;

            //4. 打开数据库
            mycon.Open();

            mycmd.CommandText = "select * from Book";  //获取数据库中的Book表数据
            mycmd.Connection = mycon;  //命令执行类的连接情况设置和mycon一样
            
            label1.Text = mycmd.ExecuteScalar().ToString();

            //ExecuteScalar 只能对数据库进行查询操作
            //ExecuteNonQuery:只可以对数据库进行增删改操作

            mycon.Close(); //关闭数据库连接

            //5.检查数据库连接状态和数据源连接状态是否相等 ：一样：打开成功

            //if(mycon.State == ConnectionState.Open)//ConnectionState：数据源当前的连接状态
            //{
            //    label1.Text = "成功连接SQLine数据库";
            //}
            //else
            //{
            //    label1.Text = "连接数据库失败";
            //}

        }
    }
}
