using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Problem2
{
    class HR : Employee
    {
        public HR(string name, string designation, int experience, string joiningDate, double annualSalary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Experience = experience;
            this.JoiningDate = joiningDate;
            this.AnnualSalary = annualSalary;
        }

        public override double calculateSalary(double basicSalary)
        {
            return basicSalary + (1000 * this.Experience);
        }
    }
}
