//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ДЗ_1._Массивы__enum__StringBuilder
//{
//    internal class _3
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
//            //1.Система суммирования.И даже вычитания.Создайте Массив из количества чисел.Все числа генерируются случайным образом 
//            //    в диапазоне, заданным также с клавиатуры!Далее все числа суммируются между собой.
//            //    Пользователю выводится результат данного суммирования.
//            //Console.WriteLine("Enter size of arr");
//            //string? strNumber = Console.ReadLine();
//            //bool isN = int.TryParse(strNumber, out int userNumber);
//            //int size = userNumber;
//            //int[] arr = new int[size];
//            //Console.WriteLine("Enter minimum value");
//            //strNumber= Console.ReadLine();
//            //isN = int.TryParse(strNumber, out int low);
//            //Console.WriteLine("Enter maximum  value");
//            //strNumber = Console.ReadLine();
//            //isN = int.TryParse(strNumber, out int max);

//            //if (max > low)
//            //{
//            //    for (int i = 0; i < size; i++)
//            //    {
//            //        arr[i] = rand.Next(low, max + 1);
//            //    }
//            //}
//            //else for (int i = 0; i < size; i++)
//            //    {
//            //        arr[i] = rand.Next(max, low + 1);
//            //    }
//            //showArr(arr);
//            //int summ = 0, subtracts = 0;

//            //for (int i = 0; i < size; i++)
//            //{
//            //    summ += arr[i];
//            //    subtracts -= arr[i] ;
//            //}
//            //Console.WriteLine($"Сумма всех элемантов массива = {summ}\t Вычитание всех элементов массива = {subtracts}");


//            //2.Усложнённая игра “Угадай число ..чисел”. Создайте Массив, состоящий из ста элементов.Элементы добавляются 
//            //    в Массив со случайными значениями от 0 до 13.После этого программа генерирует число от 0 до 13 и предлагает
//            //    пользователю угадать количество раз, которое данное число встречается в списке.
//            //    Иной вариант: пусть программа предлагает угадать число со случайным индексом от 0 до 99.
//            //const int size = 100;
//            //int[] arr = new int[size];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(0, 13 + 1);
//            //}            
//            //showArr(arr);
//            //int programNumber = rand.Next(0, 13 + 1);
//            //int timesOfNumber = 0;
//            //for (int i = 0; i < size; i++)
//            //{
//            //    if (programNumber == arr[i])
//            //        timesOfNumber++;
//            //}
//            //Console.WriteLine($"the program guessed the number {programNumber}");
//            //while (true)
//            //{
//            //    Console.WriteLine("Enter your number");
//            //    string? strNumber = Console.ReadLine();
//            //    bool isN = int.TryParse(strNumber, out int userNumber);
//            //    if (userNumber == timesOfNumber)
//            //    {
//            //        Console.WriteLine("You win");
//            //        break;
//            //    }
//            //    else Console.WriteLine("Try again\n");
//            //}


//            //    Иной вариант: пусть программа предлагает угадать число со случайным индексом от 0 до 99.
//            //const int size = 100;
//            //int[] arr = new int[size];
//            //for (int i = 0; i < size; i++)
//            //{
//            //    arr[i] = rand.Next(0, 13 + 1);
//            //}
//            //showArr(arr);
//            //int programNumber = rand.Next(0,99+1);
//            //Console.WriteLine($"guess the number on the index {programNumber}");
//            //while (true)
//            //{
//            //    Console.WriteLine("Enter your number");
//            //    string? strNumber = Console.ReadLine();
//            //    bool isN = int.TryParse(strNumber, out int userNumber);
//            //    if (userNumber == arr[programNumber])
//            //    {
//            //        Console.WriteLine("You win");
//            //        break;
//            //    }
//            //    else Console.WriteLine("Try again\n");
//            //}


//            //3.Массив дел.Пользователю отображается меню с возможностями:
//            //1) добавить в Массив какое-либо дело
//            //2) вывести Массив дел с их индексами
//            //3) удалить дело по индексу
//            //Console.WriteLine("Enter 1 for add something to array\n\t2 output Array of cases with their indexes\n\t3 delete case by index");
//            //int size = 100;
//            //string[] arr = new string[size];
//            //string? strNumber;
//            //bool isN;
//            //int i = 0;
//            //while (true)
//            //{
//            //    Console.WriteLine("\nEnter your choice");
//            //    strNumber = Console.ReadLine();
//            //    isN = int.TryParse(strNumber, out int userChoise);
//            //    switch (userChoise)
//            //    {
//            //        case 1:
//            //            Console.WriteLine("\nEnter something ");
//            //            arr[i] = Console.ReadLine();
//            //            i++;
//            //            break;
//            //        case 2:
//            //            Console.WriteLine("Your case array");
//            //            for (int j = 0; j < i; j++)
//            //            {
//            //                Console.WriteLine($"#{j}  {arr[j]}");
//            //            }
//            //            break;
//            //        case 3:
//            //            Console.WriteLine("\nEnter number for del ");
//            //            strNumber = Console.ReadLine();
//            //            isN = int.TryParse(strNumber, out int del);
//            //            Array.Clear(arr, del, del);

//            //            break;
//            //        default:
//            //            break;
//            //    }
//            //}


