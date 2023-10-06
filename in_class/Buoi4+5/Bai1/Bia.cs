using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Bia : SanPham
    {
        private string huongVi;
        //constructors

        public Bia() : base()
        {
            huongVi = "Lua mach";
        }

        public Bia(string huongVi,int maSanPham, string tenSanPham, string donViTinh, float donGia) 
            : base(maSanPham, tenSanPham, donViTinh, donGia)
        {
            this.huongVi = huongVi;
        }
        //get set
        public string HuongVi { get => huongVi; set => huongVi = value; }
        
        //methods
        public new void NhapTTSP()
        {
            base.NhapTTSP();
            Console.Write("Huong vi: ");
            huongVi = Console.ReadLine();
        }
        public new void XuatTTSP()
        {
            base.XuatTTSP();
            Console.WriteLine("Huong vi: " + huongVi);
            Console.WriteLine("=====================");
        }
    }
}
