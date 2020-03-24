using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  1.异常处理
            ////注意：如果变量是在try里面申请，则该变量属于局部变量，不可以全局使用
            //int data = 0;
            //bool flag = true;//当输入的格式正确时，保证它正常输出
            //try
            //{
            //    //这里写可能会出错的代码
            //    data = Convert.ToInt32(Console.ReadLine());
            //}
            //catch(Exception e)
            //{
            //    //出错了解决的代码
            //    Console.WriteLine("请输入正确的格式的数字：");
            //    data = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine(e.Message);
            //    //flag = false;
            //}
            //Console.WriteLine(data * 3);
            #endregion

            #region 2.witch和判断平年闰年代码
            //WriteLine("请输入数字：");
            //int select = Convert.ToInt32(ReadLine());
            //switch(select)
            //{
            //    case 1:
            //        WriteLine("你输入的是" + select);
            //        break;
            //    case 2:
            //        WriteLine("你输入的是" + select);
            //        break;
            //    case 3:
            //        WriteLine("你输入的是" + select);
            //        break;
            //    case 4:
            //        WriteLine("你输入的是" + select);
            //        break;
            //    default:
            //        WriteLine("你的输入暂时无法显示");
            //        break;

            //}
            //判断平年闰年
            //WriteLine("请输入年份数字：");
            //int data = 0;
            //int select = 0;
            //bool flag = true;
            //try
            //{
            //    data = Convert.ToInt32(ReadLine());
            //}
            //catch (Exception e)
            //{
            //    WriteLine(e.Message);
            //    flag = false;
            //}
            //if (flag)
            //{
            //    if ((data % 400 == 0 && data % 100 != 0) || data % 4 == 0)
            //    {
            //        select = 1;
            //    }
            //    switch (select)
            //    {

            //        case 0:
            //            WriteLine(data + "是平年");
            //            break;
            //        case 1:
            //            WriteLine(data + "是闰年");
            //            break;
            //    }
            //}
            #endregion
            #region 3. 循环和一些例子
            //输出你好10次，会好的100次
            //int i;
            //i = 1;
            //while(i<=10)
            //{
            //    WriteLine("你好:{0}",i);
            //    int j = 1;
            //    while(j<=10)
            //    {
            //        WriteLine("会好的");
            //        ++j;
            //    }
            //    ++i;
            //}

            //账号密码登录
            //WriteLine("请输入登录账号：");
            //string name = ReadLine();
            //WriteLine("请输入登录密码：");
            //string password = ReadLine();
            //while(name!="admin"&&password!="123")
            //{
            //    WriteLine("登录失败！");
            //    WriteLine("请输入登录账号：");
            //    name = ReadLine();
            //    WriteLine("请输入登录密码：");
            //    password = ReadLine();
            //}
            //WriteLine("登录成功！");

            //输入学生姓名，年龄，性别信息，输出这些信息，然后计算年龄总和和平均年龄
            //int newNum, ageSum, number;
            //newNum = ageSum = number = 0;
            //bool flag = true;

            //try
            //{
            //    WriteLine("输入学生个数：");
            //    number = Convert.ToInt32(ReadLine());
            //    newNum = number;
            //}
            //catch (Exception e)
            //{

            //    WriteLine(e.Message);
            //    flag = false;
            //}
            //if (flag)
            //{
            //    int i = 1;
            //    while (i <= number)
            //    {
            //        string name = "";
            //        int age = 0;
            //        string sex = "";
            //        WriteLine("输入{0}个学生姓名：", i);
            //        name = ReadLine();
            //        WriteLine("年龄：");
            //        age = Convert.ToInt32(ReadLine());
            //        WriteLine("性别：");
            //        sex = ReadLine();
            //        ageSum += age;
            //        WriteLine("********\n{0}个学生姓名：{1}\n年龄: {2}\n性别:{3}",
            //            i, name, age, sex);
            //       ++i;

            //    }
            //    WriteLine("学生年龄总和：{0}\n学生平均年龄{1}", ageSum, ageSum / newNum);

            //}
            #endregion

            //作业
            //1.先登录 2.在输入学生信息（姓名，年龄，性别）

            WriteLine("请输入系统登录账号：");
            string account = ReadLine();
            WriteLine("请输入系统登录账号密码：");
            string password = ReadLine();

            while (account != "admin" || password != "pwd")
            {
                WriteLine("你的账号或者密码错误，请重新输入");
                WriteLine("请输入系统登录账号：");
                account = ReadLine();
                WriteLine("请输入系统登录账号密码：");
                password = ReadLine();
            }

            WriteLine("登录成功！");
            int newNum, ageSum, number;
            newNum = ageSum = number = 0;
            bool flag = true;

            try
            {
                WriteLine("输入学生个数：");
                number = Convert.ToInt32(ReadLine());
                newNum = number;
            }
            catch (Exception e)
            {

                WriteLine(e.Message);
                flag = false;
            }
            if (flag)
            {
                int i = 1;
                while (i <= number)
                {
                    string name = "";
                    int age = 0;
                    string sex = "";
                    WriteLine("输入{0}个学生姓名：", i);
                    name = ReadLine();
                    WriteLine("年龄：");
                    age = Convert.ToInt32(ReadLine());
                    WriteLine("性别：");
                    sex = ReadLine();
                    ageSum += age;
                    WriteLine("********\n{0}个学生姓名：{1}\n年龄: {2}\n性别:{3}",
                        i, name, age, sex);
                    ++i;

                }
                WriteLine("学生年龄总和：{0}\n学生平均年龄{1}", ageSum, ageSum / newNum);

            }

            ReadKey();

        }
    }
}
