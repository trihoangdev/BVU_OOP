using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapCuoiKiChieuT6
{
    internal class Banh : SanPham
    {
        private int loaiBanh;
        private int soLuong;
        public Banh() : base() { }
        public Banh(int maSP, string tenSP, float donGia) : base(maSP, tenSP, donGia) { }
        public Banh(int loaiBanh, int soLuong, int maSP, string tenSP, float donGia): base(maSP, tenSP, donGia)
        {
            this.loaiBanh = loaiBanh;
            this.soLuong = soLuong;
        }

        public int LoaiBanh { get => loaiBanh; set => loaiBanh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Loai banh: ");
            loaiBanh = int.Parse(Console.ReadLine());
            Console.Write("So luong: ");
            soLuong = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Ma SP: " + maSP);
            Console.WriteLine("Ten SP: " + tenSP);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Loai banh: "+ loaiBanh);
            Console.WriteLine("So luong: " + soLuong);
        }
        // cái này tào lao???
        public new float TinhTien()
        {
            return soLuong * donGia + base.TinhTien();
        }
    }
}
