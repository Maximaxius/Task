using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW_05_операторы_
{
    internal class Book
    {
        static Random rand = new Random();
        public string Name { get; set; }

        public Book()
        {            
            Name = genName();
        }

        public Book(string name)
        {
            Name = name;
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
                        
        public override string ToString()
        {
            return $"Book {Name}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Book) return false;

            Book? other = obj as Book;
            return this.Name.Equals(other!.Name);
        }
    }
}
