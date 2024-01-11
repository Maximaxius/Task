using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_1
{
//Создайте класс ArrayP12821(массив целого типа) с необходимыми методами.
//Этот класс должен имплементировать интерфейс IOutput.
//Метод Show() — отображает на экран элементы массива.
//Метод Show(string info) — отображает на экран элементы массива и информационное сообщение,
//указанное в параметре info. 

    internal class ArrayP12821 : IOutput,IMath
    {
        private int[] _arr;

        public int[] Arr { get { return _arr; } set { _arr = value; } }

        public void Show ()
        {
            foreach (var item in _arr)
            {
                Console.Write(item+" ");
            }
        }
        public void Show(string info)
        {
            foreach (var item in _arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"{info}"); // чтоыбы инфо 1 раз выведо 
        }

        public int Max()
        {
            return _arr.Max();
        }

        public int Min()
        {
            return _arr.Min();
        }

        public float Avg()
        {
            return (float)_arr.Average() ;
        }

        public bool Search(int valueToSerch)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == valueToSerch)
                    return true;
            }
            return false;
        }

    }
}
