using System;
using System.Collections.Generic;

namespace NorthwindConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entries = new List<int>();
            entries.Add(1);
            entries.Add(2);
            entries.Add(3);

            int prev = 0;
            bool first = true;
            foreach (var item in entries)
            {
                if (first)
                {
                    first = false;
                }
                else if (prev < item)
                {
                    Console.WriteLine("Succes");
                }
                else
                {
                    Console.WriteLine("Error");
                }

                prev = item;
            }
            Console.ReadLine();
        }
    }
}
