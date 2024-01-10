using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_3
{
    //Используя наследование класса Орган, реализовать класс Лёгкие с полями: объем, здоровье,
    //сила(объём воздухав минуту). Перегрузить ToString().
    internal class Lungs:Organ
    {
        public override string ToString()
        {
            return $"volume {_volume}\nhealth {_health}\npower{_power} ";
        }
    }
}
