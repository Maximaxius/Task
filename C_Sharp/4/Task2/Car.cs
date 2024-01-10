using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks_2
{
    internal class Car : Device
    {
        public int _year = 0;
        public int _speed = 0;

        public Car(string name, string characteristics, int year, int speed) : base(name, characteristics)
        {
            _name = name;
            _characteristics = characteristics;
            _year = year;
            _speed = speed;
        }


        public void Sound()
        {
            for (int i = 0; i < 2; i++)
                Console.Beep(rand.Next(100, 1000), rand.Next(100, 1000));
        }
        public void Show()
        {
            Console.WriteLine($"name of car {_name}");
        }

        public void Desc()
        {
            Console.WriteLine($"characteristics of car {_characteristics}, year {_year}, speed {_speed}");
        }
    }
}
