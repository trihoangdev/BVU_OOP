using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapCuoiKiChieuT6
{
    abstract class SanPham
    {
        protected int maSP;
        protected string tenSP;
        protected float donGia;

        protected SanPham(int maSP = 1, string tenSP = "thuc pham", float donGia = 1000)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donGia = donGia;
        }

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public virtual void Nhap()
        {
            Console.Write("Ma sp: ");
            maSP = int.Parse(Console.ReadLine());
            Console.Write("Ten sp: " );
            tenSP = Console.ReadLine();
            Console.Write("Don gia: ");
            donGia = float.Parse(Console.ReadLine());
        }
        public abstract void Xuat();
        public float TinhTien()
        {
            return donGia;
        }
    }
}
