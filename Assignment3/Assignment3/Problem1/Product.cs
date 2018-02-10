using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Product
    {
        public static string[] types = { "Leafy green", "Cruciferous", "Marrow", "Root" };
        private string type;
        private double quantity;
        private string name;
        private string price;

        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public Product(string name, string price, int quantity, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;  
        }

        public static List<Product> ProductsWithType(List<Product> products,string type)
        {

            switch (type)
            {
                case "Leafy green":
                    return products.FindAll(x => x.Type == types[0]).ToList();
                    break;
                case "Cruciferous":
                    return products.FindAll(x => x.Type == types[1]).ToList();
                    break;
                case "Marrow":
                    return products.FindAll(x => x.Type == types[2]).ToList();
                    break;
                case "Root":
                    return products.FindAll(x => x.Type == types[3]).ToList();
                    break;

                default:
                    return null;
                    break;
            }
        }

    }
}
