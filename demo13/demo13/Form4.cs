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
    public partial class Form4 : Form
    {
        int i = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (PlayMusic.Text == "播放音乐")
            {
               
                sp.SoundLocation = @"G:\c#\第十四章\半城烟沙.wav";
                sp.Play();
                PlayMusic.Text = "停止播放";
            }
           else if(PlayMusic.Text == "停止播放")
            {
                sp.Stop();
                PlayMusic.Text = "播放音乐";
            }
        }

        private void picPicture_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            picPicture.Load(@"G:\c#\第十四章\图片\1.jpg");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (i <9)
            {
                picPicture.Load(@"G:\c#\第十四章\图片\"+ ++i + ".jpg");
            }
            else if(i >=9)
            {
               
                picPicture.Load(@"G:\c#\第十四章\图片\1.jpg");
                i = 1;
            }
        }

        private void Last_Click(object sender, EventArgs e)
        {
            if (i >=1)
            {
                if(i == 1)
                {
                    i = 9;
                    picPicture.Load(@"G:\c#\第十四章\图片\9.jpg");
                }
                else
                    picPicture.Load(@"G:\c#\第十四章\图片\" + --i + ".jpg");
            }
           
        }
    }
}
