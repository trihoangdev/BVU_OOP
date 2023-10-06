using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Advanced
{
    internal class KhachHang
    {
        private int maKH;
        private string tenKH;
        private string diaChi;

        public KhachHang()
        {
        }

        public KhachHang(int maKH, string tenKH, string diaChi)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = diaChi;
        }

        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public void NhapTTKH()
        {
            Console.Write("Ma KH: ");
            maKH = int.Parse(Console.ReadLine());
            Console.Write("Ten KH: ");
            tenKH = Console.ReadLine();
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();
        }
        public void XuatTTKH()
        {
            Console.WriteLine("Ma KH: " + maKH);
            Console.WriteLine("Ten KH: " + tenKH);
            Console.WriteLine("Dia chi: " + diaChi);
        }
    }
}
