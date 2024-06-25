using MindBoxTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Triangle : Shape
    {
        
        public double a {  get; set; }
        public double b { get; set; }
        public double c { get; set; } 

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        public override double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        /// <summary>
        /// Периметр треугольника
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }

        /// <summary>
        /// Проверку на то, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle()
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }

        internal override bool IsCorrectSides()
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
