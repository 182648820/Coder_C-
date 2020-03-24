using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo14
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process[] pros = Process.GetProcesses();//获取现在启动的所有进程
            //foreach (var item in pros)
            //{
            //   // item.Kill();//杀死所有进程，会导致电脑死机
            //    totalPe.AppendText(item.ToString()); //将进程添加到textbox文本框中
            //}
            //Process.Start("calc");//打开计算器
            //Process.Start("mspaint");//打开画图
            //Process.Start("notepad");//打开记事本
            //Process.Start("iexplore"); //打开IE浏览器

            //如果不加子线程，那么主线程就会跑去执行循环
            //如果加了子线程，那么窗口就不会假死，而被我们的子线程控制
            Thread td = new Thread(Tset);//创建一个线程来管理我们的窗口
           // td.IsBackground = true;  //前台线程变成后台线程
            td.Start();
            
        }
        public void Tset()
        {
            for (int i = 0; i < 100000; i++)//在我们点击按钮的时候，主线程跑去执行循环
            {
                //因为totalPe.Text属于主线程的东西
                //而我们要用子线程访问它，那么就会造成跨线程访问，会导致直接抛出异常
                //  totalPe.Text = i.ToString(); //这样会报错
                Console.WriteLine(i);
            }
        }
    }
}
