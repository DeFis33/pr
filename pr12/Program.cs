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
            Console.WriteLine("Практическая работа №12");
            Console.WriteLine("Здравствуйте!");

            try
            {
                Console.Write("Введите предложение: ");
                System.String predl = Console.ReadLine();
                
                Console.Write("Введите три буквы, которые вы хотели бы заменить: ");
                System.String a = Console.ReadLine();
                
                Console.Write("Введите три буквы, которые вы хотели бы использовать для замены: ");
                System.String b = Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}
// Contains: определяет, содержится ли подстрока в строке
// Replace: замещает в строке символ или подстроку другим символом или подстрокой