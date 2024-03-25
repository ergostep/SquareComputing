using SquareComputer;

namespace SquareComputerTests
{
    internal class CircleTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CircleWithNegativeAndZeroShouldThrowException(double radius)
        {
            //Arrange and Act, Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        [TestCase(1, Math.PI)]
        [TestCase(2, 4 * Math.PI)]
        public void CircleSquareShoulBeCalculatedRight(double radius, double expectedCircle)
        {
            var circle = new Circle(radius);
            Assert.That(expectedCircle, Is.EqualTo(circle.Square));
        }
    }
}
