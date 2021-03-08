using System;

namespace _1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator(Console.ReadLine());
        }

        static void Validator(string enter)
        {
            char[] enterToChar = enter.ToCharArray();
            bool toUp = true;
            for (int i = 0; i < enterToChar.Length; i++)
            {
                if (char.IsLetter(enterToChar[i]))
                {
                    if (toUp == true)
                    {
                        enterToChar[i] = char.ToUpper(enterToChar[i]);
                        toUp = false;
                    }
                }
                if (enterToChar[i] == '!' || enterToChar[i] == '?' || enterToChar[i] == '.')
                {
                    toUp = true;
                }
            }

            foreach(char i in enterToChar)
            {
                Console.Write( i);
            }
        }
    }
}
