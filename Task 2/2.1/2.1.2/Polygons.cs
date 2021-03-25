using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    public abstract class Polygon : Figure //многоугольник
    {
        public Point[] points { private set; get; }
        public Polygon(string name, params Point[] points) : base(name)
        {
            this.points = points;
            if (points.Length > points.Distinct().Count())
            {
                throw new Exception("Polygon can't contain the same points");
            }
        }

        public override double GetLength()
        {
            double length = 0;
            if (points.Length == 2) return points[0].GetDistance(points[1]);
            for (int i = 0; i < points.Length - 1; i++)
                {
                    length += points[i].GetDistance(points[i+1]);
                }
            length += points[points.Length - 1].GetDistance(points[0]);
            return length;
        }

    }

    public class Line : Polygon //линия
    {
        public Line(Point one, Point two) : base("Line", one, two) { }

        public override double GetArea()
        {
            return 0;
        }

        public override string ToString()
        {
            return name + " - Point one: " + points[0] + ", two: " + points[1];
        }

        public bool isPerpendicular(Line argument)
        {
            double x = (this.points[0].x - this.points[1].x) * (argument.points[0].x - argument.points[1].x);
            double y = (this.points[0].y - this.points[1].y) * (argument.points[0].y - argument.points[1].y);
            if (x + y < 0.000001) return true;
            return false;
        }
    }

    public class Triangle : Polygon //треугольник
    {
        public Triangle(Point one, Point two, Point three) : base("Triangle", one, two, three) { }

        public override double GetArea()
        {
            double p = GetLength()/2;
            return Math.Sqrt(p*(p-points[0].GetDistance(points[1])) * (p - points[1].GetDistance(points[2])) * (p - points[2].GetDistance(points[0])));
        }

        public override string ToString()
        {
            string result = name + " - Point one: " + points[0] + ", two: " + points[1] + ", three: " + points[2];
            return result + "; length: " + GetLength() + "; area: " + GetArea();
        }
    }

    public abstract class Quadrilateral : Polygon //прямоугольное
    {
        public Quadrilateral(string name, Point one, Point two, Point three, Point four) : base(name, one, two, three, four) 
        {
            Line a = new Line(one, two);
            Line b = new Line(two, three);
            Line c = new Line(three, four);
            Line d = new Line(four, one);
            if (!a.isPerpendicular(b) || !b.isPerpendicular(c) || !c.isPerpendicular(d))
            {
                throw new Exception("The sides of " + name + " must be perpendicular");
            }
        }

        public override double GetLength()
        {
            Line a = new Line(points[0], points[1]);
            Line b = new Line(points[1], points[2]);
            return 2*(a.GetLength() + b.GetLength());
        }

        public override double GetArea()
        {
            Line a = new Line(points[0], points[1]);
            Line b = new Line(points[1], points[2]);
            return a.GetLength() * b.GetLength();
        }

        public override string ToString()
        {
            string result = name + " - Point one: " + points[0] + ", two: " + points[1] + ", three: " + points[2] + ", four: " + points[3];
            return result + "; length: " + GetLength() + "; area: " + GetArea();
        }
    }

    public class Rectangle : Quadrilateral //прямоугольник
    {
        public Rectangle(Point one, Point two, Point three, Point four) : base("Rectangle", one, two, three, four) { }
    }

    public class Square : Quadrilateral //квадрат
    {
        public Square(Point one, Point two, Point three, Point four) : base("Rectangle", one, two, three, four)
        {
            Line a = new Line(one, two);
            Line b = new Line(two, three);
            if (Math.Abs(a.GetLength() - b.GetLength()) > 0.000001)
            {
                throw new Exception("All sides of Square must be equals");
            }
        }

        public override double GetLength()
        {
            Line a = new Line(points[0], points[1]);
            return 4 * a.GetLength();
        }

        public override double GetArea()
        {
            double a = new Line(points[0], points[1]).GetLength();
            return a * a;
        }
    }
}
