using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public class Tree : Barrier
    {
        public Tree(int x, int y) : base('T', x, y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Wall : Barrier
    {
        public Wall(int x, int y) : base('H', x, y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Lake : Barrier
    {
        public Lake(int x, int y) : base('O', x, y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
