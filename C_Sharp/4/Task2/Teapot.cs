using System.Reflection.PortableExecutable;
using static System.Console;

namespace Tasks_2
{
    public class Teapot : Device
    {

        public int _year = 0;
        public string _type = "";
        
        public Teapot(string name, string characteristics,int year,string type):base(name, characteristics)
        {
            _name = name;
            _characteristics = characteristics;
            _year = year;
            _type = type;
        }


        public new void Sound()
        {
            for(int i=0;i<2;i++)
                Console.Beep(rand.Next(100,1000), rand.Next(100, 1000));
        }
        public void Show()
        {
            Console.WriteLine($"name of teapot {_name}");
        }

        public void Desc()
        {
            Console.WriteLine($"characteristics of teapot {_characteristics}, year {_year}, type {_type}");
        }

    }
}
