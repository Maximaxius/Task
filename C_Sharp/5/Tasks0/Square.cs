using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_0
{
    class Square :GeometricFigure
    {
        protected int _aSquare = 0;

        public Square() : this(5)
        {
            Console.WriteLine("side = 5");
            FigureArea();
            FigurePerimeter();
        }
        public Square(int aSquare)
        {
            _aSquare = aSquare;
            FigureArea();
            FigurePerimeter();
        }

        public override void FigureArea()
        {
            S = _aSquare * _aSquare;
        }
        public override void FigurePerimeter()
        {
            P= 4 * _aSquare;           
        }
        public override string ToString()
        {
            return $"Square {base.ToString()}";
        }

    }
}
