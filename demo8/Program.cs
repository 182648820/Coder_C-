using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 类
            //Person是一个类，下面是实例化一个Person类的对象；
            //这个对象person具有Person这个类的属性和方法

            //Person person = new Person();//定义一个实例，New person 指的是在内存中开辟一个空间
            //person.Name = "ZYX";//非静态属性
            //Person.Age = -20;//静态属性
            //person.Sex = "男";
            //person.show();
            //WriteLine("姓名：{0}\n年龄：{1}\n性别：{2}", person.Name, person.Age, person.Sex);
            #endregion

            #region 构造函数
            #endregion
            Person p = new Person("zyx",28, "女");
            p.show();
            ReadKey();
        }
    }
}
