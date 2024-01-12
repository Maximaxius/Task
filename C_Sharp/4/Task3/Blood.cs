using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_3
{
    //Реализовать класс Кровь. Поля: группа, объём.
    //Реализовать конструктор по умолчанию, с параметрами, копирования; деструктор.Генератор со случайной
    //инициализацией полей.
    internal class Blood
    {
        protected string _group = "";
        protected int _volumeOfBlood = 0;

        public Blood():this("First",10)
        {

        }

        public Blood(string group,int volumeOfBlood)
        {
            _group = group;
            _volumeOfBlood= volumeOfBlood;
        }

        public void Deconstruct(out string group, out int volumeOfBlood)
        {
            group = _group;
            volumeOfBlood = _volumeOfBlood;
        }

        public override string ToString()
        {
            return $"group {_group}\nvolumeOfBlood {_volumeOfBlood} ";
        }

    }
}
