using System.Collections.Specialized;
using System.Numerics;


namespace Practice_modul_10_part_01
{
    class Program
    {
       
        static Random rand = new Random();

        static void findMax<T>(T num0, T num1, T num2)
        {
            T[] arr = { num0, num1, num2 };

            Console.WriteLine($"Maximum {arr.Max()}");
        }

        static void findMin<T>(T num0, T num1, T num2)
        {
            T[] arr = { num0, num1, num2 };
            Console.WriteLine($"Minimum {arr.Min()}");
        }

        static void findSumInArr<T>(T[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Convert.ToInt32(arr[i]);
            }
            Console.WriteLine($"Sum all el in arr = {sum}");
        }


        static void Main(string[] args)
        {
            //Задание 1
            //Создайте generic версию метода вычисления максимума из трёх чисел.
            //int a = rand.Next(5, 100);
            //int b = rand.Next(5, 100);
            //int c = rand.Next(5, 100);                       
            //Console.WriteLine($"a = {a} b = {b} c = {c}");
            //findMax(a,b,c);


            //Задание 2
            //Создайте generic версию метода вычисления минимума из трёх чисел.
            //int a = rand.Next(5, 100);
            //int b = rand.Next(5, 100);
            //int c = rand.Next(5, 100);                       
            //Console.WriteLine($"a = {a} b = {b} c = {c}");
            //findMin(a, b, c);


            //Задание 3
            //Создайте generic версию метода поиска суммы элементов в массиве.
            //int[] arr = new int[rand.Next(3, 10)];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(13, 100);
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //findSumInArr(arr);


            //Задание 4
            //Создайте generic класс Стека. Реализуйте стандартные
            //методы и свойства для работы стека:
            //■ pop;
            //■ push;
            //■ peek;
            //■ count.

            //Stacks<int> stacks = new Stacks<int>();
            //stacks.Push(1);
            //stacks.Push(1);
            //stacks.Push(5);
            //stacks.Push(13);

            //Console.WriteLine("Original stac");
            //for (int i = stacks.size-1; i >= 0; i--)
            //{
            //    Console.WriteLine(stacks[i]);                       //  соответствии с аалгоритмом стека LIFO данные извлекаются в порядке, обратном их добавлению.
            //}

            //int poper = stacks.Pop();
            //Console.WriteLine($"\nPop = {poper}");

            //Console.WriteLine("\nStac after pop");
            //for (int i = stacks.size - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(stacks[i]);                           
            //}

            //int peeker = stacks.Peek();
            //Console.WriteLine($"\nPeek = {peeker}");

            //Console.WriteLine("\nStac after peek");
            //for (int i = stacks.size - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(stacks[i]);
            //}

            //int size = stacks.size;
            //Console.WriteLine($"count = {size}");


            //Задание 5
            //Создайте generic класс Очередь. Реализуйте стандарт-
            //ные методы и свойства для работы очереди:
            //■ enqueue;
            //■ dequeue;
            //■ peek;
            //■ count.

            Queue<int> queues = new Queue<int>();

            queues.Enqueue(1);
            queues.Enqueue(2);
            queues.Enqueue(3);
            Console.WriteLine("Original Queue");
            for (int i = 0; i < queues.size; i++)
            {
                Console.WriteLine(queues[i]);
            }

            int peeker = queues.Peek();
            Console.WriteLine($"\nPeek = {peeker}");
            Console.WriteLine("\nQueue after peek");
            for (int i = 0; i < queues.size; i++)
            {
                Console.WriteLine(queues[i]);
            }

            int dequeueer = queues.Dequeue();
            Console.WriteLine($"\nDequeue = {dequeueer}");
            Console.WriteLine("\nQueue after Dequeue");
            for (int i = 0; i < queues.size; i++)
            {
                Console.WriteLine(queues[i]);
            }

        }
    }
}