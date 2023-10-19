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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №8. \n Здравствуйте! ");

            while (true)
            {
                try
                {
                    try
                    {
                        Console.WriteLine("... (для завершения введите 0): ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        if (a == 0) // если a = 0, то завершаем программу
                        {
                            Console.WriteLine("Программа завершена.");
                            break;
                        }
                    }
                    catch (FormatException fe) // частное исключение
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка ввода \n" + fe.Message); // вывод ошибки на экран
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ReadKey();
        }
    }
}
