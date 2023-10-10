namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x, y, z;
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10;

            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y = ");
            y = Convert.ToDouble(Console.ReadLine());

            v1 = Math.Pow(x, 2);
            v2 = Math.Log10(v1);
            v3 = 2 * y;
            v4 = Math.Sin(v3);
            v5 = Math.Exp(v4);
            v6 = v2*v5;
            v7 = 3 * x;
            v8 = Math.Log10(v7);
            v9 = Math.Sqrt(y);
            v10 = v8+v9;
            
            z = v6/v10;

            Console.WriteLine("Результат: z = " + z);
            Console.ReadKey();
            // сделаешь подписи и надпись практическая работа сам
        }
    }
}