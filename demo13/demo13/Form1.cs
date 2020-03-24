using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length <= 0 || txtPwd.Text.Length <= 0)
            {
                MessageBox.Show("账号或者密码不能为空");
            }
            if (txtName.Text == "zyx" && txtPwd.Text == "107")
            {
                btnSave.Visible = true;
                btnWrap.Visible = true;
                textBox.Visible = true;
            }
            else
            {
                MessageBox.Show("你的账号或者密码出错");
                txtName.Clear();//清空输入的账号
                txtPwd.Clear();//清空输入的密码
                txtName.Focus(); //获取焦点
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWrap_Click(object sender, EventArgs e)
        {
            if (btnWrap.Text == "自动换行")
            {
                textBox.WordWrap = true;
                btnWrap.Text = "取消自动换行";
            }
            else if (btnWrap.Text == "取消自动换行")
                textBox.WordWrap = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\晴雪\Desktop\new.txt", textBox.Text.Trim());
            MessageBox.Show("保存成功");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnWrap.Visible = false;
            textBox.Visible = false;
        }
    }
}
