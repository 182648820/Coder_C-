using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MyVar mysql = new MyVar(); //定义一个myVar类
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Name.Text.Length <= 0)
            {
                MessageBox.Show("请输入下面相关信息");
                return;
            }
            else
            {

                if (mysql.Show("insert into Person(Name, Age, Sex) values('" + Name.Text + "', '" + Age.Text + "', '" + Sex.Text + "')") > 0)
                {
                    MessageBox.Show("添加成功");
                    Name.Clear();
                    Age.Clear();
                    Sex.Clear();
                    readContent.Items.Clear();
                    read();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("请输入你要删除的姓名");
            if (mysql.Show("delete from Person where Name = '" + Name.Text + "'") > 0)
            {
                MessageBox.Show("删除成功");
                Name.Clear();
                readContent.Items.Clear();
                read();

            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            if (txtID.Text.Length <= 0)
            {
                MessageBox.Show("请输入要修改的编号");
                return;
            }
            else
            {
                if (mysql.Show("update Person set Name='" + Name.Text + "', Age = '" + Age.Text + "',Sex = '" + Sex.Text + "' where ID='" + txtID.Text + "' ") > 0)
                {
                    MessageBox.Show("修改成功");
                    Name.Clear();
                    txtID.Clear();
                    Age.Clear();
                    Sex.Clear();
                    readContent.Items.Clear();
                    read();

                }
                else
                {
                    MessageBox.Show("没有该内容");
                }
            }

        }
        public void read()
        {
            using (SqlConnection mycon = new SqlConnection())
            {
                using (SqlCommand mycmd = new SqlCommand())
                {
                    string path = @"Data Source=LAPTOP-5IHIBBCL\SQLSERVER2014;Initial Catalog=demo;Persist Security Info=True;User ID=sa;Password=281164czq";

                    mycon.ConnectionString = path;
                    mycon.Open();
                    mycmd.CommandText = "select * from Person";
                    mycmd.Connection = mycon;

                    SqlDataReader reader = mycmd.ExecuteReader();
                    readContent.Items.Add("ID\t 姓名\t 年龄\t 性别");
                    //readContent.Items.Add("************************");
                    while (reader.Read()) //类似i++
                    {
                        readContent.Items.Add(String.Format("{0}\t {1}\t {2}\t {3}", reader[0], reader[1], reader[2], reader[3]));

                    }
                }

            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            read();
        }


    }

}