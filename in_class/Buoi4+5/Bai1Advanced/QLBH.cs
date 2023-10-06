using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Advanced
{
    internal class QLBH
    {
        private List<NhanVien> nhanViens;
        private List<KhachHang> khachHangs;
        private List<HoaDon> hoaDons;
        private List<SanPham> sanPhams;

        public QLBH()
        {
        }

        public QLBH(List<SanPham> sanPhams, List<NhanVien> nhanViens,
            List<KhachHang> khachHangs, List<HoaDon> hoaDons)
        {
            this.sanPhams = sanPhams;
            this.nhanViens = nhanViens;
            this.khachHangs = khachHangs;
            this.hoaDons = hoaDons;
        }

        internal List<SanPham> SanPhams { get => sanPhams; set => sanPhams = value; }
        internal List<NhanVien> NhanViens { get => nhanViens; set => nhanViens = value; }
        internal List<KhachHang> KhachHangs { get => khachHangs; set => khachHangs = value; }
        internal List<HoaDon> HoaDons { get => hoaDons; set => hoaDons = value; }
        public void ThemKhachHang()
        {
            Console.Clear();
            if (khachHangs == null)
            {
                khachHangs = new List<KhachHang>();
            }
            Console.WriteLine("===> THEM THONG TIN KHACH HANG <===");
            KhachHang khach = new KhachHang();
            khach.NhapTTKH();
            khachHangs.Add(khach);
            Console.WriteLine("===> " + khachHangs.Count);
        }
        public void ThemNhanVien()
        {
            Console.Clear();
            if (nhanViens == null)
            {
                nhanViens = new List<NhanVien>();
            }
            Console.WriteLine("===> THEM THONG TIN NHAN VIEN<===");
            NhanVien nhanVien = new NhanVien();
            nhanViens.Add(nhanVien.NhapTTNV());
        }
        public void ThemSanPham()
        {
            Console.Clear();
            if (sanPhams == null)
            {
                sanPhams = new List<SanPham>();
            }
            Console.WriteLine("===> THEM THONG TIN SAN PHAM <===");
            int choice;
            do
            {
                Console.WriteLine("==> Nhap thong tin san pham <===");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("1.Ruou");
                Console.WriteLine("2.Bia");
                Console.WriteLine("3.Nuoc ngot");
                Console.Write("Chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Thoat!");
                            break;
                        }
                    case 1:
                        {
                            SanPham sp = new Ruou();
                            sp.NhapTTSP();
                            if (CheckMaSanPham(sp))
                                Console.WriteLine("MA SAN PHAM DA TON TAI. VUI LONG NHAP LAI!\n");
                            else
                            {
                                sanPhams.Add(sp);
                                Console.WriteLine("Nhap thong tin thanh cong!\n");
                            }
                            break;
                        }
                    case 2:
                        {
                            SanPham sp = new Bia();
                            sp.NhapTTSP();
                            if (CheckMaSanPham(sp))
                                Console.WriteLine("MA SAN PHAM DA TON TAI. VUI LONG NHAP LAI!\n");
                            else
                            {
                                sanPhams.Add(sp);
                                Console.WriteLine("Nhap thong tin thanh cong!\n");
                            }
                            break;
                        }
                    case 3:
                        {
                            SanPham sp = new NuocNgot();
                            sp.NhapTTSP();
                            if (CheckMaSanPham(sp))
                                Console.WriteLine("MA SAN PHAM DA TON TAI. VUI LONG NHAP LAI!\n");
                            else
                            {
                                sanPhams.Add(sp);
                                Console.WriteLine("Nhap thong tin thanh cong!\n");
                            }
                            break;
                        }
                }
            } while (choice != 0);
        }
        public void ThemHoaDon()
        {
            Console.Clear();
            if (hoaDons == null)
            {
                hoaDons = new List<HoaDon>();
            }
            Console.WriteLine("===> THEM THONG TIN HOA DON <===");
            HoaDon hoaDon = new HoaDon();
            hoaDon.NhapThongTinHoaDon(nhanViens, khachHangs, sanPhams);
            hoaDons.Add(hoaDon);
        }

        public bool CheckMaSanPham(SanPham x)
        {
            for (int i = 0; i < sanPhams.Count; i++)
                if (x.MaSanPham == sanPhams[i].MaSanPham)
                    return true;
            return false;
        }
        public bool CheckMaSanPham(int x)
        {
            for (int i = 0; i < sanPhams.Count; i++)
                if (x == sanPhams[i].MaSanPham)
                    return true;
            return false;
        }
        public bool CheckMaKhachHang(KhachHang x)
        {
            for (int i = 0; i < khachHangs.Count; i++)
                if (x.MaKH == khachHangs[i].MaKH)
                    return true;
            return false;
        }
        public bool CheckMaKhachHang(int x)
        {
            for (int i = 0; i < khachHangs.Count; i++)
                if (x == khachHangs[i].MaKH)
                    return true;
            return false;
        }
        /**
         * Kiểm tra xem mã nhân viên đã tồn tại chưa? Nếu đã tồn tại return true
         * ngược lại return false;
         */
        public bool CheckMaNhanVien(NhanVien x)
        {
            for (int i = 0; i < nhanViens.Count; i++)
                if (x.MaNV == nhanViens[i].MaNV)
                    return true;
            return false;
        }

        public bool CheckMaNhanVien(int x)
        {
            for (int i = 0; i < nhanViens.Count; i++)
                if (x == nhanViens[i].MaNV)
                    return true;
            return false;
        }
        public bool CheckMaHoaDon(HoaDon x)
        {
            for (int i = 0; i < hoaDons.Count; i++)
                if (x.MaHoaDon == hoaDons[i].MaHoaDon)
                    return true;
            return false;
        }
        public bool CheckMaHoaDon(int x)
        {
            for (int i = 0; i < hoaDons.Count; i++)
                if (x == hoaDons[i].MaHoaDon)
                    return true;
            return false;
        }
        public void XuatThongTinSanPham()
        {
            Console.Clear();
            int choice;
            do
            {
                Console.WriteLine("==> Xuat thong tin san pham <===");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("1.Ruou");
                Console.WriteLine("2.Bia");
                Console.WriteLine("3.Nuoc ngot");
                Console.Write("Chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Thoat.");
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("==> THONG TIN RUOU <==");
                            int count = 0;
                            for (int i = 0; i < sanPhams.Count; i++)
                                if (sanPhams[i] is Ruou)
                                {
                                    Console.WriteLine("San pham thu {0}: ", count);
                                    Ruou ruou = (Ruou)sanPhams[i];
                                    ruou.XuatTTSP();
                                }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("==> THONG TIN BIA <==");
                            int count = 0;
                            for (int i = 0; i < sanPhams.Count; i++)
                                if (sanPhams[i] is Bia)
                                {
                                    Console.WriteLine("San pham thu {0}: ", count++);
                                    Bia bia = (Bia)sanPhams[i];
                                    bia.XuatTTSP();
                                }
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("==> THONG TIN NUOC NGOT <==");
                            int count = 0;
                            for (int i = 0; i < sanPhams.Count; i++)
                                if (sanPhams[i] is NuocNgot)
                                {
                                    Console.WriteLine("San pham thu {0}: ", count);
                                    NuocNgot nuocNgot = (NuocNgot)sanPhams[i];
                                    nuocNgot.XuatTTSP();
                                }
                            Console.ReadKey();
                            break;
                        }
                }
            } while (choice != 0);
        }
        public void XuatThongTinNhanVien()
        {
            Console.Clear();
            Console.WriteLine("===> XUAT THONG TIN NHAN VIEN <===");
            for (int i = 0; i < nhanViens.Count; i++)
            {
                Console.WriteLine("Nhan vien thu {0}: ", i);
                nhanViens[i].XuatTTNV();
                Console.WriteLine("===============");
            }
            Console.WriteLine();
        }
        public void XuatThongTinKhachHang()
        {
            Console.Clear();
            Console.WriteLine("===> XUAT THONG TIN KHACH HANG <===");
            for (int i = 0; i < khachHangs.Count; i++)
            {
                Console.WriteLine("Khach hang thu {0}: ", i);
                khachHangs[i].XuatTTKH();
                Console.WriteLine("===============");
            }
            Console.WriteLine();
        }
        public void XuatThongTinHoaDon()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("==> MENU XUAT THONG TIN HOA DON <==");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Xuat thong tin hoa don theo ma nhan vien");
                Console.WriteLine("2. Xuat thong tin hoa don theo ma khach hang");
                Console.WriteLine("3. Xuat tat ca hoa don");
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
                            XuatHoaDonTheoNhanVien();
                            break;
                        }
                    case 2:
                        {
                            XuatHoaDonTheoKhachHang();
                            break;
                        }
                    case 3:
                        {
                            XuatTatCaHoaDon();
                            break;
                        }
                }
            } while (choice != 0);



        }

        private void XuatHoaDonTheoKhachHang()
        {
            Console.Clear();
            Console.WriteLine("===> XUAT HOA DON THEO KHACH HANG <===");
            Console.Write("Nhap ma khach hang: ");
            int maKhachHang = int.Parse(Console.ReadLine());
            if (CheckMaKhachHang(maKhachHang))
            {
                for (int i = 0; i < khachHangs.Count; i++)
                    if (khachHangs[i].MaKH == maKhachHang)
                    {
                        khachHangs[i].XuatTTKH();
                    }
            }
            else
            {
                Console.WriteLine(" ==> Ma khach hang khong ton tai! ");
                return;
            }
            for (int i = 0; i < HoaDons.Count; i++)
                if (maKhachHang == hoaDons[i].MaKhachHang)
                {
                    Console.WriteLine("HOA DON {0}: ", i);
                    hoaDons[i].XuatThongTinHoaDon();
                }
        }

        private void XuatHoaDonTheoNhanVien()
        {
            Console.Clear();
            Console.WriteLine("===> XUAT HOA DON THEO NHAN VIEN <===");
            Console.Write("Nhap ma nhan vien: ");
            int maNhanVien = int.Parse(Console.ReadLine());
            if (CheckMaNhanVien(maNhanVien))
            {
                for(int i = 0;i<nhanViens.Count;i++)
                    if (nhanViens[i].MaNV == maNhanVien)
                    {
                        nhanViens[i].XuatTTNV();
                    }
            }
            else
            {
                Console.WriteLine(" ==> Ma nhan vien khong ton tai! ");
                return;
            }
            for(int i = 0;i<HoaDons.Count;i++)
                if(maNhanVien == hoaDons[i].MaNhanVien)
                {
                    Console.WriteLine("===> THONG TIN CAC DON HANG <===");
                    Console.WriteLine("HOA DON {0}: ",i);
                    hoaDons[i].XuatTTHoaDon_NV();
                }
        }

        public void XuatTatCaHoaDon()
        {
            Console.Clear();
            Console.WriteLine("===> XUAT THONG TIN HOA DON <===");
            for (int i = 0; i < hoaDons.Count; i++)
            {
                Console.WriteLine("Hoa don thu {0}: ", i);
                hoaDons[i].XuatThongTinHoaDon();
                Console.WriteLine("==================");
            }
            Console.WriteLine();
        }
    }
}
