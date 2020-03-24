using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 在文件中写入内容
            // // 1 在文件中写入编码后的内容
            // string str = "welcome using C#";
            //// 将str 的编码类型 且当前系统支持的编码类型进行编码，然后将值给buffer
            // byte[] buffer = Encoding.Default.GetBytes(str);
            // //将bufferd 的内容写入路径中所指的文件中
            //  File.WriteAllBytes(@"C:\Users\**\Desktop\test.txt", buffer);
            // WriteLine("写入成功");

            //// 2 写入字符串数组
            //  string[] str1 = { "you ", "do you?" };
            //// 将str中的字符，以换行的方式进行写入 第一行：you 第二行：do you?

            //File.WriteAllLines(@"C:\Users\**\Desktop\test.txt", str1);


            // // 3 写入字符串
            // string st = "i love you!";
            // File.WriteAllText(@"C:\Users\**\Desktop\test.txt", st);
            // WriteLine("写入成功");
            #endregion
            #region
            //string str = "hello!nice to meet you!";
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\晴雪\Desktop\test.txt",buffer);
            //WriteLine("写入成功");

            //指明路径，第二个参数解码类型(要和上面写入的一致)
            //string[] contents = File.ReadAllLines(@"C:\Users\**\Desktop\test.txt", Encoding.Default);
            //foreach (var item in contents)
            //{
            //    WriteLine(item);
            //}

            //读取的是字符串类型，相对于上面的简便
            // 读取文档的所有内容
            // string str = File.ReadAllText(@"C:\Users\**\Desktop\test.txt", Encoding.Default);
            // WriteLine(str);
            //读取媒体文件，如音乐等
            // byte[] buffer = File.ReadAllBytes(@"C:\Users\**\Desktop\test.txt");
            //string s = Encoding.Default.GetString(buffer);
            //foreach(var item in s)
            //{
            //    Write(item);
            //}

            #endregion
            #region 拆装箱
            //List<object> list = new List< object>();
            //list.Add(2);
            //list.Add("nihao");
            //list[0] = "hello";
            //int i = 10;
            //object j = i;  //装箱
            //int n = (int)j;  //拆箱  
            #endregion

            #region 字典

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "hello");
            //dic.Add(2, "nice");
            //foreach (KeyValuePair<int,string> item in dic)
            //{
            //    WriteLine("键={0}——值={1}", item.Key, item.Value);
            //}
            #endregion
            #region 
            //FileStream流
            //使用FileStream来读取数据
            //FileStream fsRead = new FileStream(@"C:\Users\晴雪\Desktop\test.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //指定文件大小
            //byte[] buffer = new byte[1024 * 1024 * 6];//6M
            //返回本次实际读取到的有效字数
            // int num = fsRead.Read(buffer, 0, buffer.Length);
            //将字节数组中每一个元素按照指定的编码成字符串
            //string str = Encoding.Default.GetString(buffer, 0, num);

            //关闭流
            // fsRead.Close();
            // WriteLine(str);
            //释放资源
            //fsRead.Dispose();

            //FileStream写入流
            //using(FileStream fsWrite = new FileStream(@"C:\Users\晴雪\Desktop\test.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    string str = "would you help me?\n";
            //    //将str进行编码
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //    WriteLine("ok");
            //}
            //string path = @"C:\Users\**\Desktop\test.mp4";
            //string path1 = @"C:\Users\test.mp4";
            //CopyFile(path, path1);
            #endregion
            #region 多态
            //Person p = new Person("chen");
            //Japan J = new Japan("jan");
            //    Person[] us = { new Person ( "chen"), new Japan ("jan") };
            //    for (int i = 0; i < us.Length; i++)
            //    {

            //        us[i].show();
            //    }
            //    ReadKey();
            //}
            //#region FileStream
            ////public static void CopyFile(string source, string target)
            ////{
            ////    using(FileStream fsRead = new FileStream(source,FileMode.OpenOrCreate,FileAccess.Read))
            ////    {
            ////        using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate,FileAccess.Write))
            ////        {
            ////            byte[] buffer = new byte[1024 * 1024 * 6];
            ////            while(true)
            ////            {
            ////                int num = fsRead.Read(buffer, 0, buffer.Length);
            ////                if(num == 0)
            ////                {
            ////                    break;
            ////                }
            ////                fsWrite.Write(buffer, 0, num);
            ////            }
            ////        }
            ////    }
            //#endregion
            //public class Person
            //{
            //    public string _name;
            //    //public string _country;
            //    public string Name
            //    {
            //        set { _name = value; }
            //        get { return _name; }
            //    }

            //    //public string Country
            //    //{
            //    //    set { _country = value; }
            //    //    get { return _country; }
            //    //}
            //    public Person(string name)
            //    {
            //        Name = name;
            //    }
            //    public virtual void show()
            //    {
            //        WriteLine("i am Chinese, my name is: {0}", this.Name);
            //public class Japan:Person
            //{
            //    public Japan(string name) : base(name)
            //    { }
            //    public  override void show()
            //    {
            //        WriteLine("i am Japenese, my name is: {0}", this.Name);
            //    }
            //}//    }
            #endregion
            //MoveU U = new TV();
            MoveU[] us = { new TV(), new MP3() };
            for (int i = 0; i < us.Length; i++)
            {
                us[i].UPan();
            }
           // U.UPan();
            ReadKey();
        }
        #region 抽象类
        //public abstract class TypeLine//抽象类可以根多态一起使用
        //{
        //    //只有方法定义，没有方法体，实现是在继承这个抽象类中的子类中
        //    public abstract void Jiao();
        //}

        //public class Dog : TypeLine
        //{
        //    public override void Jiao()
        //    {
        //        WriteLine("猫会叫");
        //    }
        //}

        #endregion
        public abstract class MoveU
        {
            public abstract string Name { get; set; }
            public abstract void UPan();
        }
        public class TV : MoveU
        {
            public override string Name{  get; set; }

            public override void UPan()
            {
                WriteLine("U盘可以拷贝电影");
            }
        }
        public class MP3 : MoveU
        {
            public override string Name
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public override void UPan()
            {
                WriteLine("U盘可以拷贝音乐");
            }
        }
    }
}