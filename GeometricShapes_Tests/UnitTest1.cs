using FluentAssertions;
using GeometricShapes.Interfaces;
using GeometricShapes.Models;
using GeometricShapes.Services;
using Xunit;

namespace GeometricShapes_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CircleService_GetArea_ReturnArea()
        {
            // Arrange
            var circleService = new CircleService(new Circle() { Radius = 5.0 });

            // Act 
            var actualArea = circleService.GetArea();

            // Assert
            actualArea.Should().BePositive();
            Assert.Equal(78.53981633974483, actualArea, 0.0001);
        }

       [Fact]
        public void TriangleService_GetArea_ReturnArea()
        {
            // Arrange
            var triangleService = new TriangleService(new Triangle() { Side1 = 3, Side2 = 4, Side3 = 6 });

            // Act 
            var actualArea = triangleService.GetArea();

            // Assert
            actualArea.Should().BePositive();
            Assert.Equal(5.332682251925386, actualArea, 0.0001);
        }

        [Fact]
        public void AnotherShapeService_GetArea_ReturnArea()
        {
            // Arrange
            var anotherShapeService = new AnotherShapeService(new AnotherShape() { Length = 6, Width = 8 });

            // Act 
            var actualArea = anotherShapeService.GetArea();

            // Assert
            actualArea.Should().BePositive();
            Assert.Equal(48, actualArea, 0.0001);
        }

        [Fact]
        public void TriangleService_GetRightTriangleArea_ReturnArea()
        {
            // Arrange
            var triangleService = new TriangleService(new Triangle() { Side1 = 3, Side2 = 4, Side3 = 5 });

            // Act 
            bool isRightTriangle = ((TriangleService)triangleService).IsRightTriangle();
            double actualArea = triangleService.GetRightTriangleArea();

            // Assert
            actualArea.Should().BePositive();
            Assert.True(isRightTriangle);
            Assert.Equal(5, actualArea, 0.0001);
        }
    }
}