using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo9
{
    public class Person
    {
        public string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public int _age;
        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }
        public string _sex;
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        //有参数的构造函数
        public Person(string name, int age, string sex) 
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
        public void Work()
        {
            WriteLine("teacher like work");
        }

    }
    public class Student:Person
    {
        public Student(string name, int age, string sex):base(name, age, sex)
        { }
        public void Study()
        {
            WriteLine("this student love study very much");
        }
        public new void Work()
        {
            WriteLine("teacher like work");
        }
    }
    public class Teacher:Student
    {//Teacher  类既有Student类的方法属性 也有Person类的方法属性
        public Teacher(string name, int age, string sex):base(name, age, sex)
        { }
        public void Work()
        {
            WriteLine("teacher like work");
        }
    }
}
