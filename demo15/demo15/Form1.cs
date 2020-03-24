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

namespace demo15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();//打开对话框

            file.Title = "选择文件";  //对话框标题
            file.Multiselect = true;  //可以多选文件
            file.Filter = "音乐文件|*.wav|所有文件|*.*";
            file.InitialDirectory = @"G:\";  //默认盘符
            file.ShowDialog();


            path = file.FileNames; ; //获取文件路径 【包括文件名+扩展名】

            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path[i])); //将Listbox的选项内容设置为所获取的文件名+扩展名

            }
            
        }
        SoundPlayer playMusic = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
            playMusic.SoundLocation = path[listBox1.SelectedIndex];//根据Listbox中的索引 找到对应的文件路径
            playMusic.Play();

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //获取当前播放的索引值
            ++index;
            if (index == listBox1.Items.Count) //当索引值等于播放个数时，就重置0
                index = 0;
            listBox1.SelectedIndex = index;
            playMusic.SoundLocation = path[listBox1.SelectedIndex];//根据Listbox中的索引 找到对应的文件路径
            playMusic.Play();
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //获取当前播放的索引值
            --index;
            if (index <0) //当索引值等于播放个数时，就重置0
                index = listBox1.Items.Count-1;
            listBox1.SelectedIndex = index;
            playMusic.SoundLocation = path[listBox1.SelectedIndex];//根据Listbox中的索引 找到对应的文件路径
            playMusic.Play();
        }
    }
}
