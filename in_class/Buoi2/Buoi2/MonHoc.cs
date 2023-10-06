using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class MonHoc
    {
        private int maMH;
        private string tenMH;
        private int soTC;

        public int MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoTC { get => soTC; set => soTC = value; }

        public MonHoc(int maMH = 12, string tenMH = "LTHDT", int soTC = 3)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTC = soTC;
        }
        public void NhapThongTin()
        {
            Console.WriteLine("===> NHAP THONG TIN MON HOC <===");
            Console.Write("Ma mon hoc: ");
            maMH = int.Parse(Console.ReadLine());
            Console.Write("Ten mon hoc: ");
            tenMH = Console.ReadLine();
            Console.Write("So tin chi: ");
            soTC = int.Parse(Console.ReadLine());
            Console.WriteLine("===============================\n");
        }
        public void XuatThongTin()
        {
            Console.WriteLine("===> XUAT THONG TIN MON HOC <===");
            Console.WriteLine("Ma mon hoc: " + maMH);
            Console.WriteLine("Ten mon hoc: " + tenMH);
            Console.WriteLine("So tin chi: " + soTC);
            Console.WriteLine("================================\n");
        }
    }
}
