using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiemTra
{
    internal class QLBH
    {
        private List<DienLanh> dienLanhs;

        public QLBH() { }

        public QLBH(List<DienLanh> dienLanhs)
        {
            this.dienLanhs = dienLanhs;
        }
        internal List<DienLanh> DienLanhs { get => dienLanhs; set => dienLanhs = value; }

        public void NhapTTSP()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine(" ===> MENU <===");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("1. Nhap thong tin may giat");
                Console.WriteLine("2. Nhap thong tin tu lanh");
                choice = int.Parse(Console.ReadLine());
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
                            if (dienLanhs == null)
                                dienLanhs = new List<DienLanh>();
                            DienLanh mayGiat = new MayGiat();
                            mayGiat.NhapTTSanPham();
                            dienLanhs.Add(mayGiat);
                            break;
                        }
                    case 2:
                        {
                            if (dienLanhs == null)
                                dienLanhs = new List<DienLanh>();
                            DienLanh tuLanh = new TuLanh();
                            tuLanh.NhapTTSanPham();
                            dienLanhs.Add(tuLanh);
                            break;
                        }
                }
            } while (choice != 0);
        }
        public void XuatTTSP()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine(" ===> MENU <===");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("1. Xuat thong tin may giat");
                Console.WriteLine("2. Xuat thong tin tu lanh");
                Console.WriteLine("3. Xuat thong tin san pham hang 'Panasonic' ");
                Console.WriteLine("4. Xuat san pham co ma X");
                Console.WriteLine("5. Xuat san pham co gia tu Y->Z co hang san xuat M");
                Console.WriteLine("6. Xuat tt san pham co so lit K");
                choice = int.Parse(Console.ReadLine());
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
                            if (dienLanhs == null)
                            {
                                Console.WriteLine("Danh sach rong!");
                                break;
                            }
                            for (int i = 0; i < dienLanhs.Count; i++)
                                if (dienLanhs[i] is MayGiat)
                                {
                                    Console.WriteLine("[SAN PHAM {0}]", i);
                                    dienLanhs[i].XuatTTSanPham();
                                }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {

                            if (dienLanhs == null)
                            {
                                Console.WriteLine("Danh sach rong!");
                                break;
                            }
                            for (int i = 0; i < dienLanhs.Count; i++)
                                if (dienLanhs[i] is TuLanh)
                                {
                                    Console.WriteLine("[SAN PHAM {0}]", i);
                                    dienLanhs[i].XuatTTSanPham();
                                }
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            if (dienLanhs == null)
                            {
                                Console.WriteLine("Danh sach rong!");
                                break;
                            }
                            Console.WriteLine("[DANH SACH SAN PHAM PANASONIC]");
                            for (int i = 0; i < dienLanhs.Count; i++)
                                if (dienLanhs[i].HangSX == "panasonic")
                                {
                                    Console.WriteLine("[SAN PHAM {0}]", i);
                                    dienLanhs[i].XuatTTSanPham();
                                }
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            int count = 0;
                            Console.Write("Nhap x: ");
                            int x = int.Parse(Console.ReadLine());
                            for (int i = 0; i < dienLanhs.Count; i++)
                                if (dienLanhs[i].MaSP == x)
                                {
                                    if (dienLanhs[i] is MayGiat)
                                    {
                                        DienLanh temp = (MayGiat)dienLanhs[i];
                                        temp.XuatTTSanPham();
                                        count++;
                                    }
                                    if (dienLanhs[i] is TuLanh)
                                    {
                                        DienLanh temp = (TuLanh)dienLanhs[i];
                                        temp.XuatTTSanPham();
                                        count++;
                                    }
                                    break;
                                }
                            if(count==0)
                                Console.WriteLine("KHONG TIM THAY SAN PHAM CO MA TREN!");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            int count = 0;
                            Console.Write("Nhap hang SX: ");
                            string hangSX = Console.ReadLine();
                            double y, z;
                            do
                            {
                                Console.WriteLine("Nhap Y: ");
                                y = double.Parse(Console.ReadLine());
                                Console.WriteLine("Nhap Z: ");
                                z = double.Parse(Console.ReadLine());
                                if (y > z)
                                    Console.WriteLine("Nhap lai!");
                            } while (y > z);
                            for (int i = 0; i < dienLanhs.Count; i++)
                                if (dienLanhs[i].HangSX.CompareTo(hangSX) == 0 && dienLanhs[i].DonGia >= y && dienLanhs[i].DonGia <= z)
                                {
                                    if (dienLanhs[i] is MayGiat)
                                    {
                                        DienLanh temp = (MayGiat)dienLanhs[i];
                                        temp.XuatTTSanPham();
                                    }
                                    if (dienLanhs[i] is TuLanh)
                                    {
                                        DienLanh temp = (TuLanh)dienLanhs[i];
                                        temp.XuatTTSanPham();
                                    }
                                    count++;
                                }
                            if (count == 0)
                                Console.WriteLine("Khong tim thay san pham nhu tren!");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            int count = 0;
                            Console.WriteLine("Nhap K: ");
                            int k = int.Parse(Console.ReadLine());
                            for (int i = 0; i < dienLanhs.Count; i++)
                                if (dienLanhs[i] is TuLanh)
                                {
                                    TuLanh sp = (TuLanh)dienLanhs[i];
                                    if (sp.SoLit == k)
                                    {
                                        sp.XuatTTSanPham();
                                        count++;
                                    }
                                }
                            if(count == 0)
                                Console.WriteLine("KHONG CO SAN PHAM THOA MAN NHU TREN");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (choice != 0);
        }
        public void SapXepGiaTangDan()
        {
            Console.Clear();
            if (dienLanhs == null)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }
            for (int i = 0; i < dienLanhs.Count - 1; i++)
                for (int j = i + 1; j < dienLanhs.Count; j++)
                    if (dienLanhs[j].DonGia > dienLanhs[i].DonGia)
                    {
                        DienLanh temp = dienLanhs[i];
                        dienLanhs[i] = dienLanhs[j];
                        dienLanhs[j] = temp;
                    }
            Console.WriteLine("===> SAP XEP THANH CONG <===\n");
        }
    }
}
