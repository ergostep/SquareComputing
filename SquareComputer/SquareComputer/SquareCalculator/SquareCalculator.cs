namespace SquareComputer
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    public class SquareCalculator : ICalculator
    {
        #region ICalculator

        public double ComputeSquare<T>(T figure) where T : IFigure
        {
            return figure.Square;
        }
        #endregion
    }
}
