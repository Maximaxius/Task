using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_0
{
    //Реализовать класс «Составная Фигура», который может состоять из любого количества «Геометрических Фигур». 
    //Для данного класса определить метод нахождения площади фигуры.

    internal class CompositeFigure 
    {
        private GeometricFigure[] _arrFigure;
        public double _SComposive;

        public GeometricFigure[] ArrFigure { get { return _arrFigure; } set { _arrFigure = value; } }

        public void FigureArea()
        {
            foreach (var item in _arrFigure)
            {
                _SComposive += item.S;
            }
            
        }

        public void Show()
        {
            //foreach (var item in _arrFigure)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < _arrFigure.Length; i++)
            {
                Console.WriteLine($"Figure {i} {_arrFigure[i]}");
            }
        }

        public override string ToString()
        {
            Console.WriteLine($"CompositeFigure consists of {_arrFigure.Length} Figure");
            Show();
            FigureArea();
            return $"Area of CompositeFigure = {string.Format("{0:f3}", _SComposive)}";
        }
    }    
}
