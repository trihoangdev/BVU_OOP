using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class Ruou : SanPham
    {
        private int nongDo;
        private string xuatXu;
        private double thue;

        public Ruou(): base()
        {
        }

        public Ruou(string tenSanPham, string donViTinh, double donGia, double phuThu, string xuatXu, double thue) 
            : base(tenSanPham, donViTinh, donGia, phuThu)
        {
            this.xuatXu = xuatXu;
            this.thue = thue;
        }


        //get,set
        public int NongDo { get => nongDo; set => nongDo = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public double Thue { get => thue; set => thue = TinhThueNhapKhau(); }

        //methods
        public override void NhapTTSP()
        {
            base.NhapTTSP();
            Console.Write("Nong do (Nhap toi da 20 ki tu): ");
            nongDo = int.Parse(Console.ReadLine());
            Console.Write("Xuat xu (Nhap toi da 20 ki tu): ");
            xuatXu = Console.ReadLine();
            Console.WriteLine("==> NHAP THONG TIN HOAN TAT! <===\n");
        }
        public override void XuatTTSP()
        {
            donGia = donGia * (1 - thue);
            base.XuatTTSP();
            string[,] tableData = new string[3, 2];
            tableData[0, 0] = "| Nong do:";
            tableData[0, 1] = nongDo.ToString();
            tableData[1, 0] = "| Xuat xu:";
            tableData[1, 1] = xuatXu;
            tableData[2, 0] = "| Thue nhap khau:";
            tableData[2, 1] = thue.ToString();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tableData[i, j].PadRight(20) + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("+----------------------------------------+\n");
        }
        public override void GiamGia()
        {
            base.GiamGia();
            if (nongDo > 45)
                donGia *= 0.2;
            else if (nongDo > 30)
                donGia *= 0.15;
        }
        public double TinhThueNhapKhau()
        {
            if (xuatXu.CompareTo("my") == 0)
                return 0.07;
            else if (xuatXu.CompareTo("TQ") == 0)
                return 0.1;
            else if (xuatXu.CompareTo("ThaiLan") == 0)
                return 0.15;
            return 0;
        }
    }
}
