using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(String[] args)
        {
            switch (Console.ReadLine().ToString())
            {
                case "7":
                    var x = new hw7();
                    x.Sort();
                    break;
            }
        }
    }
}