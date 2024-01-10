using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_2
{
    internal class Steamer : Device
    {
        public int _year = 0;
        public int _capacity = 0;

        public Steamer(string name, string characteristics, int year, int capacity) : base(name, characteristics)
        {
            _name = name;
            _characteristics = characteristics;
            _year = year;
            _capacity = capacity;
        }


        public void Sound()
        {
            for (int i = 0; i < 2; i++)
                Console.Beep(rand.Next(100, 1000), rand.Next(100, 1000));
        }
        public void Show()
        {
            Console.WriteLine($"name of steamer {_name}");
        }

        public void Desc()
        {
            Console.WriteLine($"characteristics of steamer {_characteristics}, year {_year}, capacity {_capacity}");
        }
    }
}
