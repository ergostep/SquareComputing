using SquareComputer;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("SquareComputerTests")]

namespace SquareComputer
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IFigure
    {
        #region Fields and Properties.

        /// <summary>
        /// Первая сторона.
        /// </summary>
        private readonly double _firstSide;

        internal double FirstSide
        {
            get => this._firstSide;
        }


        /// <summary>
        /// Вторая сторона.
        /// </summary>
        private readonly double _secondSide;
        internal double SecondSide
        {
            get => this._secondSide;
        }

        /// <summary>
        /// Third trianle side.
        /// </summary>
        private readonly double _thirdSide;

        internal double ThirdSide
        {
            get => this._thirdSide;
        }
        #endregion

        #region IFigure.

        public  double Square => this.ComputeTriangleSquare();

        #endregion

        #region Methods.

        /// <summary>
        /// Вычисляем площадь по формуле Герона https://ru.wikipedia.org/wiki/%D0%A4%D0%BE%D1%80%D0%BC%D1%83%D0%BB%D0%B0_%D0%93%D0%B5%D1%80%D0%BE%D0%BD%D0%B0.
        /// </summary>
        /// <returns> Площадь треугольника.</returns>
        private double ComputeTriangleSquare()
        {
            var p = (this._firstSide + this._secondSide + this._thirdSide) / 2;

            // geron
            return Math.Sqrt(p * (p - this._firstSide) * (p - this._secondSide) * (p - this._thirdSide));
        }

        /// <summary>
        /// Проверяем валидность сторон треугольника при его создании.
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns> Валидны ли стороны? </returns>
        private static bool IsValid(double firstSide, double secondSide, double thirdSide)
        {
            return 
                (firstSide + secondSide > thirdSide) &&
                (secondSide + thirdSide > firstSide) &&
                (thirdSide + firstSide > secondSide);
        }

        /// <summary>
        /// Определяем, что полученный треугольник является прямоугольным по теореме Пифагора.
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns> Треугольник прямоугольный?.</returns>
        public static bool IsRectangular(Triangle triangle)
        {
            double [] sides = { triangle.FirstSide, triangle.SecondSide, triangle.ThirdSide };
            var hypotenuse = sides.Max();
            var legs = sides.Where(side => side != hypotenuse).ToArray();
            // теорема пифагора.
            return legs[0] * legs[0] + legs[1] * legs[1] == hypotenuse * hypotenuse;

        }
        #endregion

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (IsValid(firstSide, secondSide, thirdSide)) 
            {
                _firstSide = firstSide;
                _secondSide = secondSide;
                _thirdSide = thirdSide;
            }
            else
            {
                throw new ArgumentException($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} не валиден.");
            }
        }
    }
}
