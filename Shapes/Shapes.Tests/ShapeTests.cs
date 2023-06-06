using NUnit.Framework;
using Shapes.Figures;
using Shapes.Interfaces;

namespace Shapes.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void Circle_CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = 78.53981633974483;
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void Triangle_CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateArea_Dynamic_ReturnsCorrectArea()
        {
            // Arrange
            IShape shape = new Triangle(3, 4, 5);

            // Act
            double area = shape.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            // Arrange
            double side1 = 4;
            double side2 = 5;
            double side3 = 6;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }

        [Test]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double side1 = 5;
            double side2 = 10;
            double side3 = 25;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }
    }
}