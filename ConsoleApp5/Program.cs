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
                case "1":
                    var x = new hw1();
                    x.Add();
                    break;

                case "2":
                    var y = new hw2();
                    y.Rank();
                    break;

                case "3":
                    var z = new hw3();
                    z.CM();
                    break;

                case "4":
                    var a = new hw4();
                    a.Guess();
                    break;

                case "5":
                    var b = new hw5();
                    b.Tree();
                    break;

                case "6":
                    var c = new hw6();
                    c.Dice();
                    break;

                case "7":
                    var d = new hw7();
                    d.Sort();
                    break;
            }
        }
    }
}