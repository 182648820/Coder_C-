using demo17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo16
{
    //  public delegate string wSayHi(string name); //将SayHi定义成委托

    public delegate void Show();
    public class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 委托
            //委托只接收方法
            //wSayHi who = new wSayHi(SayHi);//使用委托方法一
            //who("张三");
            //SayHi("zyx", SayHello);
            //Console.ReadKey();

            //匿名函数 就是没有函数名称
            //wSayHi who = delegate (string str)
            //{
            //    Console.WriteLine("nihao" + str);
            //};
            //who("zyxiamloveyou");
            //Console.ReadKey();


            ////兰姆达表达式  lamdba
            //wSayHi who1 = (string name) => { return "你好" + name; };
            //Console.WriteLine(who1("zyxiamloveyou"));
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2());
            #endregion

            Show s = show1; // 定义委托变量s  
            s += show2;    //委托可以添加 也可以删除 s -= show2
            s();
            Console.ReadKey();
        }
        //public static void SayHi(string name,wSayHi who)  //方法二
        //{
        //    who(name);
        //}
        //public static void SayHello(string name)
        //{
        //    Console.WriteLine(name+"hello");
        //}
        public static void show1()
        {
            Console.WriteLine("你订阅了昨天的报纸");
        }
        public static void show2()
        {
            Console.WriteLine("你订阅了今天的报纸");
        }
        public static void show3()
        {
            Console.WriteLine("你订阅了明天的报纸");
        }
    }
}