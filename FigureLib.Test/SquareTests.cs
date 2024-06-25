namespace FigureLib.Test
{
    public class SquareTests
    {
        [Fact]
        public void Area_CalculatedCorrectly()
        {
            // Arrange
            double sideLength = 5;
            var square = new Square(sideLength);

            // Act
            double expectedArea = sideLength * sideLength;

            // Assert
            Assert.Equal(expectedArea, square.Area);
        }

        [Fact]
        public void Perimeter_CalculatedCorrectly()
        {
            // Arrange
            double sideLength = 5;
            var square = new Square(sideLength);

            // Act
            double expectedPerimeter = 4 * sideLength;

            // Assert
            Assert.Equal(expectedPerimeter, square.Perimeter);
        }
    }
}