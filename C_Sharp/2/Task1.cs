//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ДЗ_1._Массивы__enum__StringBuilder
//{
//    public class _1
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
//            //Задание 1 Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел
//            //    с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В
//            //    случайными числами с помощью циклов.Вывести на экран значения массивов: массива А в одну строку,
//            //    массива В — в виде матрицы.Найти в данных массивах общий максимальный элемент, минимальный элемент,
//            //    общую сумму всех элементов, общеепроизведение всех элементов, сумму четных элементов массива А,
//            //    сумму нечетных столбцов массива В.
//            //int sizeA = 5;
//            //int[] A = new int[sizeA];
//            //string? strNumber;
//            //bool IsNumber;
//            //Console.WriteLine("Enter numbers");
//            //for (int i = 0; i < sizeA; i++)
//            //{
//            //    strNumber = Console.ReadLine();
//            //    IsNumber = int.TryParse(strNumber, out int userNumber);
//            //    A[i] = userNumber;
//            //}
//            //showArr(A);

//            //int sizeRowsB = 3, sizeColuB = 4;
//            //double[,] B = new double[sizeRowsB, sizeColuB];
//            //Console.WriteLine("Enter lower limit");
//            //strNumber = Console.ReadLine();
//            //IsNumber = int.TryParse(strNumber, out int lower);

//            //Console.WriteLine("Enter upper limit");
//            //strNumber = Console.ReadLine();
//            //IsNumber = int.TryParse(strNumber, out int upper);

//            //for (int i = 0; i < sizeRowsB; i++)
//            //{
//            //    for (int j = 0; j < sizeColuB; j++)
//            //    {
//            //        B[i, j] = Convert.ToDouble(rand.Next(lower, upper + 1) / 10.0) + rand.Next(lower, upper + 1);
//            //    }
//            //}

//            //for (int i = 0; i < sizeRowsB; i++)
//            //{
//            //    for (int j = 0; j < sizeColuB; j++)
//            //    {
//            //        Console.Write(B[i, j] + "\t");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //int maxA = A[0], minA = A[0], sumA = 0, productA = 1, sumEven = 0;
//            //for (int i = 0; i < sizeA; i++)
//            //{
//            //    if (maxA <= A[i])
//            //        maxA = A[i];
//            //    if (minA >= A[i])
//            //        minA = A[i];
//            //    sumA += A[i];
//            //    productA *= A[i];
//            //    if (i % 2 == 0)
//            //        sumEven += A[i];
//            //}

//            //double maxB = B[0, 0], minB = B[0, 0], sumB = 0, productB = 1, sumOddCol = 0;
//            //for (int i = 0; i < sizeRowsB; i++)
//            //{
//            //    for (int j = 0; j < sizeColuB; j++)
//            //    {
//            //        if (maxB <= B[i, j])
//            //            maxB = B[i, j];
//            //        if (minB >= B[i, j])
//            //            minB = B[i, j];
//            //        sumB += B[i, j];
//            //        productB *= B[i, j];
//            //        if (j % 2 == 1)
//            //            sumOddCol += B[i, j];
//            //    }

//            //}
//            //double maxMax = 0, minMin = 0;
//            //if (maxA > maxB)
//            //    maxMax = maxA;
//            //else maxMax = maxB;
//            //if (minA < minB)
//            //    minMin = minA;
//            //else minMin = minB;

//            //double sumAll = sumA + sumB;
//            //double productAll = productA * productB;
//            //Console.WriteLine($"Mаксимальный элемент {maxMax}\nMинимальный элемент {minMin}\nOбщую сумму всех элементов {sumAll}\nOбщее произведение всех элементов {productAll}\nCумму четных элементов массива А {sumEven}\nCумму нечетных столбцов массива В {sumOddCol} ");


//            //Задание 2 Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
//            //    Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
//            //const int size = 5;
//            //int[,] arr = new int[size, size];
//            //int[] arr2 = new int[arr.Length];
//            //for (int i = 0, for2arr = 0; i < size; i++)
//            //{
//            //    for (int j = 0; j < size; j++)
//            //    {
//            //        arr[i, j] = rand.Next(-100, 100 + 1);
//            //        arr2[for2arr] = arr[i, j];
//            //        for2arr++;
//            //    }
//            //}

