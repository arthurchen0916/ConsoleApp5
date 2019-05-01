using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class hw6
    {
        public void Dice()
        {
            Console.WriteLine("====請輸入您想投擲骰子的次數===");
            int i;
            int n = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
            int[] ary = new int[n];


            Random Dice = new Random();
            for (i = 1; i <= n; i++)
            {
                int num = Dice.Next(1, 7);
                switch (num)
                {
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;
                }
                ary[i - 1] = num;
            }
            Console.WriteLine("1出現的次數為:{0}次", (num1));
            Console.WriteLine("2出現的次數為:{0}次", (num2));
            Console.WriteLine("3出現的次數為:{0}次", (num3));
            Console.WriteLine("4出現的次數為:{0}次", (num4));
            Console.WriteLine("5出現的次數為:{0}次", (num5));
            Console.WriteLine("6出現的次數為:{0}次", (num6));
            Console.WriteLine();



            int y = 1;

            while (y != 0)
            {
                Console.WriteLine("===您可繼續查看第N次的投擲結果(請輸入數字；輸入0即離開)===");

                y = Convert.ToInt32(Console.ReadLine());
                if (y == 0)
                {
                    Console.WriteLine("Exit");
                }
                else if (y > n || y < 0)
                {
                    Console.WriteLine("輸入投擲次數內之數字");
                }
                else
                {
                    Console.WriteLine("第{1}次的投擲結果為{0}", ary[y - 1],y);
                }

            }
            Console.ReadKey();
        }
    }
}
