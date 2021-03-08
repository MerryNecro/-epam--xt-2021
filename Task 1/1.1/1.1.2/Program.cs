using System;

namespace _1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle();
        }

        static void Triangle()
        {
            Console.WriteLine("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            String str = "";
            for (int i = 0; i < n; i++)
            {
                str += "*";
                Console.WriteLine(str);
            }
        }
    }
}
