using System;
using System.Collections.Generic;

namespace _1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Averages();
        }

        static void Averages()
        {
            string phrase = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";
            char[] phraseToChar = phrase.ToCharArray();
            double midLenght = 0;//дробная средняя длина слов
            bool isNewWord = true;
            List<int> wordLenght = new List<int>();//массив длин слов
            for(int i = 0; i<phraseToChar.Length;i++)
            {
                if (char.IsLetterOrDigit(phraseToChar[i]))
                {
                    if (isNewWord)
                    {
                        wordLenght.Add(1);
                        isNewWord = false;
                    }
                    else
                    {
                        wordLenght[wordLenght.Count - 1]++;
                    }
                }
                else
                {
                    isNewWord = true;
                }
            }
            
            foreach(int i in wordLenght)
            {
                midLenght += i;
            }
            midLenght /= wordLenght.Count;
            Console.WriteLine("ВЫВОД: " + midLenght);
        }
    }
}
