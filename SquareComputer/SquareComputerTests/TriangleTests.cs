
using NUnit;
using SquareComputer;

namespace SquareComputerTests
{
    public class Tests
    { 
        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(3, 4, 6.08)]
        [TestCase(20, 10, 12.39)]
        public void TriangleSidesShouldBeValid(double firstSide, double secondSide, double thirdSide) 
        {
            //Arrange and Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.Multiple(() =>
                {
                    Assert.That(firstSide, Is.EqualTo(triangle.FirstSide));
                    Assert.That(secondSide, Is.EqualTo(triangle.SecondSide));
                    Assert.That(thirdSide, Is.EqualTo(triangle.ThirdSide));
                }
            );
 
        }

        [Test]
        [TestCase(-3, 4, 5)]
        [TestCase(3, -4, 5)]
        [TestCase(3, 4, -5)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -4, -5)]
        [TestCase(-3, 4, -5)]
        [TestCase(3, -4, -5)]
        [TestCase(3, 4, 0.5)]

        public void TriangleSidesShouldNotBeValid(double firstSide, double secondSide, double thirdSide)
        {
            //Arrange and Act
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(12, 13, 5)]
        [TestCase(17, 8, 15)]
        public void TriangleShouldBeRectungular(double firstSide, double secondSide, double thirdSide)
        {
            //Arrange and Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            //Assert
            Assert.That(Triangle.IsRectangular(triangle), Is.True);
        }

        [Test]
        [TestCase(3, 4, 6.08)]
        [TestCase(20, 10, 12.39)]
        public void TriangleShouldNotBeRectungular(double firstSide, double secondSide, double thirdSide)
        {
            //Arrange and Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            //Assert
            Assert.That(Triangle.IsRectangular(triangle), Is.False);
        }
    }
}