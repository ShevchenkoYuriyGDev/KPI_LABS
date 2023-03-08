using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_2sem
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
            set
            {
                if (!IsValidTriangle(value, b, c))
                {
                    throw new ArgumentException("Invalid triangle sides.");
                }
                a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (!IsValidTriangle(a, value, c))
                {
                    throw new ArgumentException("Invalid triangle sides.");
                }
                b = value;
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (!IsValidTriangle(a, b, value))
                {
                    throw new ArgumentException("Invalid triangle sides.");
                }
                c = value;
            }
        }

        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double Perimetr()
        {
            return a + b + c;
        }
        public Point MedianIntersection()
        {
            double x = (1.0 / 3.0) * (a + b + c) * ((2.0 * b * b + 2.0 * c * c - a * a) / (4.0 * b * c));
            double y = (1.0 / 3.0) * (a + b + c) * (Math.Sqrt(3.0) / 2.0) * ((2.0 * a * a - b * b + 2.0 * c * c) / (4.0 * a * c));
            return new Point(x, y);
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }
    }
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public override string ToString()
        {
            return $"({x}///{y})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = ReadValue();
            b = ReadValue();
            c = ReadValue();
            Triangle triangle = new Triangle(a,b,c);
            Console.WriteLine($"Triangle area = {triangle.Area()}");
            Console.WriteLine($"Triangle perimetr = {triangle.Perimetr()}");
            Console.WriteLine($"Triangle median point = {triangle.MedianIntersection()}");
            Console.ReadKey();
        }
        static double ReadValue()
        {
            double value;
            while (true)
            {
                bool b = double.TryParse(Console.ReadLine(), out value);
                if (b) { return value; }
                else { Console.WriteLine("Invalid value, try again"); }
            }
        }
    }
}
