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

namespace demo16
{
    public partial class Form1 : Form
    {
        public static Form1 frmSingle = null;
        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 GetSingle()
        {
            if(frmSingle == null)
            {
                frmSingle = new Form1();
            }
            return frmSingle;
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();  //暂停播放
        }

        private void Play_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play(); //开始播放
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop(); //停止播放
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicPlayer.URL = @"G:\c#\第十五章\mp3\半城烟沙.mp3";
            musicPlayer.Ctlcontrols.stop();
        }
        bool b = true; //用来控制单击listpath，点击播放暂停按钮，歌曲会停在原处，而不是从头开始
        private void PlayOrPause_Click(object sender, EventArgs e)
        {
            if (PlayOrPause.Text == "播放")
            {
                if (b)
                {
                    musicPlayer.URL = path[listPath.SelectedIndex];
                }
                musicPlayer.Ctlcontrols.play();
                PlayOrPause.Text = "暂停";
            }
            else if (PlayOrPause.Text == "暂停")
            {
                musicPlayer.Ctlcontrols.pause();//暂停
                PlayOrPause.Text = "播放";
                b = false;
            }
        }
        string[] path;
        List<string> liBox = new List<string>(); //存储路径
        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "选择文件";  //对话框标题
            open.Filter = "音乐文件|*.mp3|所有文件|*.*";  //文件类型
            open.Multiselect = true; //多选文件
            open.ShowDialog(); //显示对话框
            open.InitialDirectory = @"G:\c#\第十五章\mp3"; //默认路径

            path = open.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listPath.Items.Add(Path.GetFileName(path[i]));
                liBox.Add(path[i]);
            }
        }


        private void listPath_DoubleClick(object sender, EventArgs e)
        {
            if (listPath.Items.Count <= 0)
            {
                MessageBox.Show("请先选择文件");
                return; //结束进程
            }
            //为了解决点击空白选项处，需要做异常处理

            try
            {
                musicPlayer.URL = path[listPath.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                PlayOrPause.Text = "暂停";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int index = listPath.SelectedIndex; //获取listPath索引

            //当listBox控件的selectMode属性是 MultiExtended时
            //导致无法正常上一曲的操作，需要先将之前的索引值清空
            listPath.SelectedIndices.Clear();
            --index;
            if (index < 0)
                index = listPath.Items.Count - 1;
            listPath.SelectedIndex = index;
            musicPlayer.URL = path[listPath.SelectedIndex];

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            int index = listPath.SelectedIndex;

            //当listBox控件的selectMode属性是 MultiExtended时
            //导致无法正常下一曲的操作，需要先将之前的索引值清空
            listPath.SelectedIndices.Clear();
            ++index;
            if (index >= listPath.Items.Count)
                index = 0;
            listPath.SelectedIndex = index;
            musicPlayer.URL = path[listPath.SelectedIndex];

        }

        private void DeletMenuItem_Click(object sender, EventArgs e)
        {
            //删除listBox中的某些选项
            //1. 在窗体中添加 ContextMenuStrip 控件， 并在控件中添加删除事件
            //2. 将ListBox与ContextMenuStrip控件联系起来：设置ListBox控件中的ContextMenuStrip属性，选择控件的名称

            //先删除路径集合，再删除listBox列表
            //原因：首先明确，列表集合是根据路径集合来添加的，
            //如果先删列表集合，导致，列表里的内容和路径集合的内容对不上号

            int count = listPath.SelectedIndices.Count;
            //for (int i = 0; i < path.Length; i++)
            //{
            //    MessageBox.Show(path[i]);
            //}
            for (int i = 0; i < count; i++)
            {
                //先删除路径集合
                liBox.RemoveAt(listPath.SelectedIndex);

                //再删除listBox列表
                listPath.Items.RemoveAt(listPath.SelectedIndex);
            }

        }

        private void Pictrue_Click(object sender, EventArgs e)
        {
            //静音功能
            if (Pictrue.Tag.ToString() == "1")
            {
                musicPlayer.settings.mute = true;
                Pictrue.Tag = "2";
                Pictrue.Image = Image.FromFile(@"2.png");
            }
            else if (Pictrue.Tag.ToString() == "2")
            {
                musicPlayer.settings.mute = false;
                Pictrue.Tag = "1";
                Pictrue.Image = Image.FromFile(@"1.png");
            }
        }

        private void listPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayOrPause.Text = "播放";
            // MessageBox.Show("点击");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop(); //停止播放
            PlayOrPause.Text = "播放";
            b = true;
        }

        private void SoundSet_Click(object sender, EventArgs e)
        {
            //增音量
            musicPlayer.settings.volume += 5;
        }

        private void DSound_Click(object sender, EventArgs e)
        {
            //减音量
            musicPlayer.settings.volume -= 5;
        }

        private void Time_Click(object sender, EventArgs e)
        {
            //设置前提： 添加timer控件，切记将控件中的TClick 设为time_clik

            //自动播放下一曲方法：
            //1. 想办法获取歌曲总时长
            //2. 获取播放时长，
            //3. 进行对比，如果播放时长大于等于视频的时长，就进行下一曲

            //currentMedia //当前媒体属性
            //currentMedia.duration:double; 媒体总长度
            //currentMedia.durationString:string; 媒体总长度，字符串格式。如“03:24”

            //Ctlcontrols.currentPosition:double; 当前进度
            // Ctlcontrols.currentPositionString:string; 当前进度，字符串格式。如“00:23”

            //如果播放状态等于正在播放
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                GetTime.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" +
                          musicPlayer.currentMedia.durationString + "\r\n" +
                          musicPlayer.Ctlcontrols.currentPosition + "\r\n" +
                          musicPlayer.Ctlcontrols.currentPositionString;
                double time1 = double.Parse(musicPlayer.currentMedia.duration.ToString());//视频原本时长
                double time2 = double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString())+1;//当前播放进度
                if(time2 >= time1)
                {
                    int index = listPath.SelectedIndex;
                    listPath.SelectedIndices.Clear();
                    ++index;
                    if(index == listPath.Items.Count)
                    {
                        index = 0;
                    }
                    listPath.SelectedIndex = index;
                    musicPlayer.URL = path[index];
                    musicPlayer.Ctlcontrols.play();
                }
            }
        }
    }
}
