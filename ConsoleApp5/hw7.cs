using System;
using System.Collections.Generic;


namespace ConsoleApp5
{
    public class hw7
    {
        public void Sort()
        {
            Random rNnmber = new Random();
            List<int> lstran = new List<int>();

            for (int i=0; i < 10; i++)
            {
                var r = rNnmber.Next(1, 100);
                Console.WriteLine(r);
                lstran.Add(r);
            }
            Console.WriteLine("---sort---");

            lstran.Sort();
            foreach (var x in lstran)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
