using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public abstract class Objects
    {
        public char symbol { protected set; get; }
        public int x { protected set; get; }
        public int y { protected set; get; }
        public bool availableToGo { protected set; get; }

        public Objects(char symbol, int x, int y, bool availableToGo)
        {
            this.symbol = symbol;
            this.x = x;
            this.y = y;
            this.availableToGo = availableToGo;
        }

        public abstract void Print();
    }
}
