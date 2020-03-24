using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using demo8;
using System.Diagnostics;

namespace demo9
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            #region 字符串的一些性质
            //Person p = new Person("zyx",28,"男");
            ////p.show();
            //string str = "abcdefg";
            //WriteLine(str[2]);//结果为c
            //char[] arr = str.ToCharArray();  //将字符串转换成字符数组类型
            //arr[2] = '0';
            ////这里改变的是字符数组的内容，和字符串无关
            ////如果 要改变字符串的内容，就要接收
            ////str = Convert.ToString(arr);//这种改变是无法转换的
            //str = new string(arr);
            //WriteLine(str);
            //string str1 = "zyx";
            //string str2 = "zyx";
            //这里两个在栈中的地址不一样，但是在堆中，其地址是一样的，因为它内容一样
            #endregion
            #region 字符串的方法和属性
            //WriteLine("请输入你喜欢的学科：");
            //string course1 = ReadLine();
            //string course1 = ReadLine().ToUpper();//将英文全部转换成大写
            // string course1 = ReadLine().ToLower();//将英文全部转换成小写
            //WriteLine("请输入你朋友喜欢的学科：");
            //string course2 = ReadLine();
            //if(course1.Equals(course2))//不区分大小写
            //if (course1.Equals(course2,StringComparison.OrdinalIgnoreCase))
            //{
            //    WriteLine("你们喜欢的学科一样");
            //}
            //else
            //{
            //    WriteLine("你们喜欢的学科不一样");
            //}

            //  string st = " ag , gsls + hfdw= ag -";
            //当要切割多个符号时，
            //可以先将要切割的内容定义到一个字符数组中
            //如果只切割一个符号，可以st.Split('')
            //char[] chs = { ' ', ',', '+', '=','-' };
            //string[] st1 = st.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //string newstr = "";
            //for (int i = 0; i < st1.Length; i++)
            //{
            //    newstr += st1[i];
            //}
            //st = Convert.ToString(st1);
            ////WriteLine(newstr);
            //WriteLine(st);
            //st = new string(st1);
            //WriteLine(st2);
            // WriteLine(st.Split(chs, StringSplitOptions.RemoveEmptyEntries));
            //string s = " ahkga";
            //s.Trim();
            //s.TrimStart();
            //s.TrimEnd();
            //WriteLine();
            #endregion
            #region 字符串不常用的方法
            //string time = DateTime.Now.ToShortDateString();
            //WriteLine(time);
            //2020/3/15 15:08:25要求输出2020年3月15日
            //char[] chs = { '/', ' ' };
            //string[] times = time.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < times.Length; i++)
            //{
            //    Write(times[i]);
            //}
            //WriteLine("**********");
            //string[] times = time.Split(new char[] { '/', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //WriteLine("{0}年{1}月{2}日", times[0], times[1], times[2]);

            //string str = "hellozyxiloveyou";
            //string str1 = str.Substring(4); //x>=4
            //WriteLine(str1);//结果ozyxiloveyou
            //str = str.Substring(1, 4);  //1<=x<=4
            //WriteLine(str);//结果ello
            //string str = "hellozyxiloveyou";
            //if(str.StartsWith("h"))//返回的是bool类型
            //{
            //    //判断字符串是否是以h开头
            //}
            //查找字符串Y的位置，索引值从0开始
            //int i = str.IndexOf("y");
            //查找某字符串最后出现的位置
            //int j = str.LastIndexOf("o"); 
            //string str = null;
            //if(string.IsNullOrEmpty(str))
            //{
            //    WriteLine("空");
            //}
            //string[] str = { "zyx", "hobby", "is", "music" };
            //string sr = string.Join("|", str);
            //WriteLine(sr);
            //WriteLine(i);
            //WriteLine(j);
            #endregion

           
        

            ReadKey();
        }
    }
}
