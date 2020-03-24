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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打开对话框
            //OpenFileDialog open = new OpenFileDialog();//打开文件对话框的类
            //open.Title = "请选择你所操作的文件"; //弹跳出来的框的标题
            //open.InitialDirectory = @"G\";   //默认盘符
            ////open.Multiselect = true;//选多个文件
            //open.Filter = "媒体文件|*.mp3|视频文件|*.mp4|其他|*.txt";  //文件类型
            //open.ShowDialog();

            //string path = open.FileName;

            //if (path.Length <= 0)
            //{
            //    return;
            //}
            //using(FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Read))
            //{
            //   // textBox1.Text = path;
            //    byte[] buffer = new byte[1024 * 1024 * 5];//缓存区大小
            //    int r = fsRead.Read(buffer, 0, buffer.Length);//读出有效字节数
            //    textBox1.Text = Encoding.Default.GetString(buffer, 0, r);

            //}

            //保存对话框

            //SaveFileDialog open = new SaveFileDialog();//保存文件对话框的类
            //open.Title = "选择保存路径";
            //open.InitialDirectory = @"G:\c#\第十四章\图片"; //默认保存路径
            //open.Filter = "文本文件|*.txt|所有文件|*.*";
            //open.ShowDialog();//显示对话框

            //string path = open.FileName;
            //if (path.Length <= 0)
            //    return;

            //using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    //缓冲池 写入的时候，是将内容放在里面
            //    //读取的时候，只是申请一个空的缓冲池
            //    byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text); 
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //textBox1.Clear();
            //MessageBox.Show("保存成功");
            //FontDialog font = new FontDialog();
            //font.ShowDialog();
            //textBox1.Font = font.Font;
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            textBox1.ForeColor = color.Color;
           
        }
    }
}
