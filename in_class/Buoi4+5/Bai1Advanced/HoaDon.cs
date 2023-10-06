using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Advanced
{
    internal class HoaDon
    {
        private int maHoaDon;
        private int maNhanVien;
        private int maSanPham;
        private int maKhachHang;
        private int soLuong;
        public HoaDon()
        {
        }

        public HoaDon(int maHoaDon, int maNhanVien, int maSanPham, int maKhachHang, int soLuong)
            : this(maHoaDon, maNhanVien, maSanPham, maKhachHang)
        {
            this.soLuong = soLuong;
        }

        public HoaDon(int maHoaDon, int maNhanVien, int maSanPham, int maKhachHang)
        {
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.maSanPham = maSanPham;
            this.maKhachHang = maKhachHang;
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

        public void NhapThongTinHoaDon(List<NhanVien> nhanViens, List<KhachHang> khachHangs, List<SanPham> sanPhams)
        {
            if (khachHangs == null)
            {
                Console.WriteLine("Thong tin khach hang rong. Vui long nhap thong tin khach hang.");
                Console.ReadKey();
                return;
            }
            if (nhanViens == null)
            {
                Console.WriteLine("Thong tin nhan vien rong. Vui long nhap thong tin nhan vien.");
                Console.ReadKey();
                return;
            }
            if (sanPhams == null)
            {
                Console.WriteLine("Thong tin san pham rong. Vui long nhap thong tin san pham.");
                Console.ReadKey();
                return;
            }
            Console.Write("Nhap ma hoa don: ");
            maHoaDon = int.Parse(Console.ReadLine());

            //nhap thong tin khach hang, nhan vien, sp
            int maKhachHang, maNhanVien, maSanPham;
            bool check = false;
            do
            {
                Console.Write("Nhap ma khach hang: ");
                maKhachHang = int.Parse(Console.ReadLine());
                for (int i = 0; i < khachHangs.Count; i++)
                    if (maKhachHang == khachHangs[i].MaKH)
                    {
                        check = true;
                        break;
                    }
                Console.WriteLine("Ma khach hang khong ton tai. Vui long nhap lai.");
            } while (!check);
            check = false;
            do
            {
                Console.Write("Nhap ma nhan vien: ");
                maNhanVien = int.Parse(Console.ReadLine());
                for (int i = 0; i < nhanViens.Count; i++)
                    if (maNhanVien == nhanViens[i].MaNV)
                    {
                        check = true;
                        break;
                    }
                Console.WriteLine("Ma nhan vien khong ton tai. Vui long nhap lai.");
            } while (!check);
            check = false;
            do
            {
                Console.Write("Nhap ma san pham: ");
                maSanPham = int.Parse(Console.ReadLine());
                for (int i = 0; i < sanPhams.Count; i++)
                    if (maSanPham == sanPhams[i].MaSanPham)
                    {
                        check = true;
                        break;
                    }
                Console.WriteLine("Ma san pham khong ton tai. Vui long nhap lai.");
            } while (!check);
            Console.Write("Nhap so luong mua: ");
            soLuong = int.Parse(Console.ReadLine());
        }
        public void XuatThongTinHoaDon()
        {
            Console.WriteLine("===> THONG TIN DON HANG <===");
            Console.WriteLine("Ma hoa don: " + maHoaDon);
            Console.WriteLine("Ma khach hang: " + maKhachHang);
            Console.WriteLine("Ma nhan vien: " + maNhanVien);
            Console.WriteLine("Ma san pham: " + maSanPham);
            Console.WriteLine("So luong mua: " + soLuong);
            Console.WriteLine("============================\n");
        }
        /**
         * Xuất thông tin hoá đơn của nhân viên x bán được
         */
        public void XuatTTHoaDon_NV()
        {
            Console.WriteLine("Ma hoa don: " + maHoaDon);
            Console.WriteLine("Ma khach hang: " + maKhachHang);
            Console.WriteLine("Ma san pham: " + maSanPham);
            Console.WriteLine("So luong mua: " + soLuong);
            Console.WriteLine("============================\n");
        }
        
    }
}
