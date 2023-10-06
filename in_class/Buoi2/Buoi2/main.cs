using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class main
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.XuatThongTin();
            sv.NhapThongTin();
            sv.XuatThongTin();

            MonHoc mh = new MonHoc();
            mh.XuatThongTin();
            MonHoc mh1 = new MonHoc(15, "KTLT", 3);
            mh1.XuatThongTin();

            KetQua kq = new KetQua();
            kq.NhapThongTin();
            kq.XuatThongTin();

            XuatThongTinSinhVien(sv, mh1, kq);

            Console.ReadKey();
        }
        public static float TinhDTB(float diemCC , float diemGK,float diemCK)
        {
            return diemCC * 0.2f + diemGK * 0.2f + diemCK * 0.6f;
        }
        public static void XuatThongTinSinhVien(SinhVien sv, MonHoc mh, KetQua kq)
        {
            sv.XuatThongTin();
            mh.XuatThongTin();
            Console.WriteLine("Diem cua sinh vien: " + TinhDTB(kq.DiemCC, kq.DiemGK, kq.DiemCK));
            if (TinhDTB(kq.DiemCC,kq.DiemGK,kq.DiemCK)>4)
                Console.WriteLine("Sinh vien dau");
            else
                Console.WriteLine("Sinh vien rot");
        }
    }
}
