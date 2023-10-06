using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class SanPham
    {
        public int maSP;
        public string tenSP;
        public string dvt;
        public int soLuong;
        public double donGia;

        public void NhapThongTinSanPham()
        {
            Console.Write("Ma san pham: ");
            maSP = int.Parse(Console.ReadLine());
            Console.Write("Ten san pham: ");
            tenSP = Console.ReadLine();
            Console.Write("Don vi tinh: ");
            dvt = Console.ReadLine();
           /* Console.Write("So luong: ");
            soLuong = int.Parse(Console.ReadLine());*/
            Console.Write("Don gia: ");
            donGia = double.Parse(Console.ReadLine());
            Console.WriteLine("==========================");
        }
        public void XuatThongTinSanPham()
        {
            Console.WriteLine("Ma san pham: " + maSP);
            Console.WriteLine("Ten san pham: " + tenSP);
            Console.WriteLine("Don vi tinh: " + dvt);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("====================");
        }
        /*public void CapNhatGiamGia()
        {
            if (soLuong > 50)
            {
                donGia = donGia * 0.9f;
            }
            else if (soLuong > 30)
            {
                donGia = donGia * 0.95f;
            }
        }*/
    }
}
