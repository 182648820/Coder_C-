using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo15
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            treeView1.Indent = 20; //缩进距离
            treeView1.Nodes.Add("节点1"); //添加节点
            treeView1.Nodes[0].Nodes.Add("子节点1");
            treeView1.Nodes[0].Nodes.Add("字节点2");
            treeView1.Nodes[0].Nodes.Add("子节点");

            treeView1.Nodes.Add("节点2"); //添加节点
            treeView1.Nodes[1].Nodes.Add("子节点1");
            treeView1.Nodes[1].Nodes.Add("字节点2");
            treeView1.Nodes[1].Nodes.Add("子节点");

            treeView1.Nodes.Add("节点3"); //添加节点
            treeView1.Nodes[2].Nodes.Add("子节点1");
            treeView1.Nodes[2].Nodes.Add("字节点2");
            treeView1.Nodes[2].Nodes.Add("子节点");

            treeView1.ExpandAll();//将所有节点全部展开
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text; //SelectedNode获取我们选中的节点，Text 选择节点的文本
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            string str = "";
            if (e.Button == MouseButtons.Right)
            {
                str = "鼠标右键";
            }
            else if (e.Button == MouseButtons.Left)
            {
                str = "鼠标左键";
            }
            else if (e.Button == MouseButtons.Middle)
                str = "鼠标操作中";
            textBox1.Text = str;
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.F)
            //    MessageBox.Show("你按下了F键");
            if(e.Alt && e.KeyCode ==Keys.K)
            {
                label1.Text = "ctr+K键已按下";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = "当前系统目录为：" + Environment.OSVersion;//获取系统标识符和平台版本号
        }
    }
}
