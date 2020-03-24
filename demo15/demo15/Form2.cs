using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        bool b = false;
        private void Start_Click(object sender, EventArgs e)
        {
           
            if(b)
            {
                b = false;
                Start.Text = "开始";
            }
            else
            {
                b = true;
                Start.Text = "停止";
            }
            Thread th = new Thread(RandomNum);
            th.IsBackground = true; //后台线程
            th.Start(); //子线程开始
        }
        private void RandomNum()
        {
            
            Random rNum = new Random();//定义一个生成随机数的类
            
            while (b)
            {
             
                label1.Text = rNum.Next(1, 10).ToString();
                label2.Text = rNum.Next(1, 10).ToString();
                label3.Text = rNum.Next(1, 10).ToString();
            }
            //设置中奖
            if(label1.Text == label2.Text)
            {
                if (label2.Text == label3.Text)
                    MessageBox.Show("恭喜你中奖了");
            }
        }
    }
}
