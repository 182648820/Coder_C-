using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo5
{
    #region 枚举定义
    //public enum Sex
    //{
    //    男,
    //    女
    //}
    //public enum Infor
    //{
    //    one,
    //    two,
    //    three,
    //    four
    //}
    //public enum 枚举名
    //{
    //    枚举内容1,
    //    枚举内容2,
    //    ....
    //    枚举内容n
    //}
    #endregion

    #region 结构体定义
    //public struct 结构体名
    //{
    //    public string name;
    //    //public是设为共有属性,设为其他属性都可以,根据实际情况
    //    public string age;
    //    ......
    //}
    //public struct Family
    //{
    //    public string _name;
    //    public int _number;
    //}
    //public struct Person
    //{
    //    public string name;
    //    public int age;
    //    public Family family;
    //}
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region 常量
            //       const int num = 10; 
            ////num常量，用const定义，它的值不可以随意更改，即不可以多次赋值
            //       int i = 2;//变量 可以多次赋值
            //       Console.WriteLine(num);
            #endregion

            #region 枚举，转换类型
            //需要先声明，声明位置在用的地方的上一层以上都可以

            //枚举转换成int型
            //int One = (int)Infor.one;//强制转换 
            //枚举第一个数的int值默认为0，其他往下加一
            // int Two = Convert.ToInt32(Infor.two);//Convert转换

            // WriteLine(One);//结果=0
            // WriteLine(Two);//结果=1

            //int 型转换成枚举
            // int oNe = 1;
            // Infor one1 = (Infor)oNe;//转换类型
            //  WriteLine(one1);

            //枚举的默认值是可以改变的
            //直接在枚举定义那里赋值，
            //如One = 2,那么接下来的Two 就是在2的基础上往下加1
            //转换成string类型
            // string onee = Infor.one.ToString();//第一种转换
            // string twee = Convert.ToString(Infor.two);//第二种转换
            //WriteLine("转换string: ",onee);
            //WriteLine(twee);
            //WriteLine("输入一个月份");
            //string month = ReadLine();
            //switch (month)
            //{
            //    case "1":
            //        //object Enum.Parse(typeof(枚举名), string value)
            //        //将一个或者多个枚举常数或者数字值的字符串转换成等效的枚举对象
            //        Seasonal spring = (Seasonal)Enum.Parse(typeof(Seasonal), month);
            //        WriteLine("this is " + spring + " seasonal");
            //        break;
            //    case "2":
            //        //object Enum.Parse(typeof(枚举名), string value)
            //        //将一个或者多个枚举常数或者数字值的字符串转换成等效的枚举对象
            //        Seasonal summer = (Seasonal)Enum.Parse(typeof(Seasonal), month);
            //        WriteLine("this is " + summer + " seasonal");
            //        break;
            //    case "3":
            //        //object Enum.Parse(typeof(枚举名), string value)
            //        //将一个或者多个枚举常数或者数字值的字符串转换成等效的枚举对象
            //        Seasonal autumn = (Seasonal)Enum.Parse(typeof(Seasonal), month);
            //        WriteLine("this is " + autumn + " seasonal");
            //        break;
            //    case "4":
            //        //object Enum.Parse(typeof(枚举名), string value)
            //        //将一个或者多个枚举常数或者数字值的字符串转换成等效的枚举对象
            //        Seasonal winter = (Seasonal)Enum.Parse(typeof(Seasonal), month);
            //        WriteLine("this is " + winter + " seasonal");
            //        break;
            //    default:
            //        WriteLine("it have't this seasonal");
            //        break;

            // }
            #endregion

            #region 结构体
            //Person student;
            //student.name = "zyx";
            //student.age = 28;
            //student.family._number = 6;
            //WriteLine(student.family._number);//6
            //WriteLine("*******************");
            //WriteLine(student.name + ",今年:"+student.age);
            #endregion

            #region 数组

            //数组定义:数据类型[] 数组名= new 数据类型[数组长度];
            //int[] arr = new int[5];
            //这里的new int[]等价:在内存里面开辟一块空间,空间的个数按照数组长度而定
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    WriteLine("请输入{0}个数组值:", i);
            //    arr[i] = Convert.ToInt32(ReadLine());
            //}
            //int j = 0;
            //while(arr.Length>j)
            //{
            //    WriteLine("{0}数组值:{1}",j, arr[j]);
            //    ++j;
            //}

            //string[] str = { "小七", "小狗", "小猫", "小青", "小小" };
            //string str1 = null;
            //for (int i = 0; i < str.Length-1; i++)
            //{
            //   str1 += str[i] + "|";
            //}
            //WriteLine(str1+str[str.Length - 1]);

            //数组排序(冒泡)
            //int[] arr = { 2, 4, 3, 1, 5 };
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i+1; j < arr.Length ; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //           //WriteLine(j);
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    WriteLine(arr[i] + " ");
            //}

            #endregion

            #region 函数
            //函数体,执行函数,需要在程序中进行调用
            //public static 数据类型 函数名(参数(可以没有))
            //{
            //     内容
            // }
            int sum = Show(10, 23);
            int sum1 = Program.Show(5, 6);//在同一个类中,program可以省略不写
            
            if(Select())
            {
                WriteLine("wellcom to using c#");
            }
            ReadKey();//执行完这个语句之后,整个程序将不会继续往下执行
        #endregion
        }
        //函数的定义
        public static int Show(int i, int j)
        {
            int sum = i + j;
            return sum;
        }

        public static bool Select()
        {
            int i = 1;
            if (i == 1)
            {
                return true;
            }
            else
                return false;
        }
    }
}
