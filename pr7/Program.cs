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

                        int a = 0;
                        for (int i = 0; i < N; i++)
                        {
                            Console.Write($"Введите число {i + 1}: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            // нужно сохранить каждое введённое число пользователя, для вычисления квадрата расстояния... (2 этап)
                            a += number; 
                        }
                        int c = a / N; // вычисляем среднее арифметическое (1 этап)

                        //double b = Math.Sqrt(a / N); заменить a на другую переменнную, т.к. она занята (3 этап)
                        Console.WriteLine($"Среднее квадратическое N чисел: {b}");

                    }
                    catch (FormatException fe) // частное исключение
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка ввода \n" + fe.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }
}
