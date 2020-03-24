using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo14
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        string[] path = Directory.GetFiles(@"G:\c#\第十五章\mp3", "*.wav");//获取图片文件夹中，所有.jpg格式的文件
        //方法一： 定义一个集合，存取获取来的路径
        List<string> list = new List<string>();
        private void Form4_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < path.Length; i++)
            {
                string infor = Path.GetFileName(path[i]); //获取文件名称，包括扩展名
                listBox1.Items.Add(infor);
                list.Add(path[i]);//寸的是地址 
            }
            //pictureBox1.Image = Image.FromFile(path[0]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //方法一：将集合中存放的路径 根据listBox1中的索引值，获得完整路径
            // pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);//直接用索引

            //方法二：不用集合存取，在path[]字符串集合中，存放的也是文件路径，直接通过listBox的索引值获取
            //  pictureBox1.Image = Image.FromFile(path[listBox1.SelectedIndex]);
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = path[listBox1.SelectedIndex];
            sp.Play();

        }
    }
}
