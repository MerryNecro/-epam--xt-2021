using System;
using CastomStrings;

namespace _2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CastomString подключен как dll
            //но редактировать его проще как проект
            CastomString abc = new CastomString("aaaaa");
            CastomString cba= new CastomString("bbbbb");

            Console.WriteLine(abc.Equals(cba));
            Console.WriteLine(abc.CompareTo(cba));
            Console.WriteLine(abc == cba);
            Console.WriteLine(abc != cba);
            Console.WriteLine(abc + cba);
            Console.WriteLine(abc.Clone());
            Console.WriteLine(abc.Contains('b'));
            Console.WriteLine(abc.GetHashCode());
            Console.WriteLine(abc.IndexOf('a'));
            Console.WriteLine(abc.LastIndexOf('a'));
            Console.WriteLine(abc.ToLower());
            Console.WriteLine(abc.ToUpper() + "!");
        }
    }
}
