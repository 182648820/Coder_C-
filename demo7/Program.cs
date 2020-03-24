using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demo7
{
    class Program
    {
        public static int[] Maps = new int[110];
        public static int[] playerpos = new int[2];//玩家数
        public static string[] namePlayer = new string[20];
        static void Main(string[] args)
        {
            #region 1.飞行棋游戏
            InitaiMaps();//初始化地图
            GameShow();//显示地图头
            for (int i = 0; i < 2; i++)
            {
               int j = i;
                WriteLine("请输入{0}玩家姓名：", ++j);
                namePlayer[i] = ReadLine();
                while (namePlayer[i] ==""|| namePlayer[0]== namePlayer[1])
                {
                    WriteLine("名字不能为空或者姓名已存在");
                    
                    WriteLine("请重新输入{0}玩家姓名：", j);
                    namePlayer[i] = ReadLine();
                    if (namePlayer[i] != "")
                    {
                        break;
                    }
                }
            }

            Clear();
            InitaiMaps();//初始化地图
            GameShow();//显示地图头
            for (int i = 0; i < 2; i++)
            {
                int j = i;
                WriteLine("玩家{0}姓名：{1}", ++j, namePlayer[i]);
            }

            DrawMap();//画地图
            #endregion
            ReadKey();

        }
        /// <summary>
        /// 飞行棋游戏
        /// </summary>
        public static void GameShow()
        {
            //Console.BackgroundColor和Console.ForegroundColor
            //只改变它后面的代码，与它放的位置有关系
            //如果整个函数中只设置了一次，那么输出的颜色就和它的设置一样
            //如果整个函数进行了多次设置，那么就和它后面设置的会覆盖前面设置的

            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("******************************");
            //Console.BackgroundColor = ConsoleColor.Cyan;
            WriteLine("******************************");
            WriteLine("******** 飞行棋游乐园 ********");
            WriteLine("******************************");
            WriteLine("******************************");

        }

        public static void InitaiMaps()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] lanMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < lanMine.Length; i++)
            {
                Maps[lanMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }

        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMap()
        {
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Write(DrawShape(i));
            }
            WriteLine();
            
            //竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <=31 ; j++)
                {
                    Write(" ");
                }
           
                WriteLine(DrawShape(i));
            }
            //第二横行
            for (int i =65 ; i>35; i--)
            {
                Write(DrawShape(i));
            }
            //第二竖行
            for (int i =67 ; i < 72 ; i++)
            {
                WriteLine(DrawShape(i));
            }
            //第三横行
            for (int i = 73; i <104 ; i++)
            {
                Write(DrawShape(i));
            }

        }
        /// <summary>
        /// 显示的形状
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string DrawShape(int i)
        {
            string str = "";
            if (playerpos[0] == playerpos[1] && playerpos[0] == i)
            {
                str = "<>";
            }
            else if (playerpos[0] == i)
            {
                str = "A";
            }
            else if (playerpos[1] == i)
            {
                str = "B";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "#";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "*";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "/";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        str = "+";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "×";
                        break;
                }
            }
            return str;
        }
    }
}
