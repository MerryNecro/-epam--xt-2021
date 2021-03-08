using System;
using System.Collections.Generic;

namespace _1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Doubler();
        }
        static void Doubler()
        {
            string inputOne = "написать программу, которая";
            string inputTwo = "описание";
            char[] charInputOne = inputOne.ToCharArray();
            char[] charInputTwo = inputTwo.ToCharArray();
            List<char> listInputTwo = new List<char>();
            string result = "";
            for (int i = 0; i < charInputTwo.Length; i++)
            {
                listInputTwo.Add(charInputTwo[i]);
            }

            for (int i = 0; i < charInputOne.Length; i++)
            {   
                if (listInputTwo.Contains(charInputOne[i]))
                {
                    result += charInputOne[i];
                    result += charInputOne[i];
                }
                else
                {
                    result += charInputOne[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
