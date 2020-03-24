using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo13
{
    public partial class Form5 : Form
    {
        int i = 1;
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(@"G:\c#\第十四章\图片\1.jpg");
            pictureBox2.Load(@"G:\c#\第十四章\图片\1.jpg");
            pictureBox3.Load(@"G:\c#\第十四章\图片\1.jpg");
            pictureBox4.Load(@"G:\c#\第十四章\图片\1.jpg");
            pictureBox5.Load(@"G:\c#\第十四章\图片\1.jpg");
            pictureBox6.Load(@"G:\c#\第十四章\图片\1.jpg");
            pictureBox7.Load(@"G:\c#\第十四章\图片\1.jpg");
            pictureBox8.Load(@"G:\c#\第十四章\图片\1.jpg");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (Music.Text == "播放音乐")
            {

                sp.SoundLocation = @"G:\c#\第十四章\半城烟沙.wav";
                sp.Play();
                Music.Text = "停止播放";
            }
            else if (Music.Text == "停止播放")
            {
                sp.Stop();
                Music.Text = "播放音乐";
            }
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (i > 9)
            {
                i = 1;
            }
            pictureBox1.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            pictureBox2.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            pictureBox3.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            pictureBox4.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            pictureBox5.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            pictureBox6.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            pictureBox7.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            pictureBox8.Load(@"G:\c#\第十四章\图片\" + i + ".jpg");
            ++i;

        }
    }
}
