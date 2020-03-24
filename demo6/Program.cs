using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 求最大值
            //WriteLine("输入比较大小的个数:");
            //int number = Convert.ToInt32(ReadLine());
            //int[] arr = new int[number];
            //for (int i = 0; i < number; i++)
            //{
            //    arr[i] = Convert.ToInt32(ReadLine());
            //}
            //getMax(arr);
            //ReadKey();
            #endregion
            #region 一行代码实现求三个数的最大值
            //int[] arr = new int[3];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(ReadLine());

            //}

            //int num = getmax(arr);
            //WriteLine("最大值：" + num);
            #endregion

            #region 作业
            //提示用户输入一个数字，是数字，就结束 
            //不是继续输入

            //judge();
            //作业1 求一个数组的总和和平均数
            //WriteLine("请输入数组的总个数：");
            //int number = Convert.ToInt32(ReadLine());
            //int[] arr = new int[number];

            //getSumAvg(arr);

            //作业2
            // Judge();
            #endregion
            #region out关键字的使用
            //WriteLine("请输入数字：");
            //int num = Convert.ToInt32(ReadLine());
            //int avg, sum;
            //int[] arr = new int[num];
            //WriteLine("please read {0} 个数组值", arr.Length);
            //for (int i = 0; i < num; i++)
            //{
            //    arr[i] = Convert.ToInt32(ReadLine());
            //}

            //getsum(arr, out sum, out avg);
            ////使用out avg意思是这个avg参数不用return返回来，
            ////Out已经在内部完成返回的操作了，直接输出即可
            //WriteLine("总和：{0}\n平均数：{1}", sum, avg);
            //  ReadKey();
            #endregion

            #region 小项目
            //WriteLine("请输入账号密码");
            //string[] userLogin = new string[2];
            //for (int i = 0; i < userLogin.Length; i++)
            //{
            //    userLogin[i] = ReadLine();
            //}
            //string onCheck = CheckLogin(userLogin);
            //while (true)
            //{
            //    if (onCheck == "登录成功！")
            //    {
            //        WriteLine("登录成功！");
            //        StudentIn();
            //        ReadKey();
            //    }
            //    else
            //    {


            //        if (onCheck == "警告：账号或者密码不能为空")
            //        {
            //            WriteLine("警告：账号或者密码不能为空");
            //            WriteLine("请输入账号密码");

            //            for (int i = 0; i < userLogin.Length; i++)
            //            {
            //                userLogin[i] = ReadLine();
            //            }
            //            onCheck = CheckLogin(userLogin);
            //        }
            //        else
            //        {
            //            WriteLine("登录失败！请仔细核对你的账号或者密码");
            //            WriteLine("请输入账号密码");

            //            for (int i = 0; i < userLogin.Length; i++)
            //            {
            //                userLogin[i] = ReadLine();
            //            }
            //            onCheck = CheckLogin(userLogin);
            //        }

            //    }
            //}

            #endregion

            #region ref关键字
            //int number = 200;
            //function(ref number);
            //WriteLine(number);
            #endregion
            //params关键字
            //1. params可以接受多个同种类型的值,把多个值当一个来传递
            //2. params的值可以是空的
            //3. params在形参处，必须在最后声明，如果在前面会报错
            //public static void sum(******, params int[]变量)
            //4. 同一个方法中，只能存在一个params
            WriteLine("请输入一个数字：");
            int number = Convert.ToInt32(ReadLine());
            Sum(number);
            ReadKey();
        }

        //函数定义：

        #region 求最大值的函数
        //public static void getMax(int[] arr)
        //{
        //    int max = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if(max<arr[i])
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    WriteLine("最大值: {0}", max);
        //}
        #endregion

        #region 一行代码实现求三个数的最大值
        //public static int getmax(int[] arr)
        //{
        //    int number = arr[0] > arr[1] && arr[0] > arr[2] ? arr[0] : (arr[1] > arr[0] && arr[1] > arr[2] ? arr[1] : arr[2]);
        //    return number;
        //}
        #endregion

        #region 
        //public static void judge()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            WriteLine("请输入一个数字：");
        //            int num = Convert.ToInt32(ReadLine());
        //            WriteLine(num);
        //            break;
        //        }
        //        catch (Exception e)
        //        {

        //            WriteLine(e.Message);
        //        }
        //    }
        //}
        #endregion

        #region 数组求和函数
        //public static void getSumAvg(int[] arr)
        //{
        //    int sum = 0;
        //    WriteLine("请输入数组的值：");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToInt32(ReadLine());
        //        sum += arr[i];
        //    }
        //    WriteLine("数组总和：{0}\n平均值：{1}", sum, sum / arr.Length);
        //}
        #endregion
        #region 
        //public static void Judge()
        //{
        //    while (true)
        //    {
        //        WriteLine("请输入yes或者no");
        //        try
        //        {
        //            string str = ReadLine();
        //            if (str == "yes")
        //            {
        //                break;
        //            }
        //        }
        //        catch (Exception)
        //        {

        //            WriteLine("请继续输入：");
        //        }
        //    }
        //}
        #endregion
        #region out例子
        //public static void getsum(int[] arr, out int sum, out int avg)
        //{
        //    sum = 0;//在内部赋值

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    //sum = j;
        //    avg = sum / arr.Length;
        //}
        #endregion

        #region 项目的函数
        //public static string CheckLogin(string[] userLogin)
        //{
        //    if (userLogin[0] == "admin" && userLogin[1] == "123")
        //    {

        //        return "登录成功！";
        //    }
        //    else if (userLogin[0].Length < 0 || userLogin[1].Length < 0)
        //    {

        //        return "警告：账号或者密码不能为空";
        //    }
        //    return "登录失败！请仔细核对你的账号或者密码";
        //}

        //public static void StudentIn()
        //{
        //    int sumAge, avgAge; //计算学生总年龄和平均年龄
        //    WriteLine("请输入学生个数：");

        //    int number = Convert.ToInt32(ReadLine());
        //    string[] name = new string[number];
        //    int[] age = new int[number];
        //    string[] sex = new string[number];
        //    for (int i = 0; i < number; i++)
        //    {
        //        int j = i;
        //        Write("请输入{0}个学生姓名：", ++j);
        //        name[i] = ReadLine();
        //        Write("学生年龄：");
        //        age[i] = Convert.ToInt32(ReadLine());
        //        Write("学生性别：");
        //        sex[i] = ReadLine();
        //    }
        //    Student(name, age, sex, out sumAge, out avgAge);
        //    WriteLine("学生总年龄：{0}\n 学生平均年龄：{1}", sumAge, avgAge);
        //}

        //public static void Student(string[] name, int[] age, string[] sex, out int sumAge, out int avgAge)
        //{
        //    sumAge = 0;
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        WriteLine("第{0}个学生的姓名：{1}--年龄：{2}--性别：{3}", i, name[i], age[i], sex[i]);
        //        sumAge += age[i];
        //    }
        //    avgAge = sumAge / name.Length;
        //}
        #endregion

        //public static void function(ref int number)
        //{
        //    number *= 3; 
        //}
        public static void Sum(int number)
        {
            if(number==107)
            {
                WriteLine("hello!nice to meet you ");
            }
            else
            {
                WriteLine("请重新输入一个数字：");
                number = Convert.ToInt32(ReadLine());
                Sum(number);
            }
            
        }
       
    }
}