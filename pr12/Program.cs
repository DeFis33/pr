//***************************************************************
//* Практическая работа № 12                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: изучение методов создания функций                  *
//***************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №12 \n Здравствуйте!");

            try
            {
                Console.Write("Введите предложение: ");
                System.String predl = Console.ReadLine();
                
                Console.Write("Введите три буквы, которые вы хотели бы заменить: ");
                System.String a = Console.ReadLine();
                
                Console.Write("Введите три буквы, которые вы хотели бы использовать для замены: ");
                System.String b = Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка ввода данных!" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
// Contains: определяет, содержится ли подстрока в строке
// Replace: замещает в строке символ или подстроку другим символом или подстрокой
// включить программу в блок обработки ошибок
