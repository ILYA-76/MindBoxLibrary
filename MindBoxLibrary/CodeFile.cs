
using System;

namespace MindBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", 10);
            Triangle triangle = new Triangle("Triangle", 4, 3, 5);

            Console.WriteLine(circle.CalcSquare());
            Console.WriteLine(triangle.CalcSquare());
        }
    }
}