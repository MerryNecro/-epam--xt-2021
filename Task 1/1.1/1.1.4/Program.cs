using System;

namespace _1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Xmas_Tree();
        }

        static void Xmas_Tree()
        {
            Console.WriteLine("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            for (int m = 1; m <= n; m++)
            {
                for (int i = 0; i < m; i++)
                {
                    String str = "";
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        str += " ";
                    }
                    for (int j = 0; j < 2 * i + 1; j++)
                    {
                        str += "*";
                    }
                    Console.WriteLine(str);
                }
            }
        }
    }
}
