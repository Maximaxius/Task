//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ДЗ_1._Массивы__enum__StringBuilder
//{
//    public class _2
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
//            //Задание 1 Создайте приложение, которое отображает количество чётных, нечётных, уникальных элементов массива.
//            //Console.WriteLine("Enter size of arr");
//            //string? strNumber = Console.ReadLine();
//            //bool isN = int.TryParse(strNumber, out int userNumber);
//            //int size = userNumber;
//            //int[] arr = new int[size];
//            //int even = 0, odd = 0, unique = 0;
//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(1, 13 + 1);
//            //}
//            //showArr(arr);

//            //for (int i = 0; i < size; i++)
//            //{
//            //    int unUnique = 0;
//            //    if (arr[i] % 2 == 0)
//            //        even++;
//            //    else odd++;
//            //    for(int j = 0; j < size; j++)
//            //    {
//            //        if (arr[i] == arr[j]) 
//            //            unUnique++;                   
//            //    }
//            //    if (unUnique <= 1)   // если число повторяеттся больше чкм 1раз оно не уникальное
//            //        unique++;
//            //}
//            //Console.WriteLine($"Четных {even}\nНечетных {odd}\nУникальных {unique}");


//            //Задание 2 Создайте приложение, отображающее количество значений в массиве меньше заданного параметра
//            //    пользователем.Например, количество значений меньших, чем 7 (7 введено пользователем с клавиатуры).
//            //Console.WriteLine("Enter size of arr");
//            //string? strNumber = Console.ReadLine();
//            //bool isN = int.TryParse(strNumber, out int userNumber);
//            //int size = userNumber;
//            //int[] arr = new int[size];
//            //Console.WriteLine("Enter your number (1-13)");
//            //strNumber = Console.ReadLine();
//            //isN = int.TryParse(strNumber, out userNumber);

//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(1, 13 + 1);
//            //}
//            //showArr(arr);

//            //int smaller = 0;
//            //for (int i = 0; i < size; i++)
//            //{
//            //    if (userNumber >= arr[i])
//            //        smaller++;
//            //}
//            //Console.WriteLine($"Numbers less than {userNumber} = {smaller}");


//            //Задание 3 Пользователь вводит с клавиатуры три числа. Необхдимо подсчитать сколько раз последовательность
//            //    из этих трёх чисел встречается в массиве.
//            //    Например: пользователь ввёл: 7 6 5;
//            //               массив: 7 6 5 3 4 7 6 5 8 7 6 5;
//            //               количество повторений последовательности: 3.
//            //int size = 100, kolvo = 0, sizeNumber = 3;
//            //int[] arr = new int[size];
//            //int[] userNumbers = new int[sizeNumber];
//            //Console.WriteLine("Enter firs number (0-3)");
//            //string? strNumber = Console.ReadLine();
//            //bool isN = int.TryParse(strNumber, out userNumbers[0]);
//            //Console.WriteLine("Enter second number ");
//            //strNumber = Console.ReadLine();
//            //isN = int.TryParse(strNumber, out userNumbers[1]);
//            //Console.WriteLine("Enter third number ");
//            //strNumber = Console.ReadLine();
//            //isN = int.TryParse(strNumber, out userNumbers[2]);

//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(0, 3 + 1);                  
//            //}

//            //for (int i = 0; i < size - sizeNumber; i++)
//            //{
//            //    int raz = 0;
//            //    for (int j = 0, ii = i + j; j < sizeNumber; j++, ii++)
//            //    {
//            //        if (userNumbers[j] == arr[ii])
//            //            raz++;
//            //        if (raz == sizeNumber)
//            //            kolvo++;
//            //    }
//            //}
//            //showArr(arr);
//            //Console.WriteLine(kolvo);


//            //Задание 4
//            //    Даны 2 массива размерности M и N соответственно.Необходимо переписать в третий массив общие
//            //    элементы первых двух массивов без повторений
//            //Console.WriteLine("Enter size of arr 1");
//            //string? strNumber = Console.ReadLine();
//            //bool isN = int.TryParse(strNumber, out int userNumber);
//            //int size = userNumber;
//            //int[] arr = new int[size];
//            //Console.WriteLine("Enter size of arr 2");
//            //strNumber = Console.ReadLine();
//            //isN = int.TryParse(strNumber, out userNumber);
//            //int size2 = userNumber;
//            //int[] arr2 = new int[size2];

//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(1, 10 + 1);
//            //}
//            //showArr(arr);
//            //for (int i = 0; i < size2; i++)
//            //{
//            //    arr2[i] = rand.Next(1, 10 + 1);
//            //}
//            //showArr(arr2);

//            //if (size > size2)
//            //{
//            //    int[] arrUnique = new int[size2];
//            //    for (int i = 0,ii=0; i < size; i++)
//            //    {
//            //        int unique = 0;
//            //        bool presence = true;
//            //        for (int j = 0; j < size2; j++)
//            //        {
//            //            if (arr[i] == arr2[j])
//            //                unique++;
//            //        }
//            //        if (unique >= 1)
//            //        {
//            //            for (int j = 0; j < size2; j++)
//            //            {
//            //                if (arr[i] == arrUnique[j])
//            //                    presence = false;
//            //            }
//            //            if (presence)
//            //            {
//            //                arrUnique[ii] = arr[i];
//            //                ii++;
//            //            }
                            
