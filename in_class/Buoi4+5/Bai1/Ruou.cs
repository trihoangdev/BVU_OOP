using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Ruou : SanPham
    {
        private int nongDo;
        private string xuatXu;

        //constructors
        public Ruou() : base()
        {
            nongDo = 45;
            xuatXu = "Viet Nam";
        }

        public Ruou(int nongDo, string xuatXu, int maSanPham, string tenSanPham, string donViTinh, float donGia)
                    : base(maSanPham, tenSanPham, donViTinh, donGia)
        {
            this.nongDo = nongDo;
            this.xuatXu = xuatXu;
        }

        //get set
        public int NongDo { get => nongDo; set => nongDo = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }

        //methods
        public new void NhapTTSP()
        {
            base.NhapTTSP();
            Console.Write("Nong do: ");
            nongDo = int.Parse(Console.ReadLine());
            Console.Write("Xuat xu: ");
            xuatXu = Console.ReadLine();
        }
        public new void XuatTTSP()
        {
            base.XuatTTSP();
            Console.WriteLine("Nong do: " + nongDo);
            Console.WriteLine("Xuat xu: " + xuatXu);
            Console.WriteLine("=====================");
        }
    }
}
