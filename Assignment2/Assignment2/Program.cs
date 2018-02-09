using System;
using System.Collections.Generic;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            products.Add("Tomato");
            products.Add("Potato");
            products.Add("ToMato");
            products.Add("Potato");
            products.Add("Red Tomato");
            products.Add("Tomato Catchup");
            products.Add("Grapes");
            products.Add("grapes");
            products.Add("potato");

            var match  = products.FindAll(x => string.Equals("tomato",x, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Types of string ‘tomato’(case insensititve) in inventory: "+match.Count);

            var match2 = products.FindAll(x => string.Equals("Potato", x, StringComparison.Ordinal));

            Console.WriteLine("Index of “Potato”(case sensitive) in list (list index starts from 0): ");
            int j = 0;
            foreach (var i in products)
            {
                if (string.Equals("Potato", i, StringComparison.Ordinal)) {
                    Console.WriteLine(j);
                    
                }
                j++;
            }

            float X = 0.06f;
            float Y = 5.94f;
            float sum = X + Y;
            Console.WriteLine("\n\nSum of X & Y : " + sum);

            if (sum > 6)
            {
                Console.WriteLine("X + Y = 6: False");
            }
            else if (sum < 6)
            {
                Console.WriteLine("X + Y = 6: False");
            }
            else {

                Console.WriteLine("X + Y = 6: True");
            }

            if (X > Y)
            {
                Console.WriteLine("X has greater value");
            }
            else {
                Console.WriteLine("Y has greater value");
            }


        }
    }
}
