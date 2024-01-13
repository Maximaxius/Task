using System.Text;

namespace Task_0
{
    class Program
    {

        static void writeFile(string path, string[] userString)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                for (int i = 0;i < userString.Length; i++)
                {
                    byte[] writeBite = Encoding.Default.GetBytes(userString[i]);
                    fs.Write(writeBite, 0, writeBite.Length);
                }                 
            }
        }

        static void writeFile(string path, int[] userint)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                for (int i = 0; i < userint.Length; i++)
                {
                    byte[] writeBite = Encoding.Default.GetBytes((userint[i]).ToString());
                    fs.Write(writeBite, 0, writeBite.Length);
                }
            }
        }

        static string ReadFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath,
                    FileMode.Open, FileAccess.Read,
                    FileShare.Read))
            {
                byte[] readBytes = new byte[(int)fs.Length];
                fs.Read(readBytes, 0, readBytes.Length);

                return Encoding.Default.GetString(readBytes);
            }
        }

        static Random rand = new Random();


        
        static void Main()
        {
            //1.Мусорить аналогично нужно уметь
            //Создайте файл размером ~2 Мбайта(допускается погрешность), состоящий из 13
            //строк, каждая из которых состоит из случайных символов.
            string[] arrString = new string[13];
            for (int i = 0; i < 13; i++)
            {
                StringBuilder st = new StringBuilder();
                for (int j = 0; j < 162000; j++)
                {
                    st.Append((char)rand.Next('0', 'z'));
                }
                arrString[i] = st.ToString();
            }
            
            string filePath = "../../../test.bin";
            writeFile(filePath, arrString);
            ReadFile(filePath);


            //2. ..как и убирать за собой
            //Считайте файл, который создали ранее, уберите из него все символы, кроме цифр, а
            //после запишите результат фильтрации в новый файл, записывая каждую из цифр на новой строке.

            string fromFile = ReadFile(filePath);

            int kolvoNumb = 0;
            for (int i = 0; i < fromFile.Length; i++)
            {
                if (fromFile[i] == '0' || fromFile[i] == '1' || fromFile[i] == '2' || fromFile[i] == '3' || fromFile[i] == '4' || fromFile[i] == '5' || fromFile[i] == '6' || fromFile[i] == '7' || fromFile[i] == '8' || fromFile[i] == '9')
                    kolvoNumb++;
            }
            Console.WriteLine($"vsego num in file 0 = {kolvoNumb}");

            int[] numbers = new int[kolvoNumb];
            for (int i = 0, j = 0; i < fromFile.Length; i++)
            {
                if (fromFile[i] == '0' || fromFile[i] == '1' || fromFile[i] == '2' || fromFile[i] == '3' || fromFile[i] == '4' || fromFile[i] == '5' || fromFile[i] == '6' || fromFile[i] == '7' || fromFile[i] == '8' || fromFile[i] == '9')
                {
                    numbers[j] = int.Parse(fromFile[i].ToString());
                    j++;
                }                                                   /// очень глупо тк через парс почемуто ек вышло 
            }

            string filePathForNumbers = "../../../Numbers.bin";             // в строку "/(

            writeFile(filePathForNumbers, numbers);


        }
    }
}