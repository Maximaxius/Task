using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW_05_операторы_
{
    internal class Journal
    {
        static Random rand = new();

        private string _name;
        private int _employees;

        public string Name { get { return _name; }}
        public int Employees { get { return _employees;} }

        public Journal()
        {
            _name= genName();
            _employees = rand.Next(1, 22);
        }

        public Journal(string name,int employees)
        {
            _name=name;
            _employees= employees ;
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

        public static Journal operator ++(Journal journal)
        {
            Console.WriteLine("Enter the number of employees to add");
            string? userNumber = Console.ReadLine();
            bool isNum = int.TryParse(userNumber, out int num);
            //int num = Convert.ToInt32(Console.ReadLine());
            journal._employees+= num;
            return journal;
        }

        public static Journal operator --(Journal journal)
        {
            Console.WriteLine("Enter the number of employees to subtract");
            string? userNumber = Console.ReadLine();
            bool isNum = int.TryParse(userNumber, out int num);
            journal._employees -= num;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.Equals(journal2);
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return !(journal1 == journal2);
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.Employees>journal2.Employees;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.Employees < journal2.Employees;
        }

        public override string ToString()
        {
            return $"Name {_name}  Employees {_employees}";            
        }

        public override bool Equals(object? obj)
        {            
            Journal? other = obj as Journal;
            return this.Employees.Equals(other!.Employees);
        }

        public override int GetHashCode()
        {
            return this.Employees * 22;
        }


    }
}
