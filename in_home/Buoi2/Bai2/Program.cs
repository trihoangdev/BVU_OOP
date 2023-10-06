using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[2];
            Console.WriteLine("===> INPUT BOOKS <===");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("==> Book {0}: ",i);
                books[i] = new Book();
                books[i].Input();
            }

            Console.WriteLine("===> OUTPUT BOOKS <===");
            for(int i = 0;i < books.Length; i++)
            {
                Console.WriteLine("==> Book {0}: ", i);
                books[i].Output();
            }

            Console.ReadKey();
        }
    }
}
