using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapCuoiKi
{
    abstract class SanPham
    {
        protected int maSanPham;
        protected string tenSanPham;
        protected double donGia;
        public SanPham() { }
        public SanPham(int maSanPham, string tenSanPham, double donGia)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.donGia = donGia;
        }

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double DonGia { get => donGia; set => donGia = value; }

        public virtual void Nhap()
        {
            Console.Write("Nha ma SP: ");
            maSanPham = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten san pham: ");
            tenSanPham = Console.ReadLine();
            Console.Write("Nhap don gia: ");
            donGia = double.Parse(Console.ReadLine());
        }
        public abstract void Xuat();
        public double TinhThanhTien()
        {
            return donGia;
        }
    }
}
