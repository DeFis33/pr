//***************************************************************
//* Практическая работа № 16                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: выполнить операции с объектами файловой системы    *
//***************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string filepath;
            int n = 0; // i - счетчик, n - количество чисел
            double a = 0; // текущее вещественное число
            Console.WriteLine("Практическая работа №16 \nЗдравствуйте!");
            Console.WriteLine("Введите путь к сохраненному файлу и укажите имя файла, \n\tнапример: D:\\Users\\1213-5\\Documents\\2-ИСП\\Дисциплина\\Основы программирования\\Фамилия\\Пирогов Д\\pr16\\pr16.txt");
            filepath = Console.ReadLine();
            try
            {
                // создание нового экземпляра объекта StreamReader и передача пути к файлу в конструктор
                FileStream F = new FileStream(filepath, FileMode.Create);
                StreamWriter writer = new StreamWriter(F); // создание файловой переменной, поток для записи в файл
                Console.Write("Введите количество чисел, n = ");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++) // цикл для перебора нужного количества строк
                {
                    Console.Write("a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                    writer.Write(a + " "); // запись значения в поток
                }
                writer.Close(); // зыкрытие потока
            }
            catch (IOException e) // обработка исключений для IOException
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка открытия файла для записи. Проверьте месторасположение файла!\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: {0}", e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            double[] mas = null; // динамический массив для считывания данных из файла
            string s; // временная переменная
            try
            {
                Array.Resize(ref mas, n); // изменение размерности массива
                Console.WriteLine("\nСодержание файла {0}: ", filepath);
                FileStream F1 = new FileStream(filepath, FileMode.Open);
                StreamReader reader = new StreamReader(F1); // создание файловой переменной, поток для чтения из файла
                while ((s = reader.ReadLine()) != null) // пока не достигнут конца файла
                {
                    s = s.TrimEnd(' '); // удаление пробела в конце строки
                    string[] text = s.Split(' '); // разбиение строки на подстроки, разделители - пробелы, запись в массив строк
                    for (int j = 0; j < text.Length; j++)
                    {
                        mas[j] = Convert.ToDouble(text[j]);
                    }
                }
                F1.Close();
            }
            catch (IOException e) // обработка исключений типа IOException
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка открытия файла для записи. Проверьте месторасположение файла!\n");
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: {0}", e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            foreach (double element in mas) // вывод массива на экран
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
