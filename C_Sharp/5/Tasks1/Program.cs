namespace Tasks_1
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] arr = new int[rand.Next(3,22)];

            for (int i=0;i< arr.Length; i++)
            {
                arr[i] = rand.Next(1,100);
            }

            foreach (var item in arr)
            {
                Console.Write(item +" ");
            }

            Console.WriteLine("\nМетод Show() — отображает на экран элементы массива");
            ArrayP12821 array= new ArrayP12821();
            array.Arr = arr;            
            array.Show();

            Console.WriteLine("\n\nМетод Show(string info) — отображает на экран элементы массива и информационное сообщение");
            array.Show("bob");
            
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Average = {array.Avg()}");

            int randomInt = rand.Next(1,100);
            Console.WriteLine($"Search number {randomInt} in arr {array.Search(randomInt)}");
        }

    }
}