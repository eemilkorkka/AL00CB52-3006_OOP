using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects_EX1
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private int idNumber;
        private double salary;

        public void SetName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetName()
        {
            return $"{firstName} {lastName}";
        }

        public void SetSalary(double p)
        {
            salary = p;
        }

        public void AddSalary(double p)
        {
            salary += p;
        }

        public void PrintSalary()
        {
            Console.WriteLine("The salary" + " of the employee is " + salary);
        }

        public double GetSalary()
        {
            return salary;
        }

        public double CalcTax(double percentage)
        {
            return (percentage / 100) * salary;
        }
    }
}

