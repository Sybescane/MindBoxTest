using FigureLib;
using MindBoxTest.Interfaces;

namespace MindBoxTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape circle = ShapeFactory.CreateCircle(3);
                Console.WriteLine("circle.Area = " + circle.Area);
                Console.WriteLine("circle.Perimetr = " + circle.Perimeter);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Shape triangle = ShapeFactory.CreateTriangle(3,4,5);
                Console.WriteLine("triangle.Area = " + triangle.Area);
                Console.WriteLine("triangle.Perimetr = " + triangle.Perimeter);
                if (triangle is Triangle)
                {
                    Console.WriteLine(((Triangle)triangle).IsRightTriangle());
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Shape square = ShapeFactory.CreateCircle(3);
                Console.WriteLine("square.Area = " + square.Area);
                Console.WriteLine("square.Perimetr = " + square.Perimeter);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
