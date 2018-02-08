using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InventorySystem
{
    class InventoryManagement
    {
        public static void Answer()
        {

            List<Product> products = new List<Product>();

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

            Console.WriteLine("Problem 1: Inventory System");
            Console.WriteLine("Total number of product in the list: " + products.Count);

            products.Add(new Product("Potato", "10", 50, "Root"));

            Console.WriteLine("\n\nAfter adding Potato, Products in the list:");


           Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", "Name","Price", "Quantity", "Type");

            foreach (Product product in products)
            {
                Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", product.name, product.price, product.quantity, product.type);
            }

            Console.WriteLine("Total number of product in the list: " + products.Count);


            var output = products.FindAll(x => x.type == "Leafy green");

            Console.WriteLine("\nProducts in the list with type Leafy green:");
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", "Name", "Price", "Quantity", "Type");
            foreach (Product product in output)
            {
                Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12}", product.name, product.price, product.quantity, product.type);
            }

            products.Remove(products.Find(x => x.name == "Garlic"));
            Console.WriteLine("\nGarlic are sold out, Total number of product in the list: " + products.Count);

            var cabbageIndex = products.FindIndex(x => x.name == "cabbage");
            products[cabbageIndex].quantity += 50;
            Console.WriteLine("\nAfter adding 50 Quantity of cabbage final quantity in the inventory: " + products[cabbageIndex].quantity);

            double priceOfLettuce = double.Parse(products.Find(x => x.name == "lettuce").price.Replace(" RS","").Trim());
            double priceOfZucchini = double.Parse(products.Find(x => x.name == "zucchini").price.Replace(" RS", "").Trim());
            double priceOfBroccoli = double.Parse(products.Find(x => x.name == "broccoli").price.Replace(" RS", "").Trim());

            var totalPrice = (1 * priceOfLettuce) + (2 * priceOfZucchini) + (1 * priceOfBroccoli);
            Console.WriteLine("\nUser purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli, Round figure that user need to pay: " + Math.Round(totalPrice)+" RS");

        }
    }
}
