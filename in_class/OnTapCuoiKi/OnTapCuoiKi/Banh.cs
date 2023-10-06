using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapCuoiKi
{
    internal class Banh : SanPham
    {
        private int loaiBanh;
        private int soLuong;
        public Banh() : base() { }
        public Banh(int maSanPham, string tenSanPham, double donGia) : base(maSanPham, tenSanPham, donGia)
        {
        }
        public Banh(int loaiBanh, int soLuong, int maSanPham, string tenSanPham, double donGia) 
            : base(maSanPham, tenSanPham, donGia)
        {
            this.loaiBanh = loaiBanh;
            this.soLuong = soLuong;
        }

        public int LoaiBanh { get => loaiBanh; set => loaiBanh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine();
        }
        public override void Xuat()
        {
            throw new NotImplementedException();
        }
    }
}
