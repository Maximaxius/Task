namespace C_HW_05_операторы_
{
    internal class Program
    {
        static void Main()
        {
            //Задание 1
            //Ранее в одном из практических заданий вы создавали
            //класс «Журнал». Добавьте к уже созданному классу инфор-
            //мацию о количестве сотрудников. Выполните перегрузку
            //+ (для увеличения количества сотрудников на указанную
            //величину), — (для уменьшения количества сотрудников
            //на указанную величину), == (проверка на равенство ко-
            //личества сотрудников), < и > (проверка на меньше или
            //больше количества сотрудников), != и Equals.Используйте
            //механизм свойств для полей класса.
            //Journal journal = new Journal("Stepa",11);
            //Journal journal2 = new Journal();
            //Console.WriteLine(journal);
            //Console.WriteLine(journal2);
            //++journal;
            //Console.WriteLine(journal);

            //--journal;
            //Console.WriteLine(journal);

            //Console.WriteLine("\njournal == journal2");
            //Console.WriteLine(journal == journal2);
            //Console.WriteLine("\njournal != journal2");
            //Console.WriteLine(journal != journal2);
            //Console.WriteLine("\njournal > journal2");
            //Console.WriteLine(journal > journal2);
            //Console.WriteLine("\njournal < journal2");
            //Console.WriteLine(journal < journal2);


            //Ранее в одном из практических заданий вы создава-
            //ли класс «Магазин». Добавьте к уже созданному классу
            //информацию о площади магазина.Выполните перегруз-
            //ку + (для увеличения площади магазина на указанную
            //величину), — (для уменьшения площади магазина на
            //указанную величину), == (проверка на равенство площа -
            //дей магазинов), < и > (проверка на меньше или больше
            //площади магазина), != и Equals.Используйте механизм
            //свойств для полей класса.
            //Shop shop = new Shop("Stepa", 11);
            //Shop shop2 = new Shop();
            //Console.WriteLine(shop);
            //Console.WriteLine(shop2);
            //++shop;
            //Console.WriteLine(shop);

            //--shop;
            //Console.WriteLine(shop);

            //Console.WriteLine("\nshop == shop2");
            //Console.WriteLine(shop == shop2);
            //Console.WriteLine("\nshop != shop2");
            //Console.WriteLine(shop != shop2);
            //Console.WriteLine("\nshop > shop2");
            //Console.WriteLine(shop > shop2);
            //Console.WriteLine("\nshop < shop2");
            //Console.WriteLine(shop < shop2);


            //Задание 3
            //Создайте приложение «Список книг для прочтения».
            //Приложение должно позволять добавлять книги в спи -
            //сок, удалять книги из списка, проверять есть ли книга в
            //списке, и т. д.Используйте механизм свойств, перегрузки
            //операторов, индексаторов.

            ListBooks listBooks = new(3);
            Console.WriteLine(listBooks);
           
            listBooks[1] = new Book("asd");

            while (true)
            {
                Console.WriteLine("enter 1 for add\n\t2 for remove\n\t3 for search\n\t4 to add random name book");
                Console.Write("Your chouse ");
                string? userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "1":
                        listBooks.addBook();
                        break;
                    case "2":
                        listBooks.removeBook();
                        break;
                    case "3":
                        listBooks.searchBook();
                        break;
                    case "4":
                        ++listBooks;           
                        break;
                    default:
                        Console.WriteLine("ERR");
                        break;
                }
                Console.WriteLine(listBooks);
            }            
        }    
    }
}