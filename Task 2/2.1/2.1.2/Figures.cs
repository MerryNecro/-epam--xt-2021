using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    public abstract class Figure
    {
        public string name { protected set;  get; }

        public Figure(string name)
        {
            this.name = name;
        }

        public abstract double GetLength();
        public abstract double GetArea();
        public abstract override string ToString();

    }

    public class Point : Figure //точка
    {
        public int x { get; }
        public int y { get; }
        
        public Point(int x, int y):base("Point")
        {
            this.x = x;
            this.y = y;
        }

        public override double GetLength()
        {
            return 0;
        }

        public override double GetArea()
        {
            return 0;
        }

        public double GetDistance(Point argument)
        {
            return Math.Sqrt(Math.Pow((this.x - argument.x), 2) + Math.Pow((this.y - argument.y), 2));
        }

        public override bool Equals(object argument)
        {
            if (argument == null || !(argument is Point)) return false;
            Point newArgument = argument as Point;

            if(this.x == newArgument.x && this.y == newArgument.y)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "{" + x + " : " + y + "}";
        }
    }

    public abstract class Сircular : Figure //круглое
    {
        public Point centre { get; }
        public double radius { get; }

        protected Сircular(String name, Point centre, double radius) : base(name)
        {
            if (radius <= 0) throw new Exception("Radius cann't be < or = 0");
            this.centre = centre;
            this.radius = radius;
        }

        public override double GetLength()
        {
            return 2 * Math.PI * radius;
        }

        public override bool Equals(object argument)
        {
            if (argument == null || !(argument is Сircular)) return false;
            Сircular newArgument = argument as Сircular;

            if (this.centre == newArgument.centre && this.radius == newArgument.radius)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return name + " - { Center: " + centre + "; radius: " + radius + "; length:" + GetLength() + "}";
        }
    }

    public class Round : Сircular //круг
    {
        public Round(Point centre, double radius) : base("Round", centre, radius) { }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return name + " - { Center: " + centre + "; radius: " + radius + "; length:" + GetLength() + "; area: " + GetArea() + "}";
        }
    }

    public class Circle : Сircular //окружность
    {
        public Circle(Point centre, double radius) : base("Circle", centre, radius){}

        public override double GetArea()
        {
            return 0;
        }
    }

    public class Ring : Figure //кольцо
    {
        public Point centre { get; }
        public Round outherCircle { get; }
        public Round innerCircle { get; }

        public Ring(Point centre, double outherRadius, double innerRadius) : base("Ring")
        {
            if (outherRadius <= innerRadius) throw new Exception("Outher radius cann't be < or = inner radius");
            this.centre = centre;
            outherCircle = new Round(centre, outherRadius);
            innerCircle = new Round(centre, innerRadius);
        }

        public override double GetLength()
        {
            return outherCircle.GetLength() + innerCircle.GetLength();
        }

        public override double GetArea()
        {
            return outherCircle.GetArea() - innerCircle.GetArea();
        }

        public override bool Equals(object argument)
        {
            if (argument == null || !(argument is Ring)) return false;

            Ring newArgument = argument as Ring;
            if (this.centre == newArgument.centre && this.outherCircle == newArgument.outherCircle && this.innerCircle == newArgument.innerCircle)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return name + " - { Center: " + centre + "; outher radius: " + outherCircle.radius + "; inner radius: " + innerCircle.radius + "; length:" + GetLength() + "; area: " + GetArea() + "}";
        }
    }
}
