using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class hw2
    {
        public void Rank()
        {
            Console.Write("請輸入數字1~100內佳:"); //輸入數字做結果判斷
            var e = Convert.ToInt32(Console.ReadLine());
            if (e > 100)
                Console.WriteLine("Error");
            else if (e >= 0 & e <= 60)
                Console.WriteLine("C");
            else if (e >= 61 & e <= 80)
                Console.WriteLine("B");
            else if (e >= 81 & e <= 100)
                Console.WriteLine("A");
                Console.ReadKey();
        }
    }
}
