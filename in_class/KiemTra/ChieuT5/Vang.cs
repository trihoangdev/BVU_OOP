using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChieuT5
{
    internal class Vang : VangBac
    {
        private int tuoiVang;
        private string loaiVang;
        private int soLuong;

        public Vang() : base()
        { }
        public Vang(int tuoiVang, string loaiVang, int soLuong, int maSP,
            string tenSP, string hangSX, double donGia)
            : base(maSP, tenSP, hangSX, donGia)
        {
            this.tuoiVang = tuoiVang;
            this.loaiVang = loaiVang;
            this.soLuong = soLuong;
        }

        public int TuoiVang { get => tuoiVang; set => tuoiVang = value; }
        public string LoaiVang { get => loaiVang; set => loaiVang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public override double TinhTongTien()
        {
            return donGia * soLuong * (1-XetGiamGia());
        }
        public override double XetGiamGia()
        {
            if (tuoiVang == 96 && loaiVang.CompareTo("nhan") == 0)
                return 0.03;
            if (tuoiVang == 97 && loaiVang.CompareTo("nhan") == 0)
                return 0.02;
            if (tuoiVang == 98 && loaiVang.CompareTo("nhan") == 0)
                return 0.01;
            return 0;

        }

        public override void XuatTTSanPham()
        {
            Console.WriteLine("===> XUAT THONG TIN VANG <===");
            Console.WriteLine("Ma SP: " + maSP);
            Console.WriteLine("Ten SP: " + tenSP);
            Console.WriteLine("Hang SX: " + hangSX);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Tuoi vang: " + tuoiVang);
            Console.WriteLine("Loai vang: " + loaiVang);
            Console.WriteLine("So luong: " + soLuong);
            Console.WriteLine("Tong tien: " + TinhTongTien());
            Console.WriteLine("=============================\n\n");
        }
        public override void NhapTTSanPham()
        {
            base.NhapTTSanPham();
            Console.Write("Tuoi vang: ");
            tuoiVang = int.Parse(Console.ReadLine());
            Console.Write("Loai vang: ");
            loaiVang = Console.ReadLine();
            Console.Write("So luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("===> NHAP THONG TIN THANH CONG! <===\n\n");
        }
    }
}
