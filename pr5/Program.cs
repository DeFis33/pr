//***************************************************************
//* Практическая работа № 5                                     *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: составить программу для работы алгоритма ветвления *
//***************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, sum1 = 0; // объявление переменной sum и sum1

            Console.WriteLine("Практическая работа № 5\nЗдравствуйте!\n");
            Console.Write("Введите номер вашего шестизначного билета: "); // ввод исходных данных
            int a = Convert.ToInt32(Console.ReadLine());

            // вычисляем сумму цифр первой половины билета
            sum += a / 100000;
            sum += (a / 10000) % 10;
            sum += (a / 1000) % 10;
            // вычисляем сумму цифр второй половины билета
            sum1 += (a / 100) % 10;
            sum1 += (a / 10) % 10;
            sum1 += a % 10;

            if (sum == sum1) // если sum == sum1, то
            {
                Console.WriteLine("\nБилет является счастливым!");
            }
            // иначе
            else Console.WriteLine("Билет не является счастливым.");

            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }
}
