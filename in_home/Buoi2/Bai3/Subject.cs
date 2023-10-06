using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Subject
    {
        private string name;
        private int credits;//so tín chỉ
        private double score;
        public string Name { get => name; }
        public int Credits { get => credits; }
        public double Score { get => score; }

        public Subject()
        {
        }

        public Subject(string name, int credits, double score)
        {
            this.name = name;
            this.credits = credits;
            this.score = score;
        }

        

        public void Input()
        {
            Console.WriteLine("===> SUBJECT INFO <===");
            Console.Write("Name of subject: ");
            name = Console.ReadLine();
            Console.Write("Num of credits: ");
            credits = int.Parse(Console.ReadLine());
            Console.Write("Score: ");
            score = double.Parse(Console.ReadLine());
            Console.WriteLine("=====================");
        }
        public void Output()
        {
            Console.WriteLine("===> SUBJECT INFO <===");
            Console.WriteLine("Name of subject: "+ name);
            Console.WriteLine("Num of credits: " + credits);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("======================");

        }
    }
}
