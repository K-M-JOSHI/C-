using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Problem1
{
    class InventoryManagement
    {
        public static void Answer()
        {
            double totalPrice = 0, totalQty = 0, totalPriceOfProduts=0;
            List<Product> products = new List<Product>();
            List<Product> costlyProducts = new List<Product>();
            List<Product> chipProducts = new List<Product>();

            products.Add(new Product("lettuce", "10.5 RS", 50, "Leafy green"));
            products.Add(new Product("cabbage", "20 RS", 100, "Cruciferous"));
            products.Add(new Product("pumpkin", "30 RS", 30, "Marrow"));
            products.Add(new Product("cauliflower", "10 RS", 25, "Cruciferous"));
            products.Add(new Product("zucchini", "20.5 RS", 50, "Marrow"));
            products.Add(new Product("yam", "30 RS", 50, "Root"));
            products.Add(new Product("spinach", "10 RS", 100, "Leafy green"));
            products.Add(new Product("broccoli", "20.2 RS", 75, "Cruciferous"));
            products.Add(new Product("Garlic", "30 RS", 20, "Leafy green"));
            products.Add(new Product("silverbeet", "10 RS", 50, "Marrow"));

            Console.WriteLine("Problem 1: ");
            Console.WriteLine("Product list based on type of product: Leafy green(1), Cruciferous(2), Marrow(3), Root(4), Skip(5)");
            while (true)
            {
                Console.Write("Enter your choice: ");
                try
                {

                    int index = int.Parse(Console.ReadLine());
                    if (index == 5) break;
                    Console.WriteLine(Product.types[index - 1]);
                    var result = Product.ProductsWithType(products, Product.types[index - 1]);
                    Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", "Name", "Price", "Quantity", "Type");
                    foreach (var i in result)
                    {
                        Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", i.Name, i.Price, i.Quantity, i.Type);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter only numbers from 1,2,3,4,5 !!");
                }
            }


            foreach (var i in products)
            {
                totalPrice += double.Parse(i.Price.Replace(" RS", "").Trim()) * i.Quantity;
                totalQty += i.Quantity;
                totalPriceOfProduts += double.Parse(i.Price.Replace(" RS", "").Trim());

            }
            
            Console.WriteLine("\nTotal prize of whole Inventory: " + totalPrice);
            Console.WriteLine("\nAverage prize of Product w.r.t whole inventory price and total quantity : " + totalPrice / totalQty);
            Console.WriteLine("\nAverage prize of Product w.r.t all products and it's price: " + totalPriceOfProduts / products.Count);


            foreach (var p in products)
            {
                if (double.Parse(p.Price.Replace(" RS", "").Trim()) > 50)
                {
                    costlyProducts.Add(p);
                }
                else
                {

                    chipProducts.Add(p);
                }
            }


            if (costlyProducts.Count != 0)
            {
                Console.WriteLine("\nCostly Products: ");
                Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", "Name", "Price", "Quantity", "Type");
                foreach (var i in costlyProducts)
                {
                    Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", i.Name, i.Price, i.Quantity, i.Type);
                }
            }
            else
            {

                Console.WriteLine("\nThere is no product which have price greater than 50 !!");
            }

            if (chipProducts.Count != 0)
            {
                Console.WriteLine("\nChip Products: ");
                Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", "Name", "Price", "Quantity", "Type");
                foreach (var i in chipProducts)
                {
                    Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", i.Name, i.Price, i.Quantity, i.Type);
                }
            }
            else
            {

                Console.WriteLine("\nThere is no product which have price less than or equal 50 !!");
            }
        }
    }
}
