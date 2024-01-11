using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_0
{
    class Triangle : GeometricFigure
    {
        protected int _aTriangle = 0;
        protected int _bTriangle = 0;
        protected int _cTriangle = 0;

        public Triangle():this(5,5,5)
        {
            Console.WriteLine($"a={_aTriangle} b={_bTriangle} c={_cTriangle}");
            FigureArea();
            FigurePerimeter();
        }
        public Triangle(int aTriangle,int bTriangle,int cTriangle)
        {
            _aTriangle= aTriangle;
            _bTriangle= bTriangle;
            _cTriangle= cTriangle;
            FigureArea();
            FigurePerimeter();
        }

        public override void FigureArea()
        {
            S = _aTriangle * _bTriangle /2;
        }
        public override void FigurePerimeter()
        {
            P = _aTriangle + _bTriangle + _cTriangle;
        }
        public override string ToString()
        {
            return $"Triangle  {base.ToString()}";
        }

    }
}
