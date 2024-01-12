using ConsoleApp1;
using System;
using System.Numerics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
#pragma warning disable SYSLIB0011

namespace Task_1
{
    class Program
    {
        static Random rand = new Random();

        static void Main()
        {
            //1.Мусорить аналогично нужно уметь
            //Создайте файл размером ~2 Мбайта(допускается погрешность), состоящий из 13
            //строк, каждая из которых состоит из случайных символов.
            //string[] arrString = new string[13];
            //for (int i = 0; i < 13; i++)
            //{
            //    StringBuilder st = new StringBuilder();
            //    for (int j = 0; j < 162000; j++)          //16200
            //    {
            //        st.Append((char)rand.Next('0', 'z'));
            //    }
            //    arrString[i] = st.ToString();
            //}
            //File.WriteAllLines("../../../file.txt", arrString);


            //2. ..как и убирать за собой
            //Считайте файл, который создали ранее, уберите из него все символы, кроме цифр, а
            //после запишите результат фильтрации в новый файл, записывая каждую из цифр на новой строке.
            //string fromFile = File.ReadAllText("../../../file.txt");

            //int kolvoNumb = 0;
            //for (int i = 0; i < fromFile.Length; i++)
            //{
            //    if (fromFile[i] == '0' || fromFile[i] == '1' || fromFile[i] == '2' || fromFile[i] == '3' || fromFile[i] == '4' || fromFile[i] == '5' || fromFile[i] == '6' || fromFile[i] == '7' || fromFile[i] == '8' || fromFile[i] == '9')
            //        kolvoNumb++;
            //}

            //int[] numbers = new int[kolvoNumb];
            //for (int i = 0, j = 0; i < fromFile.Length; i++)
            //{
            //    if (fromFile[i] == '0' || fromFile[i] == '1' || fromFile[i] == '2' || fromFile[i] == '3' || fromFile[i] == '4' || fromFile[i] == '5' || fromFile[i] == '6' || fromFile[i] == '7' || fromFile[i] == '8' || fromFile[i] == '9')
            //    {
            //        numbers[j] = int.Parse(fromFile[i].ToString());
            //        j++;
            //    }                                                   /// очень глупо тк через парс почемуто ек вышло 
            //}

            //string[] strings = new string[kolvoNumb];
            //for (int i = 0; i < kolvoNumb; i++)
            //{
            //    strings[i] = Convert.ToString(numbers[i]);                  // наверное луучше было бы сразу создать массив стринга вместо инт
            //}

            //File.WriteAllLines("../../../Numbers.txt", strings);


            //3.Но даже убранное нужно обрабатывать
            //Напишите программу, которая просуммирует все числа из файла созданного во втором
            //задании, а затем вычислит среднее между ними, поделив сумму на их количество.
            //• Дополните файл количеством чисел от 337 до 1597.
            //• Определить произведение нечётных чисел из данного файла.            
            //string fromFile2 = File.ReadAllText("../../../Numbers.txt");
            //int summ = 0, allNumInFile2 = 0;
            //for (int i = 0; i < fromFile2.Length; i++)
            //{
            //    int num;
            //    if (int.TryParse(fromFile2[i].ToString(), out num))
            //        allNumInFile2++;
            //    summ += num;
            //}
            //Console.WriteLine($"Avg in file Numbers.txt before add new num = {(double)summ / allNumInFile2}");

            //string[] newNumFor2 = new string[rand.Next(337, 1597 + 1)];       //[rand.Next(100, 110)] тк выдает 0 изза выхода за рамки long даже через ulong
            //for (int i = 0; i < newNumFor2.Length; i++)
            //{
            //    newNumFor2[i] = rand.Next(10).ToString();
            //}
            //File.AppendAllLines("../../../Numbers.txt", newNumFor2);

            //string fromFile2WithNewNum = File.ReadAllText("../../../Numbers.txt");
            //long product = 1;
            //for (int i = 0, j = 0; i < fromFile2WithNewNum.Length; i++)
            //{
            //    int num = 1;
            //    if (int.TryParse(fromFile2WithNewNum[i].ToString(), out num))
            //    {
            //        if (j % 2 == 1 && num != 0)                                       // ограничение чтобы небыло 0 тк в ответе будет 0
            //            product *= num;
            //        j++;
            //    }

            //}
            //Console.WriteLine($"product of odd numbers in file Numbers.txt  = {product}");


            //4.Давно мы ничего не авторизовали
            //    Создать класс “Пользователь” с полями: логин, пароль, почта, датавремя регистрации
            //    (генерировать в формате “ДД-ММ - ГГ ЧЧ: ММ: СС”).
            //    Реализовать:
            //    • конструкторы по умолчанию / с параметрами
            //    • необходимые аксессоры
            //    • метод ToString()
            //    Реализовать класс БД для хранения пользователей с возможностями:
            //    • Добавлять пользователей по имени
            //    • Находить / проверять доступность пользователя по любому из их свойств
            //    • Удалять заданного пользователя(критерий определяйте сами)
            //    • Экспортировать всех пользователей в файл
            //    • Импортировать всех пользователей из файла в ОЗУ
            BinaryFormatter binFormat = new();
            BD bd = new BD();
            bd.Show();
           
            while (true)
            {
                Console.WriteLine($"Enter 1 for add new user\n\t2 for del for login\n\t3 for find user by login\n\t4 for add user in File\n\t5 for read from file");
                string userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "1":
                        Console.WriteLine("Enter new user name");
                        string newUser = Console.ReadLine();
                        bd.ADD(newUser);
                        Console.WriteLine();
                        bd.Show();
                        break;
                    case "2":
                        Console.WriteLine("Enter user name for delete");
                        string del = Console.ReadLine();
                        bd.Delet(del);
                        Console.WriteLine();
                        bd.Show();
                        break;
                    case "3":
                        Console.WriteLine("Enter user name for delete");
                        string find = Console.ReadLine();
                        bd.Find(find);
                        Console.WriteLine();
                        bd.Show();
                        break;
                    case "4":                        
                        using (Stream fStream = File.Create("../../../BD.bin"))
                        {
                            binFormat.Serialize(fStream, bd);
                        }
                        Console.WriteLine("Add to file");
                        bd.Show();
                        break;
                    case "5":
                        using (Stream fStream = File.OpenRead("../../../BD.bin"))
                        {
                            bd = (BD)binFormat.Deserialize(fStream);
                        }
                        Console.WriteLine("Read from file");
                        bd.Show();
                        break;
                    case "9":
                        bd.Show();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}