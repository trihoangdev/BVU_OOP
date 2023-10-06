using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class KhachHang
    {
        private static int maKH;
        private string maKHstr;
        private string ten;
        private int tuoi;
        private bool gioiTinh;
        private string diaChi;

        public KhachHang()
        {
            maKH++;
            maKHstr = "NV" + maKH;
        }

        public KhachHang(string ten, int tuoi, bool gioiTinh, string diaChi) : this()
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }

        public int MaKhachHang { get => maKH; }
        public string MaKhachHangStr { get => maKHstr; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public void NhapTTKH()
        {
            Console.WriteLine(" ===> NHAP THONG TIN KHACH HANG <===");
            Console.Write("Ten KH (toi da 20 ki tu): ");
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
            Console.Write("Dia chi (toi da 20 ki tu): ");
            Console.WriteLine("NHAP THONG TIN THANH CONG!");
            Console.WriteLine("================================\n");
        }
        public void XuatTTNV()
        {
            string[,] tableData = new string[5, 2];
            tableData[0, 0] = "| Ma NV";
            tableData[0, 1] = maKHstr;
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
            tableData[4, 0] = "Dia chi";
            tableData[4, 1] = diaChi;
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("| ======> XUAT THONG TIN KHACH HANG <==== |");
            for (int i = 0; i < 5; i++)
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
