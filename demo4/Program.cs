using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for循环和例子
            //九九乘法表
            //for (int i = 1; i <=9 ; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Write("{0}*{1}={2}\t", j, i, i * j);
            //    }
            //    WriteLine();
            //}

            ////0+10 = 10;1+9=10.......10+0=10
            //WriteLine("请输入你要计算的数字：");
            //int count = Convert.ToInt32(ReadLine());
            //for (int i = 0; i <=count; i++)
            //{
            //    WriteLine("{0} + {1} = {2}", i, count-i, i + count-i);

            //}
            #endregion
            // int num = '1';
            //  bool flag = int.TryParse("123", out num);
            //WriteLine(flag);
            // WriteLine(num); //输出'1'的ASCII码

            #region 类型转换
            //char st = char.Parse(ReadLine());
            //int data = int.Parse(ReadLine());
            //double da = double.Parse(ReadLine());
            //char number = '0';
            //bool data = char.TryParse(ReadLine(), out number); //返回的是bool值
            //WriteLine(number);
            #endregion

            #region 最大值，，最小值
            //int num = int.MaxValue;
            //int num1 = int.MinValue;
            ////double dnum = double.MaxValue;
            ////double dnum1 = double.MinValue;
            ////short snum = short.MaxValue;
            ////short snum1 = short.MinValue;
            //WriteLine("{0}~~{1}", num, num1);
            #endregion

            #region continue, break
            //int sum = 0; 
            //for (int i = 0; i < 5; i++)
            //{
            //    if(i == 3)
            //    {
            //        break;//执行到这里，就会终止这个for循环
            //    }
            //    sum += i;
            //}
            //WriteLine(sum);//结果3  <——0+1+2= 3
            #endregion

            #region Random 随机数类型
            //Random是一个产生随机数的类，这里是定义了一个随机数实例（即对象）
            //Random ran = new Random();
            //for (int i = 0; i < 4; i++)
            //{
            //    int num = ran.Next(1, 2);//ran.Next(写范围)  
            //    //1<= num < 2
            //    switch(num)
            //    {
            //        case 1:
            //            WriteLine("hello! i am {0}", num);
            //            break;
            //        case 2:
            //            WriteLine("hello! i am {0}", num);
            //            break;
            //        case 3:
            //            WriteLine("hello! i am {0}", num);

            //            break;
            //    }
            //}
            #endregion

            #region DataTime  时间类型
           // DateTime time = DateTime.Now;//获取当前时间
           // int year = time.Year;//获取年份
           // int month = time.Month;//月份
           // int day = time.Day;//日
           //int  week =(int)time.DayOfWeek;//星期几

           // WriteLine("当前时间：{0}",time);
           // Write(year + "年" + month + "月" + day + "日");
           // WriteLine("星期{0}", week);
            #endregion
            ReadKey();
        }
    }
}
