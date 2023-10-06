using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnTapCuoiKiChieuT6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int dem = 0;
            Console.Write("Nhap so luong: ");
            n = int.Parse(Console.ReadLine());
            SanPham[] ds = new SanPham[n];
            NhapSP(ref ds,ref n,ref dem);
            Console.WriteLine("======================================");
            XuatBanh(ref ds, ref dem);
            Console.WriteLine("======================================");
            Console.WriteLine("Tong tien keo: " + TinhTongTienKeo(ref ds, ref dem));
            Console.WriteLine("======================================");
            XuatBanh1(ref ds, ref dem);
            Console.WriteLine("======================================");
            SapXepDonGia(ref ds, ref dem);
            Console.WriteLine("======================================");
            Console.ReadKey();
        }

        private static void XuatBanh(ref SanPham[] ds, ref int dem)
        {
            for (int i = 0; i < dem; i++)
                if (ds[i] is Banh)
                {
                    Banh banh = (Banh)ds[i];
                    banh.Xuat();
                }
        }

        private static void SapXepDonGia(ref SanPham[] ds, ref int dem)
        {
            for (int i = 0; i < dem - 1; i++)
                for (int j = i + 1; j < dem; j++)
                    if (ds[i].DonGia > ds[j].DonGia)
                    {
                        SanPham sp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = sp;
                    }
            Console.WriteLine("Sap xep thanh cong!");
        }

        private static void XuatBanh1(ref SanPham[] ds, ref int dem)
        {
            for (int i = 0; i < dem; i++)
            {
                if (ds[i] is Banh)
                {
                    Banh banh = (Banh)ds[i];
                    if (banh.LoaiBanh == 1)
                        banh.Xuat();
                }
            }
        }

        private static float TinhTongTienKeo(ref SanPham[] ds, ref int dem)
        {
            float tong = 0;
            for (int i = 0; i < dem; i++)
                if (ds[i] is Keo)
                {
                    Keo keo = (Keo)ds[i];
                    tong += keo.TinhTien();
                }
            return tong;
        }



        private static void NhapSP(ref SanPham[] ds,ref  int n,ref int dem)
        {
            int choice1, choice2;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Nhap tt Banh");
                Console.WriteLine("2. Nhap tt Keo");
                Console.Write("Moi chon: ");
                choice1 = int.Parse(Console.ReadLine());

                switch (choice1)
                {
                    case 1:
                        {
                            ds[dem] = new Banh();
                            ds[dem].Nhap();
                            dem++;
                            break;
                        }
                    case 2:
                        {
                            ds[dem] = new Keo();
                            ds[dem].Nhap();
                            dem++;
                            break;
                        }
                }
                if (dem >= n)
                {
                    Console.WriteLine("Danh sach da day!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Ban muon thoat nhap khong?");
                    Console.WriteLine("1.Yes\n2.No");
                    Console.Write("Chon: ");
                    choice2 = int.Parse(Console.ReadLine());
                    if (choice2 == 1)
                        break;
                }
            } while (dem < n && choice2 != 1);

        }
    }
}
