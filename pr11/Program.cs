//***************************************************************
//* Практическая работа № 11                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: разработать программу алгоритма решения задачи     *
//***************************************************************

using System;

namespace pr11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!\nПрактическая работа №11");
            try
            {
                string S = null, S1 = null;
                int index = 0;
                char[] new_str = new char[100]; // массив символов для вывода слов
                Console.WriteLine("Введите, пожалуйста, предложение: ");
                S = Console.ReadLine();
                Console.WriteLine("Введите, пожалуйста, символ, который хотите подсчитать в строке: ");
                S1 = Console.ReadLine();
                bool a = S.Contains(S1);
                
            }
            catch (FormatException e) // частное исключение
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (Exception e) // общее исключение
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ReadKey();
        }
    }
}