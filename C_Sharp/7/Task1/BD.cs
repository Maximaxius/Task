using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


//Реализовать класс БД для хранения пользователей с возможностями:
//• Добавлять пользователей по имени
//• Находить/проверять доступность пользователя по любому из их свойств
//• Удалять заданного пользователя (критерий определяйте сами)
//• Экспортировать всех пользователей в файл
//• Импортировать всех пользователей из файла в ОЗУ

namespace ConsoleApp1
{
    [Serializable]
    class BD
    {
        private List<User> users;

        public BD()
        {
            users = new List<User>();
            for (int i = 0; i < 3; i++) 
                users.Add(new User());
        }

        public void ADD(string name)
        {
            users.Add(new User(name));
        }
        public void Find(string name)
        {
            Console.WriteLine($"\n{users.Contains(new User(name))}\n");
        }

        public void Delet(string name)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if(users[i].login == name)
                    users.RemoveAt(i);
            }
        }

        public void Show()
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i}]:{users[i]}");
                Console.WriteLine();
            }


            //foreach (var item in users)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //};
            Console.WriteLine();
        }




    }
}
