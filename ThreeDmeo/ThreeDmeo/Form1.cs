using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBll;

namespace ThreeDmeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyBllDemo bllDemo = new MyBllDemo(); //定义有一个逻辑层BLL类
        private void btnAdd_Click(object sender, EventArgs e)
        {
           if( bllDemo.Infor(pName.Text, Age.Text, Sex.Text) > 0)//UI层调用BLL层的方法 ——>BLL层调用DAL层的同一方法
            {
                MessageBox.Show("添加成功");
            }
        }
    }
}
