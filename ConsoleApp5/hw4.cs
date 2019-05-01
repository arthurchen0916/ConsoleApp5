using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class hw4
    {
        public void Guess()
        {
            int keyin; //猜數字小遊戲設計
            int answer;
            int max;
            int min;
            int count;

            count = 0; //預設0次開始
            min = 1; //最小值
            max = 100; //最大值

            Random A = new Random();
            answer = A.Next(1, 100);

            Console.WriteLine("猜1~100內任一數字");
            do
            {
                Console.WriteLine("範圍：{0} < Lucky Number < {1}", min, max);
                keyin = Convert.ToInt32(Console.ReadLine());
                if (keyin >= min && keyin <= max)
                {
                    count += 1;
                    if (keyin == answer)
                    {
                        Console.WriteLine("Bingo !!答案就是{0}，你猜了{1}次", answer, count);
                        break;
                    }
                    else if (keyin > answer)
                    {
                        max = keyin;
                        Console.WriteLine("再小一點哦!");
                    }
                    else if (keyin < answer)
                    {
                        min = keyin;
                        Console.WriteLine("再大一點哦!");
                    }
                }
                else
                {
                    Console.WriteLine("請輸入1~100內的數字哦!");
                }
            }
            while (true);
            Console.ReadKey();
        }
    }
}
