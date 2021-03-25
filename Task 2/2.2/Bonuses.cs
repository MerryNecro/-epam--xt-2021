using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public class Health : Bonus
    {
        public Health(int x, int y) : base('H', x, y) 
        {
            this.x = x;
            this.y = y;
        }

        public override void Append(Moveable moveable)
        {
            moveable.health++;
        }
    }
    public class Mana : Bonus
    {
        public Mana(int x, int y) : base('M', x, y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Append(Moveable moveable)
        {
            moveable.damage++;
        }
    }

    public class Stamina : Bonus
    {
        public Stamina(int x, int y) : base('S', x, y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Append(Moveable moveable)
        {
            moveable.stepLength++;
        }
    }
}
