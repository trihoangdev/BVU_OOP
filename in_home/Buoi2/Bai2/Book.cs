using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Book
    {
        private string name;
        private Author author;
        private double price;
        private int booksInStack = 0;

        public Book()
        {
        }

        public Book(string name, Author author, double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }

        public Book(string name, Author author, double price, int booksInStack) : this(name, author, price)
        {
            this.booksInStack = booksInStack;
        }

        public string Name { get => name; }
        public double Price { get => price; set => price = value; }
        public int BooksInStack { get => booksInStack; set => booksInStack = value; }
        internal Author Author { get => author; }

        public void Input()
        {
            Console.Write("Name of book: ");
            name = Console.ReadLine();
            Console.WriteLine("-- Author Infor --");
            author = new Author();
            author.Input();
            Console.WriteLine("------------------");
            Console.Write("Price of book: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Num of books in stack: ");
            booksInStack = int.Parse(Console.ReadLine());
            Console.WriteLine("================================\n");
        }
        public void Output()
        {
            Console.WriteLine("Name of book: " + name);
            Console.WriteLine("-- Author Infor --");
            author.Output();
            Console.WriteLine("------------------");
            Console.WriteLine("Price of book: " + price);
            Console.WriteLine("Num of books in stack: " + booksInStack);
            Console.WriteLine("============================\n");
        }
    }
}
