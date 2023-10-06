using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLBH
{
    internal class HoaDon
    {
        private static int maHD = 0;
        private string maHDstr;
        private int maNV;
        private int maKH;
        private int maSP;
        private int soLuong;
        private double tongTien;
        public HoaDon()
        {
            maHD++;
            maHDstr = "HD" + maHD;
        }
        public HoaDon(int maNV, int maKH, int maSP, int soLuong, double tongTien) : this()
        {
            this.maNV = maNV;
            this.maKH = maKH;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }

        //get,set
        public static int MaHD { get => maHD; set => maHD = value; }
        public string MaHDstr { get => maHDstr; set => maHDstr = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }

        //methods
        public void NhapHD(List<SanPham> sanPham, List<NhanVien> nhanVien,List<KhachHang> khachHang)
        {
            int maSP, maNV, maKH;
            Console.Write("Nhap ma SP: ");
            maSP = int.Parse(Console.ReadLine());
            
        }
    }
}
