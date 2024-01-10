using System.Xml.Linq;
using static System.Console;

namespace Tasks_3
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            //Реализовать в Main:
            //1.Генерацию последовательности объектов класса Зомбовек(количество случайное от 13 до 113).
           
            // Zombie zombie= new Zombie();
            //Console.WriteLine(zombie);

            Zombie zombie1 = new Zombie(new Heart(),new Lungs(),null,"Test zomb",rand.Next(18,99));
            Console.WriteLine(zombie1);



            Console.WriteLine("\n");
            Zombie[] zombiesss = new Zombie[rand.Next(13, 113+1)];
            for (int i = 0; i < zombiesss.Length; i++)
            {
                zombiesss[i] = new Zombie();
            }

            for (int i = 0; i < zombiesss.Length; i++)
            {
                Console.WriteLine($"zomb {i}\n{zombiesss[i]}\n");
            }

        }
    }
}