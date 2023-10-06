using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien[] nhanViens = new NhanVien[2];
            nhanViens[0] = new NhanVien();
            nhanViens[0].NhapTTNV();
            nhanViens[0].XuatTTNV();
            nhanViens[1] = new NhanVien();
            nhanViens[1].NhapTTNV();
            nhanViens[1].XuatTTNV();

            
            Console.ReadKey();
        }
    }
}
