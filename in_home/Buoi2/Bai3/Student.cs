using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Student
    {
        private int id;
        private string name;
        private ClassName className;
        private Subject[] subject;
        int numOfSubject;
        public Student()
        {
        }

        public Student(int id, string name, ClassName className, Subject[] subject)
        {
            this.id = id;
            this.name = name;
            this.className = className;
            this.subject = subject;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal ClassName ClassName { get => className; set => className = value; }
        internal Subject[] Subject { get => subject; set => subject = value; }

        public void Input()
        {
            Console.Write("ID of student: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name of student: ");
            name = Console.ReadLine();
            className = new ClassName();
            className.Input();
            Console.Write("Num of subject studying: ");
            numOfSubject = int.Parse(Console.ReadLine());
            subject = new Subject[numOfSubject];

            //nhập thông tin từng môn học của sv
            for (int i = 0; i < numOfSubject; i++)
            {
                Console.WriteLine("==> SUBJECT {0}:",i);
                subject[i] = new Subject();
                subject[i].Input();
            }
        }
        public void Output()
        {
            Console.WriteLine("\n ===> STUDENT INFO <===");
            Console.WriteLine("ID of student: " + id);
            Console.WriteLine("Name of student: " + name);
            className.Output();
            for (int i = 0; i < numOfSubject; i++)
            {
                subject[i].Output();
            }
            Console.WriteLine("AVG grade score: " + CalculAvgGrade(subject));
        }
        public double CalculAvgGrade(Subject[] subjects)
        {
            double sum = 0;
            for (int i = 0;i < subjects.Length;i++)
            {
                sum += subjects[i].Score;
            }
            return sum / subjects.Length;
        }
    }
}
