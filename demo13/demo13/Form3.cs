using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Acount_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            #region 单选框
            //if (Teacher.Checked)
            //{
            //    if (Acount.Text.Length <= 0 || Password.Text.Length <= 0)
            //    {
            //        MessageBox.Show("账号或者密码不能为空");
            //    }
            //    if (Acount.Text == "Teacher" && Password.Text == "Teacher")
            //    {
            //        MessageBox.Show("老师登录成功");
            //    }
            //    else
            //    {
            //        MessageBox.Show("你的账号或者密码出错");
            //        Acount.Clear();//清空输入的账号
            //        Password.Clear();//清空输入的密码
            //        Acount.Focus(); //获取焦点
            //    }
            //} 
            //else
            //{
            //    if (Acount.Text.Length <= 0 || Password.Text.Length <= 0)
            //    {
            //        MessageBox.Show("账号或者密码不能为空");
            //    }
            //    if (Acount.Text == "Student" && Password.Text == "Student")
            //    {
            //        MessageBox.Show("学生登录成功");
            //    }
            //    else
            //    {
            //        MessageBox.Show("你的账号或者密码出错");
            //        Acount.Clear();//清空输入的账号
            //        Password.Clear();//清空输入的密码
            //        Acount.Focus(); //获取焦点
            //    }
            //} 
            #endregion

            #region 多选框
            if (ckTeacher.Checked)
            {
                if (Acount.Text.Length <= 0 || Password.Text.Length <= 0)
                {
                    MessageBox.Show("账号或者密码不能为空");
                }
                if (Acount.Text == "Teacher" && Password.Text == "Teacher")
                {
                    MessageBox.Show("老师登录成功");
                }
                else
                {
                    MessageBox.Show("你的账号或者密码出错");
                    Acount.Clear();//清空输入的账号
                    Password.Clear();//清空输入的密码
                    Acount.Focus(); //获取焦点
                }
            }
            else
            {
                if (Acount.Text.Length <= 0 || Password.Text.Length <= 0)
                {
                    MessageBox.Show("账号或者密码不能为空");
                }
                if (Acount.Text == "Student" && Password.Text == "Student")
                {
                    MessageBox.Show("学生登录成功");
                }
                else
                {
                    MessageBox.Show("你的账号或者密码出错");
                    Acount.Clear();//清空输入的账号
                    Password.Clear();//清空输入的密码
                    Acount.Focus(); //获取焦点
                }
            }
            #endregion


        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Teacher_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ckTeacher.Checked = true;
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(ckTeacher.Checked ==true)

            {
                ckStudent.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (ckStudent.Checked == true)

            {
                ckTeacher.Checked = false;
            }
        }
    }
}
