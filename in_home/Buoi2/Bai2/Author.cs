using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Author
    {
        private string name;
        private string email;
        private char gender;
        //getter,setter
        public string Name { get => name; }
        public string Email { get => email; set => email = value; }
        public char Gender { get => gender; }

        //constructors
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public Author()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public void Input()
        {
            Console.Write("Name of author: ");
            name = Console.ReadLine();
            Console.Write("Email of author: ");
            email = Console.ReadLine();
            Console.Write("Gender of author(M/F): ");
            gender = char.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Name of author: " + name);
            Console.WriteLine("Email of author: " + email);
            Console.WriteLine("Gender of author: " + gender);
        }
    }
}
