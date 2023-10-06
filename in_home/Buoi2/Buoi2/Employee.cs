using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private double basicSalary;
        private double bonus;

        //constructors
        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string address, double basicSalary, double bonus)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.basicSalary = basicSalary;
            this.bonus = bonus;
        }

        //getter,setter
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double Bonus { get => bonus; set => bonus = value; }
        
        //methods
        public double CalculBonus(double percent)
        {
            bonus = basicSalary * percent * 0.01;
            return bonus;
        }
        public void Input()
        {
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Address: ");
            address = Console.ReadLine();
            Console.Write("Basic Salary: ");
            basicSalary = double.Parse(Console.ReadLine());
            bonus = 0;
        }
        public void Output()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Bonus: " + bonus);
        }
    }
}
