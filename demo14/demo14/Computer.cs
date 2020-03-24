using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo14
{
   public class Computer
    {  
        public string Fist { get; set; }//用来存放剪刀石头布

        public int ShowFist()
        {
            Random random = new Random();
            int rNumber = random.Next(1, 4);
            switch (rNumber)
            {
                case 1:
                    this.Fist = "石头";
                    break;
                case 2:
                    this.Fist = "剪刀";
                    break;
                case 3:
                    this.Fist = "布";
                    break;
            }

            return rNumber;

        }
    }
}
