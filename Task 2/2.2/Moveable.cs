using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public abstract class Moveable : Objects
    {
        public Moveable(char symbol, int x, int y) : base(symbol, x, y, false) { }

        public int health = 2;
        public int damage = 1;
        public int stepLength = 1;

        public void Move()
        {

        }
    }

    public class Enemy : Moveable
    {
        public Enemy(int x, int y) : base('¤', x, y) { }

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(symbol);
        }
    }

    public class User : Moveable
    {
        public User(int x, int y) : base('§', x, y) { }

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(symbol);
        }
    }
}
