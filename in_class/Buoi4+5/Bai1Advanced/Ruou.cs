using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Advanced
{
    internal class Ruou : SanPham
    {
        private int nongDo;
        private string xuatXu;
        private float thue;

        //constructors
        public Ruou() : base()
        {
            nongDo = 45;
            xuatXu = "Viet Nam";
        }
        public Ruou(int nongDo, string xuatXu, int maSanPham, string tenSanPham, string donViTinh,
            float donGia)
            : base(maSanPham, tenSanPham, donViTinh, donGia)
        {
            this.nongDo = nongDo;
            this.xuatXu = xuatXu;
        }
        public Ruou(int nongDo, string xuatXu, int maSanPham, string tenSanPham, string donViTinh,
            float donGia, float thue)
            : base(maSanPham, tenSanPham, donViTinh, donGia, thue)
        {
            this.nongDo = nongDo;
            this.xuatXu = xuatXu;
        }


        //get set
        public int NongDo { get => nongDo; set => nongDo = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public float Thue { get => thue; set => thue = TinhThueNhapKhau(xuatXu); }

        //methods

        public override void NhapTTSP()
        {
            base.NhapTTSP();
            Console.Write("Nong do: ");
            nongDo = int.Parse(Console.ReadLine());
            Console.Write("Xuat xu: ");
            xuatXu = Console.ReadLine();
        }
        public override void XuatTTSP()
        {
            base.XuatTTSP();
            Console.WriteLine("Nong do: " + nongDo);
            Console.WriteLine("Xuat xu: " + xuatXu);
            Console.WriteLine("Thue: " + thue);
            Console.WriteLine("=====================");
        }
        public override float GiamGia()
        {
            if (nongDo > 45)
                return donGia * 0.8f;//giam gia 20%
            else if (nongDo > 30)
                return donGia * 0.85f;//giam gia 15%
            else
                return donGia;
        }
        public float TinhThueNhapKhau(string xuatXu)
        {
            xuatXu = xuatXu.ToLower();
            if (xuatXu.Equals("my"))
                thue =  0.07f;
            else if (xuatXu.Equals("tq"))
                thue =  0.1f;
            else if (xuatXu.Equals("thailan"))
                thue = 0.15f;
            else
                thue = 0;
            return thue;
        }
    }
}
