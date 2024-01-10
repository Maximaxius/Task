using Wakanda;
using Belarus;
using Shire;

namespace Tasks_0
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            //9.Разработайте приложение «7 чудес света», где каждое чудо будет представлено отдельным классом.
            //Создайте дополнительный класс, содержащий точку входа. Распределите приложение по файлам проекта и
            //с помощью пространства имён обеспечьте возможность взаимодействия классов. 
            PyramidOfCheops Pyramid = new PyramidOfCheops();
            HangingGardensOfBabylon Hanging = new HangingGardensOfBabylon();
            ZeusStatueInOlympia Zeus = new ZeusStatueInOlympia();
            TempleOfArtemisAtEphesus Artemis = new TempleOfArtemisAtEphesus();
            MausoleumInHalicarnassus Mausoleum = new MausoleumInHalicarnassus();
            TheColossusOfRhodes Colossus = new TheColossusOfRhodes();
            AlexandrianLighthouse Alexandrian = new AlexandrianLighthouse();
            Console.WriteLine($"{Pyramid}\n{Hanging}\n{Zeus}\n{Artemis}\n{Mausoleum}\n{Colossus}\n{Alexandrian}\n");


            //10.Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран.
            //Причём страна бы обозначалась пространством имён, а город — классом в данном пространстве.
            BirninZana birninZana = new BirninZana(rand.Next(10, 2235));
            Minsk minsk = new Minsk(rand.Next(10, 2235));
            Hobbiton hobbiton = new Hobbiton(rand.Next(10, 2235));
            Console.WriteLine("\n\n");
            if (birninZana.Population >= minsk.Population && birninZana.Population >= hobbiton.Population)
            {
                Console.WriteLine($"top 1 {birninZana}");
                if (minsk.Population >= hobbiton.Population)
                    Console.WriteLine($"top 2 {minsk}\ntop3 {hobbiton}");
                else Console.WriteLine($"top 2 {hobbiton}\ntop3 {minsk}");
            }
            else if (minsk.Population >= birninZana.Population && minsk.Population >= hobbiton.Population)
            {
                Console.WriteLine($"top 1 {minsk}");
                if (birninZana.Population >= hobbiton.Population)
                    Console.WriteLine($"top 2 {birninZana}\ntop3 {hobbiton}");
                else Console.WriteLine($"top 2 {hobbiton}\ntop3 {birninZana}");
            }
            else
            {
                Console.WriteLine($"top 1 {hobbiton}");
                if (birninZana.Population >= minsk.Population)
                    Console.WriteLine($"top 2 {birninZana}\ntop3 {minsk}");
                else Console.WriteLine($"top 2 {minsk}\ntop3 {birninZana}");
            }



        }
    }
}