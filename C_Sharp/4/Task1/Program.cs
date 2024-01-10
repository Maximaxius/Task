//На выбор создать один из классов с предельным наполнением с учётом ранее нами изученного 😊
//КонстуркторЫ, деконструкторы, свойства, переопределение ToString() и т.п.
//В Main продемонстрировать работоспособность работы с массивом объектов одного из созданных классов.
//Вариант 2 Создайте класс «Журнал». Необходимо хранить в полях класса: название журнала, год основания,
//       описание журнала, контактный телефон, контактный e-mail.Реализуйте методы класса для ввода данных,
//       вывода данных, реализуйте доступ к отдельным полям через методы класса. 


namespace Task_1         
{
    internal class Program
    {
        static string[] nameJournal = new string[] { "None", "Game","Video","Step"};
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Journal[] journals = new Journal[rand.Next(3,15)];

            for (int i = 0; i < journals.Length; i++)
            {
                journals[i] = new Journal(nameJournal[rand.Next(nameJournal.Length)],rand.Next(2077)," ",0," ");
            }

            for (int i = 0; i < journals.Length; i++)
            {
                Console.WriteLine($"journal {i}\n{journals[i]}\n");
            }

            (string deconName, int deconYear,_,_,_) = journals[0];
            journals[1].Name= deconName;                              /// первый журнал получит год и название от журнала 0
            journals[1].YearOfFoundation = deconYear;
                        
            for (int i = 0; i < journals.Length; i++)
            {
                Console.WriteLine($"journal {i}\n{journals[i]}\n");
            }
        }      
    }
}