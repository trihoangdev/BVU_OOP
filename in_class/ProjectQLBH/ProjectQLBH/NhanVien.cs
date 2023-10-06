using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class NhanVien
    {
        private static int maNhanVien = 0000;
        private string maNhanVienstr;
        private string ten;
        private int tuoi;
        private bool gioiTinh;
        public NhanVien()
        {
            maNhanVien++;
            maNhanVienstr = "NV" + maNhanVien;
        }

        public NhanVien(string ten, int tuoi, bool gioiTinh):this()
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
        }

        public int MaNhanVien { get => maNhanVien;}
        public string MaNhanVienstr { get => maNhanVienstr;}
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public void NhapTTNV()
        {
            Console.WriteLine(" ===> NHAP THONG TIN NHAN VIEN <===");
            Console.Write("Ten NV (toi da 20 ki tu): ");
            ten = Console.ReadLine();
            Console.Write("Tuoi (toi da 20 ki tu): ");
            tuoi = int.Parse(Console.ReadLine());
            /**
             * m: nam -> true
             * f: nữ -> false
             */
            Console.Write("Gioi tinh (m/f): ");
            char input = char.Parse(Console.ReadLine());
            if (input == 'm')
                gioiTinh = true;
            else if (input == 'f')
                gioiTinh = false;
            Console.WriteLine("NHAP THONG TIN THANH CONG!");
            Console.WriteLine("================================\n");
        }
        public void XuatTTNV()
        {
            string[,] tableData = new string[4, 2];
            tableData[0, 0] = "| Ma NV";
            tableData[0, 1] = maNhanVienstr;
            tableData[1, 0] = "| Ten NV";
            tableData[1, 1] = ten;
            tableData[2, 0] = "| Tuoi ";
            tableData[2, 1] = tuoi.ToString();
            tableData[3, 0] = "| Gioi tinh";
            char gioiTinhchar;
            if (gioiTinh == true)
                gioiTinhchar = 'm';
            else
                gioiTinhchar = 'f';
            tableData[3, 1] = gioiTinhchar.ToString();
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("| ======> XUAT THONG TIN NHAN VIEN <==== |");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tableData[i, j].PadRight(20) + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("+---------------------------------------+");
        }
    }
}
