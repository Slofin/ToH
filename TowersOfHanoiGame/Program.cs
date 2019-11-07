using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class HanoiGame
    {

        int disk = -1;
        int from = -1;
        int to = -1;
        int aux = -1;

        public void Setup()
        {
            //輸入高度


            Console.WriteLine("請輸入河內塔的高度：");

            while (true)
            {
                disk = GetInput(1, 214748348);

                if (disk >= 15) // 數字太大的自我保護
                {
                    Console.WriteLine("過高的高度可能導致遊戲運作過久，你確定？(1為是，2為否)");
                    int con = GetInput(1, 2);

                    if (con == 1)
                    {
                        Console.WriteLine("河內塔的高度為：{0}", disk);
                        break;
                    }
                    else if (con == 2)
                    {
                        Console.WriteLine("請輸入河內塔的高度：");
                    }
                }
                else
                {
                    break;
                }




            }



            Console.WriteLine("起始地的柱子:(1,2,3)");

            from = GetInput(1, 3);

            Console.WriteLine("目的地的柱子：(1,2,3)");

            to = GetInput(1, 3);


            #region // 取得 第三柱子
            /* 例如 輸入 1 3  得到  2
             *      輸入 1 2  得到  3
             *      輸入 2 3  得到  1
             */
            aux = 0;
            int[] temp = { 1, 2, 3 };
            foreach (int item in temp)
            {
                if (item != from && item != to)
                {
                    aux = item;
                    break;
                }
            }
            #endregion




        }

        public void Play()
        {
            Hanoi(disk, from, to, aux);
        }


        //參考演算法: http://notepad.yehyeh.net/Content/DS/CH02/4.php
        //參考演算法: http://program-lover.blogspot.com/2008/06/tower-of-hanoi.html
        public static void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Hanoi(Disk - 1, Aux, Dest, Src);
            }
        }

        public static int GetInput(int min, int max) // 從 2019.10.24(07) 那邊抓下來的
        {
            int result = -1;

            while (true)
            {
                string input_str = Console.ReadLine();

                if (int.TryParse(input_str, out result))
                {
                    result = int.Parse(input_str);

                    //離開的條件
                    if (result >= min && result <= max)
                    {
                        break;
                    }
                    Console.WriteLine("您輸入的數字不在範圍內，請重新輸入一個數字({0}-{1})", min, max);
                }
                else
                {
                    //輸入的不是數字
                    Console.WriteLine("您輸入的不是數字，請重新輸入一個數字({0}-{1}):", min, max);
                }
            }

            return result;
        }

    }
}
