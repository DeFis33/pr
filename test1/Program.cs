using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        struct Hotel
        {
            int cost;
            int rooms;
            string name;
            string category;

            public Hotel(string name, string category, int cost, int rooms)
            {
                this.name = name;
                this.category = category;
                this.cost = cost;
                this.rooms = rooms;
                WriteHotel();
            }
            void WriteHotel()
            {
                Console.WriteLine("Имя: {0}; Количество комнат: {1}; Категория: {2}; Цена: {3}", name, rooms, category, cost);
            }
        }
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel("Отель 12", "Номер Люкс", 1200, 100);
            Console.ReadKey(); 
        }
    }
}