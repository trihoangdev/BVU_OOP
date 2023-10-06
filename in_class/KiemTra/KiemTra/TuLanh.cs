using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    internal class TuLanh : DienLanh
    {
        private int soLit;
        private int soCua;
        private int soLuong;
        public TuLanh(int maSP = 11, string tenSP = "Toshi_1268",
            string hangSX = "Toshiba", double donGia = 10000000)
            : base(maSP, tenSP, hangSX, donGia)
        { }
        public TuLanh(int soLit, int soCua, int soLuong, int maSP = 11, string tenSP = "Toshi_1268",
            string hangSX = "Toshiba", double donGia = 10000000)
            : base(maSP, tenSP, hangSX, donGia)
        {
            this.soLit = soLit;
            this.soCua = soCua;
            this.soLuong = soLuong;
        }
        public int SoLit { get => soLit; set => soLit = value; }
        public int SoCua { get => soCua; set => soCua = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public override double TinhTongTien()
        {
            XetGiamGia();
            double tong = soLuong * donGia;
            return tong;
        }

        public override void XetGiamGia()
        {
            if (soLit == 20 && soCua == 1)
            {
                Console.Write("Giam gia 4%. Gia con lai sau khi giam la: ");
                donGia = donGia * 0.96;
                Console.WriteLine(donGia);
            }
            else if (soLit == 40 && soCua == 2)
            {
                Console.Write("Giam gia 3%. Gia con lai sau khi giam la: ");
                donGia = donGia * 0.97;
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
            Console.WriteLine("Ten SP: " + tenSP);
            Console.WriteLine("Hang SX: " + hangSX);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("So lit: " + soLit);
            Console.WriteLine("So cua: " + soCua);
            Console.WriteLine("So luong: " + soLuong);
            Console.WriteLine("Tong tien: " + TinhTongTien());
            Console.WriteLine("=================================");
        }
        public override void NhapTTSanPham()
        {
            base.NhapTTSanPham();
            int soLitInput;
            do
            {
                Console.Write("So lit (1. 20L,2. 30L ,3. 40L):");
                soLitInput = int.Parse(Console.ReadLine());
                if (soLitInput < 1 || soLitInput > 3)
                    Console.WriteLine("Nhap lai!");
            } while (soLitInput < 1 || soLitInput > 3);
            if (soLitInput == 1)
                soLit = 20;
            else if (soLitInput == 2)
                soLit = 30;
            else
                soLit = 40;
            int soCuaInput;
            do
            {
                Console.Write("So cua (1. 1 cua, 2. 2 cua, 3. 3 cua): ");
                soCuaInput = int.Parse(Console.ReadLine());
                if (soCuaInput < 1 || soCuaInput > 3)
                    Console.WriteLine("Nhap lai!");
            } while (soCuaInput < 1 || soCuaInput > 3);
            soCua = soCuaInput;
            Console.Write("So luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("===> NHAP THONG TIN THANH CONG <===\n");
        }
    }
}
