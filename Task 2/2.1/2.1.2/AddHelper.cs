using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    public class AddHelper
    {
        private static AddHelper helper;

        public static AddHelper GetHelper()
        {
            if(helper == null)
            {
                helper = new AddHelper();
            }
            return helper;
        }

        public Figure AddFigure(string name)
        {
            Console.WriteLine(name + ", what you want to creat?");
            Console.WriteLine("    1) Point");
            Console.WriteLine("    2) Circle");
            Console.WriteLine("    3) Round");
            Console.WriteLine("    4) Ring");
            Console.WriteLine("    5) Line");
            Console.WriteLine("    6) Triangle");
            Console.WriteLine("    6) Rectangle");
            Console.WriteLine("    6) Square");
            switch (DrawingArea.IntValue())
            {
                case 1:
                    Console.Clear();
                    return AddPoint();
                case 2:
                    Console.Clear();
                    return AddCircle();
                case 3:
                    Console.Clear();
                    return AddRound();
                case 4:
                    Console.Clear();
                    return AddRing();
                case 5:
                    Console.Clear();
                    return AddLine();
                case 6:
                    Console.Clear();
                    return AddTriangle();
                case 7:
                    Console.Clear();
                    return AddRectangle();
                case 8:
                    Console.Clear();
                    return AddSquare();
                default:
                    return AddFigure(name);
            }
        }

        public Point AddPoint()//точка
        {
            Console.WriteLine("Enter x: ");
            int x = DrawingArea.IntValue();
            Console.WriteLine("Enter y:");
            int y = DrawingArea.IntValue();
            Console.Clear();
            return new Point(x, y);
        }

        public Circle AddCircle()//окружность
        {
            Console.WriteLine("Enter centre: ");
            Point centre = AddPoint();
            Console.WriteLine("Enter radius:");
            int radius = DrawingArea.IntValue();
            Console.Clear();
            return new Circle(centre, radius);
        }

        public Round AddRound()//круг
        {
            Console.WriteLine("Enter centre: ");
            Point centre = AddPoint();
            Console.WriteLine("Enter radius:");
            int radius = DrawingArea.IntValue();
            Console.Clear();
            return new Round(centre, radius);
        }

        public Ring AddRing()//кольцо
        {
            Console.WriteLine("Enter centre: ");
            Point centre = AddPoint();
            Console.WriteLine("Enter outher radius:");
            int outherRadius = DrawingArea.IntValue();
            Console.WriteLine("Enter  inner radius:");
            int innerRadius = DrawingArea.IntValue();
            Console.Clear();
            return new Ring(centre, outherRadius, innerRadius);
        }

        public Line AddLine()//линия
        {
            Console.WriteLine("Enter first point: ");
            Point one = AddPoint();
            Console.WriteLine("Enter second point: ");
            Point two = AddPoint();
            Console.Clear();
            return new Line(one, two);
        }

        public Triangle AddTriangle()//треугольник
        {
            Console.WriteLine("Enter first point: ");
            Point one = AddPoint();
            Console.WriteLine("Enter second point: ");
            Point two = AddPoint();
            Console.WriteLine("Enter third point: ");
            Point three = AddPoint();
            Console.Clear();
            return new Triangle(one, two, three);
        }

        public Rectangle AddRectangle()//прямоугольник
        {
            Console.WriteLine("Enter first point: ");
            Point one = AddPoint();
            Console.WriteLine("Enter second point: ");
            Point two = AddPoint();
            Console.WriteLine("Enter third point: ");
            Point three = AddPoint();
            Console.WriteLine("Enter fourth point: ");
            Point four = AddPoint();
            Console.Clear();
            return new Rectangle(one, two, three, four);
        }

        public Square AddSquare()//квадрат
        {
            Console.WriteLine("Enter first point: ");
            Point one = AddPoint();
            Console.WriteLine("Enter second point: ");
            Point two = AddPoint();
            Console.WriteLine("Enter third point: ");
            Point three = AddPoint();
            Console.WriteLine("Enter fourth point: ");
            Point four = AddPoint();
            Console.Clear();
            return new Square(one, two, three, four);
        }
    }
}
