using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    class User
    {
        public string name { get; }
        private List<Figure> figures = new List<Figure>();

        public User(string name)
        {
            this.name = name;
        }

        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
        }
        
        public void WriteAllFigures()
        {
            Console.Clear();
            if (figures.Count == 0)
            {
                Console.WriteLine("There are no figures");
            }
            else
            {
                for (int i = 0; i < figures.Count(); i++)
                {
                    int j = i + 1;
                    Console.WriteLine(j + ") " + figures[i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void DeleteAllFigures()
        {
            figures = new List<Figure>();
            Console.Clear();
            Console.WriteLine("All figures was deleted!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