//            //4.Финансовый помощник.Создайте программу, которая позволяет вносить траты, а также добавлять к ним комментарии.
//            //    Работать должна следующим образом:
//            //0) Вывод пользователю меню с пунктами:
//            //    a)	Внести трату(число должно вноситься в Массив отрицательным!):вносим число вносим комментарий к трате
//            //    b)	Внести доход(число должно вноситься в Массив положительным!):вносим число вносим комментарий к источнику поступления
//            //    c)	Посмотреть Массив трат и доходов с выводом в виде:
//            //         Число[0] — ‘Комментарий[0]’
//            //        Число[1] — ‘Комментарий[1]’
//            //        Число[2] — ‘Комментарий[2]’
//            //    d)	Рассчитать текущий баланс
//            //    e)	Рассчитать, сколько текущей суммы на балансе хватит на заданное с клавиатуры количество суток
//            //Console.WriteLine("Enter 1 for add a spending and comment\n\t2 for add income and comment\n\t3 View Spending and Income Array\n\t4 Calculate current balance\n\t5 Calculate how much the current amount on the balance will be enough for a given number of days");
//            //int size = 100;
//            //string[] comment = new string[size];
//            //int[] money = new int[size];
//            //string? strNumber;
//            //bool isN;
//            //int i = 0;
//            //while (true)
//            //{
//            //    int balanceNow = 0;
//            //    Console.WriteLine("\nEnter your choice");
//            //    strNumber = Console.ReadLine();
//            //    isN = int.TryParse(strNumber, out int userChoise);
//            //    switch (userChoise)
//            //    {
//            //        case 1:
//            //            Console.WriteLine("\nEnter your spending (negative number)");
//            //            strNumber = Console.ReadLine();
//            //            bool minus = strNumber.StartsWith("-");
//            //            isN = int.TryParse(strNumber, out int spend);
//            //            if (minus)
//            //                money[i] = spend;
//            //            else { Console.WriteLine("You entered a positive number. Return to menu");
//            //                break;
//            //            }
//            //            Console.WriteLine("Enter your comment ");
//            //            comment[i]= Console.ReadLine();
//            //            i++;
//            //            break;
//            //        case 2:
//            //            Console.WriteLine("\nEnter your income (positive number)");
//            //            strNumber = Console.ReadLine();
//            //            isN = int.TryParse(strNumber, out int income);
//            //            money[i] = income;
//            //            Console.WriteLine("Enter your comment ");
//            //            comment[i] = Console.ReadLine();
//            //            i++;
//            //            break;
//            //        case 3:
//            //            for (int j = 0; j < i; j++)
//            //            {
//            //                Console.WriteLine($"{money[j]}  {comment[j]}");
//            //            }
//            //            break;
//            //        case 4:
//            //            for (int j = 0; j < i; j++)
//            //            {
//            //                balanceNow += money[j];
//            //            }
//            //            Console.WriteLine($"Your balance {balanceNow}");
//            //            break;
//            //        case 5:
//            //            for (int j = 0; j < i; j++)
//            //            {
//            //                balanceNow += money[j];
//            //            }
//            //            Console.WriteLine("\nEnter how much to spend per day ");
//            //            strNumber = Console.ReadLine();
//            //            isN = int.TryParse(strNumber, out int spendForDay);
//            //            float days = balanceNow / spendForDay;
//            //            Console.WriteLine($"enough for {days}");
//            //            break;
//            //        default:
//            //            break;
//            //    }
//            //}


//            //5.Калькулятор с историей
//            //    Создать программу-калькулятор, которая не только будет выполнять операции, но и записывать ваши действия
//            //    в Массив. Для этого достаточно после каждой операции добавлять строку с данными в Массив,
//            //    в котором и будет храниться история.Таким образом в Массив заносится строка c числами и результатом.
//            //        Калькулятор должен реализовывать операции:
//            //        1)	Суммирование
//            //        2)	Произведение
//            //        3)	Разность
//            //        Усложнение:
//            //        4)	Деление с выводом остатка от деления и целой части отдельно!
//            //        5)	Степень
//            //Console.WriteLine("Enter + for summ\n\t- for product\n\t* for difference\n\t/ for Division\n\t^ for Degree\n\t1 for see history");
//            //int size = 100;
//            //string[] history = new string[size];
//            //string? strNumber, userChoise;
//            //bool isN;
//            //int i = 0;
//            //while (true)
//            //{
//            //    int first = 0, second = 0;
//            //    Console.WriteLine("\nEnter operation");
//            //    userChoise = Console.ReadLine();
//            //    if (userChoise != "1")
//            //    {
//            //        Console.WriteLine("\nEnter first number");
//            //        strNumber = Console.ReadLine();
//            //        isN = int.TryParse(strNumber, out first);

//            //        Console.WriteLine("\nEnter second number");
//            //        strNumber = Console.ReadLine();
//            //        isN = int.TryParse(strNumber, out second);
//            //    }
//            //    switch (userChoise)
//            //    {
//            //        case "+":
//            //            history[i] = $"{first}{userChoise}{second}={first + second}";
//            //            Console.WriteLine(history[i]);
//            //            i++;
//            //            break;
//            //        case "-":
//            //            history[i] = $"{first}{userChoise}{second}={first - second}";
//            //            Console.WriteLine(history[i]);
//            //            i++;
//            //            break;
//            //        case "*":
//            //            history[i] = $"{first}{userChoise}{second}={first * second}";
//            //            Console.WriteLine(history[i]);
//            //            i++;
//            //            break;
//            //        case "/":
//            //            history[i] = $"{first}{userChoise}{second}={first / second}";
//            //            Console.WriteLine(history[i]);
//            //            i++;
//            //            history[i] = $"{first}{userChoise}{second}={((double)first / second) - (first / second)}";
//            //            Console.WriteLine(history[i]);
//            //            i++;
//            //            break;
//            //        case "^":
//            //            history[i] = $"{first}{userChoise}{second}={Math.Pow(first, second)}";
//            //            Console.WriteLine(history[i]);
//            //            i++;
//            //            break;
//            //        case "1":
//            //            for (int j = 0; j < i; j++)
//            //                Console.WriteLine(history[j]);
//            //            break;
//            //        default:
//            //            break;
//            //    }
//            //}

//        }
//    }
//}
