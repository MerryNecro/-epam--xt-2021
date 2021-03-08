using System;

namespace _1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            NonNegativeSum();
        }

        static void NonNegativeSum()
        {
            int[] arr = new int[9] { -3, 4, 2, -8, 1, 6, -22, -34, 55 };
            int sum = 0;
            foreach (int i in arr)
            {
                if (i > 0) { sum += i; }
            }
            Console.WriteLine("Sum of non-negative = " + sum);
        }
    }
}
