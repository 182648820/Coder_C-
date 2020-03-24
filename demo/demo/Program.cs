using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args) //入口主函数
        {
            #region 其他基础内容，里面的内容不注释 还是会被执行
            //Console.WriteLine("Welcome to use C#");//将内容显示到屏幕上，
            //Console.ReadKey();//将显示窗口停留在屏幕上
            //short i = 32767;
            //int i1 = -214748364;
            //long i2 = -922337203685477580;
            /*float i = 12.5f;
            double i1 = 1.55505050555550;
            Console.WriteLine("{0}\n{1}", i, i1);
            char str = 'a';
            string str1 = "aaa";
            Console.WriteLine("{0}\n{1}", str, str1);
            bool data = false;
            if (data)
            {
                Console.WriteLine("hello!");
            }
            int? name =null;
            bool? s = null;
            ushort arg = 656;
            
            Console.ReadKey();*/
            #endregion
            #region 交换两个值
            /* string name = "张艺兴";
             string hobby = "音乐";
             string always = "非常";
             Console.WriteLine($"{name}{always}喜爱{hobby}");
             Console.ReadKey();
            
            int arr = 10;
            int arr1 = 20;
            int temp;
            temp = arr;
            arr = arr1;
            arr1 = temp;
            Console.WriteLine("arr={0}\n arr1={1}", arr, arr1);
            Console.ReadKey();*/

            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //Console.WriteLine("用户输入的姓名是：" + name);
            //Console.WriteLine("\"张艺兴\"我很喜欢你爱你呦~");
            //string str = "人生不如意，十有八九\n某人";
            //File.AppendAllText(@"C:\\Users\晴雪\Desktop\file.txt", str);
            //Console.WriteLine("保存成功！");
            #endregion
            #region
            //int math = 90;
            //int Chinese = 80;
            //int English = 88;
            //Console.WriteLine("总分："+ (math + Chinese + English)+
            //    "平均分：" +(math + Chinese + English) / 3);

            //Console.WriteLine("输入一个数据：");
            //Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 3);
            //int left = 6;
            //int right = left++ + ++left * 2 + --left + left++;
            //Console.WriteLine(right);
            //Console.WriteLine(left);
            // bool d = 3< 2 | 3 < 4;if(d){}//第一种写法

            //int data = Convert.ToInt32(Console.ReadLine());if(data>2==true)//第二种写法
            //if(data >2) 第三种写法
            //data >2
            //if (data>2==true)
            //{
            //    Console.WriteLine("gradulation!!");
            //}
            // Console.WriteLine(d);
            #endregion
            //int data = Convert.ToInt32(Console.ReadLine());
            //if (data > 12)
            //{
            //    Console.WriteLine("值大于12");
            //}
            //else if(data<12&&data>5)
            //{
            //    Console.WriteLine()
            //}
            //Console.WriteLine("请输入用户账号：");
            //string str = Console.ReadLine();
            //Console.WriteLine("请输入用户密码：");
            //string password = Console.ReadLine();
            //if (str == "admin" && password == "pwd")
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else
            //{
            //    Console.WriteLine("登录失败");
            //}
            //int a = 12;
            //int b = 1;
            //int data = a > b ? (a < b ? 1 : 2) : (a == b ? 3 : 4);
            //Console.WriteLine(data); //data = 2
            //int? data = Convert.ToInt32(Console.ReadLine());
            //int? d = data ?? 10;
            //Console.WriteLine(d);
            Console.WriteLine("请输入第一个数：");
            int data1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            int data2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数：");
            int data3 = Convert.ToInt32(Console.ReadLine());
            int max = data1;
            if(max <data2)
            {
                max = data2;
            }
            if(max <data3)
            {
                max = data3;
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }

    }
}
