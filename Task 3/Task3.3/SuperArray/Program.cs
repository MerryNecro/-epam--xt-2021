using System;

namespace SuperArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 3, 8, 1};
            arr.DoChosenAction(e => e*2);
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Environment.NewLine); 
            

            int a = arr.Sum();
            Console.WriteLine(a + Environment.NewLine);


            double b = arr.Average();
            Console.WriteLine(b + Environment.NewLine);


            a = arr.MostRepeatable();
            Console.WriteLine(a + Environment.NewLine);
        }
    }
}
