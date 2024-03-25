using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareComputer
{
    /// <summary>
    /// Вычисление показателей для фигуры. 
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Вычислить площадь.
        /// </summary>
        /// <typeparam name="T">Figure type.</typeparam>
        /// <param name="figure">Object, figure.</param>
        /// <returns>Square Value.</returns>
        public double ComputeSquare<T>(T figure) where T : IFigure;
    }
}
