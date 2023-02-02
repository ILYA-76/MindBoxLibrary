using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MindBox
{
    public abstract class Shape
    {
        public string figureName { get; private set; }

        public Shape(string figureName)
        {
            this.figureName = figureName;
        }
        public abstract double CalcSquare();
    }

    public static class ShapePrototype
    {
        public static double CalcSquare(Shape shape) => shape.CalcSquare();
    }

    public class Circle : Shape
    {
        public double radius { get; private set; }

        public Circle(string figureName, double radius) : base(figureName)
        {
            this.radius = radius;
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI * radius * radius);
        }
    }

    public class Triangle : Shape
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangle(string figureName, double a, double b, double c) : base(figureName)
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException($"Error: side can't be less 0 ");
            else if (a > b + c || b > a + c || c > a + b) throw new ArgumentException($"Error: side can't be more than sum of another sides");
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public override double CalcSquare()
        {
            double p = (a + b + c) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            return result;
        }

        public bool IsRectangular()
        {
            bool check = (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2)) ||
                          b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) ||
                          c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            return check;
        }
    }
}