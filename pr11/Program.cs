//***************************************************************
//* Практическая работа № 11                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: изучить основные структуры языка: символы и строки *
//***************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pr11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №11");
            Console.WriteLine("Здравствуйте!");
            try
            {
                string S = null;
                int index = 0;
                Console.WriteLine("Введите, пожалуйста, текст: ");
                S = Console.ReadLine();

                if (string.IsNullOrEmpty(S)) // проверка строки
                {
                    Console.WriteLine("Строка пустая! Вы ничего не ввели.");
                    Console.ReadKey();
                    Environment.Exit(0); // досрочный выход из программы
                }

                int a = S.Length; // длина строки

            }
            
            catch(Exception ex) // обработка общего исключения
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что-то пошло не так. Ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
