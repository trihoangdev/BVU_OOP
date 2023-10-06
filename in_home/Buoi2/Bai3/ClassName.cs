using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class ClassName
    {
        private string name; //tên lớp đang học 
        private int course; //tên khoá học

        public ClassName()
        {
        }

        public ClassName(string name, int course)
        {
            this.name = name;
            this.course = course;
        }

        public string Name { get => name; set => name = value; }
        public int Course { get => course; set => course = value; }
        public void Input()
        {
            Console.WriteLine("===> CLASS INFO <===");
            Console.Write("Name of class: ");
            name = Console.ReadLine();
            Console.Write("Course: ");
            course = int.Parse(Console.ReadLine());
            Console.WriteLine("====================");
        }
        public void Output()
        {
            Console.WriteLine("===> CLASS INFO <===");
            Console.WriteLine("Name of class: " + name);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("====================");
        }
    }
}
