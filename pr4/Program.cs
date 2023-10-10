//**********************************************************
//* Практическая работа № 1                                *
//* Выполнил: Пирогов Д., группа 2ИСП                      *
//* Задание: составить программу работы линейного алгоритма*
//**********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args) // точка входа в программу
        {
            Console.Title = "Практическая работа № 1"; // заголовок консоли

            double x, y, z; // объявление переменных
            double v1, v2, v3, v4, v5, v6;

            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите x = ");  // ввод исходных данных
            x = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double
            Console.Write("Введите z = "); // ввод исходных данных
            z = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double

            // расчёт значения выражения
            v1 = Math.Tan(Math.PI - x);
            v2 = Math.Sin(3 * Math.PI / 2 + z); 
            v3 = Math.Cos(Math.PI + x * z);  
            v4 = Math.Cos(3 * Math.PI / 2 + x) / Math.Sin(3 * Math.PI / 2 + x); 
            v5 = v1 * v2;
            v6 = v3 * v4;

            y = v5 / v6;

            Console.WriteLine("Результат: y = {0: #.#####}", y); // вывод результата на экран
            Console.ReadKey(); // задержка экрана консоли
        }
    }
}
