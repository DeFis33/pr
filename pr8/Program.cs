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
            Console.WriteLine("Практическая работа №8. \nЗдравствуйте! ");

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите любую цифру, чтобы увидеть таблицу значений функции y=5-x^2/2 на отрезке [-5; 5] с шагом 0,5. \n(для завершения введите 0): ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a == 0) // если a = 0, то завершаем программу
                    {
                        Console.WriteLine("Программа завершена.");
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("    x |     y");
                    Console.WriteLine("----------------");
                    Console.ForegroundColor = ConsoleColor.White;

                    double x = -5, end = 5, step = 0.5;

                    do
                    {
                        double y = 5 - Math.Pow(x, 2) / 2; // вычисление значения функции для текущего значения x
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" {x,4} | {y,6}"); // вывод значения x и y на консоль
                        Console.ForegroundColor = ConsoleColor.White;
                        x += step; // увеличение значения x на шаг (step)
                    } while (x <= end); // выполнение цикла do while до тех пор, пока x не станет больше end
                }
                catch (FormatException e) // частное исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine("До свидания!");
        }
    }
}
