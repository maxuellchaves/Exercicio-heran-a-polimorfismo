using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_herança_e_polimorfismo.Entities;
using System.Globalization;

namespace Exercicio_herança_e_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                string import = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(import == "i")
                {
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, fee));
                    Product Import = new ImportedProduct();
                    Import.PriceTag(import);
                }else if(import == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacture));
                    Product used = new UsedProduct();
                   used.PriceTag(import);
                }
                else
                {
                    list.Add(new Product(name, price));
                    Product product = new Product();
                    product.PriceTag(import);
                }
            }

            Console.WriteLine();
            foreach(Product product in list)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
        }
    }
}
