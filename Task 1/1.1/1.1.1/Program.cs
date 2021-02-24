using System;

namespace _1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны: ");
            int b = int.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0) { Console.WriteLine("Неверное значение одной из сторон"); }
            else { Console.WriteLine("Площадь прямоугольника равна: " + a*b); }
        }
    }
}
