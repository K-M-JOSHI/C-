using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Problem2
{
    abstract class Employee
    {
        private string name, designation, joiningDate;
        private double annualSalary;
        private int experience;

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Experience { get => experience; set => experience = value; }
        public string JoiningDate { get => joiningDate; set => joiningDate = value; }
        public double AnnualSalary { get => annualSalary; set => annualSalary = value; }

        public abstract double calculateSalary(double basicSalary);
    }
}
