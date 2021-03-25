using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public abstract class Static : Objects
    {
        public Static(char symbol, int x, int y, bool availableToGo) : base(symbol, x, y, availableToGo) { }
    }

    public class Empty : Static
    {
        public Empty(int x, int y) : base(' ', x, y, true) { }

        public override void Print()
        {
            Console.Write(symbol);
        }
    }


    public abstract class Barrier : Static
    {
        public Barrier(char symbol, int x, int y) : base(symbol, x, y, false) { }

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(symbol);
        }

        enum Barriers { };
    }

    public abstract class Bonus : Static
    {
        public Bonus(char symbol, int x, int y) : base(symbol, x, y, true) { }

        public abstract void Append(Moveable moveable);

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(symbol);
        }
    }
}
