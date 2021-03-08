using System;

namespace _1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDArray();
        }

        static void TwoDArray()
        {
            int[,] arr = new int[4, 5];
            Random random = new Random();
            int randomNumber = 0;
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    randomNumber = random.Next(7, 99);
                    arr[i, j] = randomNumber;
                    if ((i + j) % 2 == 0)
                    {
                        sum += randomNumber;
                    }

                }
            }
            Console.WriteLine("Сумма элементов = " + sum);

        }
    }
}
