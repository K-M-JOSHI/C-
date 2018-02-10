using Assignment3.Problem1;
using Assignment3.Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            InventoryManagement.Answer();

            Console.WriteLine("\n\nProblem 2:");
            HR hr = new HR("Om","HR",4,"02/02/2017",0);
            hr.AnnualSalary = hr.calculateSalary(8000)*12;

            Developer developer = new Developer("Jay", "Developer", 5, "05/03/2017", 0);
            developer.AnnualSalary = developer.calculateSalary(8000)*12;

            Console.WriteLine("\n\n"+hr.Name + "(HR), Monthly salary is " + (hr.AnnualSalary / 12) + " and Annual salary is " + hr.AnnualSalary );
            Console.WriteLine("\n\n"+developer.Name + "(Developer), Monthly salary is " + (developer.AnnualSalary / 12) + " and Annual salary is " + developer.AnnualSalary);


        }
    }
}
