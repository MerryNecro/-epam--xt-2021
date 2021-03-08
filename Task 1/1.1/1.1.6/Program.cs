using System;
using System.Collections.Generic;

namespace _1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Font_Adjustment();
        }

        static void Font_Adjustment()
        {
            List<String> font = new List<string>();
            bool stop = false;
            int choose;
            string result;
            while (stop == false)
            {
                Console.WriteLine("Введите: " + Environment.NewLine + "1. Bold" + Environment.NewLine + "2. Italic" + Environment.NewLine + "3. Underline" + Environment.NewLine + "4. Exit");
                while (!int.TryParse(Console.ReadLine(), out choose)) { }
                switch (choose)
                {
                    case 1:
                        if (font.Contains("Bold"))
                        {
                            font.Remove("Bold");
                        }
                        else
                        {
                            font.Add("Bold");
                        }
                        result = string.Join(", ", font);
                        Console.Clear();
                        Console.WriteLine("Параметры вывода: " + result);
                        break;
                    case 2:
                        if (font.Contains("Italic"))
                        {
                            font.Remove("Italic");
                        }
                        else
                        {
                            font.Add("Italic");
                        }
                        result = string.Join(", ", font);
                        Console.Clear();
                        Console.WriteLine("Параметры вывода: " + result);
                        break;
                    case 3:
                        if (font.Contains("Underline"))
                        {
                            font.Remove("Underline");
                        }
                        else
                        {
                            font.Add("Underline");
                        }
                        result = string.Join(", ", font);
                        Console.Clear();
                        Console.WriteLine("Параметры вывода: " + result);
                        break;
                    case 4:
                        Console.Clear();
                        stop = true;
                        break;
                }
            }
        }
    }
}
