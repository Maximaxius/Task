using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_1
{
//Создайте интерфейс IMath.
//В нём должно быть четыре метода: 
//■ int Max() — возвращает максимум; 
//■ int Min() — возвращает минимум; 
//■ float Avg() — возвращает среднеарифметическое; 
//■ bool Search(int valueToSearch) — ищет valueSearch внутри контейнера данных.Возвращает true, если значение найдено.
//Возвращает false, если значение не найдено.

    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSerch);
    }
}
