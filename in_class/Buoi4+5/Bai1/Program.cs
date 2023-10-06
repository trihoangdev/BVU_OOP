using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("So luong san pham: ");
            n = int.Parse(Console.ReadLine());
            SanPham[] sanPhams = new SanPham[n];
            int choice;
            int i = 0;
            do
            {
                Console.WriteLine("===== Menu =====");
                Console.WriteLine("1. Nhap TT san pham");
                Console.WriteLine("2. Xuat TT Tat ca SP");
                Console.WriteLine("3. Xuat TT SP theo ten");
                Console.WriteLine("4. Xuat SP co gia tren 'x'");
                Console.WriteLine("5. Sap xep theo don gia tang dan");
                Console.WriteLine("6. Xuat ds san pham co gia tu a->b");
                Console.WriteLine("0. Thoat");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Thoat!");
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            int luaChon;
                            do
                            {
                                Console.WriteLine("Vui long chon 1 trong cac san pham sau: ");
                                Console.WriteLine("1. Nhap TT Ruou");
                                Console.WriteLine("2. Nhap TT Bia");
                                Console.WriteLine("3. Nhap TT Nuoc ngot");
                                Console.Write("Moi chon: ");
                                luaChon = int.Parse(Console.ReadLine());
                                switch(luaChon)
                                {
                                    case 1:
                                        {
                                            int choice2;
                                            do
                                            {
                                                sanPhams[i] = new Ruou();
                                                Ruou ruou = (Ruou)sanPhams[i];
                                                ruou.NhapTTSP();
                                                ShowMessage();
                                                i++;
                                                choice2 = int.Parse(Console.ReadLine());
                                            } while (choice2 == 1);
                                            break;
                                        }
                                    case 2:
                                        {
                                            int choice2;
                                            do
                                            {
                                                sanPhams[i] = new Bia();
                                                Bia bia = (Bia)sanPhams[i];
                                                bia.NhapTTSP();
                                                i++;
                                                choice2 = int.Parse(Console.ReadLine());
                                            } while (choice2 == 1);
                                            break;
                                        }
                                    case 3:
                                        {
                                            int choice2;
                                            do
                                            {
                                                sanPhams[i] = new NuocNgot();
                                                NuocNgot nuocNgot = (NuocNgot)sanPhams[i];
                                                nuocNgot.NhapTTSP();
                                                i++;
                                                choice2 = int.Parse(Console.ReadLine());
                                            } while (choice2 == 1);
                                            break;
                                        }

                                }
                            } while (luaChon < 4 && luaChon > 0);
                            break;
                        }
                   
                    case 2:
                        {
                            Console.WriteLine("===> XUAT THONG TIN SAN PHAM <===");
                            for (int j = 0; j < n; j++)
                            {
                                Console.WriteLine("San pham thu {0}:",j);
                                if (sanPhams[j] is Ruou)
                                {
                                    Ruou ruou = (Ruou)(sanPhams[j]);
                                    ruou.XuatTTSP();
                                }
                                if (sanPhams[j] is Bia)
                                {
                                    Bia bia = (Bia)(sanPhams[j]);
                                    bia.XuatTTSP();
                                }
                                if (sanPhams[j] is NuocNgot)
                                {
                                    NuocNgot nuocNgot = (NuocNgot)(sanPhams[j]);
                                    nuocNgot.XuatTTSP();
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhap san pham can xuat (ruou, bia, nuoc_ngot): ");
                            string input = Console.ReadLine();
                            switch (input)
                            {
                                case "bia":
                                    {
                                        for (int j = 0; j < n; j++)
                                        {
                                            if (sanPhams[j] is Bia)
                                            {
                                                Bia bia = (Bia)(sanPhams[j]);
                                                bia.XuatTTSP();
                                            }
                                        }
                                        break;
                                    }
                                case "ruou":
                                    {
                                        for (int j = 0; j < n; j++)
                                        {
                                            if (sanPhams[j] is Ruou)
                                            {
                                                Ruou ruou = (Ruou)(sanPhams[j]);
                                                ruou.XuatTTSP();
                                            }
                                        }
                                        break;
                                    }
                                case "nuoc_ngot":
                                    {
                                        for (int j = 0; j < n; j++)
                                        {
                                            if (sanPhams[j] is NuocNgot)
                                            {
                                                NuocNgot nuocNgot = (NuocNgot)(sanPhams[j]);
                                                nuocNgot.XuatTTSP();
                                            }
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Nhap sai ten san pham");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Nhap gia can xuat: ");
                            float x = float.Parse(Console.ReadLine());
                            for(int j = 0; j < n;j++)
                                if (sanPhams[j].DonGia>=x)
                                {
                                    if (sanPhams[j] is Bia)
                                    {
                                        Bia bia = (Bia)(sanPhams[j]);
                                        bia.XuatTTSP();
                                    }
                                    if (sanPhams[j] is Ruou)
                                    {
                                        Ruou ruou = (Ruou)(sanPhams[j]);
                                        ruou.XuatTTSP();
                                    }
                                    if (sanPhams[j] is NuocNgot)
                                    {
                                        NuocNgot nuocNgot = (NuocNgot)(sanPhams[j]);
                                        nuocNgot.XuatTTSP();
                                    }
                                }

                            break;
                        }
                    case 5:
                        {
                            SapXepTangDan(sanPhams);
                            Console.WriteLine("Sap xep thanh cong!");
                            break;
                        }
                    case 6:
                        {
                            float a, b;
                            do
                            {
                                Console.Write("Nhap a: ");
                                a = float.Parse(Console.ReadLine());
                                Console.Write("Nhap b: ");
                                b = float.Parse(Console.ReadLine());
                                if(a > b)
                                    Console.WriteLine("Nhap lai! a<b moi dung!");
                            } while (a >= b);
                            for (int j = 0;j<n;j++)
                                if (sanPhams[j].DonGia>a && sanPhams[i].DonGia<b)
                                {
                                    if (sanPhams[j] is Bia)
                                    {
                                        Bia bia = (Bia)(sanPhams[j]);
                                        bia.XuatTTSP();
                                    }
                                    if (sanPhams[j] is Ruou)
                                    {
                                        Ruou ruou = (Ruou)(sanPhams[j]);
                                        ruou.XuatTTSP();
                                    }
                                    if (sanPhams[j] is NuocNgot)
                                    {
                                        NuocNgot nuocNgot = (NuocNgot)(sanPhams[j]);
                                        nuocNgot.XuatTTSP();
                                    }
                                }
                            break;
                        }
                       
                }
            } while (choice != 0 && i < n);

            Console.ReadKey();
        }

        private static void SapXepTangDan(SanPham[] sanPhams)
        {
            for(int i = 0;i<sanPhams.Length-1;i++)
                for(int j = i+1;j<sanPhams.Length;j++)
                    if (sanPhams[i].DonGia > sanPhams[j].DonGia)
                    {
                        SanPham sanPham = sanPhams[i];
                        sanPhams[i] = sanPhams[j];
                        sanPhams[j] = sanPham;
                    }
        }

        public static void ShowMessage()
        {
            Console.WriteLine("Ban co muon nhap tiep? 1.Yes 2.No");
        }
    }

}
