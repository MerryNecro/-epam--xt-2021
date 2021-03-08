using System;

namespace _1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            NoPositive();
        }

        static void NoPositive()
        {
            Random rand = new Random();
            int[,,] antipositiveArr = new int[6, 3, 8];
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        antipositiveArr[i, j, k] = rand.Next(-25, 25);
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (antipositiveArr[i, j, k] > 0)
                        {
                            antipositiveArr[i, j, k] = 0;
                        }
                        Console.WriteLine(antipositiveArr[i, j, k]);
                    }
                }
            }
        }
    }
}
