using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Test
{
    public class TriangleTests
    {
        [Fact]
        public void Area_CalculatedCorrectly()
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            var triangle = new Triangle(a, b, c);

            // Act
            double expectedArea = 6;

            // Assert
            Assert.Equal(expectedArea, triangle.Area, precision: 10);
        }

        [Fact]
        public void Perimeter_CalculatedCorrectly()
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            var triangle = new Triangle(a, b, c);

            // Act
            double expectedPerimeter = a + b + c;

            // Assert
            Assert.Equal(expectedPerimeter, triangle.Perimeter);
        }

        [Fact]
        public void IsRightTriangle_DetectedCorrectly()
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            var triangle = new Triangle(a, b, c);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }
    }
}
