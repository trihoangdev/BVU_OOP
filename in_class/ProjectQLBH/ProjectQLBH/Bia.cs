using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class Bia : SanPham
    {
        private string huongVi;

        //constructors

        public Bia() : base () { }
        public Bia(string tenSanPham, string donViTinh, double donGia, double phuThu,string huongVi)
            : base(tenSanPham, donViTinh, donGia, phuThu)
        {
            this.huongVi = huongVi;
        }

        //get,set
        public string HuongVi { get => huongVi; set => huongVi = value; }

        //methods
        public override void NhapTTSP()
        {
            base.NhapTTSP();
            Console.Write("Huong vi (Nhap toi da 20 ki tu): ");
            huongVi = Console.ReadLine();
            Console.WriteLine("==> NHAP THONG TIN HOAN TAT! <===\n");
        }
        public override void XuatTTSP()
        {
            base.XuatTTSP();
            string[,] tableData = new string[1, 2];
            tableData[0, 0] = "| Huong vi:";
            tableData[0, 1] = huongVi;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tableData[i, j].PadRight(20) + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("+----------------------------------------+\n");
        }
    }
}
