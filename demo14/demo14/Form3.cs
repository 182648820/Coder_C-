using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo14
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i + "月");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();//清除之前生成的，保证选项只是以下选项
            //string[] items = { "周一", "周二", "周三" };
            //comboBox1.Items.AddRange(items); //添加选项
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //因为窗体只加载一次，不需要清除之前的生成
            int time = DateTime.Now.Year;
            for (int i = time; i >= 1949; i--)
            {
                comboBox1.Items.Add(i + "年");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int newday = Convert.ToInt32(comboBox2.Text.Split('月')[0]);
            int newyear = Convert.ToInt32(comboBox1.Text.Split('年')[0]);
           
            comboBox3.Items.Clear();
            if (newday == 2)
            {
                if ((newyear % 4 == 0 && newyear % 100 != 0) || newyear % 400 == 0)
                {
                    for (int i = 1; i <= 29; i++)
                    {
                        comboBox3.Items.Add(i + "天");
                    }
                }
                else
                {
                    for (int i = 1; i < 29; i++)
                    {
                        comboBox3.Items.Add(i + "天");
                    }
                }
            }
            else if (newday == 4 || newday == 6 || newday == 9 || newday == 11)
            {
                for (int i = 1; i <= 30; i++)
                {
                    comboBox3.Items.Add(i + "天");
                }
            }
            else
            {
                for (int i = 1; i <= 31; i++)
                {
                    comboBox3.Items.Add(i + "天");
                }
            }
        }
    }
}
