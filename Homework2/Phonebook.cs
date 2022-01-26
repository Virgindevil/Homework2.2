using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Phonebook
    {
        private List<Person> pbook = new List<Person>(); // Создание листа с учениками

        public Phonebook() // База данных
        {
            
        }

        public void addPerson(Person p) // Добавление ученика
        {
            pbook.Add(p);
        }

        public void Show() // Показать список учеников
        {
            
            foreach (var person in pbook)
            {                
                person.ShowPerson();
            }
        }

        public void Menu() // Вывод меню
        {
            
            int control = 0; // Присвоение значения переменной по-умолчанию
            while (control != 3) // Условие НЕ равнения трём
            {
                // Текстовой помощник
                
                Console.SetCursorPosition(17, 0);
                Console.WriteLine($"Сделайте выбор: 1 - Добавить ученика, 2 - Показать базу учеников, 3 - Выйти.");
                Console.SetCursorPosition(50, 1);
                control = Convert.ToInt32(Console.ReadLine()); // Конвертирование вводимых данных
                if (!(control >= 1 && control <= 4))
                {
                    Console.SetCursorPosition(33, 2);
                    Console.WriteLine("Некорректный Ввод! Введите число от 1 до 4");
                    control = int.Parse(Console.ReadLine());
                }

                // Выриативность действий в зависимости от введённых данных
                switch (control)
                {
                    case 1: // Если ввели 1
                        Console.Clear();
                        Person person = new Person(); // Начало ввода данных нового ученика
                        Console.SetCursorPosition(45, 0);
                        Console.WriteLine("Введите Имя:"); // Ввод имени
                        Console.SetCursorPosition(40, 1);
                        person.AddFName(Console.ReadLine()); // Добавление данных
                        Console.SetCursorPosition(43, 2);
                        Console.WriteLine("Введите Фамилию:"); // Ввод фамилии
                        Console.SetCursorPosition(40, 3);
                        person.AddLName(Console.ReadLine()); // Добавление данных
                        Console.SetCursorPosition(43, 4);
                        Console.WriteLine("Введите Отчество:"); // Ввод отчества
                        Console.SetCursorPosition(40, 5);
                        person.AddAName(Console.ReadLine()); // Добавление данных
                        Console.SetCursorPosition(43, 6);
                        Console.WriteLine("Введите Возраст:"); // Ввод возраста
                        Console.SetCursorPosition(40, 7);
                        person.AddAge(Console.ReadLine()); // Добавление данных
                        Console.SetCursorPosition(45, 8);
                        Console.WriteLine("Введите Email:"); // Ввод email
                        Console.SetCursorPosition(40, 9);
                        person.AddHeight(Console.ReadLine()); // Добавление данных
                        Console.SetCursorPosition(38, 10);                        
                        Console.WriteLine("Введите баллы по истории: "); // Ввод данных пользователя                        
                        Console.SetCursorPosition(40, 11);
                        person.AddHistory(float.Parse (Console.ReadLine())); // Считывание данных
                        Console.SetCursorPosition(37, 12);
                        Console.WriteLine("Введите баллы по математике: "); // Ввод данных пользователя                        
                        Console.SetCursorPosition(40, 13);
                        person.AddMath(float.Parse(Console.ReadLine())); // Считывание данных
                        Console.SetCursorPosition(36, 14);
                        Console.WriteLine("Введите баллы по русскому языку: "); // Ввод данных пользователя                        
                        Console.SetCursorPosition(40, 15);
                        person.AddRus(float.Parse(Console.ReadLine())); // Считывание данных  
                        Console.SetCursorPosition(35, 16);
                        person.Summ();
                        person.Score();                        
                        Console.WriteLine($"Готово! Ученик занесён в базу. ");
                        Console.SetCursorPosition(32, 17);
                        Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        Console.Clear();
                        addPerson(person);
                        break;
                        
                    case 2: // Если ввели 2
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"{"Имя",10} {"Фамилия",15} {"Отчество",15} {"Возраст",10} {"Email",10} {"История",12} {"Математика",7} {"Русский",5} {"Сумма баллов",7} {"Ср.балл",7}");
                        Show(); // Показать список                        
                        Console.SetCursorPosition(32, 25);
                        Console.WriteLine($"Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3: // Если ввели 3
                        Environment.Exit(0); // Выход
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
