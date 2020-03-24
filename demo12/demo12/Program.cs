using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo12
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //int j = i;
            //j = 20;
            //WriteLine(i);//i = 10
            //WriteLine(j);//j = 20  i的值并不会随着j值的改变而改变

            //Person p = new Person();
            //p.Age = 13;
            //Person p2 = new Person();
            //p2.Age = p.Age;
            //SayHello(p2);
            //WriteLine(p.Age);
            //结果是38 因为它p2.age存放的是P.age的地址，因为地址一样，所以指向的值会因为值的改变而改变

            // int n = 3;
            //SayHello(ref n);
            //ref只是起到了让n和n1指向同一块空间而已
            //保证了n1的改变 从而改变n
            // WriteLine(n);

            // Read n = new Read();//这是错误的，接口不可以实例化
            //Read read = new People();
            //read.Book();
            IRead read = new People();
            read.Book();
            ReadKey();
        }

        public static void SayHello(ref int n1)
        {
           n1 = 38;
        }

        public partial class Person
        {
            public int _age;
            public int Age
            {
                set { _age = value; }
                get { return _age; }
            }
            public void getinfor()
            {
                WriteLine("hello ");
            }

           
        }
        public partial class Person
        {
            public void  show()
            {
                //使用之前的同名类的属性方法 要在方法中使用
               
            }
        }
        public sealed class A:Person
        {
        }

        public interface IRead
        {
            void Book();
            //接口里面定义的方法 至于方法体是在继承它的子类中实现
        }
        public class People : IRead
        {
            void IRead.Book()
            {
                //要进行的操作
                WriteLine("我是接口的书");
            }
            public void Book()
            {
                WriteLine("我是类的书");
            }
        }


    }
}
