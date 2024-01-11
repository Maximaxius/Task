using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_0
{
    internal class Circle : GeometricFigure
    {
        protected int _rCircle = 0;

        public Circle() : this(5)
        {
            Console.WriteLine("R5");
            FigureArea();
            FigurePerimeter();
        }
        public Circle(int rCircle)
        {
            _rCircle = rCircle;
            FigureArea();
            FigurePerimeter();
        }

        public override void FigureArea()
        {
            S = Math.PI * Math.Pow(_rCircle, 2);
        }
        public override void FigurePerimeter()
        {
            P = Math.PI *_rCircle;
        }
        public override string ToString()
        {
            return $"Circle R={_rCircle}  Area = {string.Format("{0:f3}", _S)}  Perimeter = {string.Format("{0:f3}", _P)}";
        }
    }
}
