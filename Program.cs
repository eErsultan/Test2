using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product(){ Warehous = "Нью-Йоркский", Name = "Апельсины", UnitOfMeasurement = "Тонны", Remainder = 2.321 },
                new Product(){ Warehous = "Лондонский", Name = "Груши", UnitOfMeasurement = "Килограммы", Remainder = 980 },
                new Product(){ Warehous = "Нью-Йоркский", Name = "Груши", UnitOfMeasurement = "Килограммы", Remainder = 1100 },
                new Product(){ Warehous = "Нью-Йоркский", Name = "Бананы", UnitOfMeasurement = "Тонны", Remainder = 1.5 },
                new Product(){ Warehous = "Лондонский", Name = "Авокадо", UnitOfMeasurement = "Килограммы", Remainder = 490 },
                new Product(){ Warehous = "Лондонский", Name = "Апельсины", UnitOfMeasurement = "Килограммы", Remainder = 200 },
                new Product(){ Warehous = "Нью-Йоркский", Name = "Яблоки", UnitOfMeasurement = "Тонны", Remainder = 3.483 },
                new Product(){ Warehous = "Нью-Йоркский", Name = "Мандарины", UnitOfMeasurement = "Килограммы", Remainder = 1500 },
                new Product(){ Warehous = "Нью-Йоркский", Name = "Ананасы", UnitOfMeasurement = "Килограммы", Remainder = 375 },
            };


            var result = products
                .Where(p => p.Name.ToUpper()[0] == 'А' &&
                            ((p.UnitOfMeasurement == "Килограммы" && p.Remainder < 500) ||
                             (p.UnitOfMeasurement == "Тонны" && p.Remainder < 0.5)))
                .GroupBy(p => p.Warehous)
                .ToList();

            foreach (var res in result)
            {
                Console.WriteLine(res.Key);

                foreach (var product in res)
                {
                    Console.WriteLine($"{product.Name}: {product.Remainder} {product.UnitOfMeasurement}");
                }
                Console.WriteLine();
            }
        }
    }

    class Product
    {
        public string Warehous { get; set; }
        public string Name { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double Remainder { get; set; }
    }
}
