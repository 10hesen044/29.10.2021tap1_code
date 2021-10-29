using System;

namespace _29._10._2021tap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Name = "Sweatshirt";
            product.BrandName = "Tommy Hilfiger";
            product.Price = 150;

            Console.WriteLine($"{product.Name} {product.BrandName} {product.Price}");


            Product product2 = new Product();

            product2.Name = "Qelem";
            product2.BrandName = "Oyal";
            product2.Price = 2;

            Console.WriteLine($"{product2.Name} {product2.BrandName} {product2.Price}");


            Product product3 = new Product();

            product3.Name = "Ayaqqabi";
            product3.BrandName = "Zara";
            product3.Price = 200;

            Console.WriteLine($"{product3.Name} {product3.BrandName} {product3.Price}");
        }

    }
}
