//Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль», «Пароход».
//С помощью конструктора установить имя каждого устройства и его характеристики.
//Для каждого устрйоства, которое создано на основе базового добавить хотя бы 2 индивидуальных характеристики.

//Реализуйте для каждого из классов методы: 
//■ Sound — издает звук устройства (пишем текстом в консоль либо вспомните начало наших занятий);
//■ Show — отображает название устройства; 
//■ Desc — отображает описание устройства

using static System.Console;

namespace Tasks_2
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Teapot tea = new Teapot("Home of tea", "make good tea", rand.Next(100, 3000), "electrical");
            tea.Sound();
            tea.Show();
            tea.Desc();
            Console.WriteLine("\n");

            Microwave microwave = new Microwave("Good Microwave", "quickly warms up", rand.Next(1900, 3000), rand.Next(100, 1000));
            microwave.Sound();
            microwave.Show();
            microwave.Desc();
            Console.WriteLine("\n");

            Car car = new Car("BMW", "syper fast", rand.Next(1900, 3000), rand.Next(100, 1000));
            car.Sound();
            car.Show();
            car.Desc();
            Console.WriteLine("\n");

            Steamer steamer = new Steamer("TITANIC", "won't drown", rand.Next(1900, 3000), rand.Next(100, 1000));
            steamer.Sound();
            steamer.Show();
            steamer.Desc();
            Console.WriteLine("\n");


            //Тоже самое но через массив
            Device[] devices = {
                new Teapot("Home of tea", "make good tea", rand.Next(100, 3000), "electrical"),
                new Microwave("Good Microwave", "quickly warms up", rand.Next(1900, 3000), rand.Next(100, 1000)),
                new Car("BMW", "syper fast", rand.Next(1900, 3000), rand.Next(100, 1000)),
                new Steamer("TITANIC", "won't drown", rand.Next(1900, 3000), rand.Next(100, 1000))
            };

            foreach(Device el in devices)
            {
                el.Sound();
                el.Show();
                el.Desc();
            }
        }
    }
}