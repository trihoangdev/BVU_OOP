using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Meo tom = new Meo();
            Console.WriteLine("Chieu cao tom: " + tom.ChieuCao);
            tom.info();*/

            ThuCung meo = new Meo();
            Meo cat = (Meo)meo;
            
            Console.ReadKey();
        }
    }
}
