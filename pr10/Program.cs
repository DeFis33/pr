//***************************************************************
//* Практическая работа № 10                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: обработать двумерный массив                        *
//***************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // объявление и инициализация
            int M = 3, N = 5; // задание размерностей массива
            int[,] mas = new int[M, N]; // объявление двумерного массива

            // заполнение двумерного массива с клавиатуры
            for (int i = 0; i < M; i++) // ввод по строкам
            {
                for (int j = 0; j < N; j++) // ввод по столбцам
                {
                    Console.WriteLine("Введите [" + i + "," + j + "] элемент массива: ");
                    mas[i, j] = Convert.ToInt32(Console.ReadLine()); // запись числа в текущий элемент массива
                }
            }

            Console.ReadKey();
        }
    }
}