using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вариант 2 Создайте класс «Журнал». Необходимо хранить в полях класса: название журнала, год основания,
//       описание журнала, контактный телефон, контактный e-mail.Реализуйте методы класса для ввода данных,
//       вывода данных, реализуйте доступ к отдельным полям через методы класса. 

namespace Task_1
{
    internal class Journal
    {
        private string _name="";
        private int _yearOfFoundation=0;
        private string _description = "";
        private int _phone = 0;
        private string _mail = "";

        public string Name { get { return _name; } set { if (value.Length > 0) _name = value; } }
        public int YearOfFoundation { get { return _yearOfFoundation; } set {if(value>0 ) _yearOfFoundation = value; } }
        public string Description { get { return _description;} set { if (value.Length > 0) _description = value; } }
        public int Phone { get { return _phone;} set { if (value > 0) _phone = value; } }
        public string Mail { get { return _mail;} set { if (value.Length > 0) _mail = value; } }

        public Journal():this("journal",2000," ", 911, "journal@.com")
        {

        }

        public Journal(string name, int year, string description, int phone, string mail)
        {
            if(name.Length>0) _name = name;
            if(year > 0) _yearOfFoundation = year;
            if(description.Length > 0) _description = description;
            if(phone>0) _phone = phone;
            if (mail.Length > 0) _mail = mail;
        }   
        public void Deconstruct(out string name,out int year,out string description,out int phone, out string mail)
        {
            name = _name;
            year = _yearOfFoundation;
            description = _description;
            phone = _phone;
            mail = _mail;
        }

        public override string ToString()
        {
            return $"name {_name}\nyear {_yearOfFoundation}\ndescription {_description}\nphone {_phone}\nmail {_mail} "; 
        }

    }
}
