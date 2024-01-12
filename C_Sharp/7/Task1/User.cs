using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//Создать класс “Пользователь” с полями: логин, пароль, почта, датавремя регистрации
//(генерировать в формате “ДД-ММ-ГГ ЧЧ:ММ: СС”).
//Реализовать:
//• конструкторы по умолчанию/с параметрами
//• необходимые аксессоры
//• метод ToString()

namespace ConsoleApp1
{
    [Serializable]
    class User
    {
        [NonSerialized]
        static Random rand = new Random();
        [NonSerialized]
        string[] logins = { "User", "Non user","123"};


        private string _login;
        private string _password;
        private string _email;
        private DateTime _dateReg;

        public string login { get { return _login; } }

        public User()
        {
            _login = logins[rand.Next(logins.Length)];
            _password = genPassword();
            _email = "hell13@step.com";
            _dateReg = DateTime.Now;
        }

        public User(string Login)//, string Password, string Email, DateTime DateReg )
        {
            _login = Login;
            //_password = Password;
            //_email = Email;
            //_dateReg = DateReg;
        }

        private string genPassword()
        {
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < rand.Next(3, 15); i++)
            {
                password.Append((char)rand.Next('0', 'z'));
            }
            return password.ToString();
        }

        public override string ToString()
        {
            return $"login {_login}\npassword {_password}\nemail {_email}\n_dateReg {_dateReg}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not User) return false;

            User? other = obj as User;
            return this.login.Equals(other!.login);
        }


    }
}
