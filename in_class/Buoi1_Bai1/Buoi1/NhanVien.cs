using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class NhanVien
    {
        /**
         * mã nv,ten,lương,tuổi,sđt
         * Nhập thông tin nv
         * Xuất tt nhân viên
         * Xét tăng lương:
         *  - Nếu nhân viên có tuổi > 50 => tăng 10%
         *  - Nếu trên 40 => tăng 8%
         *  - Trên 30t => tăng 5%
         *  - Ngược lại => ko tăng
         */
        public int maNhanVien;
        public float luong;
        public int tuoi;
        public string sdt;
        public string ten;

        public void NhapThongTinNhanVien()
        {
            Console.Write("Ma nhan vien: " );
            maNhanVien = int.Parse(Console.ReadLine());
            Console.Write("Ten nhan vien: ");
            ten = Console.ReadLine();
            Console.Write("Tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("SDT: ");
            sdt = Console.ReadLine();
            Console.Write("Luong: ");
            luong = float.Parse(Console.ReadLine());
            Console.WriteLine("===================");
        }
        public void XuatThongTinNhanVien()
        {
            Console.WriteLine("Ma nhan vien: " + maNhanVien);
            Console.WriteLine("Ho va ten: " + ten);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("SDT: " + sdt);
            Console.WriteLine("Luong: " + luong);
            Console.WriteLine("=====================");
        }
        public void XetTangLuong()
        {
            if (tuoi > 50)
                luong += luong * 0.1f;
            else if (tuoi > 30)
                luong += luong * 0.08f;
            else
                luong += luong * 0.05f;
        }
    }
}