//            //for (int i = 0; i < size; i++)
//            //{
//            //    for (int j = 0; j < size; j++)
//            //    {
//            //        Console.Write($"{arr[i, j]}\t");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //int max = arr[0, 0], min = arr[0, 0];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    for (int j = 0; j < size; j++)
//            //    {
//            //        if (max < arr[i, j])
//            //            max = arr[i, j];
//            //        if (min > arr[i, j])
//            //            min = arr[i, j];
//            //    }
//            //}
//            //int start = Array.IndexOf(arr2, min);
//            //int end = Array.IndexOf(arr2, max);

//            //int summBetween = 0;
//            //if (start <= end)
//            //{
//            //    for (; start <= end; start++)
//            //    {
//            //        summBetween += arr2[start];
//            //    }
//            //}
//            //else for (; start >= end; end++)
//            //    {
//            //        summBetween += arr2[end];
//            //    }
//            //Console.WriteLine($"\nМинимальное = {min}\nМаксимальное = {max}");
//            //Console.WriteLine($"Сумма между мин и макс {summBetween}");


//            //Задание 3 Пользователь вводит строку с клавиатуры.Необходимо зашифровать данную строку используя шифр Цезаря.
//            //string? userLine = Console.ReadLine();
//            //int size = userLine.Length;
//            //char[] code = new char[size];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    code[i] = userLine[i];
//            //    if (code[i] != ' ')
//            //        code[i] = Convert.ToChar(code[i] + 3);
//            //}
//            //Console.Write("зашифрованный со сдвигом вправо на 3 = ");
//            //Console.WriteLine(code);

//            //for (int i = 0; i < size; i++)
//            //{
//            //    if (code[i] != ' ')
//            //        code[i] = Convert.ToChar(code[i] - 3);
//            //}
//            //Console.Write("расшифрованый = ");
//            //Console.WriteLine(code);



//            //Задание 4 Создайте приложение, которое производит операции над матрицами:
//            //    ■ Умножение матрицы на число;
//            //    ■ Сложение матриц;
//            //    ■ Произведение матриц.            
//            //const int size = 3;
//            //int[,] arr = new int[size,size];
//            //int[,] arr2 = new int[size, size];
//            //int[,] arr3 = new int[size, size];           
//            //for (int i = 0; i < size; i++)
//            //{
//            //    for (int j = 0; j < size; j++)
//            //    {
//            //        arr[i, j] = rand.Next(-13, 13 + 1);
//            //        arr2[i, j] = rand.Next(-13, 13 + 1);
//            //    }
//            //}
//            //Console.WriteLine("First matrix");            
//            //showMatrix(arr, size);
//            //Console.WriteLine("Second matrix");
//            //showMatrix(arr2, size);
//            //Console.WriteLine("Enter 1 for Multiplying a Matrix by a Number\n 2 Matrix addition\n 3 Product of matrices");
//            //string? userNum = Console.ReadLine();
//            //bool isN = int.TryParse(userNum, out int choice);
//            //switch (choice)
//            //{
//            //    case 1:
//            //        Console.WriteLine("Enter number for multiply");
//            //        userNum = Console.ReadLine();
//            //        isN = int.TryParse(userNum, out int number);
//            //        for (int i = 0; i < size; i++)
//            //            {
//            //                for (int j = 0; j < size; j++)
//            //                {
//            //                    arr[i, j] *= number;
//            //                    arr2[i, j] *= number;
//            //                }
//            //        }
//            //        Console.WriteLine("First matrix");
//            //        showMatrix(arr, size);
//            //        Console.WriteLine("Second matrix");
//            //        showMatrix(arr2, size);
//            //        break;
//            //    case 2:                    
//            //        for (int i = 0; i < size; i++)
//            //        {
//            //            for (int j = 0; j < size; j++)
//            //            {
//            //                arr3[i, j] = arr[i, j]+ arr2[i, j];
//            //            }
//            //        }
//            //        showMatrix(arr3, size);
//            //        break;
//            //    case 3:
//            //        for (int i = 0; i < size; i++)
//            //        {
//            //            for (int j = 0; j < size; j++)
//            //            {
//            //                for (int k = 0; k < size; k++)
//            //                {
//            //                    arr3[i, j] += arr[i, k] * arr2[k, j];
//            //                }
//            //            }
//            //        }
//            //        showMatrix(arr3, size);
//            //        break;
//            //    default:
//            //        Console.WriteLine("err");
//            //        break;
//            //}

