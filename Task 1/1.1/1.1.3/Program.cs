using System;

namespace _1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                String str = "";
                for (int j = 0; j < 10 - i; j++)
                {
                    str += " ";
                }
                for(int j = 0; j < 2*i+1; j++)
                {
                    str += "*";
                }
                Console.WriteLine(str);
            }
        }
    }
}
