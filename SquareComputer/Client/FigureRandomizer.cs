using SquareComputer;

namespace Client
{
    internal static class FigureRandomizer
    {
        private static readonly Random Random = new Random();

        private static readonly Triangle triangle = new Triangle(3, 4, 5);
        private static readonly Circle circle = new Circle(1);
        private static readonly Rectangle rectangle = new Rectangle(10, 20);

        public static IFigure GetRandomFigure()
        {
            int randomNumber = Random.Next(0, 3);
            switch (randomNumber)
            {
                case 0:
                    return circle;
                case 1:
                    return rectangle;
                case 2:
                    return triangle;
                default:
                    throw new ArgumentException("wrong generated number");
            }
        }
    }
}
