using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myDal;

namespace MyBll
{
    public class MyBllDemo
    {
        myDalDemo dalDemo = new myDalDemo();
        public int Infor(string str_1, string str_2, string str_3)
        {
            return dalDemo.Infor(str_1, str_2,str_3);
        }
    }
}