//            //Задание 5 Пользователь с клавиатуры вводит в строку арифметическое выражение.Приложение должно посчитать его результат.
//            //    Необходимо поддерживать только две операции: + и –.
//            //Выполнено наверное частично тк нужны пробелы мужду всеми символами
//            //Console.WriteLine("Enter arithmetic expression with + or - ");
//            //string? sentence = Console.ReadLine();
//            //string[] arr = sentence.Split(new Char[] { ' ' });
//            ////string[] arr = sentence.Split(new Char[] { '+','-' });
//            //int result = 0, number = 0;
//            //bool plus = true;
//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    if (int.TryParse(arr[i], out number))
//            //    {
//            //        if (plus)
//            //            result = result + number;
//            //        else
//            //            result = result - number;
//            //    }
//            //    else
//            //    {
//            //        if (arr[i] == "+")
//            //            plus = true;
//            //        else
//            //            plus = false;
//            //    }
//            //}
//            //Console.WriteLine(result);


//            //Задание 6 Пользователь с клавиатуры вводит некоторый текст. Приложение должно изменять регистр первой буквы 
//            //    каждого предложения на букву в верхнем регистре.
//            //Console.WriteLine("Enter your sentence ");
//            //string? sentence = Console.ReadLine();
//            //char[] arr = new char[sentence.Length];
//            //for (int i = 0; i < sentence.Length; i++)
//            //{
//            //    arr[i] = sentence[i];
//            //}
//            //for (int i = 0; i < sentence.Length; i++)
//            //{
//            //    if (arr[i] == '.' && arr[i + 1] == ' ')                          // после точки нужен пробел (>_<)/`
//            //        arr[i + 2] = Convert.ToChar(arr[i + 2] - 32);                   
//            //}
//            //for (int i = 0; i < sentence.Length; i++)
//            //{
//            //    Console.Write(arr[i]);                                               
//            //}

//            //Задание 6.2                                                          
//            //Console.WriteLine("Enter your sentence ");
//            //string? sentence = Console.ReadLine();
//            //StringBuilder newSentence = new StringBuilder();
//            //newSentence.Append(sentence[0].ToString().ToUpper());
//            //newSentence.Append(sentence[1].ToString());
//            //for (int i = 2; i < sentence.Length; i++)
//            //{
//            //    if(sentence[i-2]=='.' && sentence[i - 1] ==' ' )
//            //    {
//            //        newSentence.Append(sentence[i].ToString().ToUpper());
//            //    }
//            //    else
//            //    {
//            //        newSentence.Append(sentence[i]);
//            //    }
//            //}                       
//            //Console.WriteLine(newSentence.ToString());



//            //Задание 7 Создайте приложение, проверяющее текст на недопустимые слова.Если недопустимое слово найдено, оно
//            //    должно быть заменено на набор символов *.По итогам работы приложения необходимо показать статистику действий.
//            //Console.WriteLine("Enter your text ");
//            //string? sentence = Console.ReadLine();
//            //string[] arr = sentence.Split(new Char[] { ' ' });
//            //Console.WriteLine("Enter  your word to find ");
//            //string? userWord = Console.ReadLine();
//            //int kolvo = 0;

//            //string? userReplacements  = "";
//            //for (int i = 0; i < userWord.Length; i++)
//            //{
//            //    userReplacements  += "*";
//            //}

//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    if (arr[i] == userWord)
//            //    {
//            //        kolvo++;
//            //        arr[i] = userReplacements ;
//            //    }                    
//            //}

//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    Console.Write(arr[i] + " ");
//            //}
//            //Console.WriteLine($"\nStatistics: {kolvo} replacements for the word {userWord} ");

//        }
//    }
//}



