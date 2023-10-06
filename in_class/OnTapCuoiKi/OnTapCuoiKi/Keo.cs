using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnTapCuoiKi
{
    internal class Keo : SanPham
    {
        private string hinhDang;
        private int soLuong;

        public string HinhDang { get => hinhDang; set => hinhDang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public Keo() : base() { }
        public Keo(int maSanPham, string tenSanPham, double donGia) : base(maSanPham, tenSanPham, donGia)
        {
        }

        public Keo(string hinhDang, int soLuong, int maSanPham, string tenSanPham, double donGia) : base(maSanPham, tenSanPham, donGia)
        {
            this.hinhDang = hinhDang;
            this.soLuong = soLuong;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Hinh dang: ");
            hinhDang = Console.ReadLine();
            Console.Write("So luong: ");
            soLuong = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma sp: " + maSanPham);
            Console.WriteLine("Ten sp: " + tenSanPham);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Hinh dang: " + hinhDang);
            Console.WriteLine("So luong: " + soLuong);
        }
        public new double TinhThanhTien()
        {
            return donGia * soLuong;
        }
    }
}
