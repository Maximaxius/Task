using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_0
{
    internal class Rectangle : GeometricFigure
    {
        protected int _aRectangle = 0;
        protected int _bRectangle = 0;

        public Rectangle() : this(5, 5)
        {
            Console.WriteLine($"a={_aRectangle} b={_bRectangle}");
            FigureArea();
            FigurePerimeter();
        }
        public Rectangle(int aRectangle, int bRectangle)
        {
            _aRectangle = aRectangle;
            _bRectangle = bRectangle;
            FigureArea();
            FigurePerimeter();
        }

        public override void FigureArea()
        {
            S = _aRectangle * _bRectangle;
        }
        public override void FigurePerimeter()
        {
            P = (_aRectangle + _bRectangle)*2;
        }
        public override string ToString()
        {
            return $"Rectangle A={_aRectangle} B={_bRectangle}  {base.ToString()}";
        }
    }
}
