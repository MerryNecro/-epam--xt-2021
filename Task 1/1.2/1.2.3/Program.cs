using System;

namespace _1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lowercase();
        }

        static void Lowercase()
        {
            string phrase = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            char[] phraseToChar = phrase.ToCharArray();
            int count = 0;
            bool isNewWord = true;
            for (int i = 0; i < phraseToChar.Length; i++)
            {
                if (char.IsLetter(phraseToChar[i]))
                {
                    if (isNewWord)
                    {
                        if (char.IsLower(phraseToChar[i]))
                        {
                            count++;
                        }
                        isNewWord = false;
                    }
                }
                else
                {
                    isNewWord = true;
                }
            }
            Console.WriteLine("Вывод: " + count);
        }
    }
}
