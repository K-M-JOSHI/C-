using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InventorySystem
{
    class Product
    {
        public string name, price, type;
        public double quantity;

        public Product(string name, string price, int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

    }
}
