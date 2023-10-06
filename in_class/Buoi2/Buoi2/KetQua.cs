using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class KetQua
    {
        private int maMH;
        private string tenMH;
        private float diemCC;
        private float diemGK;
        private float diemCK;

        public int MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public float DiemCC { get => diemCC; set => diemCC = value; }
        public float DiemGK { get => diemGK; set => diemGK = value; }
        public float DiemCK { get => diemCK; set => diemCK = value; }
        public KetQua(int maMH = 0, string tenMH = null, float diemCC = 0f, float diemGK = 0f, float diemCK = 0f)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.diemCC = diemCC;
            this.diemGK = diemGK;
            this.diemCK = diemCK;
        }
        public void NhapThongTin()
        {
            Console.WriteLine("===> NHAP THONG TIN KET QUA <===");
            Console.Write("Ma mon hoc: " );
            maMH = int.Parse(Console.ReadLine());
            Console.Write("Ten mon hoc: " );
            tenMH = Console.ReadLine();
            Console.Write("Diem CC: ");
            diemCC = float.Parse(Console.ReadLine());
            Console.Write("Diem GK: ");
            diemGK = float.Parse(Console.ReadLine());
            Console.Write("Diem CK: ");
            diemCK = float.Parse(Console.ReadLine());
            Console.WriteLine("================================\n");
        }
        public void XuatThongTin()
        {
            Console.WriteLine("===> XUAT THONG TIN KET QUA <===");
            Console.WriteLine("Ma mon hoc: "+ maMH);
            Console.WriteLine("Ten mon hoc: "+ tenMH);
            Console.WriteLine("Diem CC: " + diemCC);
            Console.WriteLine("Diem GK: " + diemGK);
            Console.WriteLine("Diem CK: " + diemCK);
            Console.WriteLine("================================\n");
        }
    }
}