//            //        }
//            //    }
//            //    for (int i = 0; i < size2; i++)
//            //    {
//            //        if (arrUnique[i] != 0)              
//            //            Console.Write(arrUnique[i]);
//            //    }
//            //}
//            //else
//            //{
//            //    int[] arrUnique = new int[size];
//            //    for (int i = 0,ii=0; i < size2; i++)
//            //    {
//            //        int unique = 0;
//            //        bool presence = true;
//            //        for (int j = 0; j < size; j++)
//            //        {
//            //            if (arr2[i] == arr[j])
//            //                unique++;
//            //        }
//            //        if (unique >= 1)
//            //        {
//            //            for (int j = 0; j < size; j++)
//            //            {
//            //                if (arr2[i] == arrUnique[j])
//            //                    presence = false;
//            //            }
//            //            if (presence)
//            //            {
//            //                arrUnique[ii] = arr2[i];
//            //                ii++;
//            //            }
                            
//            //        }
//            //    }
//            //    for (int i = 0; i < size; i++)
//            //    {
//            //        if (arrUnique[i] != 0)
//            //            Console.Write(arrUnique[i]+" ");
//            //    }
//            //}                                


//            //Задание 5 
//            //Разработайте приложение, которое будет находить минимальное и максимальное значение в двумерном массиве.
//            //const int size = 5;
//            //int[,] arr = new int[size, size];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    for (int j = 0; j < size; j++)
//            //    {
//            //        arr[i, j] = rand.Next(0, 100 + 1);
//            //    }
//            //}
//            //showMatrix(arr, size);
//            //int min = arr[0, 0], max = arr[0, 0];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    for (int j = 0; j < size; j++)
//            //    {
//            //        if (min > arr[i, j])
//            //            min = arr[i, j];
//            //        if (max < arr[i, j])
//            //            max = arr[i, j];
//            //    }
//            //}
//            //Console.WriteLine($"Max = {max}\nMin = {min}");


//            //Задание 6 
//            //    Пользователь вводит предложение с клавиатуры.Вам необходимо подсчитать количество слов в нём.            
//            //Console.WriteLine("Enter sentence ");
//            //string? sentence = Console.ReadLine();
//            //string[] arr = sentence.Split(new Char[] { ' ' });
//            //int words = arr.Length;
//            //Console.WriteLine($"{words} words in a sentence");


//            //Задание 7 Пользователь вводит предложение с клавиатуры.Вам необходимо перевернуть каждое слово предложения и 
//            //    отобразить результат на экран.
//            //Console.WriteLine("Enter sentence ");
//            //string? sentence = Console.ReadLine();
//            //string[] arr = sentence.Split(new Char[] { ' ' });
//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    char[] reverse = arr[i].ToCharArray();
//            //    Array.Reverse(reverse);
//            //    arr[i] = "";
//            //    for (int j = 0; j < reverse.Length; j++)
//            //    {
//            //        arr[i] += reverse[j];
//            //    }

//            //}
//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    Console.Write($"{arr[i]} ");
//            //}


//            //Задание 8 Пользователь вводит с клавиатуры предложение.Приложение должно посчитать количество гласных букв в нём.
//            //Console.WriteLine("Enter sentence ");
//            //string? sentence = Console.ReadLine();
//            //char[] arrLetters = new char[sentence.Length];
//            //for (int i = 0; i < arrLetters.Length; i++)
//            //{
//            //    arrLetters[i] = sentence[i];
//            //}
//            //int vowels = 0;
//            //for (int i = 0; i < arrLetters.Length; i++)
//            //{
//            //    if (arrLetters[i] == 'a' || arrLetters[i] == 'q' || arrLetters[i] == 'e' || arrLetters[i] == 'y' || arrLetters[i] == 'u' || arrLetters[i] == 'i' || arrLetters[i] == 'o' || arrLetters[i] == 'у' || arrLetters[i] == 'е' || arrLetters[i] == 'а' || arrLetters[i] == 'о' || arrLetters[i] == 'э' || arrLetters[i] == 'я' || arrLetters[i] == 'и' || arrLetters[i] == 'ю' || arrLetters[i] == 'ы')
//            //        vowels++;
//            //}
//            //Console.WriteLine($"In the text vowels {vowels}");


//            //Задание 9 Реализуйте приложение для подсчёта количество вхождений подстроки в строку.Пользователь вводит исходную
//            //    строку и слово для поиска. 
//            //Console.WriteLine("Enter sentence ");
//            //string? sentence = Console.ReadLine();
//            //string[] arr = sentence.Split(new Char[] { ' ' });
//            //Console.WriteLine("Enter your word to find ");
//            //string? userWord = Console.ReadLine();
//            //int kolvo=0;
//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    if(arr[i] == userWord)
//            //         kolvo++;
//            //}            
//            //Console.WriteLine($"In the text vowels {kolvo}");
//        }
//    }
//}
