using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11
{
    class Program
    {
        class Figure // класс родитель
        {
            int n; // кол-во сторон фигуры, для окружности n = 1
            double[] sz; // динамический массив длин сторон, для окружности - радиус
            Figure() // конструктор
            {
                Console.WriteLine("---- Абстрактная геометрическая фигура ----");
            }
            ~Figure() { } // деструктор
            public virtual double Perimetr() // вычисление периметр
            {
                double Per = 0;
                for (int i = 0; i < n; i++)
                {
                    Per += sz[i];
                }
                return Per;
            }
            public virtual double Square() // вычисление площади фигуры
            {
                return 0; // метод пустой, т.к. у абст. фиугры площадь не вычислить
            }
            public virtual void GetInfo() // вывод информации о фигуре
            {
                Console.WriteLine("Фигура абстрактная. Сведений нет.");
            }
            class FRectangle : Figure // класс-наследник (прямоугольник)
            {
                public FRectangle() // конструктор класса
                {
                    Console.WriteLine("1. Параметры фигуры: \n");
                    n = 4;
                    Console.Write("Введите длины сторон: \n");
                    sz = new double[n]; // массив для 4 сторон прямоугольника
                    Console.Write("\ta = ");
                    sz[0] = sz[2] = Double.Parse(Console.ReadLine());
                    Console.Write("\tb = ");
                    sz[1] = sz[3] = Double.Parse(Console.ReadLine());
                }
                ~FRectangle() // деструктор класса, уничтожение объекта
                {
                    Console.WriteLine("Уничтожена геометрическая фигура: прямоугольник.");
                }
                public override double Square() // переопределение метода, новая реализация метода
                {
                    return Math.Round(sz[0] * sz[1], 3);
                }
                public override void GetInfo()
                {
                    Console.WriteLine($"Фигура: прямоугольник.\nПри заданных длинах сторон a = {sz[0]} и b = {sz[1]} периметр фигуры = {Perimetr()}, площадь = {Square()}.");
                }
            }
            class FTriangle : Figure
            {
                public FTriangle()
                {
                    Console.WriteLine("2. Параметры фигуры: \n");
                    n = 3;
                    sz = new double[n];
                    Console.WriteLine("Введите длины сторон: ");
                    Console.Write("\ta = ");
                    sz[0] = Double.Parse(Console.ReadLine());
                    Console.Write("\tb = ");
                    sz[1] = Double.Parse(Console.ReadLine());
                    Console.Write("\tc = ");
                    sz[2] = Double.Parse(Console.ReadLine());
                }
                ~FTriangle()
                {
                    Console.WriteLine("Уничтожена геометрическая фигура: треугольник");
                }
                public override double Square()
                {
                    double per = Perimetr();
                    double Area = per*(per - sz[0]) * (per - sz[1])*(per - sz[2]);
                    Area = Math.Sqrt(Area);
                    return Math.Round(Area, 3);
                }
                public override void GetInfo()
                {
                    Console.WriteLine($"Фигура: треугольник.\nПри заданных длинах сторон a = {sz[0]}, b = {sz[1]} и c = {sz[2]} периметр фигуры = {Perimetr()}, площадь = {Square()}.");
                }
            }
            class FCircle : Figure
            {
                public FCircle()
                {
                    Console.WriteLine("3. Параметры фигуры: \n");
                    n = 1;
                    sz = new double[n];
                    Console.Write("Введите значение радиуса, r = ");
                    sz[0] = Double.Parse(Console.ReadLine());
                }
                ~FCircle()
                {
                    Console.WriteLine("Уничтожена геометрическая фигура: окружность");
                }
                public override double Perimetr()
                {
                    double Area = 2 * Math.PI * sz[0];
                    return Math.Round(Area, 3);
                }
                public override double Square()
                {
                    double Area = 2 * Math.PI * Math.Pow(sz[0], 2);
                    return Math.Round(Area, 3);
                }
                public override void GetInfo()
                {
                    Console.WriteLine($"Фигура: окружность.\nПри заданном радиусе r = {sz[0]} Длина окружности = {Perimetr()}, площадь = {Square()}.");
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Здравствуйте!\n");
                FRectangle obj1 = new FRectangle();
                obj1.GetInfo();
                FTriangle obj2 = new FTriangle();
                obj2.GetInfo();
                FCircle obj3 = new FCircle();
                obj3.GetInfo();
                Console.ReadKey();
            }
        }
    }
}
        
