using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            SanPham sp = new SanPham();
            sp.NhapThongTinSanPham();

            NhanVien nv = new NhanVien();
            nv.NhapThongTinNhanVien();

            BanHang banHang = new BanHang();
            banHang.NhapThongTinBanHang(nv,sp);
            banHang.XuatThongTinBanHang(nv, sp);


            Console.ReadKey();
        }
    }
}
