using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class NuocNgot : SanPham
    {
        private string mauSac;
        private string doNgot;

        //constructors
        public NuocNgot() : base()
        {
        }

        public NuocNgot(string tenSanPham, string donViTinh, double donGia, double phuThu,
            string mauSac, string doNgot) 
            : base(tenSanPham, donViTinh, donGia, phuThu)
        {
            this.mauSac = mauSac;
            this.doNgot = doNgot;
        }

        //get set
        public string MauSac { get => mauSac; set => mauSac = value; }
        public string DoNgot { get => doNgot; set => doNgot = value; }

        //methods
        public override void NhapTTSP()
        {
            base.NhapTTSP();
            Console.Write("Mau sac (Nhap toi da 20 ki tu): ");
            mauSac = Console.ReadLine();
            Console.Write("Do ngot (Nhap toi da 20 ki tu): ");
            doNgot = Console.ReadLine();
            Console.WriteLine("==> NHAP THONG TIN HOAN TAT! <===\n");
        }
        public override void XuatTTSP()
        {
            base.XuatTTSP();
            string[,] tableData = new string[2, 2];
            tableData[0, 0] = "| Mau sac:";
            tableData[0, 1] = mauSac;
            tableData[1, 0] = "| Do ngot:";
            tableData[1, 1] = doNgot;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tableData[i, j].PadRight(20) + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("+----------------------------------------+\n");
        }
        /**
         * Phương thức giảm giá tiền
         * nếu màu đỏ giảm giá 5% trên đơn giá,
         * ngược lại màu xanh giảm giá 3% trên đơn giá 
         * ngược lại không giảm giá.
         */
        public override void GiamGia()
        {
            base.GiamGia();
            if (mauSac == "do")
                donGia *= 0.95;
            else if (mauSac == "xanh")
                donGia *= 0.97;
        }
    }
}
