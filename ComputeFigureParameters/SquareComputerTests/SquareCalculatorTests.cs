using SquareComputer;

namespace SquareComputerTests
{
    internal class SquareCalculatorTest
    {
        private ICalculator squareCalculator;

        [SetUp]
        public void Setup()
        {
            this.squareCalculator = new SquareCalculator();
        }

        [Test]
        public void SquareCalculatorForTriangleShoudReturnRightSquare()
        {
            var triangle = new Triangle(3, 4, 5);
            var square = squareCalculator.ComputeSquare(triangle);
            Assert.That(square, Is.EqualTo(6));
        }

        [Test]
        public void SquareCalculatorForCircleShoudReturnRightSquare()
        {
            var circle = new Circle(1);
            var square = squareCalculator.ComputeSquare(circle);
            Assert.That(square, Is.EqualTo(Math.PI));
        }
    }
}
