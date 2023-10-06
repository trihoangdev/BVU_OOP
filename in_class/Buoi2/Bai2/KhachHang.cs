using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class KhachHang
    {
        private int maKH;
        private string tenKH;
        private string diaChi;

        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public KhachHang()
        {
            tenKH = "Nguyen Van An";
            maKH = 165;
            diaChi = "Vung Tau";
        }

        public KhachHang(int maKH, string tenKH, string diaChi)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = diaChi;
        }
        public void NhapThongTinKhachHang()
        {
            Console.WriteLine("=== NHAP THONG TIN KHACH HANG ===");
            Console.Write("Ma KH: ");
            maKH = int.Parse(Console.ReadLine());
            Console.Write("Ten KH: ");
            tenKH = Console.ReadLine();
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("======================\n");
        }
        public void XuatThongTinKhachHang()
        {
            Console.WriteLine("=== XUAT THONG TIN KHACH HANG ===");
            Console.WriteLine("Ma KH: " + MaKH);
            Console.WriteLine("Ten KH: " + TenKH);
            Console.WriteLine("Dia chi: "+ DiaChi);
            Console.WriteLine("======================\n");
        }
    }
}
