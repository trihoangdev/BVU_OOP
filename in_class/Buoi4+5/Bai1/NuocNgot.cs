using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class NuocNgot : SanPham
    {
        private string mauSac;
        private string doNgot;

        public NuocNgot() : base()
        {
            mauSac = "Cam";
            doNgot = "Khong duong";
        }

        public NuocNgot(string mauSac, string doNgot,int maSanPham, string tenSanPham, string donViTinh, float donGia)
            : base(maSanPham, tenSanPham, donViTinh, donGia)
        {
            this.mauSac = mauSac;
            this.doNgot = doNgot;
        }

        public string MauSac { get => mauSac; set => mauSac = value; }
        public string DoNgot { get => doNgot; set => doNgot = value; }

        //methods
        public new void NhapTTSP()
        {
            base.NhapTTSP();
            Console.Write("Mau sac: " );
            mauSac = Console.ReadLine();
            Console.Write("Do ngot: ");
            doNgot = Console.ReadLine();
        }
        public new void XuatTTSP()
        {
            base.XuatTTSP();
            Console.WriteLine("Mau sac: " + mauSac);
            Console.WriteLine("Do ngot: "+ doNgot);
            Console.WriteLine("=====================");
        }

    }
}
