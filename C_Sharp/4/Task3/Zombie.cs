using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks_3
{
    //Реализовать класс Зомбовек.
    //Определить внутри поля для объектов классов: сердце, лёгкие, кровь.
    //Добавить дополнительно поля: имя, статус(жив/мёртв), возраст.
    //● Реализовать конструктор по умолчанию, конструктор с параметрами.
    //● Реализовать метод для генерирования случайным образом случайных полей
    //Поле статус зависит от того, инициализированы ли жизненно важные поля: лёгкие, кровь, сердце.
    //Если какого-то из полей нет ( == null), статус ставится “мёртв”. В иных случаях — “жив” (Кодировать
    //поле можно любым удобным образом).
    //● Добавить метод для трансплантации из зомбовека каждого из объектов классов сердце, лёгкие, кровь.

    internal class Zombie
    {
        Random rand = new Random();
        protected Heart _heart = new Heart();
        protected Lungs _lungs = new Lungs();
        protected Blood _blood = new Blood();
        protected string _name = "";
        protected string _status = "";
        protected int _age = 0;

        public Zombie() : this(new Heart(), new Lungs(), new Blood(), "Zoomby man", 22)
        {
        }
        public Zombie(Heart heart, Lungs lungs, Blood blood, string name, int age)
        {
            _heart = heart;
            _lungs = lungs;
            _blood = blood;
            _name = name;
            _age = age;
            if (_lungs == null || _blood == null || _heart == null)
            {
                _status = "dead";
            }
            else _status = "life";
        }

        //НЕсделанно
        //public void GenZomby()
        //{
        //    int hearChange = rand.Next(2);
        //    if (hearChange == 0)
        //        _heart = null;
        //    else _heart= new Heart();
        //    int lungsChange = rand.Next(2);
        //    if (lungsChange == 0)
        //        _lungs = null;
        //    else _lungs = new Lungs();
        //    int bloodChange = rand.Next(2);
        //    if (bloodChange == 0)
        //        _blood = null;
        //    else _blood = new Blood();
        //    if (_lungs == null || _blood == null || _heart == null)
        //    {
        //        _status = "dead";
        //    }
        //    else _status = "life";
        //    _age = rand.Next(18, 100 + 1);
        //}
        public override string ToString()
        {
            return $"{_heart}\n{_lungs}\n{_blood}\n {_name} {_status} {_age} ";
        }

    }

}
