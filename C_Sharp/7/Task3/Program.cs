using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
//#pragma warning disable SYSLIB0011


namespace Task_1
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {

            AccountForPayment account = new AccountForPayment(10, 2, 2, 5);//(10,2,2,5);
            Console.WriteLine("Original account bool = true");
            Console.WriteLine(account);

            using (Stream file = File.Create("../../../task_2.bin"))
            {
                using (BinaryWriter bw = new BinaryWriter(file))
                {
                    account.Serializee(bw);
                }
            }

            AccountForPayment account2 = new AccountForPayment();
            using (Stream file = File.OpenRead("../../../task_2.bin"))
            {
                using (BinaryReader br = new BinaryReader(file))
                {
                    account2 = account.Deserializee(br);
                }
            }

            Console.WriteLine("\naccount1 Deserializee to acc2 with bool= true");
            Console.WriteLine(account2);


            //с false
            Console.WriteLine("\n\nOriginal account bool = false");
            Console.WriteLine(account);
            account.changeSer();                                        //изменение на false

            using (Stream file = File.Create("../../../task_2false.bin"))
            {
                using (BinaryWriter bw = new BinaryWriter(file))
                {
                    account.Serializee(bw);
                }
            }

            using (Stream file = File.OpenRead("../../../task_2false.bin"))
            {
                using (BinaryReader br = new BinaryReader(file))
                {
                    account2 = account.Deserializee(br);
                }
            }

            Console.WriteLine("\naccount1 Deserializee to acc2 with bool= false");
            Console.WriteLine(account2);



        }


    }
}