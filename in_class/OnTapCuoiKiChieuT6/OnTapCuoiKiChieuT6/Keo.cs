using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapCuoiKiChieuT6
{
    internal class Keo : SanPham
    {
        private string hinhDang;
        public Keo() : base() { }
        public Keo(int maSP, string tenSP, float donGia) : base(maSP, tenSP, donGia) { }
        public Keo(string hinhDang, int maSP, string tenSP, float donGia) : base(maSP, tenSP, donGia)
        {
            this.hinhDang = hinhDang;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Hinh dang: ");
            hinhDang = Console.ReadLine();
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma SP: " + maSP);
            Console.WriteLine("Ten SP: " + tenSP);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Hinh dang: " + hinhDang);
        }

    }
}
