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

namespace demo14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory(@"G:\source\newtex"); //创建一个文件夹
            //MessageBox.Show("创建文件夹成功");
            //Directory.Delete(@"G:\source\newtex", true);//删除文件夹,当没有文件时抛出异常
            //MessageBox.Show("删除成功");
            //Directory.Move("目标路径","移动文件原本的路径")
            //string[] path = Directory.GetFiles(@"G:\c#\第十五章\mp3","*.mp3");//获取mp3文件夹中的所有文件信息
            //for (int i = 0; i < path.Length; i++)
            //{
            //    textBox1.AppendText(path[i]+'\n');
            //}
            if(Directory.Exists(@"G:\source\app"))//判断路径是否存在
            {
                for (int i = 0; i < 5; i++)
                {
                    Directory.CreateDirectory(@"G:\source\app\"+i);//创建文件夹
                }
                MessageBox.Show("创建完成");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
