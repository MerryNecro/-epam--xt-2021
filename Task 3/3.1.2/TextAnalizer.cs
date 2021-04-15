using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2
{
    class TextAnalizer
    {
        string Text;

        public TextAnalizer()
        {
            int switchValue = 0;

            Console.WriteLine("Введите текст: " + Environment.NewLine);
            StringBuilder sb = new StringBuilder(Console.ReadLine());


            while (switchValue != 2)
            {
                Console.WriteLine(Environment.NewLine+"Что вы хотите сделать?");
                Console.WriteLine("   1) Продолжить печатать");
                Console.WriteLine("   2) Посмотреть результаты" + Environment.NewLine);

                int.TryParse(Console.ReadLine(), out switchValue);

                switch (switchValue)
                {
                    case 1:
                        Console.WriteLine(Environment.NewLine + "Продолжайте печатать:" + Environment.NewLine);
                        sb.Append(Console.ReadLine());
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }

            Text = sb.ToString().ToLower();
            TextSplit();
        }
        
        public void TextSplit()
        {
            string[] separators = new string[] { " ", "!", ",", ".", "?", ";", ":", "(", ")", "-"};

            string[] subs = Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> WordFrequency = new Dictionary<String, int>();


            for (int i = 0; i < subs.Length; i++)
            {
                if (WordFrequency.ContainsKey(subs[i]))
                {
                    WordFrequency[subs[i]]++;
                }

                else
                {
                    WordFrequency.Add(subs[i], 1);
                }
            }

            List<Word> words = new List<Word>();

            foreach(var item in WordFrequency)
            {
                words.Add(new Word(item.Key, item.Value));
            }

            words.Sort(delegate (Word x, Word y)
            {
                if (x.WordFrequency < y.WordFrequency) return 1;
                if (x.WordFrequency == y.WordFrequency) return 0;
                return -1;
            });

            Console.WriteLine( );

            Console.WriteLine("Самые часто используемые слова:");
            for(int i = 0; i < 5 && i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine();

            if (words.Count() / subs.Count() > 0.2)
            {
                Console.WriteLine("Вы довольно часто повторяетесь");
            }
            else Console.WriteLine("Вы молодец!");
        }
    }
}
