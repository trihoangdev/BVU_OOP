using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChieuT5
{
    abstract class VangBac
    {
        protected int maSP;
        protected string tenSP;
        protected string hangSX;
        protected double donGia;

        public VangBac() {
            maSP = 0;
            tenSP = "";
            hangSX = "";
            donGia = 0;
        }
        protected VangBac(int maSP, string tenSP, string hangSX, double donGia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.hangSX = hangSX;
            this.donGia = donGia;
        }
        
        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string HangSX { get => hangSX; set => hangSX = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public abstract void XuatTTSanPham();
        public abstract double TinhTongTien();
        public abstract double XetGiamGia();
        public virtual void NhapTTSanPham()
        {
            Console.WriteLine("===> NHAP THONG TIN SAN PHAM <===");
            Console.Write("Ma san pham: ");
            maSP = int.Parse(Console.ReadLine());
            Console.Write("Ten san pham: ");
            tenSP = Console.ReadLine();
            Console.Write("Hang SX: ");
            hangSX = Console.ReadLine();
            Console.Write("Don gia: ");
            donGia = double.Parse(Console.ReadLine());
        }


    }
}
