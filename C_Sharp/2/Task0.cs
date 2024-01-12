//using System;

//namespace Масиивы
//{
// С помощью матрицы строк либо нескольких массивов создать таблицу для
// хранения информации о тестах смартфонов по нескольким аспектам:
// Заполнить хотя бы 6-тью смартфонами
// **Сделать выборку данных после каждого пункта отображать рез-т в консоли), в которых:
// Рейтинг основной камеры находится в диапазоне от 126 до 133
// Рейтинг аудио меньше 70
// Рейтинг экрана 87
// Название содержит слово “Huawei”
// Смартфоном является модель серии с числом 30 в названии
//    class Program
//    {
//        static Random rand = new Random();
//        static void showArr<T>(T[] arr)
//        {
//            foreach (T el in arr)
//                Console.Write($"{el}\t");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            string[] phone = { "Huawei Mate 40 Pro", "Xiaomi Mi 10 Ultra", "Huawei P40 Pro     ", "Apple iPhone 12Pro", "Honor 30 Pro+     ", "Honor V30 Pro     " };
//            int[] camera = { 136, 133, 132, 128, 125, 122 };
//            int[] selfie = { 104, 0, 103, 0, 0, 76 };
//            int[] audio = { 0, 0, 59, 0, 0, 59 };
//            int[] display = { 0, 73, 0, 87, 0, 0 };


//            string[] phoneCopy = (string[])phone.Clone();
//            int[] cameraCopy = (int[])camera.Clone();
//            int[] selfieCopy = (int[])selfie.Clone();
//            int[] audioCopy = (int[])audio.Clone();
//            int[] displayCopy = (int[])display.Clone();


//            Array.Sort(phoneCopy[..], cameraCopy);
//            Array.Sort(phoneCopy[..], selfieCopy);
//            Array.Sort(phoneCopy[..], audioCopy);
//            Array.Sort(phoneCopy, displayCopy);



//            Console.WriteLine("Начальная таблица\nPhone name\t\tCamera\tSelfie\taudio\tdisplay");
//            for (int i = 0; i < phone.Length; i++)
//            {
//                Console.Write(phoneCopy[i] + "\t");
//                Console.Write(cameraCopy[i] + "\t");
//                Console.Write(selfieCopy[i] + "\t");
//                Console.Write(audioCopy[i] + "\t");
//                Console.Write(displayCopy[i] + "\n");
//            }
//            Console.WriteLine();

//            Console.WriteLine("\nРейтинг основной камеры находится в диапазоне от 126 до 133\nPhone name\t\tCamera\tSelfie\taudio\tdisplay");
//            for (int i = 0; i < phone.Length; i++)
//            {
//                if (cameraCopy[i] < 126 || camera[i] > 133)
//                {
//                    Console.Write(phoneCopy[i] + "\t");
//                    Console.Write(cameraCopy[i] + "\t");
//                    Console.Write(selfieCopy[i] + "\t");
//                    Console.Write(audioCopy[i] + "\t");
//                    Console.Write(displayCopy[i] + "\n");
//                }
//            }

//            Console.WriteLine("\nРейтинг аудио меньше 70\nPhone name\t\tCamera\tSelfie\taudio\tdisplay");
//            for (int i = 0; i < phone.Length; i++)
//            {
//                if (audioCopy[i] < 70 && audioCopy[i] > 0)
//                {
//                    Console.Write(phoneCopy[i] + "\t");
//                    Console.Write(cameraCopy[i] + "\t");
//                    Console.Write(selfieCopy[i] + "\t");
//                    Console.Write(audioCopy[i] + "\t");
//                    Console.Write(displayCopy[i] + "\n");
//                }
//            }

//            Console.WriteLine("\nРейтинг экрана 87\nPhone name\t\tCamera\tSelfie\taudio\tdisplay");
//            for (int i = 0; i < phone.Length; i++)
//            {
//                if (displayCopy[i] == 87)
//                {
//                    Console.Write(phoneCopy[i] + "\t");
//                    Console.Write(cameraCopy[i] + "\t");
//                    Console.Write(selfieCopy[i] + "\t");
//                    Console.Write(audioCopy[i] + "\t");
//                    Console.Write(displayCopy[i] + "\n");
//                }
//            }

//            Console.WriteLine("\nНазвание содержит слово “Huawei”\nPhone name\t\tCamera\tSelfie\taudio\tdisplay");
//            for (int i = 0; i < phone.Length; i++)
//            {
//                if (phoneCopy[i].Contains("Huawei"))  //StartsWith
//                {
//                    Console.Write(phoneCopy[i] + "\t");
//                    Console.Write(cameraCopy[i] + "\t");
//                    Console.Write(selfieCopy[i] + "\t");
//                    Console.Write(audioCopy[i] + "\t");
//                    Console.Write(displayCopy[i] + "\n");
//                }
//            }

//            Console.WriteLine("\nСмартфоном является модель серии с числом 30 в названии\nPhone name\t\tCamera\tSelfie\taudio\tdisplay");
//            for (int i = 0; i < phone.Length; i++)
//            {
//                if (phoneCopy[i].Contains("30"))
//                {
//                    Console.Write(phoneCopy[i] + "\t");
//                    Console.Write(cameraCopy[i] + "\t");
//                    Console.Write(selfieCopy[i] + "\t");
//                    Console.Write(audioCopy[i] + "\t");
//                    Console.Write(displayCopy[i] + "\n");
//                }
//            }
//        }
//    }
//}
