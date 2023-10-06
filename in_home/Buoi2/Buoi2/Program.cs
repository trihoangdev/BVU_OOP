using Buoi2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            for(int i = 0; i < 3; i++)
            {
                employees[i] = new Employee();
                Console.WriteLine("===> INPUT OF EMPLOYEE {0} <===", i);
                employees[i].Input();
                Console.Write("Percent of bonus: ");
                double percent = double.Parse(Console.ReadLine());
                employees[i].Bonus = employees[i].CalculBonus(percent);
                Console.WriteLine("===============================\n");
            }
            Console.WriteLine("\n===> OUTPUT OF EMPLOYEE <===");
            for (int i = 0;i< 3;i++)
            {
                Console.WriteLine("EMPLOYEE {0}: ",i);
                employees[i].Output();
                Console.WriteLine("__________________________");
            }

            Console.ReadKey();
        }
    }
}
