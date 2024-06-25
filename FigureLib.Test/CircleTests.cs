using MindBoxTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Test
{
    public class CircleTests
    {
        [Fact]
        public void Area_CalculatedCorrectly()
        {
            // Arrange
            double radius = 3;
            var circle = new Circle(radius);

            // Act
            double expectedArea = Math.PI * radius * radius;

            // Assert
            Assert.Equal(expectedArea, circle.Area, precision: 10);
        }

        [Fact]
        public void Perimeter_CalculatedCorrectly()
        {
            // Arrange
            double radius = 3;
            var circle = new Circle(radius);

            // Act
            double expectedPerimeter = 2 * Math.PI * radius;

            // Assert
            Assert.Equal(expectedPerimeter, circle.Perimeter, precision: 10);
        }
    }
}
