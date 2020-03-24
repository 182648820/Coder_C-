using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 集合的方法属性

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("help");
            //list.Add("me");
            //list.Add("please");//添加元素
            //list.AddRange(new int[] { 1,2,3,5,4,6});//添加一个集合
            //list.Insert(2, "hello");//在指定的索引位置插入
            //list.InsertRange(2, new int[] { 7, 8, 9 });//在指定位置插入一个集合
            //list.Remove("help");//删除指定元素
            //list.Clear();//删除所有元素
            //list.RemoveAt(2); //删除指定的索引值
            //list.RemoveRange(1, 2);//删除指定范围的值
            //list.Sort();//升序排序（需要类型一致）
            //list.Insert(2, "hello");//在指定的索引位置插入
            //WriteLine("{0},{1},{2}", list[2], list[1], list[0]);
            //bool b = list.Contains("hello");//返回的是Bool类型
            //list.Reverse();//翻转元素
            //int num = list.Count; //获取集合元素总数
            //int i= list.IndexOf(2);//返回元素为2的索引值
            //list.LastIndexOf(2);//返回元素为2最后出现的索引值

            #endregion
            ArrayList list = new ArrayList();
            #region 集合求和
            //for (int i = 0; i < 4; i++)
            //{
            //    list.Add(i);
            //}
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum += (int)list[i];

            //}
            #endregion
            #region 作业
            //for (int i = 0; i < 3; i++)
            //{
            //    int j = i;
            //    WriteLine("请输入{0}个学生的姓名：", ++j);
            //    list.Add(ReadLine());
            //    WriteLine("请输入{0}个学生的年龄：", j);
            //    list.Add(Convert.ToInt32(ReadLine()));
            //    WriteLine("请输入{0}个学生的性别：", j);
            //    list.Add(ReadLine());
            //}
            //int sumAge = 0;
            //int maxAge = (int)list[1];
            //for (int i = 0; i < list.Count; i++)
            //{
            //    WriteLine("学生的信息：{0}", list[i]);
            //    if (i == 1 || i == 4 || i == 7)
            //    {
            //        sumAge += (int)list[i];
            //        if (maxAge < (int)list[i])
            //        {
            //            maxAge = (int)list[i];
            //        }
            //    }

            //}
            //WriteLine("学生总年龄：{0}\n平均年龄：{1}", sumAge, sumAge / 3);
            //WriteLine("最大年龄是：{0}", maxAge);
            #endregion
            //键值对
            //Hashtable table = new Hashtable();
            //table.Add("name", "zyx");
            //table.Add("age", 20);
            //table.Add("sex", "男");
            //foreach (var item in table.Keys)
            //{
            //    WriteLine("键：{0} ——{1}",item, table[item]);
            //}
            //结果键：age ——20
            //键：sex ——男
            //键：name ——zyx
            //table.ContainsKey()
            //string path = @"C:\Users\**\Desktop\test.txt";
            //WriteLine(Path.GetFileName(path));//获取文件名，包括扩展名
            //WriteLine(Path.GetExtension(path));//获取文件的扩展名
            //WriteLine(Path.GetFileNameWithoutExtension(path));//获取文件名，不包括扩展名
            //WriteLine(Path.GetFullPath(path));//获取文件的全路径，包括扩展名
            //WriteLine(Path.GetDirectoryName(path));//获取文件所在文件夹的目录

            //在规定路径中创建zyx.txt文件
            //File.Create(@"C:\Users\**\Desktop\zyx.txt");

            //将前面路径的文件 复制到  后面路径中
            //File.Copy(@"C:\Users\**\Desktop\zyx.txt", @"G:\source\new.txt");

            //将前面路径的文件移动到后面路径中，类似剪切
            //File.Move(@"C:\Users\**\Desktop\zyx.txt", @"G:\source\newzyx.txt");
            //WriteLine("移动成功");
            File.Delete(@"C:\Users\**\Desktop\test.txt");
            WriteLine("删除成功");


                #region var
            //var i = 20; //i的类型是整型int
            //var str = "hello"; //str的类型是字符串类型
            //var ch = 'a';//ch是字符类型
            ////var b = true;//b 是布尔类型
            //var 声明的变量必须同时赋值，不然会报错
            #endregion

            ReadKey();
        }
    }
    #region 
    //public class Person
    //{
    //    protected int _age;
    //    public int Age
    //    {
    //        set { _age = value; }
    //        get { return _age; }
    //    }

    //    public class Student:Person
    //    {
    //        public void show()
    //        {
    //            WriteLine(Age);
    //        }
    #endregion

}

