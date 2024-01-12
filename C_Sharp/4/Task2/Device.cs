using static System.Console;

namespace Tasks_2
{
    public class Device
    {
        protected Random rand = new Random();
        protected string _name = "";
        protected string _characteristics = "";

        public Device(string name, string characteristics)
        {
            this._name = name;
            this._characteristics = characteristics;
        }


        public void Sound()
        {
            for (int i = 0; i < 2; i++)
                Console.Beep(rand.Next(100, 1000), rand.Next(100, 1000));
        }
        public void Show()
        {
            Console.WriteLine($"name of  {_name}");
        }

        public void Desc()
        {
            Console.WriteLine($"characteristics of  {_characteristics}, year ,");
        }
    }
}
