using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать абстрактный класс «Геометрическая Фигура» с методами 
//•	«Площадь Фигуры» и «Периметр Фигуры»

namespace Tasks_0
{
    abstract class GeometricFigure
    {
        protected double _S;
        protected double _P;
        public double S { get { return _S; } set { _S = value > 0 ? value : 0; } }
        public double P { get { return _P; } set { _P = value > 0 ? value : 0; } }

        public abstract void FigureArea();
        public abstract void FigurePerimeter();

        public override string ToString()
        {
            return $"Area = {_S}  Perimeter = {_P}";
        }
    }
}
