using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Advanced
{
    internal class SanPham
    {
        protected int maSanPham;
        protected string tenSanPham;
        protected string donViTinh;
        protected float donGia;
        protected float phuThu;

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float PhuThu { get => phuThu; set => phuThu = TinhPhuThu(donViTinh); }

        public SanPham()
        {
            maSanPham = 1;
            donViTinh = "lon";
        }

        public SanPham(int maSanPham, string tenSanPham, string donViTinh, float donGia,float phuThu)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.phuThu = phuThu;
        }

        public SanPham(int maSanPham, string tenSanPham, string donViTinh, float donGia)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
        }

        public virtual void NhapTTSP()
        {
            Console.WriteLine("===> NHAP THONG TIN SAN PHAM <===");
            Console.Write("Ma san pham: ");
            maSanPham = int.Parse(Console.ReadLine());
            Console.Write("Ten san pham: ");
            tenSanPham = Console.ReadLine();
            Console.Write("Don vi tinh: ");
            donViTinh = Console.ReadLine();
            Console.Write("Don gia: ");
            donGia = float.Parse(Console.ReadLine());
        }
        public virtual void XuatTTSP()
        {
            Console.WriteLine("Ma san pham: " + maSanPham);
            Console.WriteLine("Ten san pham: " + tenSanPham);
            Console.WriteLine("Don vi tinh: " + donViTinh);
            Console.WriteLine("Don gia: " + donGia);
        }
        public virtual float GiamGia()
        {
            return donGia * 0.9f;
        }
        public virtual float TinhPhuThu(string donViTinh)
        {
            donViTinh = donViTinh.ToLower();
            if (donViTinh.Equals("lon") && donGia > 20000)
                return donGia * 1.2f;
            if (donViTinh.Equals("chai") && donGia > 50000)
                return donGia * 1.15f;
            return donGia * 1.1f;
        }
    }
}
