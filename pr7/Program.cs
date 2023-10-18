//***************************************************************
//* Практическая работа № 7                                     *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: составить программу циклической структуры          *
//***************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №7 \nЗдравствуйте!");

            while (true)
            {
                try
                {
                    try
                    {
                        Console.WriteLine("Введите количество чисел (для завершения введите 0): "); // вводим значение N
                        int N = Convert.ToInt32(Console.ReadLine());
                        int a = 0; // переменная для хранения суммы квадратов чисел

                        if (N == 0) // если N = 0, то завершаем программу
                        {
                            Console.WriteLine("Программа завершена.");
                            break;
                        }
                        else if (N < 0) // если N < 0, то просим пользователя ввести положительное число
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Пожалуйста, введите положительное целое число."); 
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }

                        for (int i = 0; i < N; i++)
                        {
                            Console.Write($"Введите число {i + 1}: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            a += num * num;
                        }
                        double b = Math.Sqrt(a / N); // вычисляем среднее квадратическое
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Среднее квадратическое N чисел: {b}"); // вывод среднего квадратического на экран
                        Console.ForegroundColor = ConsoleColor.White;
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
            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }
}
