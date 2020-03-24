using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo8
{
    public class Person
    {
        //注意：在类中定义方法，不能加static属性
        #region 定义属性的第一种方法
        //public string _name; //定义名字字段
        //public int _age; //定义年龄字段
        //public string Name//注意字段和这里的数据类型相对应
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        //public int Age
        //{
        //    set {
        //        if (value < 0 || value > 200)
        //            value = 23;
        //    }
        //    get { return _age; }
        //}

        //属性设置完之后，主函数调用要和属性的变量相对应才有效
        #endregion
        #region 第二种方法
        // public string Nanme { get; set; } = "zyx";
        //public int Age { get; set; } = 23;
        #endregion

        //定义字段
        private string _name;//非静态字段
        private static int _age;//静态字段
        private string _sex;

        public string Name { get; set; } = "zyx";
        public int Age { get; set; } = 28;
        public string Sex { get; set; } = "男";

        //定义构造函数
        public Person(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
        public Person(string name, int age, string sex, string hobby):this(name, age, sex)
        {
            hobby = hobby;
        }
        ~Person()
        { }
        //定义属性
        //public string Name//非静态属性
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        //public static int Age //静态属性
        //{
        //    set
        //    {
        //        if (value < 0 || value > 120)
        //            _age = 0;
        //    }
        //    get { return _age; }
        //}
        //public string Sex
        //{
        //    set { _sex = value; }
        //    get { return _sex; }
        //}

        //public void Sum(int i, int j)
        //{
        //    //this.i = i;
        //    //this.j = j;
        //    WriteLine(i);
        //    WriteLine(j);
        //    WriteLine("*********");
        //    int sum1 = i + j;
        //    WriteLine(sum1);

        //    WriteLine(this.i + this.j);
        //}

        public void show()
        {
            WriteLine("姓名：{0}\n性别：{1}", Name, Age, Sex);
        }

    }
}
