using SquareComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareComputer
{
    public  class Circle : IFigure
    {
        private readonly double _radius;

        public double Square => Math.PI * this._radius * this._radius;

        public Circle(double radius) 
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new ArgumentException($"Окружность  радиуса {radius} не валидна.");
            }
        }
    }
}
