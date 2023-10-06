using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class BanHang
    {
        /*
         * mã sp, mã nv, số lượng
         * Nhập thông tin bán hàng
         * Xuất thông tin bán hàng:
         *   (phương thức xuất thông tin bán hàng xuất các thông tin sau: Thông tin sản phẩm, thông tin nv, số tiền phải trả)
         * Tính thành tiền
         *    - số lượng > 40 => giảm 10%
         *    - Số lượng > 20 => giảm 5%
         */
        public int maSanPham;
        public int maNhanVien;
        public int soLuong;

        public void NhapThongTinBanHang(NhanVien nv, SanPham sp)
        {
            maSanPham = sp.maSP;
            maNhanVien = nv.maNhanVien;
            Console.Write("So luong mua: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("==================");
        }
        public void XuatThongTinBanHang(NhanVien nv,SanPham sp)
        {
            sp.XuatThongTinSanPham();
            nv.XuatThongTinNhanVien();
            Console.WriteLine("Tong tien: "+ TinhTien(sp));
        }
        public double TinhTien(SanPham sp)
        {
            double tong = soLuong * sp.donGia;
            if (soLuong > 40)
                tong = tong * 0.9;
            else if (soLuong > 20)
                tong = tong * 0.95;
            return tong;
        }
    }
}
