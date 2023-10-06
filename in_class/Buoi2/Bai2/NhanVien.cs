using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class NhanVien
    {
        private int maNV;
        private string tenNV;
        private int tuoi;
        private string gioiTinh;
        private string diaChi;

        //constructors
        public NhanVien(int maNV = 555555, string tenNV = "Nguyen Thi No", int tuoi = 18,
            string gioiTinh = "nu", string diaChi = "HCM")
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }

        //getter, setter
        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; }
        public int Tuoi { set => tuoi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }



        //methods
        public void NhapThongTinNhanVien()
        {
            Console.WriteLine("=== NHAP THONG TIN NHAN VIEN ===");
            Console.Write("Ma NV: ");
            maNV = int.Parse(Console.ReadLine());
            Console.Write("Ten NV: ");
            tenNV = Console.ReadLine();
            Console.Write("Tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            gioiTinh = Console.ReadLine();
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("===================================\n");
        }

        public void XuatThongTinNhanVien()
        {
            Console.WriteLine("=== XUAT THONG TIN NHAN VIEN ===");
            Console.WriteLine("Ma NV: " + maNV);
            Console.WriteLine("Ten NV: " + tenNV );
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Gioi tinh: " + gioiTinh);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("===================================\n");
        }
    }


}
