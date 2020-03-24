using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static demo14.Judgement;

namespace demo14
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnST_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayerGame(str);
        }

        private void btnJD_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayerGame(str);
        }

        private void btnBu_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayerGame(str);
        }
        private void PlayerGame(string str)
        {
            player.Text = str; //将玩家输入的信息显示到屏幕上
            Player rplayer = new Player();
            int playerNumber = rplayer.ShowFist(str);

            Computer rcomputer = new Computer();
            int computerNumber = rcomputer.ShowFist();
            computer.Text = rcomputer.Fist;//将电脑随机产生的信息显示到屏幕上


            Result result = Judgement.Judge(playerNumber, computerNumber);
            judge.Text = result.ToString();


        }
    }
}
