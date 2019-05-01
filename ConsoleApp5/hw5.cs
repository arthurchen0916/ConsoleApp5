using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class hw5
    {
        public void Tree()
        {
            Console.WriteLine("===請輸入您想要的聖誕樹階層===");
            int n = Convert.ToInt32(Console.ReadLine());///聖誕樹(2"for"+1"if else")
            int i, j;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j < n + i; j++)
                {
                    if (j <= n - i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
