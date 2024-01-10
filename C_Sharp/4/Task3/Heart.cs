using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks_3
{
//Используя наследование от класса Орган, реализовать класс Сердце с полями: объем, здоровье, сила
//(пояснение: ритм (среднее сердцебиение в пробуждённом состоянии)) — из базового класса; добавить
//характеристику объём крови, прокачиваемый в минуту.
//Реализовать конструктор с параметрами, декоструктор, генератор для случайной инициализации
//значений.Перегрузить ToString().
    internal class Heart : Organ
    {
        protected int _volumeOfBloodPumpedPerMinute = 0;

        public Heart()                        ///Не генератор для случайной инициализациизначений а конструктор по умолчанию
        {
            Random rand = new Random();
            _volume = rand.Next(100);
            _health = rand.Next(100);
            _power = rand.Next(100);
            _volumeOfBloodPumpedPerMinute = rand.Next(100);
        }
        public Heart(int volume, int health, int power, int volumeOfBloodPumpedPerMinute)
        {
            _volume=volume;
            _health = health;
            _power = power;
            _volumeOfBloodPumpedPerMinute=volumeOfBloodPumpedPerMinute;
        }

        public void Deconstruct(out int volume, out int health, out int power, out int volumeOfBloodPumpedPerMinute)
        {
            volume = _volume;
            health = _health;
            power = _power;
            volumeOfBloodPumpedPerMinute = _volumeOfBloodPumpedPerMinute;
        }

        public override string ToString()
        {
            return $"volume {_volume}\nhealth {_health}\npower {_power}\nvolumeOfBloodPumpedPerMinute {_volumeOfBloodPumpedPerMinute} ";
        }
    }
}
