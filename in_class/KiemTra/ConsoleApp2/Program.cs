using ChieuT5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VangBac[] ds = new Vang[10];
            List<VangBac> list = new List<VangBac>();
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("===> MENU <===");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Xuat thong tin");
                Console.WriteLine("3. Sap xep don gia tang dan");
                Console.WriteLine("4. Tinh tong tien cho tung loai san pham");
                Console.Write("Chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Thoat");
                            Console.ReadKey();
                            break;
                        }
                    case 1:
                        {
                            NhapThongTin(list);
                            break;
                        }
                    case 2:
                        {
                            XuatThongTin(list);
                            break;
                        }
                    case 3:
                        {
                            SapXepDonGiaTangDan(list);
                            break;
                        }
                    case 4:
                        {
                            TinhTongTienChoTungSP(list);
                            break;
                        }
                }
            } while (choice != 0);
            Console.ReadKey();
        }

        private static void TinhTongTienChoTungSP(List<VangBac> list)
        {
            Console.WriteLine("0. Thoat");
            Console.WriteLine("1. Nhan");
            Console.WriteLine("2. Mieng");
            Console.Write("Chon: ");
            int choice = int.Parse(Console.ReadLine()); 
            switch(choice)
            {
                case 0:
                    {
                        Console.WriteLine("Thoat");
                        Console.ReadKey();
                        break;
                    }
                case 1:
                    {
                        double tong = 0;
                        for (int i = 0; i < list.Count; i++)
                            if (list[i] is Vang)
                            {
                                Vang vang = (Vang)list[i];
                                if(vang.LoaiVang.CompareTo("nhan")==0)
                                tong += vang.TinhTongTien();
                            }
                        Console.WriteLine("Tong tien nhan: "+ tong);
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        double tong = 0;
                        for (int i = 0; i < list.Count; i++)
                            if (list[i] is Vang)
                            {
                                Vang vang = (Vang)list[i];
                                if (vang.LoaiVang.CompareTo("mieng") == 0)
                                    tong += vang.TinhTongTien();
                            }
                        Console.WriteLine("Tong tien mieng: " + tong);
                        Console.ReadKey();
                        break;
                    }
            }
        }

        private static void SapXepDonGiaTangDan(List<VangBac> list)
        {
            for(int i = 0;i<list.Count;i++)
                for(int j = i+1;j<list.Count;j++)
                    if (list[i].DonGia > list[j].DonGia)
                    {
                        VangBac temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
            Console.WriteLine("Sap xep thanh cong!");
            Console.ReadKey();
        }

        private static void XuatThongTin(List<VangBac> list)
        {
            Console.WriteLine("0. Thoat");
            Console.WriteLine("1. Xuat TT cac san pham la vang");
            Console.WriteLine("2. Xuat TT cac san pham co hang 'PNJ'");
            Console.WriteLine("3. Xuat TT san pham co gia X->Y");
            Console.WriteLine("4. Xuat TT san pham co ma Z");
            Console.Write("Chon: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    {
                        Console.WriteLine("Thoat");
                        Console.ReadKey();
                        break;
                    }
                case 1:
                    {
                        for (int i = 0; i < list.Count; i++)
                            if (list[i] is Vang)
                            {
                                list[i].XuatTTSanPham();
                                /*Vang temp = (Vang)list[i];
                                temp.a();*/
                            }
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < list.Count; i++)
                            if (list[i].HangSX.CompareTo("pnj") == 0)
                                list[i].XuatTTSanPham();
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        int x, y;
                        do
                        {
                            Console.WriteLine("Nhap X: ");
                            x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap Y: ");
                            y = int.Parse(Console.ReadLine());
                            if (x > y)
                                Console.WriteLine("Vui long nhap x<y");
                        } while (x >= y);
                        for (int i = 0; i < list.Count; i++)
                            if (list[i].DonGia >= x || list[i].DonGia <= y)
                                list[i].XuatTTSanPham();
                        Console.ReadKey();
                        break;
                    }
                    case 4:
                    {
                        Console.Write("Nhap Z: ");
                        int z = int.Parse(Console.ReadLine());
                        for (int i = 0; i < list.Count; i++)
                            if (list[i].MaSP == z)
                                list[i].XuatTTSanPham();
                        Console.ReadKey();
                        break;
                    }
            }
        }

        private static void NhapThongTin(List<VangBac> list)
        {
            Console.Clear();
            Console.WriteLine("1. Nhap TT Vang");
            Console.WriteLine("2. Nhap TT Bac");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    {
                        Console.WriteLine("Thoat!");
                        Console.ReadKey();
                        break;
                    }
                case 1:
                    {
                        Console.Clear();
                        VangBac item = new Vang();
                        item.NhapTTSanPham();
                        list.Add(item);
                        break;
                    }
                case 2:
                    {
                        VangBac item = new Bac();
                        item.NhapTTSanPham();
                        list.Add(item);
                        break;
                    }
            }
        }
        

    }
}
