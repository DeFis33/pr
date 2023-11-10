//***************************************************************************************************
//* Практическая работа № 16                                                                        *
//* Выполнил: Пирогов Д., группа 2ИСП                                                               *
//* Задание: выполнить операции с объектами файловой системы, используя библиотеки работы с файлами *
//***************************************************************************************************

using System;
using System.IO;

namespace pr16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string filepath;
            Console.WriteLine("Практическая работа №17.\n\nЗдравствуйте!");
            Console.WriteLine("Введите путь к сохранённому файлу и укажите имя файла, \n\tнапример: D:\\Users\\1213-5\\Documents\\2-ИСП\\Дисциплина\\Основы программирования\\Фамилия\\Пирогов Д\\pr16\\pr16.txt");
            filepath = Console.ReadLine();
            try
            {
                FileStream F = new FileStream(filepath, FileMode.Create);
                StreamWriter writer = new StreamWriter(F);
                Console.WriteLine("\nФайл будет заполнен вещественными случайными числами в интервале [-10, 10].");
                Console.Write("Введите количество чисел, n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] B = new double[n];
                Random rnd = new Random();
                for (int i = 0; i < B.Length; i++)
                {
                    B[i] = rnd.NextDouble() * 10;
                    Console.WriteLine("Элемент массива B[" + i + "]: {0:#.####}", B[i]);
                }
                writer.Close();
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

            double[] mas = null;
            string s;
            try
            {

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
            Console.ReadKey();
        }
    }
}
