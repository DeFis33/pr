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
            Console.WriteLine("Практическая работа №7");
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Введите количество чисел: "); // вводим значение N 
            
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 0; // переменная для хранения суммы квадратов чисел
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                a += num * num;
            }
            
            double b = Math.Sqrt(a / N); // вычисляем среднее квадратическое
            Console.WriteLine($"Среднее квадратическое N чисел: {b}");

            Console.WriteLine("Досвидания!");
            Console.ReadKey();
        }
    }
}
