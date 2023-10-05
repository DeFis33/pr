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
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0; // объявление переменных
            int sum = 0; // объявление переменной sum
            int sum1 = 0; // объявление переменной sum1

            Console.WriteLine("Практическая работа № 2 ");
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите первые три цифры номера вашего билета - "); // ввод исходных данных
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите последние три цифры номера вашего билета - "); // ввод исходных данных
            b = Convert.ToInt32(Console.ReadLine());
            
            while (a > 0)
            {
                int f = a % 10; // получаем последнюю цифру числа
                sum += f; // добавляем цифру к сумме
                a /= 10; // удаляем последнюю цифру числа
            }
            while (b > 0)
            {
                int g = b % 10; // получаем последнюю цифру числа
                sum1 += g; // добавляем цифру к сумме
                b /= 10; // удаляем последнюю цифру числа
            }
            if (sum > sum1) // если sum > sum1, то
            {
                Console.WriteLine("Ваш билет не является счастливым.");
            }
            else if (sum < sum1) // иначе
                 {
                    Console.WriteLine("Ваш билет не является счастливым.");
                 }
                 else Console.WriteLine("Ваш билет является счастливым.");

            Console.ReadKey();
        }
    }
}