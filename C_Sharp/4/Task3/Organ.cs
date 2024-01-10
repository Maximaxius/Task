using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_3
{
//Реализовать класс Орган с характеристиками объём(мл. >0), здоровье(0-100%), сила(0-100%).
//Реализовать свойства(get set) для всех полей
    internal class Organ
    {
        protected int _volume = 0;
        protected int _health = 0;
        protected int _power = 0;

        public int Volume{get { return _volume; }set { _volume = value; }}
        public int Health { get { return _health;} set {if(value >=0 && value<=100) _health = value; }}
        public int Power { get { return _power; } set { if (value >= 0 && value <= 100) _power = value; }}

    }
}
