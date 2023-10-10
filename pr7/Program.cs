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
            Console.WriteLine("Практическая работа №7");
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Введите число: "); // вводим значение N 
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 0; // переменная для хранения суммы квадратов чисел
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}