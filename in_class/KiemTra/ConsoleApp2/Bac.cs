using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChieuT5
{
    internal class Bac : VangBac
    {
        private string loaiBac;
        private string kieu;
        private int soLuong;

        public Bac() : base() { }

        public Bac(string loaiBac, string kieu, int soLuong, int maSP,
            string tenSP, string hangSX, double donGia)
            : base(maSP, tenSP, hangSX, donGia)
        {
            this.loaiBac = loaiBac;
            this.kieu = kieu;
            this.soLuong = soLuong;
        }

        public string LoaiBac { get => loaiBac; set => loaiBac = value; }
        public string Kieu { get => kieu; set => kieu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public override double TinhTongTien()
        {
            return donGia * soLuong * (1 - XetGiamGia());
        }

        public override double XetGiamGia()
        {
            if (kieu.CompareTo("day chuyen") == 0 && loaiBac.CompareTo("8k") == 0)
                return 0.04;
            if (kieu.CompareTo("lac") == 0 && loaiBac.CompareTo("10k") == 0)
                return 0.02;
            return 0;
        }

        public override void XuatTTSanPham()
        {
            Console.WriteLine("===> XUAT THONG TIN VANG <===");
            Console.WriteLine("Ma SP: " + maSP);
            Console.WriteLine("Ten SP: " + tenSP);
            Console.WriteLine("Hang SX: " + hangSX);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Loai bac: " + loaiBac);
            Console.WriteLine("Kieu: " + kieu);
            Console.WriteLine("So luong: " + soLuong);
            Console.WriteLine("=============================\n\n");
        }
        public override void NhapTTSanPham()
        {
            base.NhapTTSanPham();
            Console.Write("Loai bac: " );
            loaiBac = Console.ReadLine();
            Console.Write("Kieu: ");
            kieu = Console.ReadLine();
            Console.Write("So luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("===> NHAP THONG TIN THANH CONG! <===\n\n");
        }
    }
}
