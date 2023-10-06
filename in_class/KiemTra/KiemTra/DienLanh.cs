using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    abstract class DienLanh
    {
        protected int maSP;
        protected string tenSP;
        protected string hangSX;
        protected double donGia;

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string HangSX { get => hangSX; set => hangSX = value; }
        public double DonGia { get => donGia; set => donGia = value; }

        //get,set


        //constructors

        public DienLanh(int maSP = 11, string tenSP = "Toshi_1268", string hangSX = "Toshiba", double donGia = 10000000)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.hangSX = hangSX;
            this.donGia = donGia;
        }
        public abstract void XuatTTSanPham();
        public abstract double TinhTongTien();
        public abstract void XetGiamGia();
        public virtual void NhapTTSanPham()
        {
            Console.WriteLine("===> NHAP THONG TIN SAN PHAM <===");
            Console.Write("Ma san pham: ");
            maSP = int.Parse(Console.ReadLine());
            Console.Write("Ten san pham: ");
            tenSP = Console.ReadLine();
            Console.Write("Hang san xuat: ");
            hangSX = Console.ReadLine();
            Console.Write("Don gia: ");
            donGia = double.Parse(Console.ReadLine());
        }
    }
}
