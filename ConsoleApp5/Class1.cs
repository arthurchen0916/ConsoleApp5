﻿using System;

namespace ConsoleApp5
{
    public class hw1
    {
        public void Sort()
        {   
            Console.Write("Input X : "); //輸入兩數字做加總
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Y : ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X + Y ={0}", c + d);
            Console.WriteLine();
        }
    }
}