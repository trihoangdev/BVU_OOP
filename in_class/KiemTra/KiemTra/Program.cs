using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLBH qlbh = new QLBH();
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("===> MENU <===");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap TTSP");
                Console.WriteLine("2. Xuat TTSP");
                Console.WriteLine("3. Sap xep gia tang dan");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Thoat!");
                            Console.ReadKey();
                            break;
                        }
                    case 1:
                        {
                            qlbh.NhapTTSP();
                            break;
                        }
                    case 2:
                        {
                            qlbh.XuatTTSP();
                            break;
                        }
                    case 3:
                        {
                            qlbh.SapXepGiaTangDan();
                            break;
                        }
                }
            } while (choice != 0);
            Console.ReadKey();
        }
    }
}
