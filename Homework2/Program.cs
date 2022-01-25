using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; // Изменяем цвет шрифта для печати в консоли на DarkGreen
            Phonebook phonebook = new Phonebook(); // Создание базы данных
            phonebook.Menu(); // Вывод меню
            
        }
    }
}
