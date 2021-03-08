using System;
using System.Collections.Generic;

namespace _1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfNumber();
        }

        static void SumOfNumber()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
