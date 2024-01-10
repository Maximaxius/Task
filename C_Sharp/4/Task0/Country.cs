using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wakanda
{
    class BirninZana
    {
        private int _population = 0;

        public int Population {get {return _population; } set { _population = Population; } }
        public BirninZana(int population)
        {
            this._population = population;
            Console.WriteLine($"Birnin Zana population = {_population}");
        }
        public override string ToString()
        {
            return $"Birnin Zana population = {_population}";
        }

    }
}

namespace Belarus
{
    class Minsk
    {
        private int _population = 0;

        public int Population { get { return _population; } set { _population = Population; } }

        public Minsk(int population)
        {
            this._population= population;
            Console.WriteLine($"Minsk population = {_population}");
        }
        public override string ToString()
        {
            return $"Minsk population = {_population}";
        }

    }
}

namespace Shire
{
    class Hobbiton
    {
        private int _population = 0;

        public int Population { get { return _population; } set { _population = Population; } }

        public Hobbiton(int population)
        {
            this._population = population;
            Console.WriteLine($"Hobbiton population = {_population}");
        }
        public override string ToString()
        {
            return $"Hobbiton population = {_population}";
        }

    }
}