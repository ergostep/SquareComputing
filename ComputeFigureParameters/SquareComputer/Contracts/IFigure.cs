using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareComputer
{
    /// <summary>
    /// Object, which is a figure.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Square quantity.
        /// Can be computed differently.
        /// </summary>
        public double Square { get; }
    }
}
