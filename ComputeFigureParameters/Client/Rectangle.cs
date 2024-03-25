using SquareComputer;

namespace Client
{
    public  class Rectangle : IFigure
    {
        private readonly double _height;
        private readonly double _width;
        public double Square => this._width * this._height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
    }
}
