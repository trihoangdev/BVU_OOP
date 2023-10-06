using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    internal class MayGiat : DienLanh
    {
        private int soKg;
        private string cua;
        private int soLuong;

        public MayGiat(int maSP = 11, string tenSP = "Toshi_1268",
            string hangSX = "Toshiba", double donGia = 10000000) 
            : base(maSP, tenSP, hangSX, donGia)
        {
        }
        public MayGiat( int soKg, string cua, int soLuong,int maSP = 11, 
            string tenSP = "Toshi_1268", string hangSX = "Toshiba", double donGia = 10000000)
            : base(maSP, tenSP, hangSX, donGia)
        {
            this.soKg = soKg;
            this.cua = cua;
            this.soLuong = soLuong;
        }

        public int SoKg { get => soKg; set => soKg = value; }
        public string Cua { get => cua; set => cua = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public override double TinhTongTien()
        {
            XetGiamGia();
            double tong = soLuong * donGia;
            return tong;
        }

        public override void XetGiamGia()
        {
            if (soKg == 7 && cua.CompareTo("cua tren") == 0)
            {
                Console.Write("Giam gia 3%. Gia con lai sau khi giam la: ");
                donGia = donGia * 0.97;
                Console.WriteLine(donGia);
            }
            else if (soKg == 10 && cua.CompareTo("cua truoc") == 0)
            {
                Console.Write("Giam gia 2%. Gia con lai sau khi giam la: ");
                donGia = donGia * 0.98;
                Console.WriteLine(donGia);
            }
            else if (soKg == 8 && cua.CompareTo("cua truoc") == 0)
            {
                Console.Write("Giam gia 1%. Gia con lai sau khi giam la: ");
                donGia = donGia * 0.99;
                Console.WriteLine(donGia);
            }
            else
            {
                Console.WriteLine("Khong giam gia!");
            }
        }

        public override void XuatTTSanPham()
        {
            Console.WriteLine("===> XUAT THONG TIN SAN PHAM <===");
            Console.WriteLine("Ma SP: " + maSP);
            Console.WriteLine("Ten SP: "+ tenSP);
            Console.WriteLine("Hang SX: " + hangSX);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("So kg: " + soKg);
            Console.WriteLine("Cua: " + cua);
            Console.WriteLine("So luong: " + soLuong);
            Console.WriteLine("Tong tien: " + TinhTongTien());
            Console.WriteLine("==================================\n");
        }
        public override void NhapTTSanPham()
        {
            base.NhapTTSanPham();
            int soKgInput;
            do
            {
                Console.Write("So kg (7,8,9,10): ");
                soKgInput = int.Parse(Console.ReadLine());
                if (soKgInput < 7 || soKgInput > 10)
                    Console.WriteLine("Nhap lai!");
            } while (soKgInput < 7 || soKgInput > 10);
            soKg = soKgInput;
            int cuaChoice;
            do
            {
                Console.Write("Cua (1. cua tren, 2. cua truoc): ");
                cuaChoice = int.Parse(Console.ReadLine());
                if(cuaChoice<1 || cuaChoice>2)
                    Console.WriteLine("Nhap lai!");
            }while(cuaChoice<1 || cuaChoice>2);
            if (cuaChoice == 1)
                cua = "cua tren";
            else
                cua = "cua duoi";
            Console.Write("So luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("==> NHAP THONG TIN THANH CONG <===\n");
        }
    }
}
