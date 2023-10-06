using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class SanPham
    {
        private int maSP;
        private string tenSP;
        private string dvt;
        private float donGia;

        public SanPham(int maSP = 231, string tenSP = "Bia", string dvt = "Thung", float donGia = 25000)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.dvt = dvt;
            this.donGia = donGia;
        }

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public float DonGia { get => donGia; set => donGia = value; }

        //methods
        public void NhapThongTinSP()
        {
            Console.WriteLine("=== NHAP THONG TIN SAN PHAM ===");
            Console.Write("Ma SP: ");
            maSP = int.Parse(Console.ReadLine());
            Console.Write("Ten SP: ");
            tenSP = Console.ReadLine();
            Console.Write("Don vi tinh: ");
            dvt = Console.ReadLine();
            Console.Write("Don gia: ");
            donGia = float.Parse(Console.ReadLine());
            Console.WriteLine("===============================\n");
        }
        public void XuatThongTinSP()
        {
            Console.WriteLine("=== NHAP THONG TIN SAN PHAM ===");
            Console.WriteLine("Ma SP: " + maSP);
            Console.WriteLine("Ten SP: " + tenSP);
            Console.WriteLine("Don vi tinh: " + dvt);
            Console.WriteLine("Don gia: " +  donGia);
            Console.WriteLine("===============================\n");

        }
    }
}
