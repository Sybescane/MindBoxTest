using MindBoxTest;
using MindBoxTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public static class ShapeFactory
    {
        public static Shape CreateTriangle(double a, double b, double c)
        {
            Shape triangle = new Triangle(a, b, c);
            if (!triangle.IsCorrectSides())
            {
                throw new ArgumentException("Incorrect sides for a triangle.");
            }
            return triangle;
        }

        public static Shape CreateCircle(double radius)
        {
            Shape circle = new Circle(radius);
            if (!circle.IsCorrectSides())
            {
                throw new ArgumentException("Incorrect sides for a triangle.");
            }
            return circle;
        }

        public static Shape CreateSquare(double side)
        {
            Shape square = new Square(side);
            if (!square.IsCorrectSides())
            {
                throw new ArgumentException("Incorrect sides for a triangle.");
            }
            return square;
        }

    }
}
