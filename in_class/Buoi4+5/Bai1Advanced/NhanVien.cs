using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Advanced
{
    internal class NhanVien
    {
        private int maNV;
        private string tenNV;
        private string diaChi;
        private int tuoi;
        private int doanhThu;
        //get set
        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public int DoanhThu { get => doanhThu; set => doanhThu = value; }

        public NhanVien()
        {
        }

        public NhanVien(int maNV, string tenNV, string diaChi, int tuoi)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.diaChi = diaChi;
            this.tuoi = tuoi;
        }
        public NhanVien NhapTTNV()
        {
            Console.Write("Ma NV: ");
            maNV = int.Parse(Console.ReadLine());
            Console.Write("Ten NV: ");
            tenNV = Console.ReadLine();
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            return new NhanVien { maNV = maNV, tenNV = tenNV, diaChi = diaChi, tuoi = tuoi };
        }
        public void XuatTTNV()
        {
            Console.WriteLine("Ma NV: " + maNV);
            Console.WriteLine("Ten NV: " + tenNV);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("Tuoi: " + tuoi);
        }
        
    }
}
