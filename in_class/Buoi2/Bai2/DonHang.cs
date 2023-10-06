using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class DonHang
    {
        private SanPham sp;
        private NhanVien nv;
        private KhachHang kh;
        private int soLuong;

        public int SoLuong { get => soLuong; set => soLuong = value; }
        internal SanPham Sp { get => sp; set => sp = value; }

        public DonHang() { }
        
        public void NhapThongTin()
        {
            Console.WriteLine("=== NHAP THONG TIN DON HANG ===");
            Console.Write("Ma SP: ");
            Sp.MaSP = int.Parse(Console.ReadLine());
            Console.Write("Ma NV: ");
            nv.MaNV = int.Parse(Console.ReadLine());
            Console.Write("Ma KH: ");
            kh.MaKH = int.Parse(Console.ReadLine());
            Console.WriteLine("So luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("================================\n");
        }
        public void XuatThongTin()
        {
            Console.WriteLine("=== XUAT THONG TIN DON HANG ===");
            Console.WriteLine("Ma SP: " + Sp.MaSP);
            Console.WriteLine("Ma NV: " + nv.MaNV);
            Console.WriteLine("Ma KH: " + kh.MaKH);
            Console.WriteLine("So luong: " + soLuong);
            Console.WriteLine("================================\n");

        }
    }
}
