using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class SinhVien
    {
        private int maSV;
        private string tenSV;
        private int tuoi;
        private string diaChi;

        public int MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public SinhVien()
        {
            maSV = 111;
            tenSV = "loc";
            tuoi = 20;
        }

        public SinhVien(int maSV, string tenSV, int tuoi, string diaChi)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.tuoi = tuoi;
            this.diaChi = diaChi;
        }
        public void NhapThongTin()
        {
            Console.WriteLine("====== NHAP THONG TIN SINH VIEN <===");
            Console.Write("Nhap ma sinh vien: ");
            maSV = int.Parse(Console.ReadLine());
            Console.Write("Ten sinh vien: ");
            tenSV = Console.ReadLine();
            Console.Write("Tuoi: ");
            maSV = int.Parse(Console.ReadLine());
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("====================================\n");
        }
        public void XuatThongTin()
        {
            Console.WriteLine("===> XUAT THONG TIN SINH VIEN <===");
            Console.WriteLine("Ma sinh vien: " + maSV);
            Console.WriteLine("Ten: " + tenSV);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Dia chi: "+ diaChi);
            Console.WriteLine("==================================\n");
        }
    }
}
