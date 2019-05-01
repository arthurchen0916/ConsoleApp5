using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class hw3
    {
        public void CM()
        {
            Console.Write("請輸入要判斷的數字:"); //判斷數字為2、3、5何者之倍數
            var R = Convert.ToInt32(Console.ReadLine());
            if (R % 2 == 0 && R % 3 == 0 && R % 5 == 0)
                Console.WriteLine("是2、3、5的公倍數");
            else if (R % 2 == 0 && R % 3 == 0 && R % 5 != 0)
                Console.WriteLine("是2、3的公倍數");
            else if (R % 2 == 0 && R % 3 != 0 && R % 5 == 0)
                Console.WriteLine("是2、5的公倍數");
            else if (R % 2 != 0 && R % 3 == 0 && R % 5 == 0)
                Console.WriteLine("是3、5的公倍數");
            else if (R % 2 == 0 && R % 3 != 0 && R % 5 != 0)
                Console.WriteLine("是2的公倍數");
            else if (R % 2 != 0 && R % 3 == 0 && R % 5 != 0)
                Console.WriteLine("是3的公倍數");
            else if (R % 2 != 0 && R % 3 != 0 && R % 5 == 0)
                Console.WriteLine("是5的公倍數");
            Console.WriteLine();
        }
    }
}
