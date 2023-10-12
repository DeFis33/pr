//***************************************************************
//* Практическая работа № 8                                     *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: составить программу циклической структуры          *
//***************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №8. \n Здравствуйте! ");
            int a = -5, b = 5;
            
            try
            {
                do
                {

                }
                while ();
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Что-то пошло не так. Ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
// предусмотреть многократное выполнение программы без повторного запуска
// доработать программу алгоритма с помощью кода обработки ошибок времение выполнения
// (использовать как базовый класс для исключений, так и производные от него)