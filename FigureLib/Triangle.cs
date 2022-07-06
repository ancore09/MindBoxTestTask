using System;

namespace FigureLib
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        
        public override double GetArea()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }

        public bool IsRight()
        {
            bool c1 = Math.Abs(A * A + B * B - C * C) < 0.0001;
            bool c2 = Math.Abs(A * A + C * C - B * B) < 0.0001;
            bool c3 = Math.Abs(C * C + B * B - A * A) < 0.0001;
            return c1 || c2 || c3;
        }
    }
}