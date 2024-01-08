//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ДЗ_1._Массивы__enum__StringBuilder
//{
//    internal class _4
//    {
//        static Random rand = new Random();
//        static void showArr<T>(T[] arr)
//        {
//            foreach (T el in arr)
//                Console.Write($"{el}\t");
//            Console.WriteLine();
//        }

//        static void showMatrix(int[,] arr, int size)
//        {
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    Console.Write($"{arr[i, j]}\t");
//                }
//                Console.WriteLine();
//            }
//        }

//        static void Main(string[] args)
//        {
//            //В списке целых, заполненном случайными числами
//            //        вычислить:
//            //        ■ Сумму отрицательных чисел;
//            //        ■ Сумму четных чисел;
//            //        ■ Сумму нечетных чисел;
//            //        ■ Произведение элементов с индексами кратными 3;
//            //        ■ Произведение элементов между минимальным и максимальным элементом;
//            //        ■ Сумму элементов, находящихся между первым и последним положительными элементами.
//            //Console.WriteLine("Enter size of arr");
//            //string? strNumber = Console.ReadLine();
//            //bool isN = int.TryParse(strNumber, out int userNumber);
//            //int size = userNumber;
//            //int[] arr = new int[size];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(-100, 100 + 1);
//            //}
//            //showArr(arr);
//            //int summNegative = 0, summEven = 0, summOdd = 0, productInd3 = 1, productMinMax = 1, summBetween = 0;
//            //for (int i = 0; i < size; i++)
//            //{
//            //    if (arr[i] <= 0)
//            //        summNegative += arr[i];
//            //    if(i %2 == 0)
//            //        summEven += arr[i];
//            //    if (i % 2 != 0)
//            //        summOdd += arr[i];
//            //    if (i % 3 == 0 && i!=0)
//            //        productInd3 *= arr[i];
//            //}
//            //if (productInd3 == 1)
//            //    productInd3 = 0;

//            //int intdexMax = Array.IndexOf(arr, arr.Max());
//            //int intdexMin = Array.IndexOf(arr, arr.Min());
//            //if(intdexMax> intdexMin)
//            //{
//            //    for (int i = intdexMin; i <= intdexMax; i++)
//            //    {
//            //        productMinMax *= arr[i];
//            //    }
//            //}
//            //else {
//            //    for (int i = intdexMax; i <= intdexMin; i++)
//            //    {
//            //        productMinMax *= arr[i];
//            //    }
//            //}

//            //int firstPoz = 0, lastPoz = 0;
//            //for (int i = 0; i < size; i++)
//            //{
//            //    if (arr[i] > 0)
//            //    {
//            //        firstPoz = i;
//            //        break;
//            //    }
//            //}
//            //for (int i = size-1; i > 0; i--)
//            //{
//            //    if (arr[i] > 0)
//            //    {
//            //        lastPoz = i;
//            //        break;
//            //    }
//            //}
//            //for (int i = firstPoz; i <= lastPoz; i++)
//            //{
//            //    summBetween += arr[i];
//            //}
//            //Console.WriteLine(firstPoz);
//            //Console.WriteLine(lastPoz);
//            //Console.WriteLine($"Сумма отрицательных чисел = {summNegative}\nСумма четных чисел = {summEven}\nСумма нечетных чисел = {summOdd}\nПроизведение элементов с индексами кратными 3 = {productInd3}\nПроизведение элементов между минимальным и максимальным элементом = {productMinMax}\nСумму элементов, находящихся между первым и последним положительными элементами = {summBetween}");


//            //Есть список целых, заполненный случайными числами.
//            //На основании данных этого массива нужно:
//            //    ■ Создать список целых, содержащий только четные числа из первого списка;
//            //    ■ Создать список целых, содержащий только нечетные числа из первого списка;
//            //    ■ Создать список целых, содержащий только отрицательные числа из первого списка;
//            //    ■ Создать список целых, содержащий только положительные числа из первого списка.
//            //Console.WriteLine("Enter size of arr");
//            //string? strNumber = Console.ReadLine();
//            //bool isN = int.TryParse(strNumber, out int userNumber);
//            //int size = userNumber;
//            //int[] arr = new int[size];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(-100, 100 + 1);
//            //}
//            //Console.WriteLine("Оригинальный массив");
//            //showArr(arr);
//            //int even = 0, odd = 0, negative = 0, positive = 0;
//            //for (int i = 0; i < size; i++)
//            //{
//            //    if (arr[i] < 0)
//            //        negative++;
//            //    if (arr[i] > 0)
//            //        positive++;
//            //    if (i % 2 == 0)
//            //        even++;
//            //    if (i % 2 != 0)
//            //        odd++;
//            //}
//            //int[] arrNegative = new int[negative];
//            //int[] arrPositive = new int[positive];
//            //int[] arrEven = new int[even];
//            //int[] arrOdd = new int[odd];

//            //for (int i = 0,p=0,n=0,e=0,o=0;i < size; i++)
//            //{
//            //    if(i % 2 == 0)
//            //    {
//            //        arrEven[e] = arr[i];
//            //        e++;
//            //        if (arr[i] > 0)
//            //        {
//            //            arrPositive[p] = arr[i];
//            //            p++;
//            //        }
//            //        else
//            //        {
//            //            arrNegative[n] = arr[i];
//            //            n++;
//            //        }
//            //    }
//            //    else
//            //    {
//            //        arrOdd[o] = arr[i];
//            //        o++;
//            //        if (arr[i] > 0)
//            //        {
//            //            arrPositive[p] = arr[i];
//            //            p++;
//            //        }
//            //        else
//            //        {
//            //            arrNegative[n] = arr[i];
//            //            n++;
//            //        }
//            //    }
//            //}
//            //Console.Write("только четные числа из первого   ");
//            //showArr(arrEven);
//            //Console.Write("только нечетные числа из первого   ");
//            //showArr(arrOdd);
//            //Console.Write("только отрицательные числа из первого списка   ");
//            //showArr(arrNegative);
//            //Console.Write("только положительные числа из первого   ");
//            //showArr(arrPositive);
//        }
//    }
//}
