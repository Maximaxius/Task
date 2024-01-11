using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW_05_операторы_
{
    internal class ListBooks //<T> where T : Book,new()
    {
        List<Book> forReading = new();

        public ListBooks()
        {
            Console.WriteLine(" пустой");
        }

        public ListBooks(int lengs)
        {
            for (int i = 0; i < lengs; i++)
            {
                forReading.Add(new Book());
            }
        }

        public void addBook()
        {
            Console.WriteLine("Enter name book to add");
            string? newBook = Console.ReadLine();
            forReading.Add(new Book(newBook));
        }

        public void removeBook()
        {
            Console.WriteLine("Enter name book");
            string newBook = Console.ReadLine();
            forReading.Remove(new Book(newBook));
        }

        public void searchBook() 
        {
            Console.WriteLine("Enter name book");
            string? newBook = Console.ReadLine();
            Console.WriteLine($"\n{forReading.Contains(new Book(newBook))}\n");            
        }

        public static ListBooks operator ++(ListBooks book)
        {
            book.forReading.Add(new Book());
            return book;
        }

        
        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= forReading.Count || forReading == null)
                {
                    throw new IndexOutOfRangeException();
                }

                return forReading[index]!;

            }
            set
            {
                if (index < 0 || index >= forReading.Count || forReading == null)
                {
                    throw new IndexOutOfRangeException();
                }

                forReading[index] = (Book)value;
            }
        }


        public override string ToString()
        {
            if (forReading != null && forReading.Count > 0)
            {
                StringBuilder sb = new(forReading.Count * forReading[0]!.ToString()!.Length);
                for (int i = 0; i < forReading.Count; i++)
                {
                    sb.Append($"{i}]:{forReading[i]}\n");
                }
                return sb.ToString();
            }
            return "Obj is empty";
        }



    }
}
