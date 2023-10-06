using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLBH qlbh = new QLBH();
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("===> MENU <===");
                Console.WriteLine("1. Nhap thong tin san pham");
                Console.WriteLine("2. Nhap thong tin khach hang");
                Console.WriteLine("3. Nhap thong tin nhan vien");
                Console.WriteLine("4. Nhap thong tin hoa don");
                Console.WriteLine("5. Xuat thong tin san pham");
                Console.WriteLine("6. Xuat thong tin khach hang");
                Console.WriteLine("7. Xuat thong tin nhan vien");
                Console.WriteLine("8. Xuat thong tin hoa don");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            qlbh.ThemSanPham();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            qlbh.ThemKhachHang();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            qlbh.ThemNhanVien();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            qlbh.ThemHoaDon();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            qlbh.XuatThongTinSanPham();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            qlbh.XuatThongTinKhachHang();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            qlbh.XuatThongTinNhanVien();
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            qlbh.XuatThongTinHoaDon();
                            break;
                        }
                }
            }while (choice > 0);
            Console.ReadKey();
        }
    }
}
