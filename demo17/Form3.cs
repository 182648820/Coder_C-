using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo17
{
    public delegate void Show(string str); //定义show委托
    public partial class Form3 : Form
    {
        Show Dlg; //委托变量
        public Form3(Show dlg)
        {
            Dlg = dlg; 
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dlg(textBox1.Text);
        }
       
    }
}
