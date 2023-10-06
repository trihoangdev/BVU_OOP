using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class NhanVien
    {
        private int maNhanVien;
        private string hoVaTen;
        private string diaChi;
        private float luongCoBan;
        private float tienThuong;

        public NhanVien()
        {
            diaChi = "Vung Tau";
            luongCoBan = 1780000;
            tienThuong = 500000;
        }

        public NhanVien(int maNhanVien, string hoVaTen, string diaChi, float luongCoBan, float tienThuong)
        {
            this.maNhanVien = maNhanVien;
            this.hoVaTen = hoVaTen;
            this.diaChi = diaChi;
            this.luongCoBan = luongCoBan;
            this.tienThuong = tienThuong;
        }

        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public float TienThuong { get => tienThuong; set => tienThuong = value; }

        public void NhapThongTinNhanVien()
        {
            Console.Write("Ma NV: " );
            maNhanVien = int.Parse( Console.ReadLine() );
        }
    }
}
