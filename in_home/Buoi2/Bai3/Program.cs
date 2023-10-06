using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStudent;
            Console.Write("Num of student: ");
            numOfStudent = int.Parse(Console.ReadLine());
            Student[] students = new Student[numOfStudent];
            for(int i = 0; i < numOfStudent; i++)
            {
                Console.WriteLine("=> STUDENT {0}",i);
                students[i] = new Student();
                students[i].Input();
                Console.WriteLine("=====================\n");
            }
            for(int i = 0;i<numOfStudent;i++) 
            {
                Console.WriteLine("=> STUDENT {0}", i);
                students[i].Output();
                Console.WriteLine("===================\n");
            }

            Console.ReadKey();
        }
    }
}
