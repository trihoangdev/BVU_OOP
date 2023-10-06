using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class SanPham
    {
        protected static int maSanPham = 0000;
        protected string maSanPhamstr;
        protected string tenSanPham;
        protected string donViTinh;
        protected double donGia;
        protected double phuThu;

        //constructors
        public SanPham()
        {
            maSanPham++;
            maSanPhamstr = "SP" + maSanPham.ToString();
        }

        public SanPham(string tenSanPham,
            string donViTinh, double donGia, double phuThu) : this()
        {
            this.tenSanPham = tenSanPham;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.phuThu = phuThu;
        }

        //get,set
        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string MaSanPhamstr { get => maSanPhamstr; set => maSanPhamstr = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double PhuThu { get => phuThu; set => phuThu = TinhPhuThu(); }

        //methods

        /**
         * Phương thức dùng để nhập thông tin sản phẩm
         */
        public virtual void NhapTTSP()
        {
            Console.WriteLine("===> NHAP THONG TIN SAN PHAM <===");
            Console.Write("Ten san pham (Toi da 20 ki tu): ");
            tenSanPham = Console.ReadLine();
            Console.Write("Don vi tinh (Toi da 20 ki tu): ");
            donViTinh = Console.ReadLine();
            Console.Write("Don gia (Toi da 20 ki tu): ");
            donGia = double.Parse(Console.ReadLine());
        }

        /**
         * Phương thức dùng để xuất thông tin sản phẩm
         */
        public virtual void XuatTTSP()
        {
            string[,] tableData = new string[4, 2];
            tableData[0, 0] = "| Ma san pham:";
            tableData[0, 1] = MaSanPhamstr;
            tableData[1, 0] = "| Ten san pham:";
            tableData[1, 1] = tenSanPham;
            tableData[2, 0] = "| Don vi tinh:";
            tableData[2, 1] = donViTinh;
            tableData[3, 0] = "| Don gia:";
            tableData[3, 1] = donGia.ToString();
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("| ======> XUAT THONG TIN SAN PHAM <===== |");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tableData[i, j].PadRight(20) + "|");
                }
                    Console.WriteLine();
            }
        }
        public virtual void GiamGia()
        {
        }

        /**
         * Phương thức tính phụ thu cho sản phẩm
         * nếu đơn vị tính là “lon” và đơn giá >20000 thì phụ thu 20% đơn giá,
         * ngược lại nếu đơn vị tính là “chai” và đơn giá trên 50000 thì phụ thu 15% trên đơn giá, 
         * ngược lại phụ thu 10% trên đơn giá
         */
        public virtual double TinhPhuThu() 
        {
            if (donViTinh == "lon" && donGia > 20000)
                return 0.2;
            else if (donViTinh == "chai" && donGia > 50000)
                return 0.15;
            return 0.1;
        }
        
    }
}
