using MindBoxTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Test
{
    public class ShapeFactoryTests
    {
        [Fact]
        public void CreateTriangle_CreatesInstance()
        {
            // Arrange
            double a = 3, b = 4, c = 5;

            // Act
            var triangle = ShapeFactory.CreateTriangle(a, b, c);

            // Assert
            Assert.NotNull(triangle);
            Assert.IsType<Triangle>(triangle);
        }

        [Fact]
        public void CreateSquare_CreatesInstance()
        {
            // Arrange
            double sideLength = 5;

            // Act
            var square = ShapeFactory.CreateSquare(sideLength);

            // Assert
            Assert.NotNull(square);
            Assert.IsType<Square>(square);
        }

        [Fact]
        public void CreateCircle_CreatesInstance()
        {
            // Arrange
            double radius = 3;

            // Act
            var circle = ShapeFactory.CreateCircle(radius);

            // Assert
            Assert.NotNull(circle);
            Assert.IsType<Circle>(circle);
        }
    }
}
