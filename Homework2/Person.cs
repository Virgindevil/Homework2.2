using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Person
    {
        private string Fname; // Переменная Имени
        private string Lname; // Переменная Фамилии
        private string Aname; // переменная Отчества
        private string Age; // Переменная Возраста
        private string Email; // Переменная Email
        private float History; // Переменная Баллов по Истории
        private float Math; // Переменная Баллов по Математике
        private float Rus; // Переменная Баллов по Русскому
        private string ScoreF; // Переменная среднего балла по трём предметам

        public Person()
        {
            
        } // Профиль ученика

        public void AddFName(string fname) // Данные Имени
        {
            Fname = fname;
        }

        public void AddLName(string lname) // Данные Фамилии
        {
            Lname = lname;
        }

        public void AddAName(string aname)  // Данные Отчества
        {
            Aname = aname;
        }

        public void AddAge(string age) // Данные Возраста
        {
            Age = age;
        } 

        public void AddHeight(string height) // Данные Email
        {
            Email = height;
        }

        public void AddHistory(float history) // Данные Баллов по Истории
        {
            
            History = history;
        }

        public void AddMath(float math) // Данные Баллов по Математике
        {
            
            Math = math;
        }

        public void AddRus(float rus) // Данные Баллов по Русскому
        {           
            Rus = rus;                       
        }

        public void Score() // Вычесление среднего балла по трём предметам    
        {
            float score = (History + Math + Rus) / 3; // Вычесление среднего балла по трём предметам         
            string scoref = score.ToString("#.##");
            ScoreF = scoref;
        }
        

        public void ShowPerson()
        {            
            Console.WriteLine($"{Fname,10} {Lname,15} {Aname,15} {Age,7} {Email,20} {History,10} {Math,8} {Rus,9} {ScoreF,8}");

        }
    }
}