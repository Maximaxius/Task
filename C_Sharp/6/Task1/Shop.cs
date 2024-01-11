using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW_05_операторы_
{
    internal class Shop
    {
        static Random rand = new();

        public string _name { get; set; }
        public int _area { get; set; }

        public Shop()
        {
            _name = genName();
            _area = rand.Next(1, 22);
        }

        public Shop(string name, int area)
        {
            _name = name;
            _area = area;
        }

        private string genName()
        {
            short length = (short)rand.Next(2, 10);
            StringBuilder sb = new StringBuilder();
            sb.Append((char)rand.Next('A', 'Z' + 1));

            for (int i = 0; i < length - 1; i++)
                sb.Append((char)rand.Next('a', 'z' + 1));

            return sb.ToString();
        }

        public static Shop operator ++(Shop shop)
        {
            Console.WriteLine("Enter the number of area to add");
            string? userNumber = Console.ReadLine();
            bool isNum = int.TryParse(userNumber, out int num);
            shop._area += num;
            return shop;
        }

        public static Shop operator --(Shop shop)
        {
            Console.WriteLine("Enter the number of area to subtract");
            string? userNumber = Console.ReadLine();
            bool isNum = int.TryParse(userNumber, out int num);
            shop._area -= num;
            return shop;
        }

        public static bool operator ==(Shop journal1, Shop journal2)
        {
            return journal1.Equals(journal2);
        }

        public static bool operator !=(Shop journal1, Shop journal2)
        {
            return !(journal1 == journal2);
        }

        public static bool operator >(Shop journal1, Shop journal2)
        {
            return journal1._area > journal2._area;
        }

        public static bool operator <(Shop journal1, Shop journal2)
        {
            return journal1._area < journal2._area;
        }

        public override string ToString()
        {
            return $"Name {_name}  Area of shop {_area}";
        }

        public override bool Equals(object? obj)
        {
            Shop? other = obj as Shop;
            return this._area.Equals(other!._area);
        }

        public override int GetHashCode()
        {
            return this._area * 22;
        }
    }
}
